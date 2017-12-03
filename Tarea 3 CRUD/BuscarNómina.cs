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
    public partial class BuscarNómina : Form
    {
        public BuscarNómina()
        {
            InitializeComponent();
        }

        private void BuscarNómina_Load(object sender, EventArgs e)
        {
            tbnumnomina.Select();
            tbnumnomina.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerarNomina.buscarnom = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Buscar()
        {

            try
            {
                GenerarNomina.buscarnom = true;
                GenerarNomina.numnomina = Convert.ToInt32(tbnumnomina.Text).ToString();
                this.Close();
            }
            catch
            {
                tbnumnomina.Text = "";
                tbnumnomina.Select();
                tbnumnomina.Focus();
            }

        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar();
            }
         
        }
    }
}
