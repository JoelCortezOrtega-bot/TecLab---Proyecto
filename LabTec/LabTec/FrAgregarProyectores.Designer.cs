namespace LabTec
{
    partial class FrAgregarProyectores
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
            this.EstadoTxt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.DescripcionTxt = new System.Windows.Forms.RichTextBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.pndAdorno = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btmAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pndAdorno.SuspendLayout();
            this.SuspendLayout();
            // 
            // EstadoTxt
            // 
            this.EstadoTxt.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.EstadoTxt.FormattingEnabled = true;
            this.EstadoTxt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "f"});
            this.EstadoTxt.Location = new System.Drawing.Point(161, 119);
            this.EstadoTxt.Name = "EstadoTxt";
            this.EstadoTxt.Size = new System.Drawing.Size(119, 25);
            this.EstadoTxt.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label4.Location = new System.Drawing.Point(25, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Descripcion del proyecto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label3.Location = new System.Drawing.Point(25, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Estado del proyector:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label2.Location = new System.Drawing.Point(97, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Numero del proyector:";
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Agregar.Font = new System.Drawing.Font("Corbel", 12F);
            this.Agregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Agregar.Location = new System.Drawing.Point(28, 325);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(310, 35);
            this.Agregar.TabIndex = 24;
            this.Agregar.Text = "Agrergar";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.DescripcionTxt.Location = new System.Drawing.Point(28, 179);
            this.DescripcionTxt.MaxLength = 499;
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(310, 128);
            this.DescripcionTxt.TabIndex = 23;
            this.DescripcionTxt.Text = "";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.NombreTxt.Location = new System.Drawing.Point(161, 89);
            this.NombreTxt.MaxLength = 19;
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(119, 24);
            this.NombreTxt.TabIndex = 22;
            // 
            // IdTxt
            // 
            this.IdTxt.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.IdTxt.Location = new System.Drawing.Point(161, 59);
            this.IdTxt.MaxLength = 4;
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(119, 24);
            this.IdTxt.TabIndex = 21;
            this.IdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdTxt_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(330, 330);
            this.dataGridView1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label5.Location = new System.Drawing.Point(18, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 23);
            this.label5.TabIndex = 251;
            this.label5.Text = "Registro de proyectores";
            // 
            // pndAdorno
            // 
            this.pndAdorno.BackColor = System.Drawing.Color.MidnightBlue;
            this.pndAdorno.Controls.Add(this.label6);
            this.pndAdorno.Controls.Add(this.dataGridView1);
            this.pndAdorno.Dock = System.Windows.Forms.DockStyle.Right;
            this.pndAdorno.Location = new System.Drawing.Point(389, 0);
            this.pndAdorno.Name = "pndAdorno";
            this.pndAdorno.Size = new System.Drawing.Size(388, 450);
            this.pndAdorno.TabIndex = 252;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(144, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 251;
            this.label6.Text = "Vista previa";
            // 
            // btmAtras
            // 
            this.btmAtras.BackColor = System.Drawing.Color.MidnightBlue;
            this.btmAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmAtras.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAtras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmAtras.Location = new System.Drawing.Point(12, 403);
            this.btmAtras.Name = "btmAtras";
            this.btmAtras.Size = new System.Drawing.Size(111, 35);
            this.btmAtras.TabIndex = 253;
            this.btmAtras.Text = "Atrás";
            this.btmAtras.UseVisualStyleBackColor = false;
            this.btmAtras.Click += new System.EventHandler(this.btmAtras_Click);
            // 
            // FrAgregarProyectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.btmAtras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EstadoTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.DescripcionTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.pndAdorno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrAgregarProyectores";
            this.Text = "FrAgregarProyectores";
            this.Load += new System.EventHandler(this.FrAgregarProyectores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pndAdorno.ResumeLayout(false);
            this.pndAdorno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EstadoTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.RichTextBox DescripcionTxt;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pndAdorno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btmAtras;
    }
}