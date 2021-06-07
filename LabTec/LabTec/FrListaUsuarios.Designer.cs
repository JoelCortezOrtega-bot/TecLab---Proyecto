namespace LabTec
{
    partial class FrListaUsuarios
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cBoxTiposBusqueda = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.radiobtnLaboratorios = new System.Windows.Forms.RadioButton();
            this.radiobtnProyectores = new System.Windows.Forms.RadioButton();
            this.radiobtnUsuarios = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.AutoScroll = true;
            this.panelPrincipal.Location = new System.Drawing.Point(12, 92);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(753, 348);
            this.panelPrincipal.TabIndex = 0;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(91, 34);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(161, 22);
            this.txtBusqueda.TabIndex = 1;
            // 
            // cBoxTiposBusqueda
            // 
            this.cBoxTiposBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTiposBusqueda.Enabled = false;
            this.cBoxTiposBusqueda.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxTiposBusqueda.FormattingEnabled = true;
            this.cBoxTiposBusqueda.Items.AddRange(new object[] {
            "Predeterminado",
            "Alfabeticamente",
            "Departamentos"});
            this.cBoxTiposBusqueda.Location = new System.Drawing.Point(272, 34);
            this.cBoxTiposBusqueda.Name = "cBoxTiposBusqueda";
            this.cBoxTiposBusqueda.Size = new System.Drawing.Size(161, 22);
            this.cBoxTiposBusqueda.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Silver;
            this.btnBuscar.Location = new System.Drawing.Point(597, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 33);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // radiobtnLaboratorios
            // 
            this.radiobtnLaboratorios.AutoSize = true;
            this.radiobtnLaboratorios.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnLaboratorios.Location = new System.Drawing.Point(455, 9);
            this.radiobtnLaboratorios.Name = "radiobtnLaboratorios";
            this.radiobtnLaboratorios.Size = new System.Drawing.Size(126, 27);
            this.radiobtnLaboratorios.TabIndex = 5;
            this.radiobtnLaboratorios.TabStop = true;
            this.radiobtnLaboratorios.Text = "Laboratorios";
            this.radiobtnLaboratorios.UseVisualStyleBackColor = true;
            this.radiobtnLaboratorios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radiobtnLaboratorios_MouseClick);
            // 
            // radiobtnProyectores
            // 
            this.radiobtnProyectores.AutoSize = true;
            this.radiobtnProyectores.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnProyectores.Location = new System.Drawing.Point(455, 31);
            this.radiobtnProyectores.Name = "radiobtnProyectores";
            this.radiobtnProyectores.Size = new System.Drawing.Size(121, 27);
            this.radiobtnProyectores.TabIndex = 6;
            this.radiobtnProyectores.TabStop = true;
            this.radiobtnProyectores.Text = "Proyectores";
            this.radiobtnProyectores.UseVisualStyleBackColor = true;
            this.radiobtnProyectores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radiobtnProyectores_MouseClick);
            // 
            // radiobtnUsuarios
            // 
            this.radiobtnUsuarios.AutoSize = true;
            this.radiobtnUsuarios.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnUsuarios.Location = new System.Drawing.Point(455, 55);
            this.radiobtnUsuarios.Name = "radiobtnUsuarios";
            this.radiobtnUsuarios.Size = new System.Drawing.Size(96, 27);
            this.radiobtnUsuarios.TabIndex = 7;
            this.radiobtnUsuarios.TabStop = true;
            this.radiobtnUsuarios.Text = "Usuarios";
            this.radiobtnUsuarios.UseVisualStyleBackColor = true;
            this.radiobtnUsuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radiobtnUsuarios_MouseClick);
            // 
            // FrListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.radiobtnUsuarios);
            this.Controls.Add(this.radiobtnProyectores);
            this.Controls.Add(this.radiobtnLaboratorios);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cBoxTiposBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrListaUsuarios";
            this.Text = "FrListaUsuarios";
            this.Load += new System.EventHandler(this.FrListaUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cBoxTiposBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton radiobtnLaboratorios;
        private System.Windows.Forms.RadioButton radiobtnProyectores;
        private System.Windows.Forms.RadioButton radiobtnUsuarios;
    }
}