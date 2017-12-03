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
    public partial class Login : Form
    {
        public static bool entrar = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbusuario.Select();
            entrar = false;
        }

        private void tbentrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void tbsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Entrar()
        {
            if (tbusuario.Text == "jeffry" && tbpassword.Text == "1234")
            {
                entrar = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos Erróneos, inténtelo de nuevo");
                tbpassword.Text = "";
                tbpassword.Select();
            }
        }

        private void tbusuario_KeyUp(object sender, KeyEventArgs e)
        {
            KeyHandeler((Convert.ToInt32(e.KeyCode)));
        }

        public void KeyHandeler(int e)
        {
            if (e == (Convert.ToInt32(Keys.Enter)))
            {
                if (tbpassword.Text == "")
                {
                    SendKeys.Send("{TAB}");
                }
                else
                {
                    Entrar();
                }
            }
            else
            {
            }
        }

        private void tbpassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbpassword.Text != "") {
                if (e.KeyCode == Keys.Enter)
                {
                    Entrar();
                }
                else
                {
                }
            } else
            {
            }

        }
    }
}
