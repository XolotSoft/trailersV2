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
    public partial class vehiculoNuevo : Form
    {
        public vehiculoNuevo()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            dtpAdquicision.Format = DateTimePickerFormat.Custom;
            dtpAdquicision.CustomFormat = "yyyy-MM-dd";
            dtpServicio.Format = DateTimePickerFormat.Custom;
            dtpServicio.CustomFormat = "yyyy-MM-dd";
        }

        private static vehiculoNuevo frmInst = null;
        private BaseDatos bd = new BaseDatos();
        int result;

        public static vehiculoNuevo Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true)
            {
                frmInst = new vehiculoNuevo();
            }

            frmInst.BringToFront();
            return frmInst;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (Vacio.txb(this))
            {
                if (Vacio.cbx(this))
                {
                    result = dtpAdquicision.Value.CompareTo(dtpServicio.Value);
                    if (result > 0)
                    {
                        MessageBox.Show("La fecha de servicio no puede ser menor a la de adquisición","Atención",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sq = "SELECT * FROM vehiculos WHERE placa = '" + txbPlaca.Text + "'";
                        bd.buscar(sq);
                        if (bd.ds.Tables[0].Rows.Count > 0)
                        {
                            MessageBox.Show("Ya existe un vehiculo registrado con estos datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            string sql = "INSERT INTO vehiculos(serie,marca,tipo,modelo,placa,adquicision,servicio,mantenimiento,estado,DF,Chihuahua,Moterrey,Hermosillo)VALUES('" +
                            txbSerie.Text + "','" + txbMarca.Text + "','" + txbTipo.Text + "','" + txbModelo.Text + "','" + txbPlaca.Text + "','" +
                            dtpAdquicision.Text + "','" + dtpServicio.Text + "','" + cmbMantenimiento.Text + "','libre','0','0','0','0')";
                            if (bd.insertar(sql))
                            {
                                MessageBox.Show("Vehiculo agregado correctamente", "Atención",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                                vehiculosIndex index = null;
                                index = vehiculosIndex.Instancia();
                                index.MdiParent = MDI.ActiveForm;
                                index.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se guardo el vehiculo", "Atención",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar.todo(this);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            vehiculosIndex index = null;
            index = vehiculosIndex.Instancia();
            index.MdiParent = MDI.ActiveForm;
            index.Show();
            this.Close();
        }

        private void vehiculoNuevo_Load(object sender, EventArgs e)
        {

        }

        private void txbSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void txbModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.num(e);
        }

        private void txbMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynumesp(e);
        }

        private void txbTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynumesp(e);
        }

        private void txbPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void dtpAdquicision_ValueChanged(object sender, EventArgs e)
        {
            result = dtpAdquicision.Value.CompareTo(dtpServicio.Value);
            if (result > 0) MessageBox.Show("La fecha de servicio no puede ser menor a la de adquisición", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dtpServicio_ValueChanged(object sender, EventArgs e)
        {
            result = dtpAdquicision.Value.CompareTo(dtpServicio.Value);
            if (result > 0) MessageBox.Show("La fecha de servicio no puede ser menor a la de adquisición", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
