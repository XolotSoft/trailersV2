namespace Traileros
{
    partial class vehiculoNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vehiculoNuevo));
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
            this.label6 = new System.Windows.Forms.Label();
            this.dtpAdquicision = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpServicio = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.cmbMantenimiento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Mantenimiento programado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tipo:";
            // 
            // txbTipo
            // 
            this.txbTipo.Location = new System.Drawing.Point(403, 75);
            this.txbTipo.MaxLength = 20;
            this.txbTipo.Name = "txbTipo";
            this.txbTipo.Size = new System.Drawing.Size(158, 20);
            this.txbTipo.TabIndex = 3;
            this.txbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTipo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Modelo:";
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(184, 75);
            this.txbModelo.MaxLength = 4;
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(158, 20);
            this.txbModelo.TabIndex = 2;
            this.txbModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbModelo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "N° de Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "N° de Serie:";
            // 
            // txbPlaca
            // 
            this.txbPlaca.Location = new System.Drawing.Point(184, 118);
            this.txbPlaca.MaxLength = 7;
            this.txbPlaca.Name = "txbPlaca";
            this.txbPlaca.Size = new System.Drawing.Size(158, 20);
            this.txbPlaca.TabIndex = 4;
            this.txbPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPlaca_KeyPress);
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(403, 33);
            this.txbMarca.MaxLength = 20;
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(158, 20);
            this.txbMarca.TabIndex = 1;
            this.txbMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMarca_KeyPress);
            // 
            // txbSerie
            // 
            this.txbSerie.Location = new System.Drawing.Point(184, 33);
            this.txbSerie.MaxLength = 18;
            this.txbSerie.Name = "txbSerie";
            this.txbSerie.Size = new System.Drawing.Size(158, 20);
            this.txbSerie.TabIndex = 0;
            this.txbSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSerie_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Fecha de adquicisión:";
            // 
            // dtpAdquicision
            // 
            this.dtpAdquicision.Location = new System.Drawing.Point(301, 164);
            this.dtpAdquicision.Name = "dtpAdquicision";
            this.dtpAdquicision.Size = new System.Drawing.Size(224, 20);
            this.dtpAdquicision.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Fecha del ultimo Servicio:";
            // 
            // dtpServicio
            // 
            this.dtpServicio.Location = new System.Drawing.Point(301, 207);
            this.dtpServicio.Name = "dtpServicio";
            this.dtpServicio.Size = new System.Drawing.Size(224, 20);
            this.dtpServicio.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(466, 314);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 35);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(572, 314);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 35);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // cmbMantenimiento
            // 
            this.cmbMantenimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMantenimiento.FormattingEnabled = true;
            this.cmbMantenimiento.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbMantenimiento.Location = new System.Drawing.Point(361, 254);
            this.cmbMantenimiento.Name = "cmbMantenimiento";
            this.cmbMantenimiento.Size = new System.Drawing.Size(59, 21);
            this.cmbMantenimiento.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "meses";
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
            // vehiculoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMantenimiento);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrear);
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
            this.Name = "vehiculoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Vehículo";
            this.Load += new System.EventHandler(this.vehiculoNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpAdquicision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpServicio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox cmbMantenimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegresar;
    }
}