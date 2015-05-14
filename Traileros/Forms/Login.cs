using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traileros
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string userInput, passInput;
        string userStored = "admin";
        string passStored = "admin";

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            userInput = txbUsername.Text;
            passInput = txbPassword.Text;
            if (Vacio.txb(this))
            {
                if (userInput == userStored && passInput == passStored)
                {
                    this.Hide();
                    MDI mdi = new MDI();
                    mdi.Show();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar.txb(this);
                    txbUsername.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debes de llenar ambos campos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnEntrar.PerformClick();
            }
        }
    }
}
