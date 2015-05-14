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
    public partial class usuarioIndex : Form
    {
        public usuarioIndex()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private static usuarioIndex frmInst = null;

        public static usuarioIndex Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true)
            {
                frmInst = new usuarioIndex();
            }

            frmInst.BringToFront();
            return frmInst;
        }

        private void usuarioIndex_Load(object sender, EventArgs e)
        {
            BaseDatos bd = new BaseDatos();
            bd.buscar("SELECT id, nombre AS Nombre ,username AS Usuario, rol AS Rol FROM usuarios");
            dgvOperador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOperador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOperador.RowHeadersVisible = false;
            dgvOperador.DataSource = bd.ds.Tables[0];
            dgvOperador.Columns["id"].Visible = false;
        }

        private void dgvOperador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string id = Convert.ToString(dgvOperador.Rows[e.RowIndex].Cells[0].Value);
            Variables.idx(id);
            usuarioEditar editar = null;
            editar = usuarioEditar.Instancia();
            editar.MdiParent = MDI.ActiveForm;
            editar.Show();
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            usuarioNuevo nuevo = null;
            nuevo = usuarioNuevo.Instancia();
            nuevo.MdiParent = MDI.ActiveForm;
            nuevo.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseDatos bd = new BaseDatos();
            string sql = "SELECT id, nombre AS Nombre ,username AS Usuario, rol AS Rol FROM usuarios WHERE nombre LIKE '%" + txbFiltrar.Text + "%' OR username LIKE '%" + txbFiltrar.Text + "%' OR rol LIKE '%" + txbFiltrar.Text + "%'";
            bd.buscar(sql);
            dgvOperador.DataSource = bd.ds.Tables[0];
        }
    }
}
