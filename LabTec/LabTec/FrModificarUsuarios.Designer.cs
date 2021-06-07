namespace LabTec
{
    partial class FrModificarUsuarios
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
            this.estadoUsuario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rolUsuario = new System.Windows.Forms.ComboBox();
            this.generoUsuario = new System.Windows.Forms.ComboBox();
            this.correoUsuario = new System.Windows.Forms.TextBox();
            this.claveUsuario = new System.Windows.Forms.TextBox();
            this.apellidoMaterno = new System.Windows.Forms.TextBox();
            this.apellidoPaterno = new System.Windows.Forms.TextBox();
            this.nombreUsuario = new System.Windows.Forms.TextBox();
            this.idUsuario = new System.Windows.Forms.TextBox();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pndAdorno = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pndAdorno.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // estadoUsuario
            // 
            this.estadoUsuario.Enabled = false;
            this.estadoUsuario.FormattingEnabled = true;
            this.estadoUsuario.Items.AddRange(new object[] {
            "T",
            "F"});
            this.estadoUsuario.Location = new System.Drawing.Point(192, 170);
            this.estadoUsuario.Name = "estadoUsuario";
            this.estadoUsuario.Size = new System.Drawing.Size(125, 22);
            this.estadoUsuario.TabIndex = 66;
            this.estadoUsuario.Text = "T";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 65;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 64;
            this.label8.Text = "Correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 63;
            this.label7.Text = "Clave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 62;
            this.label6.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 61;
            this.label5.Text = "Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "Apellido materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 59;
            this.label3.Text = "Apellido paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 15);
            this.label11.TabIndex = 57;
            this.label11.Text = "ID";
            // 
            // rolUsuario
            // 
            this.rolUsuario.Enabled = false;
            this.rolUsuario.FormattingEnabled = true;
            this.rolUsuario.Items.AddRange(new object[] {
            "1",
            "2"});
            this.rolUsuario.Location = new System.Drawing.Point(21, 214);
            this.rolUsuario.Name = "rolUsuario";
            this.rolUsuario.Size = new System.Drawing.Size(119, 22);
            this.rolUsuario.TabIndex = 56;
            this.rolUsuario.Text = "1";
            // 
            // generoUsuario
            // 
            this.generoUsuario.Enabled = false;
            this.generoUsuario.FormattingEnabled = true;
            this.generoUsuario.Items.AddRange(new object[] {
            "M",
            "F"});
            this.generoUsuario.Location = new System.Drawing.Point(192, 38);
            this.generoUsuario.Name = "generoUsuario";
            this.generoUsuario.Size = new System.Drawing.Size(125, 22);
            this.generoUsuario.TabIndex = 55;
            this.generoUsuario.Text = "M";
            // 
            // correoUsuario
            // 
            this.correoUsuario.Enabled = false;
            this.correoUsuario.Location = new System.Drawing.Point(192, 126);
            this.correoUsuario.MaxLength = 50;
            this.correoUsuario.Name = "correoUsuario";
            this.correoUsuario.Size = new System.Drawing.Size(125, 23);
            this.correoUsuario.TabIndex = 54;
            // 
            // claveUsuario
            // 
            this.claveUsuario.Enabled = false;
            this.claveUsuario.Location = new System.Drawing.Point(192, 82);
            this.claveUsuario.MaxLength = 9;
            this.claveUsuario.Name = "claveUsuario";
            this.claveUsuario.PasswordChar = '*';
            this.claveUsuario.Size = new System.Drawing.Size(125, 23);
            this.claveUsuario.TabIndex = 53;
            // 
            // apellidoMaterno
            // 
            this.apellidoMaterno.Enabled = false;
            this.apellidoMaterno.Location = new System.Drawing.Point(21, 170);
            this.apellidoMaterno.MaxLength = 19;
            this.apellidoMaterno.Name = "apellidoMaterno";
            this.apellidoMaterno.Size = new System.Drawing.Size(119, 23);
            this.apellidoMaterno.TabIndex = 52;
            // 
            // apellidoPaterno
            // 
            this.apellidoPaterno.Enabled = false;
            this.apellidoPaterno.Location = new System.Drawing.Point(21, 126);
            this.apellidoPaterno.MaxLength = 19;
            this.apellidoPaterno.Name = "apellidoPaterno";
            this.apellidoPaterno.Size = new System.Drawing.Size(119, 23);
            this.apellidoPaterno.TabIndex = 51;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.Enabled = false;
            this.nombreUsuario.Location = new System.Drawing.Point(21, 82);
            this.nombreUsuario.MaxLength = 25;
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(119, 23);
            this.nombreUsuario.TabIndex = 50;
            // 
            // idUsuario
            // 
            this.idUsuario.Enabled = false;
            this.idUsuario.Location = new System.Drawing.Point(21, 38);
            this.idUsuario.MaxLength = 8;
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Size = new System.Drawing.Size(119, 23);
            this.idUsuario.TabIndex = 49;
            // 
            // modificarBtn
            // 
            this.modificarBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.modificarBtn.Enabled = false;
            this.modificarBtn.Font = new System.Drawing.Font("Corbel", 12F);
            this.modificarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modificarBtn.Location = new System.Drawing.Point(178, 252);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(151, 35);
            this.modificarBtn.TabIndex = 48;
            this.modificarBtn.Text = "Guardar cambios";
            this.modificarBtn.UseVisualStyleBackColor = false;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // buscarBtn
            // 
            this.buscarBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.buscarBtn.Font = new System.Drawing.Font("Corbel", 12F);
            this.buscarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buscarBtn.Location = new System.Drawing.Point(305, 32);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(78, 35);
            this.buscarBtn.TabIndex = 47;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = false;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Buscar ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buscarTxt
            // 
            this.buscarTxt.Location = new System.Drawing.Point(85, 41);
            this.buscarTxt.Name = "buscarTxt";
            this.buscarTxt.Size = new System.Drawing.Size(214, 20);
            this.buscarTxt.TabIndex = 45;
            this.buscarTxt.TextChanged += new System.EventHandler(this.buscarTxt_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 330);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pndAdorno
            // 
            this.pndAdorno.BackColor = System.Drawing.Color.MidnightBlue;
            this.pndAdorno.Controls.Add(this.label10);
            this.pndAdorno.Controls.Add(this.dataGridView1);
            this.pndAdorno.Dock = System.Windows.Forms.DockStyle.Right;
            this.pndAdorno.Location = new System.Drawing.Point(389, 0);
            this.pndAdorno.Name = "pndAdorno";
            this.pndAdorno.Size = new System.Drawing.Size(388, 450);
            this.pndAdorno.TabIndex = 251;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(144, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 250;
            this.label10.Text = "Vista previa";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(261, 23);
            this.lblTitulo.TabIndex = 252;
            this.lblTitulo.Text = "Usuarios - Modificación de datos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idUsuario);
            this.groupBox1.Controls.Add(this.nombreUsuario);
            this.groupBox1.Controls.Add(this.apellidoPaterno);
            this.groupBox1.Controls.Add(this.apellidoMaterno);
            this.groupBox1.Controls.Add(this.claveUsuario);
            this.groupBox1.Controls.Add(this.modificarBtn);
            this.groupBox1.Controls.Add(this.estadoUsuario);
            this.groupBox1.Controls.Add(this.correoUsuario);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.generoUsuario);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rolUsuario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 9.25F);
            this.groupBox1.Location = new System.Drawing.Point(16, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 300);
            this.groupBox1.TabIndex = 253;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Location = new System.Drawing.Point(12, 403);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(111, 35);
            this.btnAtras.TabIndex = 254;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FrModificarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.buscarTxt);
            this.Controls.Add(this.pndAdorno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrModificarUsuarios";
            this.Text = "FrModificarUsuarios";
            this.Load += new System.EventHandler(this.FrModificarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pndAdorno.ResumeLayout(false);
            this.pndAdorno.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox estadoUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox rolUsuario;
        private System.Windows.Forms.ComboBox generoUsuario;
        private System.Windows.Forms.TextBox correoUsuario;
        private System.Windows.Forms.TextBox claveUsuario;
        private System.Windows.Forms.TextBox apellidoMaterno;
        private System.Windows.Forms.TextBox apellidoPaterno;
        private System.Windows.Forms.TextBox nombreUsuario;
        private System.Windows.Forms.TextBox idUsuario;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buscarTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pndAdorno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAtras;
    }
}