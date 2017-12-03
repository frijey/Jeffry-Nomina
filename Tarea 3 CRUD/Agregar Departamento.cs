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
    public partial class Admin_Departamentos : Form
    {
        operacion oper = new operacion();
        public DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public Admin_Departamentos()
        {
            InitializeComponent();
        }

        private void Agregar_Departamento_Load(object sender, EventArgs e)
        {
            Actualizar();
            dgrprincipal.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar()
        {
            string estado;
            if (rdactivo.Checked)
            {
                estado = "ACTIVO";
            }
            else
            {
                if (rdinactivo.Checked)
                {
                    estado = "DESACTIVADO";
                }
                else
                {
                    estado = "";
                }
            }

            dt = oper.ConsultaConResultadodt("SELECT * FROM departamento WhERE estado LIKE '%"+ estado +"%'");
            dgrprincipal.DataSource = dt;
            dgrprincipal.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id;
            try
            {
                id = dgrprincipal.CurrentRow.Cells[0].Value.ToString();
                oper.ConsultaSinResultado("UPDATE departamento SET estado = 'DESACTIVADO' WHERE id = " + id + "");
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione la fila que desea eliminar", "Aviso");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Form f = new EditarDepartamentos();

            string id;
            ds = oper.ConsultaConResultadods("SELECT id FROM departamento WHERE id==(SELECT max(id) FROM departamento);");
            id = ds.Tables[0].Rows[0][0].ToString();
            id = (Convert.ToInt32(id) + 1).ToString();
            EditarDepartamentos.id = id;
            EditarDepartamentos.nuevo = true;

            f.ShowDialog();
            Actualizar();
        }

        private void rdactivo_Click(object sender, EventArgs e)
        {

            Actualizar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Editar();
        }

        public void Editar()
        {
            Form f = new EditarDepartamentos();

            string id;
            id = dgrprincipal.CurrentRow.Cells[0].Value.ToString();
            EditarDepartamentos.id = id;
            EditarDepartamentos.nuevo = false;

            f.ShowDialog();
            Actualizar();
        }

        private void dgrprincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }
    }
}
