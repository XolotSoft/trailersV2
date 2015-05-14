namespace Traileros
{
    partial class Cargas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargas));
            this.dtpArribo = new System.Windows.Forms.DateTimePicker();
            this.cboxDestino = new System.Windows.Forms.ComboBox();
            this.cboxOrigen = new System.Windows.Forms.ComboBox();
            this.txbPeaje = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpPartida = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbKilometros = new System.Windows.Forms.TextBox();
            this.txbCargamento = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpArribo
            // 
            this.dtpArribo.Location = new System.Drawing.Point(457, 149);
            this.dtpArribo.Name = "dtpArribo";
            this.dtpArribo.Size = new System.Drawing.Size(184, 20);
            this.dtpArribo.TabIndex = 140;
            // 
            // cboxDestino
            // 
            this.cboxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDestino.FormattingEnabled = true;
            this.cboxDestino.Location = new System.Drawing.Point(457, 101);
            this.cboxDestino.Name = "cboxDestino";
            this.cboxDestino.Size = new System.Drawing.Size(184, 21);
            this.cboxDestino.TabIndex = 139;
            this.cboxDestino.SelectedIndexChanged += new System.EventHandler(this.cboxDestino_SelectedIndexChanged);
            // 
            // cboxOrigen
            // 
            this.cboxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxOrigen.FormattingEnabled = true;
            this.cboxOrigen.Location = new System.Drawing.Point(120, 100);
            this.cboxOrigen.Name = "cboxOrigen";
            this.cboxOrigen.Size = new System.Drawing.Size(184, 21);
            this.cboxOrigen.TabIndex = 138;
            this.cboxOrigen.SelectedIndexChanged += new System.EventHandler(this.cboxOrigen_SelectedIndexChanged);
            // 
            // txbPeaje
            // 
            this.txbPeaje.Location = new System.Drawing.Point(457, 197);
            this.txbPeaje.MaxLength = 30;
            this.txbPeaje.Name = "txbPeaje";
            this.txbPeaje.ReadOnly = true;
            this.txbPeaje.Size = new System.Drawing.Size(184, 20);
            this.txbPeaje.TabIndex = 137;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(351, 278);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 35);
            this.btnRegresar.TabIndex = 136;
            this.btnRegresar.Text = "Salir";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(398, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 135;
            this.label10.Text = "Peaje:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 134;
            this.label9.Text = "Arribo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 133;
            this.label8.Text = "Destino:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 132;
            this.label6.Text = "Partida:";
            // 
            // dtpPartida
            // 
            this.dtpPartida.Location = new System.Drawing.Point(120, 151);
            this.dtpPartida.Name = "dtpPartida";
            this.dtpPartida.Size = new System.Drawing.Size(184, 20);
            this.dtpPartida.TabIndex = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 131;
            this.label4.Text = "Kilometros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 130;
            this.label2.Text = "Origen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 129;
            this.label1.Text = "Cargamento:";
            // 
            // txbKilometros
            // 
            this.txbKilometros.Location = new System.Drawing.Point(120, 200);
            this.txbKilometros.MaxLength = 10;
            this.txbKilometros.Name = "txbKilometros";
            this.txbKilometros.ReadOnly = true;
            this.txbKilometros.Size = new System.Drawing.Size(184, 20);
            this.txbKilometros.TabIndex = 126;
            // 
            // txbCargamento
            // 
            this.txbCargamento.Location = new System.Drawing.Point(120, 48);
            this.txbCargamento.MaxLength = 50;
            this.txbCargamento.Name = "txbCargamento";
            this.txbCargamento.Size = new System.Drawing.Size(521, 20);
            this.txbCargamento.TabIndex = 124;
            this.txbCargamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCargamento_KeyPress);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(457, 278);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 35);
            this.btnLimpiar.TabIndex = 128;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(563, 278);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 35);
            this.btnSiguiente.TabIndex = 127;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(117, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 141;
            this.label3.Text = "Requerido";
            // 
            // Cargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpArribo);
            this.Controls.Add(this.cboxDestino);
            this.Controls.Add(this.cboxOrigen);
            this.Controls.Add(this.txbPeaje);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpPartida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbKilometros);
            this.Controls.Add(this.txbCargamento);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSiguiente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cargas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargas";
            this.Load += new System.EventHandler(this.Cargas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpArribo;
        private System.Windows.Forms.ComboBox cboxDestino;
        private System.Windows.Forms.ComboBox cboxOrigen;
        private System.Windows.Forms.TextBox txbPeaje;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpPartida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbKilometros;
        private System.Windows.Forms.TextBox txbCargamento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label3;
    }
}