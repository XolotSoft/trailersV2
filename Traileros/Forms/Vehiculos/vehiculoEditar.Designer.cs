namespace Traileros
{
    partial class vehiculoEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vehiculoEditar));
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpServicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpAdquicision = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbTipo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPlaca = new System.Windows.Forms.TextBox();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.txbSerie = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "meses";
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbMes.Location = new System.Drawing.Point(317, 250);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(59, 21);
            this.cmbMes.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(466, 314);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 35);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(572, 314);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(100, 35);
            this.btnCambiar.TabIndex = 8;
            this.btnCambiar.Text = "Modificar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Fecha de ultimo servicio:";
            // 
            // dtpServicio
            // 
            this.dtpServicio.Location = new System.Drawing.Point(264, 212);
            this.dtpServicio.Name = "dtpServicio";
            this.dtpServicio.Size = new System.Drawing.Size(224, 20);
            this.dtpServicio.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Fecha de adquicisión:";
            // 
            // dtpAdquicision
            // 
            this.dtpAdquicision.Location = new System.Drawing.Point(264, 169);
            this.dtpAdquicision.Name = "dtpAdquicision";
            this.dtpAdquicision.Size = new System.Drawing.Size(224, 20);
            this.dtpAdquicision.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Mantenimiento programado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Tipo:";
            // 
            // txbTipo
            // 
            this.txbTipo.Location = new System.Drawing.Point(412, 82);
            this.txbTipo.Name = "txbTipo";
            this.txbTipo.Size = new System.Drawing.Size(158, 20);
            this.txbTipo.TabIndex = 3;
            this.txbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTipo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Modelo:";
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(184, 82);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(158, 20);
            this.txbModelo.TabIndex = 2;
            this.txbModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbModelo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "N° de Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "N° de Serie:";
            // 
            // txbPlaca
            // 
            this.txbPlaca.Location = new System.Drawing.Point(184, 125);
            this.txbPlaca.Name = "txbPlaca";
            this.txbPlaca.Size = new System.Drawing.Size(158, 20);
            this.txbPlaca.TabIndex = 4;
            this.txbPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPlaca_KeyPress);
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(412, 40);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(158, 20);
            this.txbMarca.TabIndex = 1;
            this.txbMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMarca_KeyPress);
            // 
            // txbSerie
            // 
            this.txbSerie.Location = new System.Drawing.Point(184, 40);
            this.txbSerie.Name = "txbSerie";
            this.txbSerie.Size = new System.Drawing.Size(158, 20);
            this.txbSerie.TabIndex = 0;
            this.txbSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSerie_KeyPress);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(360, 314);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 35);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // vehiculoEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpServicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpAdquicision);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPlaca);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.txbSerie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vehiculoEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Vehículo";
            this.Load += new System.EventHandler(this.vehiculoEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpServicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpAdquicision;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPlaca;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.TextBox txbSerie;
        private System.Windows.Forms.Button btnRegresar;
    }
}