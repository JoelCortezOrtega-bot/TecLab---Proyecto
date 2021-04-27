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
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.AutoScroll = true;
            this.panelPrincipal.Location = new System.Drawing.Point(12, 92);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(776, 346);
            this.panelPrincipal.TabIndex = 0;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(12, 27);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(161, 20);
            this.txtBusqueda.TabIndex = 1;
            // 
            // cBoxTiposBusqueda
            // 
            this.cBoxTiposBusqueda.FormattingEnabled = true;
            this.cBoxTiposBusqueda.Items.AddRange(new object[] {
            "Predeterminado",
            "Alfabeticamente",
            "Departamentos"});
            this.cBoxTiposBusqueda.Location = new System.Drawing.Point(205, 26);
            this.cBoxTiposBusqueda.Name = "cBoxTiposBusqueda";
            this.cBoxTiposBusqueda.Size = new System.Drawing.Size(137, 21);
            this.cBoxTiposBusqueda.TabIndex = 2;
            this.cBoxTiposBusqueda.Text = "Selecciona una opcion";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(388, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(1, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(800, 11);
            this.label5.TabIndex = 4;
            // 
            // FrListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cBoxTiposBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrListaUsuarios";
            this.Text = "FrListaUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cBoxTiposBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
    }
}