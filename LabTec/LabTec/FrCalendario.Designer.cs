namespace LabTec
{
    partial class FrCalendario
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
            this.flowPanelCalendario = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMesTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowPanelCalendario
            // 
            this.flowPanelCalendario.AutoScroll = true;
            this.flowPanelCalendario.Location = new System.Drawing.Point(12, 58);
            this.flowPanelCalendario.Name = "flowPanelCalendario";
            this.flowPanelCalendario.Size = new System.Drawing.Size(800, 700);
            this.flowPanelCalendario.TabIndex = 0;
            // 
            // lblMesTitulo
            // 
            this.lblMesTitulo.AutoSize = true;
            this.lblMesTitulo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesTitulo.Location = new System.Drawing.Point(329, 32);
            this.lblMesTitulo.Name = "lblMesTitulo";
            this.lblMesTitulo.Size = new System.Drawing.Size(0, 23);
            this.lblMesTitulo.TabIndex = 1;
            // 
            // FrCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 604);
            this.Controls.Add(this.lblMesTitulo);
            this.Controls.Add(this.flowPanelCalendario);
            this.Name = "FrCalendario";
            this.Text = "FrCalendario";
            this.Load += new System.EventHandler(this.FrCalendario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanelCalendario;
        private System.Windows.Forms.Label lblMesTitulo;
    }
}