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
    public partial class indexCargas : Form
    {
        public indexCargas()
        {
            InitializeComponent();
        }

        private static indexCargas frmInst = null;

        public static indexCargas Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true)
            {
                frmInst = new indexCargas();
            }

            frmInst.BringToFront();
            return frmInst;
        }

        private void indexCargas_Load(object sender, EventArgs e)
        {
            BaseDatos cargas = new BaseDatos();
            BaseDatos vehiculo = new BaseDatos();
            BaseDatos opera = new BaseDatos();

            cargas.buscar("SELECT d.nombre AS Origen, z.nombre AS Destino, v.placa AS Placas,(o.nombre+' '+o.paterno+' '+o.materno) AS Operador, c.carga AS Carga,c.partida AS Partida,c.arribo AS Arribo,c.kilo AS Kilometros, c.peaje AS Peaje, c.comision AS Comision , c.viaticos AS Viaticos , c.litros AS Litros , c.costo AS Costo  FROM cargas c INNER JOIN destinos d ON d.id = c.origen INNER JOIN destinos z ON z.id = c.destino INNER JOIN vehiculos v ON v.id = c.vehiculo_id INNER JOIN operadores o ON c.operador_id = o.id");
            vehiculo.buscar("SELECT marca AS Marca, modelo AS Modelo, placa AS Placas, estado AS Estado FROM vehiculos");
            opera.buscar("SELECT (nombre+' '+paterno+' '+materno) AS Nombre, estado AS Estado,multas AS Multas FROM operadores");

            
            dgvCargas.DataSource = cargas.ds.Tables[0];
            dgvCargas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCargas.RowHeadersVisible = false;
            dgvOperador.DataSource = opera.ds.Tables[0];
            dgvOperador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOperador.RowHeadersVisible = false;
            dgvOperador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehiculo.DataSource = vehiculo.ds.Tables[0];
            dgvVehiculo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehiculo.RowHeadersVisible = false;
            dgvVehiculo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            BaseDatos ope = new BaseDatos();
            BaseDatos veh = new BaseDatos();

            ope.buscar("SELECT * FROM operadores WHERE estado = 'libre' AND multas < 3");

            if (ope.ds.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show("No hay operadores disponobles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                veh.buscar("SELECT * FROM vehiculos WHERE estado = 'libre'");
                if (veh.ds.Tables[0].Rows.Count < 1)
                {
                    MessageBox.Show("No hay vehiculos disponobles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Cargas nuevo = null;
                    nuevo = Cargas.Instancia();
                    nuevo.MdiParent = MDI.ActiveForm;
                    nuevo.Show();
                    this.Close();
                }
            }          
        }
    }
}
