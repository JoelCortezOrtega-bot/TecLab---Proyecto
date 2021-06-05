namespace LabTec
{
    partial class FrModificarLaboratorio
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pndAdorno = new System.Windows.Forms.Panel();
            this.dgvLaboratorios = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarID = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.grbDatosLab = new System.Windows.Forms.GroupBox();
            this.lblDGID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmbEstadoLab = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pndAdorno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).BeginInit();
            this.grbDatosLab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Location = new System.Drawing.Point(16, 403);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(111, 35);
            this.btnAtras.TabIndex = 18;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(291, 23);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Laboratorios - Modificación de datos";
            // 
            // pndAdorno
            // 
            this.pndAdorno.BackColor = System.Drawing.Color.MidnightBlue;
            this.pndAdorno.Controls.Add(this.dgvLaboratorios);
            this.pndAdorno.Dock = System.Windows.Forms.DockStyle.Right;
            this.pndAdorno.Location = new System.Drawing.Point(389, 0);
            this.pndAdorno.Name = "pndAdorno";
            this.pndAdorno.Size = new System.Drawing.Size(388, 450);
            this.pndAdorno.TabIndex = 250;
            // 
            // dgvLaboratorios
            // 
            this.dgvLaboratorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaboratorios.Location = new System.Drawing.Point(29, 60);
            this.dgvLaboratorios.Name = "dgvLaboratorios";
            this.dgvLaboratorios.Size = new System.Drawing.Size(330, 330);
            this.dgvLaboratorios.TabIndex = 249;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(305, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 35);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscarID
            // 
            this.txtBuscarID.Location = new System.Drawing.Point(85, 41);
            this.txtBuscarID.Name = "txtBuscarID";
            this.txtBuscarID.Size = new System.Drawing.Size(214, 20);
            this.txtBuscarID.TabIndex = 253;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.lblDescripcion.Location = new System.Drawing.Point(13, 42);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 17);
            this.lblDescripcion.TabIndex = 256;
            this.lblDescripcion.Text = "Buscar ID:";
            // 
            // grbDatosLab
            // 
            this.grbDatosLab.Controls.Add(this.btnRegistrar);
            this.grbDatosLab.Controls.Add(this.cmbEstadoLab);
            this.grbDatosLab.Controls.Add(this.textBox2);
            this.grbDatosLab.Controls.Add(this.textBox1);
            this.grbDatosLab.Controls.Add(this.label2);
            this.grbDatosLab.Controls.Add(this.label1);
            this.grbDatosLab.Controls.Add(this.lblDGID);
            this.grbDatosLab.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.grbDatosLab.Location = new System.Drawing.Point(29, 86);
            this.grbDatosLab.Name = "grbDatosLab";
            this.grbDatosLab.Size = new System.Drawing.Size(330, 250);
            this.grbDatosLab.TabIndex = 257;
            this.grbDatosLab.TabStop = false;
            this.grbDatosLab.Text = "Datos Generales";
            // 
            // lblDGID
            // 
            this.lblDGID.AutoSize = true;
            this.lblDGID.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.lblDGID.Location = new System.Drawing.Point(10, 30);
            this.lblDGID.Name = "lblDGID";
            this.lblDGID.Size = new System.Drawing.Size(25, 17);
            this.lblDGID.TabIndex = 257;
            this.lblDGID.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 258;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 259;
            this.label2.Text = "Estado del Laboratorio:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 24);
            this.textBox1.TabIndex = 258;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 24);
            this.textBox2.TabIndex = 260;
            // 
            // cmbEstadoLab
            // 
            this.cmbEstadoLab.FormattingEnabled = true;
            this.cmbEstadoLab.Items.AddRange(new object[] {
            "Disponible",
            "Fuera de Servicio",
            "Mantenimiento"});
            this.cmbEstadoLab.Location = new System.Drawing.Point(160, 87);
            this.cmbEstadoLab.Name = "cmbEstadoLab";
            this.cmbEstadoLab.Size = new System.Drawing.Size(151, 25);
            this.cmbEstadoLab.TabIndex = 261;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrar.Location = new System.Drawing.Point(160, 207);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(151, 35);
            this.btnRegistrar.TabIndex = 262;
            this.btnRegistrar.Text = "Guardar cambios";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // FrModificarLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.grbDatosLab);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarID);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pndAdorno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrModificarLaboratorio";
            this.Text = "FrModificarLaboratorio";
            this.pndAdorno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).EndInit();
            this.grbDatosLab.ResumeLayout(false);
            this.grbDatosLab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pndAdorno;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvLaboratorios;
        private System.Windows.Forms.TextBox txtBuscarID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox grbDatosLab;
        private System.Windows.Forms.Label lblDGID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbEstadoLab;
        private System.Windows.Forms.Button btnRegistrar;
    }
}