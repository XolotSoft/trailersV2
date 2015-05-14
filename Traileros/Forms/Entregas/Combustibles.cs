using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Traileros
{
    public partial class Combustibles : Form
    {
        public Combustibles()
        {
            InitializeComponent();
            txbPrecio.Text = ConfigurationManager.AppSettings["diesel"];
        }

        private static Combustibles frmInst = null;

        public static Combustibles Instancia()
        {
            if (frmInst == null || frmInst.IsDisposed == true)
            {
                frmInst = new Combustibles();
            }

            frmInst.BringToFront();
            return frmInst;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string precio = txbPrecio.Text;
            string rendimiento = txbRendimiento.Text;
            string litros = txbLitros.Text;
            string costo = txbCosto.Text;
            string columna = "" ;
            if (Variables.Destino == "1") columna = "DF";
            if (Variables.Destino == "2") columna = "Chihuahua";
            if (Variables.Destino == "3") columna = "Monterrey";
            if (Variables.Destino == "4") columna = "Hermosillo";
            string sql = "INSERT INTO cargas(carga,origen,destino,partida,arribo,kilo,peaje,operador_id,comision,viaticos,vehiculo_id,precio,rendimiento,litros,costo)VALUES('"+
                Variables.Carga+"','"+Variables.Origen+"','"+Variables.Destino+"','"+Variables.Partida+"','"+Variables.Arribo+"','"+Variables.Kilo+"','"+
                Variables.Peaje+"','"+Variables.Id+"','"+Variables.Comision+"','"+Variables.Viaticos+"','"+Variables.Vehiculo+"','"+precio+"','"+rendimiento+"','"+litros+"','"+costo+"')";
            BaseDatos com = new BaseDatos();
            
            if (rendimiento != string.Empty)
            {
                double rend = Convert.ToDouble(rendimiento);
                if ((rend >= 1) && (rend <= 4))
                {
                    if (com.insertar(sql))
                    {
                        if (com.insertar("UPDATE operadores SET estado = 'ocupado' WHERE id = " + Variables.Id))
                        {
                            if (com.insertar("UPDATE vehiculos SET estado = 'ocupado', " + columna + "  = " + columna + " + 1 WHERE id = " + Variables.Vehiculo))
                            {
                                MessageBox.Show("Se ha guardado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                indexCargas index = null;
                                index = indexCargas.Instancia();
                                index.MdiParent = MDI.ActiveForm;
                                index.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se realizo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se realizo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se realizo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El rango del rendimiento debe de estar entre 1 y 4", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbRendimiento.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar el rendimiento de combustible del vehiculo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbRendimiento.Focus();
            }
        }

        private void txbRendimiento_TextChanged(object sender, EventArgs e)
        {
            if (txbRendimiento.Text != string.Empty)
            {
                double precio = 14.35;
                double rendimiento = Convert.ToDouble(txbRendimiento.Text);
                double litros = Convert.ToDouble(Variables.Kilo) / rendimiento;
                double costo = precio * litros;
                txbLitros.Text = Convert.ToString(Math.Round(litros,2));
                txbCosto.Text = Convert.ToString(Math.Round(costo,2));
            }
        }

        private void txbRendimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numypun(e);
        }
    }
}
