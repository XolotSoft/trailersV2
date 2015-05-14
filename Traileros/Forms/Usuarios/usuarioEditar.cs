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
    public partial class usuarioEditar : Form
    {
        public usuarioEditar()
        {
            InitializeComponent();
        }

        private static usuarioEditar frmInst = null;
        private BaseDatos bd = new BaseDatos();

        public static usuarioEditar Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true)
            {
                frmInst = new usuarioEditar();
            }

            frmInst.BringToFront();
            return frmInst;
        }

        private void usuarioEditar_Load(object sender, EventArgs e)
        {
            bd.buscar("SELECT * FROM usuarios where id = '" + Variables.id + "'");
            txbNombre.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["nombre"]);
            txbUser.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["username"]);
            cmbRol.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["rol"]);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Index();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Realmente deseas eliminar el registro", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogo == DialogResult.OK)
            {
                string sql = "DELETE FROM usuarios WHERE id = '" + Variables.id + "'";
                if (bd.insertar(sql))
                {
                    MessageBox.Show("Se ha eliminado correctamente el usuario", "Correcto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Index();
                }
                else
                {
                    MessageBox.Show("No se ha eliminado", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE usuarios SET nombre = '"+txbNombre.Text+"', username = '"+txbUser.Text+"', password = '"+txbPass.Text+"', rol = '"+cmbRol.Text+"' WHERE id = '" + Variables.id + "'";
            if (Vacio.txb(this))
            {
                if (Vacio.cbx(this))
                {
                    if (txbPass.Text == txbConfirmar.Text)
                    {
                        if (bd.insertar(sql))
                        {
                            MessageBox.Show("Se ha modificado correctamente el usuario", "Correcto",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Index();
                        }
                        else
                        {
                            MessageBox.Show("No se ha modificado", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Atención",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una opción", "Atención",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes llenar todos los campos", "Atención",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Index()
        {
            usuarioIndex index = null;
            index = usuarioIndex.Instancia();
            index.MdiParent = MDI.ActiveForm;
            index.Show();
            this.Close();
        }

        #region validaciones

        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letrasyesp(e);
        }

        private void txbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void txbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void txbConfirmar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }
        #endregion
    }
}
