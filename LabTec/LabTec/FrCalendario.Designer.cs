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
            this.btnSiguienteMes = new System.Windows.Forms.Button();
            this.btnAnteriorMes = new System.Windows.Forms.Button();
            this.lblLun = new System.Windows.Forms.Label();
            this.lblMar = new System.Windows.Forms.Label();
            this.lblMie = new System.Windows.Forms.Label();
            this.lblJue = new System.Windows.Forms.Label();
            this.lblVie = new System.Windows.Forms.Label();
            this.lblSab = new System.Windows.Forms.Label();
            this.lblDom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowPanelCalendario
            // 
            this.flowPanelCalendario.AutoScroll = true;
            this.flowPanelCalendario.Location = new System.Drawing.Point(85, 58);
            this.flowPanelCalendario.Name = "flowPanelCalendario";
            this.flowPanelCalendario.Size = new System.Drawing.Size(800, 700);
            this.flowPanelCalendario.TabIndex = 0;
            // 
            // lblMesTitulo
            // 
            this.lblMesTitulo.AutoSize = true;
            this.lblMesTitulo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesTitulo.Location = new System.Drawing.Point(407, 5);
            this.lblMesTitulo.Name = "lblMesTitulo";
            this.lblMesTitulo.Size = new System.Drawing.Size(0, 23);
            this.lblMesTitulo.TabIndex = 1;
            // 
            // btnSiguienteMes
            // 
            this.btnSiguienteMes.Location = new System.Drawing.Point(896, 235);
            this.btnSiguienteMes.Name = "btnSiguienteMes";
            this.btnSiguienteMes.Size = new System.Drawing.Size(72, 110);
            this.btnSiguienteMes.TabIndex = 2;
            this.btnSiguienteMes.Text = "ADELANTE";
            this.btnSiguienteMes.UseVisualStyleBackColor = true;
            this.btnSiguienteMes.Click += new System.EventHandler(this.btnSiguienteMes_Click);
            // 
            // btnAnteriorMes
            // 
            this.btnAnteriorMes.Location = new System.Drawing.Point(7, 235);
            this.btnAnteriorMes.Name = "btnAnteriorMes";
            this.btnAnteriorMes.Size = new System.Drawing.Size(72, 110);
            this.btnAnteriorMes.TabIndex = 3;
            this.btnAnteriorMes.Text = "ATRAS";
            this.btnAnteriorMes.UseVisualStyleBackColor = true;
            this.btnAnteriorMes.Click += new System.EventHandler(this.btnAnteriorMes_Click);
            // 
            // lblLun
            // 
            this.lblLun.AutoSize = true;
            this.lblLun.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLun.Location = new System.Drawing.Point(211, 31);
            this.lblLun.Name = "lblLun";
            this.lblLun.Size = new System.Drawing.Size(61, 23);
            this.lblLun.TabIndex = 4;
            this.lblLun.Text = "LUNES";
            // 
            // lblMar
            // 
            this.lblMar.AutoSize = true;
            this.lblMar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMar.Location = new System.Drawing.Point(311, 31);
            this.lblMar.Name = "lblMar";
            this.lblMar.Size = new System.Drawing.Size(73, 23);
            this.lblMar.TabIndex = 5;
            this.lblMar.Text = "MARTES";
            // 
            // lblMie
            // 
            this.lblMie.AutoSize = true;
            this.lblMie.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMie.Location = new System.Drawing.Point(405, 31);
            this.lblMie.Name = "lblMie";
            this.lblMie.Size = new System.Drawing.Size(99, 23);
            this.lblMie.TabIndex = 6;
            this.lblMie.Text = "MIERCOLES";
            // 
            // lblJue
            // 
            this.lblJue.AutoSize = true;
            this.lblJue.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJue.Location = new System.Drawing.Point(536, 31);
            this.lblJue.Name = "lblJue";
            this.lblJue.Size = new System.Drawing.Size(70, 23);
            this.lblJue.TabIndex = 7;
            this.lblJue.Text = "JUEVES";
            // 
            // lblVie
            // 
            this.lblVie.AutoSize = true;
            this.lblVie.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVie.Location = new System.Drawing.Point(635, 31);
            this.lblVie.Name = "lblVie";
            this.lblVie.Size = new System.Drawing.Size(76, 23);
            this.lblVie.TabIndex = 8;
            this.lblVie.Text = "VIERNES";
            // 
            // lblSab
            // 
            this.lblSab.AutoSize = true;
            this.lblSab.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSab.Location = new System.Drawing.Point(737, 32);
            this.lblSab.Name = "lblSab";
            this.lblSab.Size = new System.Drawing.Size(73, 23);
            this.lblSab.TabIndex = 9;
            this.lblSab.Text = "SABADO";
            // 
            // lblDom
            // 
            this.lblDom.AutoSize = true;
            this.lblDom.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDom.Location = new System.Drawing.Point(98, 31);
            this.lblDom.Name = "lblDom";
            this.lblDom.Size = new System.Drawing.Size(84, 23);
            this.lblDom.TabIndex = 10;
            this.lblDom.Text = "DOMINGO";
            // 
            // FrCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 604);
            this.Controls.Add(this.lblDom);
            this.Controls.Add(this.lblSab);
            this.Controls.Add(this.lblVie);
            this.Controls.Add(this.lblJue);
            this.Controls.Add(this.lblMie);
            this.Controls.Add(this.lblMar);
            this.Controls.Add(this.lblLun);
            this.Controls.Add(this.btnAnteriorMes);
            this.Controls.Add(this.btnSiguienteMes);
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
        private System.Windows.Forms.Button btnSiguienteMes;
        private System.Windows.Forms.Button btnAnteriorMes;
        private System.Windows.Forms.Label lblLun;
        private System.Windows.Forms.Label lblMar;
        private System.Windows.Forms.Label lblMie;
        private System.Windows.Forms.Label lblJue;
        private System.Windows.Forms.Label lblVie;
        private System.Windows.Forms.Label lblSab;
        private System.Windows.Forms.Label lblDom;
    }
}