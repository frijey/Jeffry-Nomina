using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_3_CRUD
{
    public partial class GenerarNomina : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        operacion oper = new operacion();
        public double valorisr = 12;
        public double valorss = 4;
        public static bool buscarnom = false;
        public static string numnomina = "1";

        //Variables para los totales
        public double totalisr = 0;
        public double totalss = 0;
        public double totalahorros = 0;
        public double totaldesc = 0;
        public double totalneto = 0;
        public double totalbruto = 0;

        public GenerarNomina()
        {
            InitializeComponent();
        }

        private void datanomina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Form f = new HEXTODEC();
                string ideempleado = datanomina.CurrentRow.Cells[1].Value.ToString();
                ds = oper.ConsultaConResultadods("SELECT id FROM empleado WHERE cedula = '" + ideempleado + "'");
                ideempleado = ds.Tables[0].Rows[0][0].ToString();
                HEXTODEC.idbuscar = ideempleado;
                f.ShowDialog();
                Nuevo();
                GenerarNom();
            }
            catch
            {
            }
        }

        private void GenerarNomina_Load(object sender, EventArgs e)
        {
            Nuevo();
            if (buscarnom)
            {
                Buscar();
            }
            else { }
            buscarnom = false;
        }

        public void Nuevo()
        {

            //Consultar el id máximo y asignarlo al Text Box de Número de Nómina.
            ds = oper.ConsultaConResultadods("SELECT max(id) FROM cabecera_nomina;");
            try
            {
                tbnumnomina.Text = (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
            }
            catch
            {
                tbnumnomina.Text = "1";
            }

            //Asignar el mes actual al ComboBox
            cbmes.Text = cbmes.Items[(DateTime.Now.Month - 1)].ToString();

            //Asignar los Valores de la ISR e SS según la configuración del usuario, y convertirlos en porcentaje
            try
            {
                ds = oper.ConsultaConResultadods("SELECT * FROM configuracion;");
                valorisr = Convert.ToDouble(ds.Tables[0].Rows[0][0].ToString());
                valorisr = (valorisr / 100);
                valorss = Convert.ToDouble(ds.Tables[0].Rows[0][1].ToString());
                valorss = (valorss / 100);
            }
            catch
            {
                MessageBox.Show("Error al cargar la configuracion I.S.R. y S.S.", "Aviso");
            }

            //Limpiar todos los campos
            tbttbruto.Text = "";
            tbttirs.Text = "";
            tbttss.Text = "";
            tbttahorros.Text = "";
            tbttdesc.Text = "";
            tbttneto.Text = "";
            tbestado.Text = "";
            datanomina.Rows.Clear();
            
            //Desactivar el Procesado de la nómina
            btnprocesar.Enabled = false;
            btngenerar.Enabled = true;
            btnimprimir.Enabled = false;
            btnemitir.Enabled = false;
            btneliminar.Enabled = false;

            //Reactivar el Combo Box de selección del "Mes"...
            cbmes.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbmes.Text != "")
            {
                GenerarNom();
                cbmes.Enabled = false;
            }
            else
            {
                MessageBox.Show("Coloque el mes del cual desea hacer la nómina", "Aviso");
            }
        }

        public void GenerarNom()
        {

            //Traer datos de los empleados activos para la creación de la nómina (Data Grid y TextBox)
            datanomina.Rows.Clear();
            string cargo;
            string idcargo;

            //Reiniciar valor de las variables de totales
            totalisr = 0;
            totalss = 0;
            totalahorros = 0;
            totaldesc = 0;
            totalneto = 0;
            totalbruto = 0;
            
            DataSet DDS = new DataSet(); //Usado para hacer el cambio de id a nombre de departamento

            try
            {

                dt = oper.ConsultaConResultadodt("SELECT nombre, cedula, idcargo, sueldo FROM empleado WHERE estado = 'ACTIVO';");
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

                for (int i = 0; i < (dataGridView1.RowCount - 1); i++)
                {
                    datanomina.Rows.Add();
                    datanomina.Rows[i].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value.ToString(); //nombre
                    datanomina.Rows[i].Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value.ToString(); //Cédula
                    idcargo = dataGridView1.Rows[i].Cells[2].Value.ToString();

                    DDS = oper.ConsultaConResultadods("SELECT descripcion FROM cargo WHERE id = '" + idcargo + "';"); //IdCargo
                    cargo = DDS.Tables[0].Rows[0][0].ToString();

                    datanomina.Rows[i].Cells[2].Value = cargo; //Cargo
                    datanomina.Rows[i].Cells[3].Value = dataGridView1.Rows[i].Cells[3].Value.ToString(); //Sueldo Bruto
                    totalbruto += Convert.ToDouble(datanomina.Rows[i].Cells[3].Value);
                }

                string cedula;
                for (int i = 0; i < datanomina.RowCount; i++)
                {
                    datanomina.Rows[i].Cells[4].Value = (Convert.ToDouble(datanomina.Rows[i].Cells[3].Value) * valorisr).ToString(); //ISR
                    totalisr += Convert.ToDouble(datanomina.Rows[i].Cells[4].Value);
                    datanomina.Rows[i].Cells[5].Value = (Convert.ToDouble(datanomina.Rows[i].Cells[3].Value) * valorss).ToString(); //SS
                    totalss += Convert.ToDouble(datanomina.Rows[i].Cells[5].Value);

                    cedula = datanomina.Rows[i].Cells[1].Value.ToString(); //cedula

                    //Consultar el Porcentaje de ahorro del empleado actual y calcular...
                    DDS = oper.ConsultaConResultadods("SELECT ahorro FROM empleado WHERE cedula = '" + cedula + "';");
                    datanomina.Rows[i].Cells[6].Value = ((Convert.ToDouble(DDS.Tables[0].Rows[0][0]) / 100) * (Convert.ToDouble(datanomina.Rows[i].Cells[3].Value))).ToString();// Calculo del ahorro
                    totalahorros += Convert.ToDouble(datanomina.Rows[i].Cells[6].Value);

                    //Sumar las Deducciones para colocarlas en el "Total de las Deducciones"
                    datanomina.Rows[i].Cells[7].Value = Convert.ToInt32(datanomina.Rows[i].Cells[4].Value) + Convert.ToInt32(datanomina.Rows[i].Cells[5].Value) + Convert.ToInt32(datanomina.Rows[i].Cells[6].Value);
                    totaldesc += Convert.ToDouble(datanomina.Rows[i].Cells[7].Value);

                    //Calcular el Total Neto, la celda 3 menos la celda 7, equivalente al sueldo bruto menos el total de deducciones...
                    datanomina.Rows[i].Cells[8].Value = Convert.ToInt32(datanomina.Rows[i].Cells[3].Value) - Convert.ToInt32(datanomina.Rows[i].Cells[7].Value);
                    totalneto += Convert.ToDouble(datanomina.Rows[i].Cells[8].Value);
                }

                tbttbruto.Text = "RD$ " + totalbruto.ToString();
                tbttirs.Text = "RD$ " + totalisr.ToString();
                tbttss.Text = "RD$ " + totalss.ToString();
                tbttahorros.Text = "RD$ " + totalahorros.ToString();
                tbttdesc.Text = "RD$ " + totaldesc.ToString();
                tbttneto.Text = "RD$ " + totalneto.ToString();
                btnprocesar.Enabled = true;
                btngenerar.Enabled = false;
                btnemitir.Enabled = true;
                btneliminar.Enabled = true;

                //Desactivar el Combo Box de selección del "Mes"...
                cbmes.Enabled = false;

            }
            catch
            {
                MessageBox.Show("Hubo un error al intentar generar la nómina, Contacte al técnico de la base de datos", "Aviso");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form f = new Configuración();
            f.ShowDialog();
        }

        private void btnnuevanomina_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    // You could potentially name the column based on the DGV column name (beware of dupes)
                    // or assign a type based on the data type of the data bound to this DGV column.
                    dt.Columns.Add();
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            try
            {
                //Convertir el DatagridView en Datatable e imprimir el DataTable en XML
                DataTable DtReport = new DataTable();
                DtReport = GetDataTableFromDGV(datanomina);
                DataSet dsxml = new DataSet();
                dsxml.Tables.Add(DtReport);

                //Guardar los totales en el DGV Plus (Extra para totales)
                //string[] Columns = { "T.T. I.S.R.", "T.T. S.S.", "T.T. Ahorros",
                //"T.T. Deducs", "T.T. Sueldo Neto"};

                //string[] row0 = { "RD$ "+tbttirs.Text, "RD$ "+tbttss.Text, "RD$ "+tbttahorros.Text,
                //"RD$ "+tbttdesc.Text, "RD$ "+tbttneto.Text};

                //dgvPlus.Rows.Clear();
                //dgvPlus.Rows.Add(row0);      

                //DataTable DtReportTotals = GetDataTableFromDGV(dgvPlus);
                //DataSet dxmltotales = new DataSet();
                DataTable DtReportTotals = oper.ConsultaConResultadodt("SELECT mes, totalbruto, totalisr, totalss, totalahorros, totaldescuentos, totalneto FROM cabecera_nomina WHERE id = '"+ tbnumnomina.Text +"';");

                dsxml.Tables.Add(DtReportTotals);

                dsxml.WriteXml("c:\\sistema\\nomina.xml");

                Form f = new VisorDeFormularios("Nomina.rpt");
                f.ShowDialog();
            }
            catch (Exception ex) 
            {
                throw ex;
                MessageBox.Show("Error al Crear el Archivo Xml", "Aviso");
            }

        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        public void Procesar()
        {

            try
            {
                //Guardar la cabecera de la nómina
                oper.ConsultaSinResultado("INSERT INTO cabecera_nomina(mes, totalisr, totalss, totalahorros, totaldescuentos, totalneto, totalbruto, totalempleados, " +
                    "estado) VALUES('" + cbmes.Text + "','" + totalisr.ToString() + "','" + totalss.ToString() + "','" + totalahorros.ToString() + "','" + totaldesc.ToString() + "','" + totalneto.ToString() + "'," +
                    "'" + totalbruto.ToString() + "','" + datanomina.RowCount.ToString() + "','PROCESADA');");

                //Guardar Detalle de la Nómina
                string nombre;
                string cedula;
                string cargo;
                string sueldo;
                string isr;
                string ss;
                string ahorros;
                string ttdesc;
                string neto;

                for (int i = 0; i < datanomina.RowCount; i++)
                {
                    nombre = datanomina.Rows[i].Cells[0].Value.ToString();
                    cedula = datanomina.Rows[i].Cells[1].Value.ToString();
                    cargo = datanomina.Rows[i].Cells[2].Value.ToString();
                    sueldo = datanomina.Rows[i].Cells[3].Value.ToString();
                    isr = datanomina.Rows[i].Cells[4].Value.ToString();
                    ss = datanomina.Rows[i].Cells[5].Value.ToString();
                    ahorros = datanomina.Rows[i].Cells[6].Value.ToString();
                    ttdesc = datanomina.Rows[i].Cells[7].Value.ToString();
                    neto = datanomina.Rows[i].Cells[8].Value.ToString();

                    oper.ConsultaSinResultado("INSERT INTO detalle_nomina (idnom, nombre, cedula, cargo, sueldo, isr," +
                        "ss, ahorro, ttdescuentos, sueldoneto) VALUES ('" + tbnumnomina.Text + "', '" + nombre + "', '" + cedula + "'" +
                        ", '" + cargo + "', '" + sueldo + "', '" + isr + "', '" + ss + "', '" + ahorros + "', '" + ttdesc + "', '" + neto + "')");
                }

                tbestado.Text = "PROCESADA";
                btnprocesar.Enabled = false;
                btnimprimir.Enabled = true;
                MessageBox.Show("¡La nómina se procesó satisfactoriamente!", "Aviso");
            }
            catch
            {
                MessageBox.Show("Hubo un error al tatar de procesar la nómina", "Aviso");
            }

        }

        private void btnemitir_Click(object sender, EventArgs e)
        {
            DialogResult Eliminar = MessageBox.Show("¿Está a punto de emitir la nómina para su entrega, ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (Eliminar == DialogResult.Yes)
            {
                Emitir();
            }
            else if (Eliminar == DialogResult.No)
            {
                //No hacer nada
            }            
        }

        public void Emitir()
        {
            try
            {
                oper.ConsultaSinResultado("UPDATE cabecera_nomina SET estado = 'EMITIDA' WHERE id = '" + tbnumnomina.Text + "';");
                tbestado.Text = "EMITIDA";
                btnemitir.Enabled = false;
                MessageBox.Show("La nómina se emitió satisfactoriamente", "Aviso");
            }
            catch
            {
                MessageBox.Show("Hubo un error al Emitir la nómina inténtelo de nuevo", "Aviso");
            }
        }

        private void btnnomina_Click(object sender, EventArgs e)
        {
            Form f = new BuscarNómina();
            f.ShowDialog();
            if (buscarnom)
            {
                Buscar();
                buscarnom = false;
            }
            else { }
        }

        public void Buscar()
        {
            try
            {
                Nuevo();
                //Cargar la Cabecera de la Nómina
                ds = oper.ConsultaConResultadods("SELECT * FROM cabecera_nomina WHERE id = '" + numnomina + "' AND estado != 'DESACTIVADO';");
                tbnumnomina.Text = ds.Tables[0].Rows[0][0].ToString();
                cbmes.Text = ds.Tables[0].Rows[0][1].ToString();
                tbttirs.Text = ds.Tables[0].Rows[0][2].ToString();
                tbttss.Text = ds.Tables[0].Rows[0][3].ToString();
                tbttahorros.Text = ds.Tables[0].Rows[0][4].ToString();
                tbttdesc.Text = ds.Tables[0].Rows[0][5].ToString();
                tbttneto.Text = ds.Tables[0].Rows[0][6].ToString();
                tbttbruto.Text = ds.Tables[0].Rows[0][7].ToString();
                tbestado.Text = ds.Tables[0].Rows[0][9].ToString();

                //Bloquear Controles necesarios
                cbmes.Enabled = false;
                btngenerar.Enabled = false;
                btnimprimir.Enabled = true;
                btneliminar.Enabled = true;

                if (tbestado.Text == "PROCESADA") { btnemitir.Enabled = true; } else { btnemitir.Enabled = false; }

                //Cargar el Detalle de la nómina
                dt = oper.ConsultaConResultadodt("SELECT * FROM detalle_nomina WHERE idnom = '" + tbnumnomina.Text + "'");
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

                for (int i = 0; i < (dataGridView1.RowCount - 1); i++)
                {

                    datanomina.Rows.Add();
                    for (int k = 0; k < 9; k++)
                    {
                        datanomina.Rows[i].Cells[k].Value = dataGridView1.Rows[i].Cells[k + 2].Value;
                    }

                    datanomina.Refresh();
                }
            }
            catch
            {
                MessageBox.Show("Esta nómina no existe, intente con otro número de nómina...", "Aviso");
            }


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult Eliminar = MessageBox.Show("¿Seguro que desea eliminar la nómina: #" + tbnumnomina.Text + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(Eliminar == DialogResult.Yes)
            {
                EliminarNomina();
            }
            else if (Eliminar == DialogResult.No)
            {
                //No hacer nada
            }
        }

        public void EliminarNomina()
        {
            oper.ConsultaSinResultado("UPDATE cabecera_nomina SET estado = 'DESACTIVADO' WHERE id = '"+ tbnumnomina.Text +"'");
            Nuevo();
        }
    }
}
