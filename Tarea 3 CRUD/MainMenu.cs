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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btndepartamentos_Click(object sender, EventArgs e)
        {
            Form f = new Admin_Departamentos();
            f.ShowDialog();
        }

        private void btncargos_Click(object sender, EventArgs e)
        {
            Form f = new AdminCargos();
            f.ShowDialog();
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            Form f = new Empleados();
            f.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            btnnomina.Select();
        }

        private void btnnomina_Click(object sender, EventArgs e)
        {
            Form f = new GenerarNomina();
            f.ShowDialog();
        }

        private void btnconsultnom_Click(object sender, EventArgs e)
        {
            Form f = new BuscarNómina();
            f.ShowDialog();
            if (GenerarNomina.buscarnom)
            {
                f = new GenerarNomina();
                f.ShowDialog();
            }
        }
    }
}
