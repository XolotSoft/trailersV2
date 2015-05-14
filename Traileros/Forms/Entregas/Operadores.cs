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
    public partial class Operadores : Form
    {
        public Operadores()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private static Operadores frmInst = null;

        public static Operadores Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true) frmInst = new Operadores();
            frmInst.BringToFront();
            return frmInst;
        }

        private void Operadores_Load(object sender, EventArgs e)
        {
            BaseDatos ope = new BaseDatos();
            ope.buscar("SELECT id, (nombre +' '+ paterno +' '+ materno) AS Nombre FROM operadores WHERE estado = 'libre' AND multas < 3");
            cboxOrigen.DataSource = ope.ds.Tables[0];
            cboxOrigen.DisplayMember = "Nombre";
            cboxOrigen.ValueMember = "id";
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (Vacio.txb(this))
            {
                if (Vacio.cbx(this))
                {
                    if (Validar.decimales(txbViatico.Text))
                    {
                        string operador = Convert.ToString(cboxOrigen.SelectedValue);
                        string comision = cmbComision.Text;
                        string viaticos = txbViatico.Text;
                        Variables.operador(operador, comision, viaticos);
                        Vehiculos veh = null;
                        veh = Vehiculos.Instancia();
                        veh.MdiParent = MDI.ActiveForm;
                        veh.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El formato de los viaticos no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }              
                }
                else
                {
                    MessageBox.Show("Debes seleccionar alguna opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                MessageBox.Show("Debes llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
        }

        private void txbViatico_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numypun(e);
        }
    }
}
