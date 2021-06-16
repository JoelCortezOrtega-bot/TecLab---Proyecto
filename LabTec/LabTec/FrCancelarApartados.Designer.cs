namespace LabTec
{
    partial class FrCancelarApartados
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
            this.eliminarLab = new System.Windows.Forms.Button();
            this.eliminarProyector = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // eliminarLab
            // 
            this.eliminarLab.BackColor = System.Drawing.Color.MidnightBlue;
            this.eliminarLab.Font = new System.Drawing.Font("Corbel", 12F);
            this.eliminarLab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eliminarLab.Location = new System.Drawing.Point(475, 331);
            this.eliminarLab.Name = "eliminarLab";
            this.eliminarLab.Size = new System.Drawing.Size(219, 39);
            this.eliminarLab.TabIndex = 11;
            this.eliminarLab.Text = "Eliminar cita de laboratorio";
            this.eliminarLab.UseVisualStyleBackColor = false;
            this.eliminarLab.Click += new System.EventHandler(this.eliminarLab_Click);
            // 
            // eliminarProyector
            // 
            this.eliminarProyector.BackColor = System.Drawing.Color.MidnightBlue;
            this.eliminarProyector.Font = new System.Drawing.Font("Corbel", 12F);
            this.eliminarProyector.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eliminarProyector.Location = new System.Drawing.Point(87, 330);
            this.eliminarProyector.Name = "eliminarProyector";
            this.eliminarProyector.Size = new System.Drawing.Size(192, 40);
            this.eliminarProyector.TabIndex = 10;
            this.eliminarProyector.Text = "Eliminar cita de proyector";
            this.eliminarProyector.UseVisualStyleBackColor = false;
            this.eliminarProyector.Click += new System.EventHandler(this.eliminarProyector_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label2.Location = new System.Drawing.Point(495, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Laboratorios apartados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label1.Location = new System.Drawing.Point(94, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Proyectores apartados";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(425, 89);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(320, 220);
            this.dataGridView2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 220);
            this.dataGridView1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label3.Location = new System.Drawing.Point(281, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cancelación de apartados";
            // 
            // FrCancelarApartados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eliminarLab);
            this.Controls.Add(this.eliminarProyector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrCancelarApartados";
            this.Text = "FrCancelarApartados";
            this.Load += new System.EventHandler(this.FrCancelarApartados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eliminarLab;
        private System.Windows.Forms.Button eliminarProyector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}