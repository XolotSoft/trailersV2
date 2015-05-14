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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarioIndex index = null;
            index = usuarioIndex.Instancia();
            index.MdiParent = this;
            index.Show();
        }

        private void vehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vehiculosIndex index = null;
            index = vehiculosIndex.Instancia();
            index.MdiParent = this;
            index.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void operadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operadorIndex index = null;
            index = operadorIndex.Instancia();
            index.MdiParent = this;
            index.Show();
            Form frm = this.MdiChildren.FirstOrDefault(x => x is operadorEditar || x is operadorNuevo);
            if (frm != null) frm.Close();
        }

        private void entregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            indexCargas cargas = null;
            cargas = indexCargas.Instancia();
            cargas.MdiParent = this;
            cargas.Show();
            Form frm = this.MdiChildren.FirstOrDefault(x => x is Combustibles || x is Operadores || x is Vehiculos || x is Cargas);
            if (frm != null) frm.Close();
        }
    }
}
