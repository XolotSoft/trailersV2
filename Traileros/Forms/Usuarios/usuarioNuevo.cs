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
    public partial class usuarioNuevo : Form
    {
        public usuarioNuevo()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private static usuarioNuevo frmInst = null;
        private BaseDatos bd = new BaseDatos();

        public static usuarioNuevo Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true)
            {
                frmInst = new usuarioNuevo();
            }

            frmInst.BringToFront();
            return frmInst;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO usuarios(nombre, username, password, rol) VALUES('" + txbNombre.Text.Trim() + "','" + txbUsuario.Text.Trim() + "','" + txbPass.Text.Trim() + "','" + cmbRol.Text + "')";
            if (Vacio.txb(this))
            {
                if (Vacio.cbx(this))
                {
                    if (txbPass.Text == txbConfirmar.Text)
                    {
                        string sq = "SELECT * FROM usuarios WHERE username = '" + txbUsuario.Text + "'";
                        bd.buscar(sq);
                        if (bd.ds.Tables[0].Rows.Count > 0)
                        {
                            MessageBox.Show("Ya existe un usuario registrado con este Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (bd.insertar(sql))
                            {
                                MessageBox.Show("Usuario creado correctamente", "Atención",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Index();
                            }
                            else
                            {
                                MessageBox.Show("No se guardo el usuario", "Atención",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Index();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar.todo(this);
        }

        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letrasyesp(e);
        }

        private void txbUsuario_KeyPress(object sender, KeyPressEventArgs e)
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
