namespace LabTec
{
    partial class FrEliminarLaboratorio
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvLaboratorios = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtIdLaboratorio = new System.Windows.Forms.TextBox();
            this.pndAdorno = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).BeginInit();
            this.pndAdorno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(187, 23);
            this.lblTitulo.TabIndex = 33;
            this.lblTitulo.Text = "Elimanación de usuario";
            // 
            // dgvLaboratorios
            // 
            this.dgvLaboratorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaboratorios.Location = new System.Drawing.Point(29, 60);
            this.dgvLaboratorios.Name = "dgvLaboratorios";
            this.dgvLaboratorios.Size = new System.Drawing.Size(330, 330);
            this.dgvLaboratorios.TabIndex = 30;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(16, 408);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 30);
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "Atrás";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAceptar.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Location = new System.Drawing.Point(269, 41);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.lblDescripcion.Location = new System.Drawing.Point(13, 47);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(94, 17);
            this.lblDescripcion.TabIndex = 32;
            this.lblDescripcion.Text = "ID Laboratorio:";
            // 
            // txtIdLaboratorio
            // 
            this.txtIdLaboratorio.Location = new System.Drawing.Point(113, 46);
            this.txtIdLaboratorio.MaxLength = 4;
            this.txtIdLaboratorio.Name = "txtIdLaboratorio";
            this.txtIdLaboratorio.Size = new System.Drawing.Size(133, 20);
            this.txtIdLaboratorio.TabIndex = 31;
            // 
            // pndAdorno
            // 
            this.pndAdorno.BackColor = System.Drawing.Color.MidnightBlue;
            this.pndAdorno.Controls.Add(this.label2);
            this.pndAdorno.Controls.Add(this.dgvLaboratorios);
            this.pndAdorno.Dock = System.Windows.Forms.DockStyle.Right;
            this.pndAdorno.Location = new System.Drawing.Point(389, 0);
            this.pndAdorno.Name = "pndAdorno";
            this.pndAdorno.Size = new System.Drawing.Size(388, 450);
            this.pndAdorno.TabIndex = 252;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 251;
            this.label2.Text = "Vista previa";
            // 
            // FrEliminarLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.pndAdorno);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtIdLaboratorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrEliminarLaboratorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrEliminarLaboratorio";
            this.Load += new System.EventHandler(this.FrEliminarLaboratorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).EndInit();
            this.pndAdorno.ResumeLayout(false);
            this.pndAdorno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvLaboratorios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtIdLaboratorio;
        private System.Windows.Forms.Panel pndAdorno;
        private System.Windows.Forms.Label label2;
    }
}