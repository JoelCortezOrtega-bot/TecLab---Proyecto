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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLaboratorios = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarID = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.grbDatosLab = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbEstadoLab = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDLab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDGID = new System.Windows.Forms.Label();
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
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
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
            this.pndAdorno.Controls.Add(this.label3);
            this.pndAdorno.Controls.Add(this.dgvLaboratorios);
            this.pndAdorno.Dock = System.Windows.Forms.DockStyle.Right;
            this.pndAdorno.Location = new System.Drawing.Point(389, 0);
            this.pndAdorno.Name = "pndAdorno";
            this.pndAdorno.Size = new System.Drawing.Size(388, 450);
            this.pndAdorno.TabIndex = 250;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(144, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 250;
            this.label3.Text = "Vista previa";
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarID
            // 
            this.txtBuscarID.Location = new System.Drawing.Point(85, 41);
            this.txtBuscarID.MaxLength = 4;
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
            this.grbDatosLab.Controls.Add(this.btnCancelar);
            this.grbDatosLab.Controls.Add(this.btnGuardar);
            this.grbDatosLab.Controls.Add(this.cmbEstadoLab);
            this.grbDatosLab.Controls.Add(this.txtNombre);
            this.grbDatosLab.Controls.Add(this.txtIDLab);
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
            this.grbDatosLab.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(160, 198);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(151, 35);
            this.btnCancelar.TabIndex = 263;
            this.btnCancelar.Text = "Cancelar cambios";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(160, 157);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(151, 35);
            this.btnGuardar.TabIndex = 262;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbEstadoLab
            // 
            this.cmbEstadoLab.Enabled = false;
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
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(160, 57);
            this.txtNombre.MaxLength = 29;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 24);
            this.txtNombre.TabIndex = 260;
            // 
            // txtIDLab
            // 
            this.txtIDLab.Enabled = false;
            this.txtIDLab.Location = new System.Drawing.Point(160, 27);
            this.txtIDLab.MaxLength = 8;
            this.txtIDLab.Name = "txtIDLab";
            this.txtIDLab.Size = new System.Drawing.Size(151, 24);
            this.txtIDLab.TabIndex = 258;
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
            this.Load += new System.EventHandler(this.FrModificarLaboratorio_Load);
            this.pndAdorno.ResumeLayout(false);
            this.pndAdorno.PerformLayout();
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
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIDLab;
        private System.Windows.Forms.ComboBox cmbEstadoLab;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
    }
}