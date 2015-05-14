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
    public partial class Vehiculos : Form
    {
        public Vehiculos()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private static Vehiculos frmInst = null;

        public static Vehiculos Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true)
            {
                frmInst = new Vehiculos();
            }

            frmInst.BringToFront();
            return frmInst;
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            BaseDatos veh = new BaseDatos();
            veh.buscar("SELECT id, marca as Marca, tipo AS Tipo, modelo AS Modelo, placa AS Placas FROM vehiculos WHERE estado = 'libre'");
            dgvVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehiculos.RowHeadersVisible = false;
            dgvVehiculos.DataSource = veh.ds.Tables[0];
            dgvVehiculos.Columns["id"].Visible = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (lblVehiculo.Text != "NINGUNO")
            {
                Combustibles com = null;
                com = Combustibles.Instancia();
                com.MdiParent = MDI.ActiveForm;
                com.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No has selecionado un vehículo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string id = Convert.ToString(dgvVehiculos.Rows[e.RowIndex].Cells[0].Value);
            Variables.vehiculo(id);
            lblVehiculo.Text = Convert.ToString(dgvVehiculos.Rows[e.RowIndex].Cells[4].Value);
        }

    }
}
