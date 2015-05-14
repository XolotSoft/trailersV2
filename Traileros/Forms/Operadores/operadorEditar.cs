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
    public partial class operadorEditar : Form
    {
        public operadorEditar()
        {
            InitializeComponent();
            dtpNacimiento.Format = DateTimePickerFormat.Custom;
            dtpNacimiento.CustomFormat = "yyyy-MM-dd";
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private static operadorEditar frmInst = null;

        public static operadorEditar Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true) frmInst = new operadorEditar();
            frmInst.BringToFront();
            return frmInst;
        }

        private void operadorEditar_Load(object sender, EventArgs e)
        {
            BaseDatos bd = new BaseDatos();
            bd.buscar("SELECT * FROM operadores where id = '"+Variables.id+"'");
            txbNombre.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["nombre"]);
            txbPaterno.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["paterno"]);
            txbMaterno.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["materno"]);
            txbCalle.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["calle"]);
            txbNumero.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["numero"]);
            txbColonia.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["colonia"]);
            txbDelegacion.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["delegacion"]);
            txbTelefono.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["telefono"]);
            txbEmail.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["email"]);
            txbLicencia.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["licencia"]);
            dtpNacimiento.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["nacimiento"]);
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Index();
        }

        private void btnMulta_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Realmente deseas multar a este operador", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogo == DialogResult.OK)
            {
                BaseDatos update = new BaseDatos();
                string sql = "UPDATE operadores SET multas = multas + 1 WHERE id = " + Variables.id;
                if (update.insertar(sql))
                {
                    MessageBox.Show("Se ha multado el operador");
                    Index();
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseas quitar una multa a este operador", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogo == DialogResult.OK)
            {
                BaseDatos update = new BaseDatos();
                string consulta = "SELECT multas FROM operadores WHERE id = " + Variables.id;
                update.buscar(consulta);
                if (Convert.ToInt16(update.ds.Tables[0].Rows[0]["multas"]) == 0)
                {
                    MessageBox.Show("No hay multas que quitar", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
                else
                {
                    string sql = "UPDATE operadores SET multas = multas - 1 WHERE id = " + Variables.id;
                    if (update.insertar(sql))
                    {
                        MessageBox.Show("Se ha eliminado la multada a el operador");
                        Index();
                    }
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogo =  MessageBox.Show("Realmente deseas eliminar el registro", "Atención", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dialogo == DialogResult.OK)
            {
                BaseDatos bd = new BaseDatos();
                string sql = "DELETE FROM operadores WHERE id = '" + Variables.id + "'";
                if (bd.insertar(sql))
                {
                    MessageBox.Show("Se ha eliminado correctamente el operador");
                    Index();
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (Vacio.txb(this))
            {
                BaseDatos bd = new BaseDatos();
                string sql = "UPDATE operadores SET nombre = '" + txbNombre.Text.Trim() + "',paterno = '" + txbPaterno.Text.Trim() + "',materno = '" +
                    txbMaterno.Text.Trim() + "',calle = '" + txbCalle.Text.Trim() + "',numero = '" + txbNumero.Text.Trim() + "',nacimiento = '" +
                    dtpNacimiento.Text.Trim() + "',colonia = '" + txbColonia.Text.Trim() + "',telefono = '" + txbTelefono.Text.Trim() + "',delegacion = '" +
                    txbDelegacion.Text.Trim() + "',email = '" + txbEmail.Text.Trim() + "',licencia = '" + txbLicencia.Text.Trim() + "' WHERE id = '" + Variables.id + "'  ";
                if (bd.insertar(sql))
                {
                    MessageBox.Show("Se ha modificado correctamente el operador", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Index();
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
            operadorIndex index = null;
            index = operadorIndex.Instancia();
            index.MdiParent = MDI.ActiveForm;
            index.Show();
            this.Close();
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
