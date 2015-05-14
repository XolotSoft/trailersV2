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
    public partial class vehiculosIndex : Form
    {
        public vehiculosIndex()
        {
            InitializeComponent();
        }

        private static vehiculosIndex frmInst = null;
        private BaseDatos bd = new BaseDatos();

        public static vehiculosIndex Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true)
            {
                frmInst = new vehiculosIndex();
            }

            frmInst.BringToFront();
            return frmInst;
        }

        private void vehiculosIndex_Load(object sender, EventArgs e)
        {
            bd.buscar("SELECT id, marca AS Marca, tipo AS Tipo, modelo AS Modelo, placa AS Placas, serie AS Serie FROM vehiculos");
            dgvOperador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOperador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOperador.RowHeadersVisible = false;
            dgvOperador.DataSource = bd.ds.Tables[0];
            dgvOperador.Columns["id"].Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            vehiculoNuevo index = null;
            index = vehiculoNuevo.Instancia();
            index.MdiParent = MDI.ActiveForm;
            index.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseDatos bd = new BaseDatos();
            string sql = "SELECT id, marca AS Marca, tipo AS Tipo, modelo AS Modelo, placa AS Placas, serie AS Serie FROM vehiculos WHERE marca LIKE '%" + txbFiltrar.Text + "%' OR tipo LIKE '%" + txbFiltrar.Text + "%' OR modelo LIKE '%" + txbFiltrar.Text + "%' OR placa LIKE '%" + txbFiltrar.Text + "%' OR serie LIKE '%" + txbFiltrar.Text + "%'";
            bd.buscar(sql);
            dgvOperador.DataSource = bd.ds.Tables[0];
        }

        private void dgvOperador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string id = Convert.ToString(dgvOperador.Rows[e.RowIndex].Cells[0].Value);
            Variables.idx(id);
            vehiculoEditar editar = null;
            editar = vehiculoEditar.Instancia();
            editar.MdiParent = MDI.ActiveForm;
            editar.Show();
            this.Close();
        }

        private void txbFiltrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1.PerformClick();
            }
        }
    }
}
