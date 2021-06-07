namespace LabTec
{
    partial class FrAgregarLaboratorios
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbEstadoLab = new System.Windows.Forms.ComboBox();
            this.txtIdLaboratorio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvLaboratorios = new System.Windows.Forms.DataGridView();
            this.btmAtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pndAdorno = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).BeginInit();
            this.pndAdorno.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 52);
            this.txtNombre.MaxLength = 29;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // cmbEstadoLab
            // 
            this.cmbEstadoLab.FormattingEnabled = true;
            this.cmbEstadoLab.Items.AddRange(new object[] {
            "Disponible",
            "Fuera de Servicio",
            "Mantenimiento"});
            this.cmbEstadoLab.Location = new System.Drawing.Point(173, 83);
            this.cmbEstadoLab.Name = "cmbEstadoLab";
            this.cmbEstadoLab.Size = new System.Drawing.Size(148, 25);
            this.cmbEstadoLab.TabIndex = 2;
            // 
            // txtIdLaboratorio
            // 
            this.txtIdLaboratorio.Location = new System.Drawing.Point(173, 21);
            this.txtIdLaboratorio.MaxLength = 4;
            this.txtIdLaboratorio.Name = "txtIdLaboratorio";
            this.txtIdLaboratorio.Size = new System.Drawing.Size(148, 24);
            this.txtIdLaboratorio.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label5.Location = new System.Drawing.Point(9, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 245;
            this.label5.Text = "Estado del Laboratorio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label4.Location = new System.Drawing.Point(9, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 244;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 243;
            this.label3.Text = "Numero del Laboratorio:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrar.Location = new System.Drawing.Point(173, 130);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(148, 35);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar datos";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvLaboratorios
            // 
            this.dgvLaboratorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaboratorios.Location = new System.Drawing.Point(29, 60);
            this.dgvLaboratorios.Name = "dgvLaboratorios";
            this.dgvLaboratorios.Size = new System.Drawing.Size(330, 330);
            this.dgvLaboratorios.TabIndex = 240;
            // 
            // btmAtras
            // 
            this.btmAtras.BackColor = System.Drawing.Color.MidnightBlue;
            this.btmAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmAtras.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAtras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmAtras.Location = new System.Drawing.Point(16, 403);
            this.btmAtras.Name = "btmAtras";
            this.btmAtras.Size = new System.Drawing.Size(111, 35);
            this.btmAtras.TabIndex = 4;
            this.btmAtras.Text = "Atrás";
            this.btmAtras.UseVisualStyleBackColor = false;
            this.btmAtras.Click += new System.EventHandler(this.btmAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 250;
            this.label1.Text = "Registro de laboratorios";
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
            this.pndAdorno.TabIndex = 251;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtIdLaboratorio);
            this.groupBox1.Controls.Add(this.cmbEstadoLab);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(32, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 180);
            this.groupBox1.TabIndex = 252;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // FrAgregarLaboratorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pndAdorno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrAgregarLaboratorios";
            this.Text = "FrAgregarLaboratorios";
            this.Load += new System.EventHandler(this.FrAgregarLaboratorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).EndInit();
            this.pndAdorno.ResumeLayout(false);
            this.pndAdorno.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbEstadoLab;
        private System.Windows.Forms.TextBox txtIdLaboratorio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvLaboratorios;
        private System.Windows.Forms.Button btmAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pndAdorno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}