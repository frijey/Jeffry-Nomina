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
    public partial class HEXTODEC : Form
    {
        operacion oper = new operacion();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public bool guardado = false;
        public static string idbuscar = "1";
        public static bool nuevo = false;

        //Variables de los campos que se van a usar en los INSERT y UPDATE
        static string id, nombre, apellidos, cedula, fechanac, fechaing,
            iddepart, idcargo, sueldo, ahorro, imagerute, estado;

        public HEXTODEC()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            if (tbnombre.Text != "" && tbapellidos.Text != "" && cbdepto.Text != "" && cbcargo.Text != "" && tbcedula.Text != "")
            {
                Guardar();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos para poder guardar los cambios", "Aviso");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void HEXTODEC_Load(object sender, EventArgs e)
        {
            if (nuevo) { Nuevo(); }
            else
            {
                tbbuscar.Text = idbuscar;
                Buscar();
                Actualizar();
            }
            nuevo = false;

        }

        public void Guardar()
        {
            OrdenarDatos();

            if (guardado)
            {
                oper.ConsultaSinResultado("UPDATE empleado SET nombre = '" + nombre + "', apellidos = '" + apellidos + "'" +
                    ", cedula = '" + cedula + "', fechanac = '" + fechanac + "', fechaing = '" + fechaing + "', iddepart = '" + iddepart + "'" +
                    ", idcargo = '" + idcargo + "', sueldo = '" + sueldo + "', ahorro = '" + ahorro + "', foto = '" + imagerute + "'" +
                    ", estado = '" + estado + "' WHERE id = '" + id + "';");
            }
            else
            {
                oper.ConsultaSinResultado("INSERT INTO empleado (nombre, apellidos, cedula, fechanac, fechaing, iddepart, idcargo, " +
                "sueldo, ahorro, foto, estado) VALUES ('" + nombre + "', '" + apellidos + "', '" + cedula + "', '" + fechanac + "'" +
                ", '" + fechaing + "', '" + iddepart + "', '" + idcargo + "', '" + sueldo + "', '" + ahorro + "', '" + imagerute + "'" +
                ", '" + estado + "');");
                guardado = true;
            }

            MessageBox.Show("Guardado Correctamente", "Guardar");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                int nuevo = Convert.ToInt32(tbid.Text);
                nuevo++;
                tbbuscar.Text = nuevo.ToString();
                Buscar();
            }
            catch
            {

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbid.Text != "1")
                {
                    int nuevo = Convert.ToInt32(tbid.Text);
                    nuevo--;
                    tbbuscar.Text = nuevo.ToString();
                    Buscar();
                }
                else { }
            }
            catch
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void Nuevo()
        {
            ds = oper.ConsultaConResultadods("SELECT max(id) FROM empleado");
            tbid.Text = (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
            tbnombre.Text = "";
            tbapellidos.Text = "";
            tbcedula.Text = "";
            dtnacimiento.Text = DateTime.Now.ToShortDateString();
            dtfechaing.Text = DateTime.Now.ToShortDateString();
            cbdepto.Text = "";
            cbcargo.Text = "";
            tbsueldo.Text = "";
            tbahorro.Text = "";
            //Asignar la Foto por Defecto
            rdbactivo.PerformClick();
            guardado = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Buscar()
        {
            string departamento;
            string cargo;

            if (tbbuscar.Text != "")
            {
                string id = tbbuscar.Text;
                if (id == "")
                {
                    id = "1";
                }
                else
                {
                }

                try
                {
                    ds = oper.ConsultaConResultadods("SELECT * FROM empleado WHERE id = '" + id + "';");
                    tbid.Text = ds.Tables[0].Rows[0][0].ToString();
                    tbnombre.Text = ds.Tables[0].Rows[0][1].ToString();
                    tbapellidos.Text = ds.Tables[0].Rows[0][2].ToString();
                    tbcedula.Text = ds.Tables[0].Rows[0][3].ToString();

                    try
                    {
                        //Cargar Fechas
                        dtnacimiento.Text = ds.Tables[0].Rows[0][4].ToString();
                        dtfechaing.Text = ds.Tables[0].Rows[0][5].ToString();
                    }
                    catch
                    {
                        MessageBox.Show("No se cargaron correctamente las fechas del empleado", "Aviso");
                    }

                    //Id Foráneos del Departamento y Cargo
                    departamento = ds.Tables[0].Rows[0][6].ToString();
                    cargo = ds.Tables[0].Rows[0][7].ToString();

                    tbsueldo.Text = ds.Tables[0].Rows[0][8].ToString();
                    tbahorro.Text = ds.Tables[0].Rows[0][9].ToString();

                    try
                    {
                        //Establecer la foto del empleado a partir de la ruta
                        imagerute = ds.Tables[0].Rows[0][10].ToString();
                        ptbfotoempleado.Image = Image.FromFile(imagerute);
                    }
                    catch
                    {
                        ptbfotoempleado.Image = null;
                    }

                    if (ds.Tables[0].Rows[0][11].ToString() == "ACTIVO")
                    {
                        rdbactivo.PerformClick();
                    }
                    else
                    {
                        rdbinactivo.PerformClick();
                    }

                    try
                    {
                        ds = oper.ConsultaConResultadods("SELECT descripcion FROM departamento WHERE id = '" + departamento + "';");
                        cbdepto.Text = ds.Tables[0].Rows[0][0].ToString();

                        ds = oper.ConsultaConResultadods("SELECT descripcion FROM cargo WHERE id = '" + cargo + "';");
                        cbcargo.Text = ds.Tables[0].Rows[0][0].ToString();
                    }
                    catch (Exception)
                    {
                        cbdepto.Text = "";
                        cbcargo.Text = "";
                    }

                    guardado = true;

                    tbbuscar.Text = "";
                    tbbuscar.Select();
                    tbbuscar.Focus();
                }
                catch (Exception)
                {
                    tbbuscar.Text = "";
                    MessageBox.Show("Este Empleado no Existe", "Aviso");
                }
            }
            else
            {

            }

        }

        private void tbnombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            else { }
        }

        private void tbbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar();
            }
        }

        private void btndepartagregar_Click(object sender, EventArgs e)
        {
            Form f = new Admin_Departamentos();
            f.ShowDialog();
            Actualizar();
        }

        public void Actualizar()
        {
            cbdepto.Items.Clear();
            cbcargo.Items.Clear();

            ds = oper.ConsultaConResultadods("SELECT descripcion FROM departamento");
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                cbdepto.Items.Add(fila["descripcion"].ToString());
            }

            ds = oper.ConsultaConResultadods("SELECT descripcion FROM cargo");
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                cbcargo.Items.Add(fila["descripcion"].ToString());
            }

        }

        private void btncargoagregar_Click(object sender, EventArgs e)
        {
            Form f = new AdminCargos();
            f.ShowDialog();
            Actualizar();
        }

        private void ptbfotoempleado_Click(object sender, EventArgs e)
        {
            //FileDialog();
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                // Set filter options and filter index.
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    imagerute = imagen;
                    ptbfotoempleado.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        public void OrdenarDatos()
        {
            //Método para recolectar las variables y formatearlas.
            id = tbid.Text;
            nombre = tbnombre.Text;
            apellidos = tbapellidos.Text;
            cedula = tbcedula.Text;

            //Dar Formato a las Fechas
            int mes, dia, año;
            string mmes, ddia, aaño;

            año = dtnacimiento.Value.Year;
            mes = dtnacimiento.Value.Month;
            dia = dtnacimiento.Value.Day;

            try
            {
                aaño = año.ToString();

                //Agregar los 0 faltantes al més y día para que tengan el formato correcto, Ej: 2017-07-28
                if (mes < 10) { mmes = ("0" + mes.ToString()); } else { mmes = mes.ToString(); }
                if (dia < 10) { ddia = ("0" + dia.ToString()); } else { ddia = dia.ToString(); }

                //Establecer fecha con los guiones de por medio en formato estandar: año-mes-día...
                fechanac = aaño + "-" + mmes + "-" + ddia;

            }
            catch
            {
                MessageBox.Show("Error al dar formato a la fecha de nacimiento...", "Aviso");
            }

            año = dtfechaing.Value.Year;
            mes = dtfechaing.Value.Month;
            dia = dtfechaing.Value.Day;
            try
            {
                aaño = año.ToString();

                //Agregar los 0 faltantes al més y día para que tengan el formato correcto, Ej: 2017-12-05
                if (mes < 10) { mmes = ("0" + mes.ToString()); } else { mmes = mes.ToString(); }
                if (dia < 10) { ddia = ("0" + dia.ToString()); } else { ddia = dia.ToString(); }

                //Establecer fecha con los guiones de por medio en formato estandar: año-mes-día...
                fechaing = aaño + "-" + mmes + "-" + ddia;

            }
            catch
            {
                MessageBox.Show("Error al dar formato a la fecha de ingreso...", "Aviso");
            }

            try
            {
                ds = oper.ConsultaConResultadods("SELECT id FROM departamento WHERE descripcion = '" + cbdepto.Text + "';");
                iddepart = ds.Tables[0].Rows[0][0].ToString();

                ds = oper.ConsultaConResultadods("SELECT id FROM cargo WHERE descripcion = '" + cbcargo.Text + "';");
                idcargo = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                MessageBox.Show("Comprueba los Campos de Departamento y Cargo...");
                cbdepto.Select();
                iddepart = null;
                idcargo = null;
                return;
            }

            sueldo = tbsueldo.Text;
            ahorro = tbahorro.Text;

            if (rdbactivo.Checked)
            {
                estado = "ACTIVO";
            }
            else
            {
                estado = "DESACTIVADO";
            }

        }

    }
}
