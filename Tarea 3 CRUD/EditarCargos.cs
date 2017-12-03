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
    public partial class EditarCargos : Form
    {
        public static string id;
        public static bool nuevo = false;
        operacion oper = new operacion();
        DataSet ds = new DataSet();

        public EditarCargos()
        {
            InitializeComponent();
        }

        private void EditarCargos_Load(object sender, EventArgs e)
        {
            if (!nuevo)
            {
                Buscar();
            }
            else
            {
                Nuevo();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds = oper.ConsultaConResultadods("SELECT id FROM cargo WHERE id==(SELECT max(id) FROM cargo);");
            id = (Convert.ToInt32(id) + 1).ToString();
            id = ds.Tables[0].Rows[0][0].ToString();
            Nuevo();
        }

        public void Nuevo()
        {
            tbid.Text = id;
            tbnombre.Text = "";
            rdbactivo.PerformClick();
            nuevo = true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string estado;
            if (rdbactivo.Checked)
            {
                estado = "ACTIVO";
            }
            else
            {
                estado = "DESACTIVADO";
            }

            if (nuevo)
            {
                oper.ConsultaSinResultado("INSERT INTO cargo (descripcion, estado) VALUES ('" + tbnombre.Text + "','" + estado + "');");
                nuevo = false;
            }
            else
            {
                oper.ConsultaSinResultado("UPDATE cargo SET descripcion = '" + tbnombre.Text + "', estado = '" + estado + "' WHERE id = '" + tbid.Text + "';");
            }
            MessageBox.Show("Guardado Correctamente", "Guardar");
        }

        public void Buscar()
        {

            try
            {
                ds = oper.ConsultaConResultadods("SELECT * FROM cargo WHERE id = '" + id + "';");
                tbid.Text = ds.Tables[0].Rows[0][0].ToString();
                tbnombre.Text = ds.Tables[0].Rows[0][1].ToString();
                if (ds.Tables[0].Rows[0][2].ToString() == "ACTIVO")
                {
                    rdbactivo.PerformClick();
                }
                else
                {
                    rdbinactivo.PerformClick();
                }

                nuevo = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema al cargar el cargo", "Aviso");
            }

        }
    }
}
