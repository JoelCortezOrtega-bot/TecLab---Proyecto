namespace LabTec
{
    partial class FrModificarClave
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtClaveActual = new System.Windows.Forms.TextBox();
            this.txtClaveNueva = new System.Windows.Forms.TextBox();
            this.txtClaveNRepetir = new System.Windows.Forms.TextBox();
            this.lblClaveActual = new System.Windows.Forms.Label();
            this.lblClaveNueva = new System.Windows.Forms.Label();
            this.lblClaveNAnt = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pndAdorno = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(164, 23);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Cambiar contraseña";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.lblDescripcion.Location = new System.Drawing.Point(13, 43);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(444, 17);
            this.lblDescripcion.TabIndex = 17;
            this.lblDescripcion.Text = "Se recomienda usar una contraseña segura que no uses para ningún otro sitio.";
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.Location = new System.Drawing.Point(150, 74);
            this.txtClaveActual.MaxLength = 18;
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.PasswordChar = '*';
            this.txtClaveActual.Size = new System.Drawing.Size(146, 20);
            this.txtClaveActual.TabIndex = 0;
            // 
            // txtClaveNueva
            // 
            this.txtClaveNueva.Location = new System.Drawing.Point(150, 103);
            this.txtClaveNueva.MaxLength = 18;
            this.txtClaveNueva.Name = "txtClaveNueva";
            this.txtClaveNueva.PasswordChar = '*';
            this.txtClaveNueva.Size = new System.Drawing.Size(146, 20);
            this.txtClaveNueva.TabIndex = 1;
            // 
            // txtClaveNRepetir
            // 
            this.txtClaveNRepetir.Location = new System.Drawing.Point(150, 143);
            this.txtClaveNRepetir.MaxLength = 18;
            this.txtClaveNRepetir.Name = "txtClaveNRepetir";
            this.txtClaveNRepetir.PasswordChar = '*';
            this.txtClaveNRepetir.Size = new System.Drawing.Size(146, 20);
            this.txtClaveNRepetir.TabIndex = 2;
            // 
            // lblClaveActual
            // 
            this.lblClaveActual.AutoSize = true;
            this.lblClaveActual.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.lblClaveActual.Location = new System.Drawing.Point(13, 75);
            this.lblClaveActual.Name = "lblClaveActual";
            this.lblClaveActual.Size = new System.Drawing.Size(114, 17);
            this.lblClaveActual.TabIndex = 21;
            this.lblClaveActual.Text = "Contraseña actual:";
            // 
            // lblClaveNueva
            // 
            this.lblClaveNueva.AutoSize = true;
            this.lblClaveNueva.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.lblClaveNueva.Location = new System.Drawing.Point(13, 104);
            this.lblClaveNueva.Name = "lblClaveNueva";
            this.lblClaveNueva.Size = new System.Drawing.Size(115, 17);
            this.lblClaveNueva.TabIndex = 22;
            this.lblClaveNueva.Text = "Nueva Contraseña:";
            // 
            // lblClaveNAnt
            // 
            this.lblClaveNAnt.AutoSize = true;
            this.lblClaveNAnt.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.lblClaveNAnt.Location = new System.Drawing.Point(13, 135);
            this.lblClaveNAnt.Name = "lblClaveNAnt";
            this.lblClaveNAnt.Size = new System.Drawing.Size(116, 34);
            this.lblClaveNAnt.TabIndex = 23;
            this.lblClaveNAnt.Text = "Vuelve a escribir la \r\ncontraseña nueva:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(16, 185);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(426, 35);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar contraseña";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pndAdorno
            // 
            this.pndAdorno.BackColor = System.Drawing.Color.MidnightBlue;
            this.pndAdorno.Dock = System.Windows.Forms.DockStyle.Right;
            this.pndAdorno.Location = new System.Drawing.Point(463, 0);
            this.pndAdorno.Name = "pndAdorno";
            this.pndAdorno.Size = new System.Drawing.Size(314, 450);
            this.pndAdorno.TabIndex = 249;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Location = new System.Drawing.Point(16, 403);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(111, 35);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FrModificarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.pndAdorno);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblClaveNAnt);
            this.Controls.Add(this.lblClaveNueva);
            this.Controls.Add(this.lblClaveActual);
            this.Controls.Add(this.txtClaveNRepetir);
            this.Controls.Add(this.txtClaveNueva);
            this.Controls.Add(this.txtClaveActual);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrModificarClave";
            this.Text = "ModificarClave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtClaveActual;
        private System.Windows.Forms.TextBox txtClaveNueva;
        private System.Windows.Forms.TextBox txtClaveNRepetir;
        private System.Windows.Forms.Label lblClaveActual;
        private System.Windows.Forms.Label lblClaveNueva;
        private System.Windows.Forms.Label lblClaveNAnt;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pndAdorno;
        private System.Windows.Forms.Button btnAtras;
    }
}