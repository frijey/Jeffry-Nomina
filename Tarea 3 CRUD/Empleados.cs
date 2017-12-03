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
    public partial class Empleados : Form
    {
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        operacion oper = new operacion();

        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            try
            {
                datanomina.Rows.Clear();
                //Cargar la Tabla de todos los empleados activos
                dt = oper.ConsultaConResultadodt("SELECT id, nombre, apellidos, idcargo, iddepart, fechaing FROM empleado WHERE estado = 'ACTIVO'");
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                string DeptrCargo = "";

                for (int i = 0; i < (dataGridView1.RowCount - 1); i++)
                {

                    datanomina.Rows.Add();
                    for (int k = 0; k < dataGridView1.Rows[i].Cells.Count; k++)
                    {
                        if (k != 3 && k != 4)
                        {
                            datanomina.Rows[i].Cells[k].Value = dataGridView1.Rows[i].Cells[k].Value;
                        }
                        else
                        {
                            //Cargar el departamento o el cargo a partir de la llave foránea
                            DeptrCargo = dataGridView1.Rows[i].Cells[k].Value.ToString();
                            ds = oper.ConsultaConResultadods("SELECT descripcion FROM departamento WHERE id = '" + DeptrCargo + "';");
                            DeptrCargo = ds.Tables[0].Rows[0][0].ToString();
                            datanomina.Rows[i].Cells[k].Value = DeptrCargo;
                        }
                    }

                }

                btnimprimir.Enabled = true;

            }
            catch
            {

            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta función estará habilitada para la próxima clase...", "Aviso");
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            HEXTODEC.nuevo = true;
            Form f = new HEXTODEC();
            f.ShowDialog();
            ActualizarTabla();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarPor();
        }

        public void BuscarPor()
        {
            try
            {
                datanomina.Rows.Clear();
                //Cargar la Tabla de todos los empleados activos
                if (rdbnombre.Checked)
                {
                    dt = oper.ConsultaConResultadodt("SELECT id, nombre, apellidos, idcargo, iddepart, fechaing FROM empleado WHERE estado = 'ACTIVO' AND nombre LIKE '%" + tbbuscar.Text + "%'");
                }
                else
                {
                    if (rdbapellido.Checked)
                    {
                        dt = oper.ConsultaConResultadodt("SELECT id, nombre, apellidos, idcargo, iddepart, fechaing FROM empleado WHERE estado = 'ACTIVO' AND apellidos LIKE '%" + tbbuscar.Text + "%'");
                    }
                    else
                    {
                        if (rdbcedula.Checked)
                        {
                            dt = oper.ConsultaConResultadodt("SELECT id, nombre, apellidos, idcargo, iddepart, fechaing FROM empleado WHERE estado = 'ACTIVO' AND cedula LIKE '%" + tbbuscar.Text + "%'");
                        }
                        else
                        {
                            if (rdbid.Checked)
                            {
                                dt = oper.ConsultaConResultadodt("SELECT id, nombre, apellidos, idcargo, iddepart, fechaing FROM empleado WHERE estado = 'ACTIVO' AND id LIKE '%" + tbbuscar.Text + "%'");
                            }
                            else
                            {


                            }

                        }

                    }

                }
                
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                string DeptrCargo = "";

                for (int i = 0; i < (dataGridView1.RowCount - 1); i++)
                {

                    datanomina.Rows.Add();
                    for (int k = 0; k < dataGridView1.Rows[i].Cells.Count; k++)
                    {
                        if (k != 3 && k != 4)
                        {
                            datanomina.Rows[i].Cells[k].Value = dataGridView1.Rows[i].Cells[k].Value;
                        }
                        else
                        {
                            //Cargar el departamento o el cargo a partir de la llave foránea
                            DeptrCargo = dataGridView1.Rows[i].Cells[k].Value.ToString();
                            if(k == 3) {
                                ds = oper.ConsultaConResultadods("SELECT descripcion FROM cargo WHERE id = '" + DeptrCargo + "';");
                            } else
                            {
                                ds = oper.ConsultaConResultadods("SELECT descripcion FROM departamento WHERE id = '" + DeptrCargo + "';");
                            }
                            DeptrCargo = ds.Tables[0].Rows[0][0].ToString();
                            datanomina.Rows[i].Cells[k].Value = DeptrCargo;
                        }
                    }

                }

                btnimprimir.Enabled = true;

            }
            catch
            {

            }
        }

        private void tbbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarPor();
        }

        private void btnmostrartodo_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void datanomina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BuscarEmpleado();
        }

        private void datanomina_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarEmpleado();
            }
            else { }
        }

        public void BuscarEmpleado()
        {

            try
            {
                string ideempleado;
                Form f = new HEXTODEC();
                ideempleado = datanomina.CurrentRow.Cells[0].Value.ToString();
                HEXTODEC.idbuscar = ideempleado;
                f.ShowDialog();
                ActualizarTabla();
            }
            catch
            {
            }

        }
    }
}
