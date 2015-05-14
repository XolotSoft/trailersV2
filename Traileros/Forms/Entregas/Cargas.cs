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
    public partial class Cargas : Form
    {
        public Cargas()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            dtpArribo.Format = DateTimePickerFormat.Custom;
            dtpArribo.CustomFormat = "yyyy-MM-dd";
            dtpPartida.Format = DateTimePickerFormat.Custom;
            dtpPartida.CustomFormat = "yyyy-MM-dd";
        }

        private static Cargas frmInst = null;

        public static Cargas Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true)
            {
                frmInst = new Cargas();
            }

            frmInst.BringToFront();
            return frmInst;
        }

        private void Cargas_Load(object sender, EventArgs e)
        {
            BaseDatos des = new BaseDatos();
            des.buscar("SELECT * FROM destinos");
            cboxOrigen.DisplayMember = "nombre";
            cboxOrigen.ValueMember = "id";
            cboxOrigen.DataSource = des.ds.Tables[0].DefaultView;              
        }

        private void cboxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            BaseDatos ori = new BaseDatos();
            ori.buscar("SELECT * FROM destinos WHERE id != " + Convert.ToString(cboxOrigen.SelectedValue));
            cboxDestino.DisplayMember = "nombre";
            cboxDestino.ValueMember = "id";
            cboxDestino.DataSource = ori.ds.Tables[0];
            
        }

        private void cboxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            int caso = 0;
            int origen = Convert.ToInt16(cboxOrigen.SelectedValue);
            int destino = Convert.ToInt16(cboxDestino.SelectedValue);
            if (origen == 1 && destino == 2) caso = 1;
            if (origen == 1 && destino == 3) caso = 2;
            if (origen == 1 && destino == 4) caso = 3;
            if (origen == 2 && destino == 1) caso = 1;
            if (origen == 2 && destino == 3) caso = 4;
            if (origen == 2 && destino == 4) caso = 5;
            if (origen == 3 && destino == 1) caso = 2;
            if (origen == 3 && destino == 2) caso = 4;
            if (origen == 3 && destino == 4) caso = 6;
            if (origen == 4 && destino == 1) caso = 3;
            if (origen == 4 && destino == 2) caso = 5;
            if (origen == 4 && destino == 3) caso = 6;
           
            switch (caso)
            {
                case 1:
                    txbKilometros.Text = "1787.82";
                    txbPeaje.Text = "3546";

                    break;
                case 2:
                    txbKilometros.Text = "895.77";
                    txbPeaje.Text = "994";
                    break;
                case 3:
                    txbKilometros.Text = "1895.98";
                    txbPeaje.Text = "5454";
                    break;
                case 4:
                    txbKilometros.Text = "1167.25";
                    txbPeaje.Text = "2697";
                    break;
                case 5:
                    txbKilometros.Text = "751.83";
                    txbPeaje.Text = "215";
                    break;
                case 6:
                    txbKilometros.Text = "1714.56";
                    txbPeaje.Text = "5178";
                    break;
                default:
                    txbKilometros.Text = "";
                    txbPeaje.Text = "";
                    break;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (Vacio.txb(this))
            {
                string carga = txbCargamento.Text;
                string origen = Convert.ToString(cboxOrigen.SelectedValue);
                string destino = Convert.ToString(cboxDestino.SelectedValue);
                string partida = dtpPartida.Text;
                string arribo = dtpArribo.Text;
                string kilo = txbKilometros.Text;
                string peaje = txbPeaje.Text;
                Variables.carga(carga, origen, destino, partida, arribo, kilo, peaje);
                Operadores ope = null;
                ope = Operadores.Instancia();
                ope.MdiParent = MDI.ActiveForm;
                ope.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No puedes dejar campos vacios","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Index()
        {
            indexCargas index = null;
            index = indexCargas.Instancia();
            index.MdiParent = MDI.ActiveForm;
            index.Show();
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbCargamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynumesp(e);
        }
    }
}
