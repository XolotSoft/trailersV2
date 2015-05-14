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
    public partial class operadorIndex : Form
    {
        public operadorIndex()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private static operadorIndex frmInst = null;
        private BaseDatos bd = new BaseDatos();

        public static operadorIndex Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true)
            {
                frmInst = new operadorIndex();
            }

            frmInst.BringToFront();
            return frmInst;
        }

        private void operadorIndex_Load(object sender, EventArgs e)
        {
            bd.buscar("SELECT id, nombre AS Nombre, paterno AS Paterno, materno AS Materno, licencia AS Licencia, multas AS Multas FROM operadores");
            dgvOperador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOperador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOperador.RowHeadersVisible = false;
            dgvOperador.DataSource = bd.ds.Tables[0];
            dgvOperador.Columns["id"].Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            operadorNuevo nuevo = null;
            nuevo = operadorNuevo.Instancia();
            nuevo.MdiParent = MDI.ActiveForm;
            nuevo.Show();
            this.Close();
        }

        private void dgvOperador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string id = Convert.ToString(dgvOperador.Rows[e.RowIndex].Cells[0].Value);
            Variables.idx(id);
            operadorEditar editar = null;
            editar = operadorEditar.Instancia();
            editar.MdiParent = MDI.ActiveForm;
            editar.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseDatos bd = new BaseDatos();
            string sql = "SELECT id, nombre AS Nombre, paterno AS Paterno, materno AS Materno, licencia AS Licencia, multas AS Multas FROM operadores WHERE nombre LIKE '%" + txbFiltrar.Text + "%' OR paterno LIKE '%" + txbFiltrar.Text + "%' OR materno LIKE '%" + txbFiltrar.Text + "%' OR licencia LIKE '%" + txbFiltrar.Text + "%'"; 
            bd.buscar(sql);
            dgvOperador.DataSource = bd.ds.Tables[0];
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
