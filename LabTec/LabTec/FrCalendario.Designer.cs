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
            this.flowPanelCalendario.Location = new System.Drawing.Point(46, 44);
            this.flowPanelCalendario.Name = "flowPanelCalendario";
            this.flowPanelCalendario.Size = new System.Drawing.Size(684, 394);
            this.flowPanelCalendario.TabIndex = 0;
            // 
            // lblMesTitulo
            // 
            this.lblMesTitulo.AutoSize = true;
            this.lblMesTitulo.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesTitulo.Location = new System.Drawing.Point(331, 8);
            this.lblMesTitulo.Name = "lblMesTitulo";
            this.lblMesTitulo.Size = new System.Drawing.Size(0, 15);
            this.lblMesTitulo.TabIndex = 1;
            // 
            // btnSiguienteMes
            // 
            this.btnSiguienteMes.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSiguienteMes.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMes.ForeColor = System.Drawing.Color.Silver;
            this.btnSiguienteMes.Location = new System.Drawing.Point(736, 185);
            this.btnSiguienteMes.Name = "btnSiguienteMes";
            this.btnSiguienteMes.Size = new System.Drawing.Size(37, 55);
            this.btnSiguienteMes.TabIndex = 2;
            this.btnSiguienteMes.Text = "❯";
            this.btnSiguienteMes.UseVisualStyleBackColor = false;
            this.btnSiguienteMes.Click += new System.EventHandler(this.btnSiguienteMes_Click);
            // 
            // btnAnteriorMes
            // 
            this.btnAnteriorMes.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAnteriorMes.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMes.ForeColor = System.Drawing.Color.Silver;
            this.btnAnteriorMes.Location = new System.Drawing.Point(3, 185);
            this.btnAnteriorMes.Name = "btnAnteriorMes";
            this.btnAnteriorMes.Size = new System.Drawing.Size(37, 55);
            this.btnAnteriorMes.TabIndex = 3;
            this.btnAnteriorMes.Text = "❮";
            this.btnAnteriorMes.UseVisualStyleBackColor = false;
            this.btnAnteriorMes.Click += new System.EventHandler(this.btnAnteriorMes_Click);
            // 
            // lblLun
            // 
            this.lblLun.AutoSize = true;
            this.lblLun.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLun.Location = new System.Drawing.Point(165, 25);
            this.lblLun.Name = "lblLun";
            this.lblLun.Size = new System.Drawing.Size(46, 15);
            this.lblLun.TabIndex = 4;
            this.lblLun.Text = "LUNES";
            // 
            // lblMar
            // 
            this.lblMar.AutoSize = true;
            this.lblMar.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMar.Location = new System.Drawing.Point(253, 25);
            this.lblMar.Name = "lblMar";
            this.lblMar.Size = new System.Drawing.Size(55, 15);
            this.lblMar.TabIndex = 5;
            this.lblMar.Text = "MARTES";
            // 
            // lblMie
            // 
            this.lblMie.AutoSize = true;
            this.lblMie.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMie.Location = new System.Drawing.Point(337, 24);
            this.lblMie.Name = "lblMie";
            this.lblMie.Size = new System.Drawing.Size(75, 15);
            this.lblMie.TabIndex = 6;
            this.lblMie.Text = "MIERCOLES";
            // 
            // lblJue
            // 
            this.lblJue.AutoSize = true;
            this.lblJue.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJue.Location = new System.Drawing.Point(443, 24);
            this.lblJue.Name = "lblJue";
            this.lblJue.Size = new System.Drawing.Size(50, 15);
            this.lblJue.TabIndex = 7;
            this.lblJue.Text = "JUEVES";
            // 
            // lblVie
            // 
            this.lblVie.AutoSize = true;
            this.lblVie.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVie.Location = new System.Drawing.Point(535, 24);
            this.lblVie.Name = "lblVie";
            this.lblVie.Size = new System.Drawing.Size(56, 15);
            this.lblVie.TabIndex = 8;
            this.lblVie.Text = "VIERNES";
            // 
            // lblSab
            // 
            this.lblSab.AutoSize = true;
            this.lblSab.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSab.Location = new System.Drawing.Point(627, 25);
            this.lblSab.Name = "lblSab";
            this.lblSab.Size = new System.Drawing.Size(57, 15);
            this.lblSab.TabIndex = 9;
            this.lblSab.Text = "SABADO";
            // 
            // lblDom
            // 
            this.lblDom.AutoSize = true;
            this.lblDom.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDom.Location = new System.Drawing.Point(60, 25);
            this.lblDom.Name = "lblDom";
            this.lblDom.Size = new System.Drawing.Size(68, 15);
            this.lblDom.TabIndex = 10;
            this.lblDom.Text = "DOMINGO";
            // 
            // FrCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 450);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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