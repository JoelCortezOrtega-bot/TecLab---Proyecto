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

        //En esta variable se guardara la tabla
        DataTable dt;
        //En esta variable se guarda el adaptador 
        SqlDataAdapter da;
        // aqui se carga la conexion a la base de datos de funciones/Conexion.cs
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
            string iddepto = idDep.Text;

            //Condicion: entra en el if si ninguna de las casillas esta vacia
            if (!string.IsNullOrWhiteSpace(idUsuario.Text) || !string.IsNullOrWhiteSpace(nombreUsuario.Text) || !string.IsNullOrWhiteSpace(apellidoPaterno.Text)
               || !string.IsNullOrWhiteSpace(apellidoMaterno.Text) || !string.IsNullOrWhiteSpace(claveUsuario.Text) || !string.IsNullOrWhiteSpace(correoUsuario.Text) || !string.IsNullOrWhiteSpace(idDep.Text))
            {
                try
                {
                    //  Intenta insertar los valores en el campo correspondiente
                    Con.Conexiones.Open();
                    string s = string.Format("INSERT INTO Usuario VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',0,{9}) ", id, nombre, apellidop, apellidom, genero, correo, clave, rol, estado,iddepto);
                    SqlCommand comando = new SqlCommand(s, Con.Conexiones);
                    comando.ExecuteNonQuery();
                    //guarda el nombre completo del usuario para mostrarlo en el cuadro de texto
                    string fullname = nombre + " " + apellidom + " " + apellidop;
                    MessageBox.Show("usuario " + fullname + " agregado correctamente");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                Con.Conexiones.Close();

            }
            //si esta algun campo vacio entra aqui
            else
            {
                MessageBox.Show("Uno o mas campos estan en blanco, llenalos para poder registrar");
            }

            // intenta cargar el metodo cargar
            try
            {
                cargar(dataGridView1);

            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //Carga la informacion de la base de datos a el datagridview
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
    //metodo que se carga cuando inicia la forma
        private void FrAgregarUsuarios_Load(object sender, EventArgs e)
        {
            //esto evita que en el combobox se puedan editar las opciones
            rolUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            generoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            estadoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            idDep.DropDownStyle = ComboBoxStyle.DropDownList;
            // intenta cargar el metodo cargar

            try
            {
                cargar(dataGridView1);

            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //evita que en el apeido se puedan poner numeros
        private void apellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        //evita que en el apeido se puedan poner numeros
        private void apellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

    }
}
