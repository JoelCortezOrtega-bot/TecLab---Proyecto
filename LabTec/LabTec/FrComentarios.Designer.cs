namespace LabTec
{
    partial class FrComentarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrComentarios));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ptbID = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnAgregarComent = new System.Windows.Forms.Button();
            this.btnCargarComent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOcultarComentarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbID)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sección de Comentarios";
            // 
            // ptbID
            // 
            this.ptbID.Image = global::LabTec.Properties.Resources.user1;
            this.ptbID.Location = new System.Drawing.Point(16, 45);
            this.ptbID.Name = "ptbID";
            this.ptbID.Size = new System.Drawing.Size(90, 90);
            this.ptbID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbID.TabIndex = 2;
            this.ptbID.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(21, 138);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(81, 19);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID_Usuario";
            // 
            // txtComentario
            // 
            this.txtComentario.Font = new System.Drawing.Font("Arial", 12F);
            this.txtComentario.Location = new System.Drawing.Point(112, 45);
            this.txtComentario.MaxLength = 198;
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(467, 90);
            this.txtComentario.TabIndex = 6;
            // 
            // btnAgregarComent
            // 
            this.btnAgregarComent.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAgregarComent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarComent.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarComent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarComent.Location = new System.Drawing.Point(585, 29);
            this.btnAgregarComent.Name = "btnAgregarComent";
            this.btnAgregarComent.Size = new System.Drawing.Size(180, 35);
            this.btnAgregarComent.TabIndex = 243;
            this.btnAgregarComent.Text = "Agregar comentarios";
            this.btnAgregarComent.UseVisualStyleBackColor = false;
            this.btnAgregarComent.Click += new System.EventHandler(this.btnAgregarComent_Click);
            // 
            // btnCargarComent
            // 
            this.btnCargarComent.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCargarComent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarComent.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarComent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargarComent.Location = new System.Drawing.Point(585, 75);
            this.btnCargarComent.Name = "btnCargarComent";
            this.btnCargarComent.Size = new System.Drawing.Size(180, 35);
            this.btnCargarComent.TabIndex = 244;
            this.btnCargarComent.Text = "Mostrar comentarios";
            this.btnCargarComent.UseVisualStyleBackColor = false;
            this.btnCargarComent.Click += new System.EventHandler(this.btnCargarComent_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 278);
            this.panel1.TabIndex = 245;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(408, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Publicacion: 15/02/17";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Brhadaranyakopanishadvivekachudamani Erreh Muñoz";
            this.label2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Visible = false;
            // 
            // btnOcultarComentarios
            // 
            this.btnOcultarComentarios.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnOcultarComentarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultarComentarios.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultarComentarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOcultarComentarios.Location = new System.Drawing.Point(585, 122);
            this.btnOcultarComentarios.Name = "btnOcultarComentarios";
            this.btnOcultarComentarios.Size = new System.Drawing.Size(180, 35);
            this.btnOcultarComentarios.TabIndex = 246;
            this.btnOcultarComentarios.Text = "Ocultar comentarios";
            this.btnOcultarComentarios.UseVisualStyleBackColor = false;
            this.btnOcultarComentarios.Click += new System.EventHandler(this.btnOcultarComentarios_Click);
            // 
            // FrComentarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.btnOcultarComentarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCargarComent);
            this.Controls.Add(this.btnAgregarComent);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.ptbID);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrComentarios";
            this.Text = "FrComentarios";
            this.Load += new System.EventHandler(this.FrComentarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ptbID;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnAgregarComent;
        private System.Windows.Forms.Button btnCargarComent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnOcultarComentarios;
    }
}