namespace LabTec
{
    partial class FrEliminarProyectores
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
            this.Eliminarbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eliminartxt = new System.Windows.Forms.TextBox();
            this.buscarbtn = new System.Windows.Forms.Button();
            this.buscartxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btmAtras = new System.Windows.Forms.Button();
            this.pndAdorno = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pndAdorno.SuspendLayout();
            this.SuspendLayout();
            // 
            // Eliminarbtn
            // 
            this.Eliminarbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Eliminarbtn.Font = new System.Drawing.Font("Corbel", 12F);
            this.Eliminarbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Eliminarbtn.Location = new System.Drawing.Point(228, 140);
            this.Eliminarbtn.Name = "Eliminarbtn";
            this.Eliminarbtn.Size = new System.Drawing.Size(111, 35);
            this.Eliminarbtn.TabIndex = 25;
            this.Eliminarbtn.Text = "Eliminar";
            this.Eliminarbtn.UseVisualStyleBackColor = false;
            this.Eliminarbtn.Click += new System.EventHandler(this.Eliminarbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Eliminar proyector con ID:";
            // 
            // eliminartxt
            // 
            this.eliminartxt.Location = new System.Drawing.Point(19, 149);
            this.eliminartxt.MaxLength = 8;
            this.eliminartxt.Name = "eliminartxt";
            this.eliminartxt.Size = new System.Drawing.Size(203, 20);
            this.eliminartxt.TabIndex = 23;
            // 
            // buscarbtn
            // 
            this.buscarbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.buscarbtn.Font = new System.Drawing.Font("Corbel", 12F);
            this.buscarbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buscarbtn.Location = new System.Drawing.Point(228, 64);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Size = new System.Drawing.Size(111, 35);
            this.buscarbtn.TabIndex = 22;
            this.buscarbtn.Text = "Buscar";
            this.buscarbtn.UseVisualStyleBackColor = false;
            this.buscarbtn.Click += new System.EventHandler(this.buscarbtn_Click);
            // 
            // buscartxt
            // 
            this.buscartxt.Location = new System.Drawing.Point(19, 73);
            this.buscartxt.MaxLength = 8;
            this.buscartxt.Name = "buscartxt";
            this.buscartxt.Size = new System.Drawing.Size(203, 20);
            this.buscartxt.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Buscar por ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(330, 330);
            this.dataGridView1.TabIndex = 19;
            // 
            // btmAtras
            // 
            this.btmAtras.BackColor = System.Drawing.Color.MidnightBlue;
            this.btmAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmAtras.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAtras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btmAtras.Location = new System.Drawing.Point(17, 373);
            this.btmAtras.Name = "btmAtras";
            this.btmAtras.Size = new System.Drawing.Size(111, 35);
            this.btmAtras.TabIndex = 27;
            this.btmAtras.Text = "Atrás";
            this.btmAtras.UseVisualStyleBackColor = false;
            this.btmAtras.Click += new System.EventHandler(this.btmAtras_Click);
            // 
            // pndAdorno
            // 
            this.pndAdorno.BackColor = System.Drawing.Color.MidnightBlue;
            this.pndAdorno.Controls.Add(this.label4);
            this.pndAdorno.Controls.Add(this.dataGridView1);
            this.pndAdorno.Dock = System.Windows.Forms.DockStyle.Right;
            this.pndAdorno.Location = new System.Drawing.Point(412, 0);
            this.pndAdorno.Name = "pndAdorno";
            this.pndAdorno.Size = new System.Drawing.Size(388, 450);
            this.pndAdorno.TabIndex = 252;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(144, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 251;
            this.label4.Text = "Vista previa";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.lblTitulo.Location = new System.Drawing.Point(13, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 23);
            this.lblTitulo.TabIndex = 253;
            this.lblTitulo.Text = "Elimanación de proyectores";
            // 
            // FrEliminarProyectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pndAdorno);
            this.Controls.Add(this.btmAtras);
            this.Controls.Add(this.Eliminarbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eliminartxt);
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.buscartxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrEliminarProyectores";
            this.Text = "FrEliminarProyectores";
            this.Load += new System.EventHandler(this.FrEliminarProyectores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pndAdorno.ResumeLayout(false);
            this.pndAdorno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Eliminarbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eliminartxt;
        private System.Windows.Forms.Button buscarbtn;
        private System.Windows.Forms.TextBox buscartxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btmAtras;
        private System.Windows.Forms.Panel pndAdorno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitulo;
    }
}