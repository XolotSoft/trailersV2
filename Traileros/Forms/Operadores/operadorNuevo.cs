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
    public partial class operadorNuevo : Form
    {
        public operadorNuevo()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            dtpNacimiento.Format = DateTimePickerFormat.Custom;
            dtpNacimiento.CustomFormat = "yyyy-MM-dd";
        }

        private static operadorNuevo frmInst = null;
        private BaseDatos bd = new BaseDatos();

        public static operadorNuevo Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true) frmInst = new operadorNuevo();
            frmInst.BringToFront();
            return frmInst;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txbNumero.Text == string.Empty) txbNumero.Text = "S/N";
            if (Vacio.txb(this))
            {
                if (!Validar.mail(txbEmail.Text))
                {
                    MessageBox.Show("El formato del eMail es incorrecto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txbEmail.Focus();
                } 
                else
                {
                    string sql = "INSERT INTO operadores(nombre,paterno,materno,nacimiento,calle,numero,colonia,delegacion,telefono,email,licencia,estado,multas) VALUES ('" +
                        txbNombre.Text.Trim() + "','" + txbPaterno.Text.Trim() + "','" + txbMaterno.Text.Trim() + "','" + dtpNacimiento.Text.Trim() + "','" + txbCalle.Text.Trim() + "','" + txbNumero.Text.Trim() + "','" +
                        txbColonia.Text.Trim() + "','" + txbDelegacion.Text.Trim() + "','" + txbTelefono.Text.Trim() + "','" + txbEmail.Text.Trim() + "','" + txbLicencia.Text.Trim() + "','libre','0')";
                    if (bd.insertar(sql))
                    {
                        MessageBox.Show("Se ha agregado correctamente el operador", "Correcto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Index();
                    }
                    else
                    {
                        MessageBox.Show("No se agrego el operador", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void txbEmail_Leave(object sender, EventArgs e)
        {
            if (txbEmail.Text != string.Empty)
            {
                if (!Validar.mail(txbEmail.Text))
                {
                    MessageBox.Show("El formato del eMail es incorrecto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txbEmail.Focus();
                }
            } 
        }

        private void Index()
        {
            operadorIndex index = null;
            index = operadorIndex.Instancia();
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

        private void txbPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letrasyesp(e);
        }

        private void txbMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letrasyesp(e);
        }

        private void txbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.num(e);
        }

        private void txbLicencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void txbCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynumesp(e);
        }

        private void txbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynumesp(e);
        }

        private void txbColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynumesp(e);
        }

        private void txbDelegacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letrasyesp(e);
        }
        #endregion
    }
}
