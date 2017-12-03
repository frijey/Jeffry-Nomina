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
    public partial class AdminCargos : Form
    {
        operacion oper = new operacion();
        public DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public AdminCargos()
        {
            InitializeComponent();
        }

        private void AdminCargos_Load(object sender, EventArgs e)
        {
            Actualizar();
            dgrprincipal.ReadOnly = true;
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

            dt = oper.ConsultaConResultadodt("SELECT * FROM cargo WhERE estado LIKE '%" + estado + "%'");
            dgrprincipal.DataSource = dt;
            dgrprincipal.Refresh();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Form f = new EditarCargos();

            string id;
            ds = oper.ConsultaConResultadods("SELECT id FROM cargo WHERE id==(SELECT max(id) FROM cargo);");
            id = ds.Tables[0].Rows[0][0].ToString();
            id = (Convert.ToInt32(id) + 1).ToString();
            EditarCargos.id = id;
            EditarCargos.nuevo = true;

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
            Form f = new EditarCargos();

            string id;
            id = dgrprincipal.CurrentRow.Cells[0].Value.ToString();
            EditarCargos.id = id;
            EditarCargos.nuevo = false;

            f.ShowDialog();
            Actualizar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dgrprincipal_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }
    }
}
