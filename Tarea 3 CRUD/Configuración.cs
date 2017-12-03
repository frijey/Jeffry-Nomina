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
    public partial class Configuración : Form
    {
        operacion oper = new operacion();
        DataSet ds = new DataSet();

        public Configuración()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Guardar();
            this.Close();
        }

        public void Guardar()
        {
            try
            {
                double isr = Convert.ToDouble(tbisr.Text);
                double ss = Convert.ToDouble(tbss.Text);
                oper.ConsultaSinResultado("UPDATE configuracion SET isr = '" + isr.ToString() + "', ss = '" + ss.ToString() + "'");
            }
            catch
            {
                MessageBox.Show("Coloque valores válidos", "Aviso");
                tbisr.Select();
                tbisr.Focus();
            }


        }

        private void Configuración_Load(object sender, EventArgs e)
        {
            Abrir();
        }

        public void Abrir()
        {
            try
            {
                ds = oper.ConsultaConResultadods("SELECT * FROM configuracion;");
                tbisr.Text = ds.Tables[0].Rows[0][0].ToString();
                tbss.Text = ds.Tables[0].Rows[0][1].ToString();
            }
            catch
            {
                MessageBox.Show("Error al cargar la configuracion, guarde nuevos valores e inténtelo de nuevo", "Aviso");
            }


        }

        private void tbisr_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Guardar();
                this.Close();
            }
        }
    }
}
