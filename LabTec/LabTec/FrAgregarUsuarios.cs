using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LabTec
{
    public partial class FrAgregarUsuarios : Form
    {
        public FrAgregarUsuarios()
        {
            InitializeComponent();
        }

        DataTable dt;
        SqlDataAdapter da;
        Funciones.Conexion Con = new Funciones.Conexion();

        private void button1_Click(object sender, EventArgs e)
        {
            string id = idUsuario.Text;
            string nombre = nombreUsuario.Text;
            string apellidop = apellidoPaterno.Text;
            string apellidom = apellidoMaterno.Text;
            string genero = generoUsuario.Text;
            string correo = correoUsuario.Text + "@tectijuana.edu.mx";
            string clave = claveUsuario.Text;
            string rol = rolUsuario.Text;
            string estado = estadoUsuario.Text;

            if (!string.IsNullOrWhiteSpace(idUsuario.Text) || !string.IsNullOrWhiteSpace(nombreUsuario.Text) || !string.IsNullOrWhiteSpace(apellidoPaterno.Text)
               || !string.IsNullOrWhiteSpace(apellidoMaterno.Text) || !string.IsNullOrWhiteSpace(claveUsuario.Text) || !string.IsNullOrWhiteSpace(correoUsuario.Text))
            {
                try
                {
                    Con.Conexiones.Open();
                    string s = string.Format("INSERT INTO Usuario VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}') ", id, nombre, apellidop, apellidom, genero, correo, clave, rol, estado);
                    SqlCommand comando = new SqlCommand(s, Con.Conexiones);
                    comando.ExecuteNonQuery();
                    string fullname = nombre + " " + apellidom + " " + apellidop;
                    MessageBox.Show("usuario " + fullname + " agregado correctamente");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                Con.Conexiones.Close();

            }
            else
            {
                MessageBox.Show("Uno o mas campos estan en blanco, llenalos para poder registrar");
            }


            try
            {
                cargar(dataGridView1);

            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void cargar(DataGridView dgv)
        {

            Con.Conexiones.Open();
            string s = string.Format("SELECT * FROM Usuario");



            da = new SqlDataAdapter(s, Con.Conexiones);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;


            Con.Conexiones.Close();



        }

        private void FrAgregarUsuarios_Load(object sender, EventArgs e)
        {
            rolUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            generoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            estadoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                cargar(dataGridView1);

            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void apellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void apellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

    }
}
