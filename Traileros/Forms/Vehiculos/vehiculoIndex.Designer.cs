﻿namespace Traileros
{
    partial class vehiculosIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vehiculosIndex));
            this.txbFiltrar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvOperador = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperador)).BeginInit();
            this.SuspendLayout();
            // 
            // txbFiltrar
            // 
            this.txbFiltrar.Location = new System.Drawing.Point(13, 31);
            this.txbFiltrar.Name = "txbFiltrar";
            this.txbFiltrar.Size = new System.Drawing.Size(246, 20);
            this.txbFiltrar.TabIndex = 7;
            this.txbFiltrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFiltrar_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvOperador
            // 
            this.dgvOperador.AllowUserToAddRows = false;
            this.dgvOperador.AllowUserToDeleteRows = false;
            this.dgvOperador.AllowUserToResizeColumns = false;
            this.dgvOperador.AllowUserToResizeRows = false;
            this.dgvOperador.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOperador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperador.Location = new System.Drawing.Point(12, 104);
            this.dgvOperador.Name = "dgvOperador";
            this.dgvOperador.ReadOnly = true;
            this.dgvOperador.Size = new System.Drawing.Size(660, 245);
            this.dgvOperador.TabIndex = 6;
            this.dgvOperador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperador_CellClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(572, 23);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 35);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Catálogo de Vehículos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(291, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Da click para seleccionar un vehículo para editarlo o eliminarlo";
            // 
            // vehiculosIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbFiltrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvOperador);
            this.Controls.Add(this.btnNuevo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vehiculosIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehículos";
            this.Load += new System.EventHandler(this.vehiculosIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbFiltrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvOperador;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}