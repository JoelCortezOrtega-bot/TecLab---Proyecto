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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // estadoUsuario
            // 
            this.estadoUsuario.Enabled = false;
            this.estadoUsuario.FormattingEnabled = true;
            this.estadoUsuario.Items.AddRange(new object[] {
            "T",
            "F"});
            this.estadoUsuario.Location = new System.Drawing.Point(632, 291);
            this.estadoUsuario.Name = "estadoUsuario";
            this.estadoUsuario.Size = new System.Drawing.Size(125, 21);
            this.estadoUsuario.TabIndex = 66;
            this.estadoUsuario.Text = "T";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(686, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(686, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(690, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Clave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Genero de usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Rol de usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Apellido materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Apellido paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(496, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Id ";
            // 
            // rolUsuario
            // 
            this.rolUsuario.Enabled = false;
            this.rolUsuario.FormattingEnabled = true;
            this.rolUsuario.Items.AddRange(new object[] {
            "1",
            "2"});
            this.rolUsuario.Location = new System.Drawing.Point(461, 334);
            this.rolUsuario.Name = "rolUsuario";
            this.rolUsuario.Size = new System.Drawing.Size(119, 21);
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
            this.generoUsuario.Location = new System.Drawing.Point(632, 134);
            this.generoUsuario.Name = "generoUsuario";
            this.generoUsuario.Size = new System.Drawing.Size(125, 21);
            this.generoUsuario.TabIndex = 55;
            this.generoUsuario.Text = "M";
            // 
            // correoUsuario
            // 
            this.correoUsuario.Enabled = false;
            this.correoUsuario.Location = new System.Drawing.Point(632, 233);
            this.correoUsuario.MaxLength = 50;
            this.correoUsuario.Name = "correoUsuario";
            this.correoUsuario.Size = new System.Drawing.Size(125, 20);
            this.correoUsuario.TabIndex = 54;
            // 
            // claveUsuario
            // 
            this.claveUsuario.Enabled = false;
            this.claveUsuario.Location = new System.Drawing.Point(632, 186);
            this.claveUsuario.MaxLength = 20;
            this.claveUsuario.Name = "claveUsuario";
            this.claveUsuario.Size = new System.Drawing.Size(125, 20);
            this.claveUsuario.TabIndex = 53;
            // 
            // apellidoMaterno
            // 
            this.apellidoMaterno.Enabled = false;
            this.apellidoMaterno.Location = new System.Drawing.Point(461, 282);
            this.apellidoMaterno.MaxLength = 20;
            this.apellidoMaterno.Name = "apellidoMaterno";
            this.apellidoMaterno.Size = new System.Drawing.Size(119, 20);
            this.apellidoMaterno.TabIndex = 52;
            // 
            // apellidoPaterno
            // 
            this.apellidoPaterno.Enabled = false;
            this.apellidoPaterno.Location = new System.Drawing.Point(461, 233);
            this.apellidoPaterno.MaxLength = 20;
            this.apellidoPaterno.Name = "apellidoPaterno";
            this.apellidoPaterno.Size = new System.Drawing.Size(119, 20);
            this.apellidoPaterno.TabIndex = 51;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.Enabled = false;
            this.nombreUsuario.Location = new System.Drawing.Point(461, 186);
            this.nombreUsuario.MaxLength = 25;
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(119, 20);
            this.nombreUsuario.TabIndex = 50;
            // 
            // idUsuario
            // 
            this.idUsuario.Enabled = false;
            this.idUsuario.Location = new System.Drawing.Point(461, 134);
            this.idUsuario.MaxLength = 8;
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Size = new System.Drawing.Size(119, 20);
            this.idUsuario.TabIndex = 49;
            // 
            // modificarBtn
            // 
            this.modificarBtn.Enabled = false;
            this.modificarBtn.Location = new System.Drawing.Point(499, 371);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(220, 43);
            this.modificarBtn.TabIndex = 48;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(682, 77);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 47;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Escribe un numero de ID valido:";
            // 
            // buscarTxt
            // 
            this.buscarTxt.Location = new System.Drawing.Point(531, 77);
            this.buscarTxt.Name = "buscarTxt";
            this.buscarTxt.Size = new System.Drawing.Size(145, 20);
            this.buscarTxt.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 257);
            this.dataGridView1.TabIndex = 44;
            // 
            // FrModificarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.estadoUsuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rolUsuario);
            this.Controls.Add(this.generoUsuario);
            this.Controls.Add(this.correoUsuario);
            this.Controls.Add(this.claveUsuario);
            this.Controls.Add(this.apellidoMaterno);
            this.Controls.Add(this.apellidoPaterno);
            this.Controls.Add(this.nombreUsuario);
            this.Controls.Add(this.idUsuario);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarTxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrModificarUsuarios";
            this.Text = "FrModificarUsuarios";
            this.Load += new System.EventHandler(this.FrModificarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}