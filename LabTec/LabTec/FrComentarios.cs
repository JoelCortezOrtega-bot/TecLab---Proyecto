using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LabTec
{
    public partial class FrComentarios : Form
    {
        int LocalID;

        public FrComentarios(int ID)
        {
            InitializeComponent();
            LocalID = ID;
        }

        private void btnAgregarComent_Click(object sender, EventArgs e)
        {
            //Declarar Variables Auxiliares
            //Almacenamos los datos capturados por el usuario y asignamos el ID del Usuario
            int ID;
            string Comentario;

            try
            {
                //Verifica si alguno de los txt se encuentra vacio
                if (txtComentario.Text == "")
                {
                    //Llamamos al metodo static txtVacios
                    MessageBox.Show("Por favor el cuadro de texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ID = LocalID;
                    Comentario = txtComentario.Text;
                    //Creamos un objeto de la clase Operaciones
                    LabTec.Operaciones.Operaciones operaciones = new Operaciones.Operaciones();
                    //Utilizamos el Metodo para agregar un comentario a la BD
                    operaciones.AgregarComentario(Comentario, ID);
                }
            }
            catch(FormatException)
            {
          
                string mensaje = "Por favor, no ingrese los datos correctos.";
                MessageBox.Show(mensaje, "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Limpiar cuadro de texto
                txtComentario.Clear();
            }

        }

        private void btnCargarComent_Click(object sender, EventArgs e)
        {
            //Creamos objeto de la clase Conexion para utilizar SqlConnection que fue declarado
            LabTec.Funciones.Conexion Cn = new LabTec.Funciones.Conexion();
            //Creamos un objeto de la clase SqlCommand para ejecutar cualquier funcion o procedimiento de SQL
            SqlCommand Comando = new SqlCommand();

            //Guardamos el resultado de Comando en esta variable auxiliar
            string B_activo;

            //Declaracion de Variables Auxilares
            string Nombre;
            string ApellidoPaterno;
            string ApellidoMaterno;
            string Fecha;
            string Descripcion;

            //Valores predeterminados para mostrar la seccción de comentarios
            //La bandera sirver para monstrar comentarios, en caso de no tener ninguno
            //No mostrara ninguno, cuando deje cambie de estado significa que ya no hay comentarios
            bool bandera = true;
            //Valores predeterminados de las posiciones base de los comentarios
            int conteo = 0;
            int contador = 1;
            int PINombre = 96;
            int PIComentario = 0;
            int PIFecha = 96;
            int PIImagen = 12;
            panel1.AutoScroll = true;


            while (bandera == true)
            {
                //Indicamos al comando la conexión
                Comando.Connection = Cn.Conexiones;
                //Abrimos la conexion
                Cn.Conexiones.Open();
                //Asignamos al comando la consulta de B_activo
                //Utiliza la funcion se encuentra en la base de datos para verificar si el correo ingresado 
                //concuerda alguno ya existen
                Comando.CommandText = "SELECT dbo.fn_Comentarios(" + contador + ")";
                //Guardamos el resultado en la variable auxiliar
                B_activo = (Comando.ExecuteScalar()).ToString();
                Cn.Conexiones.Close();
                if (B_activo == "Si")
                {
                    //Abrimos la conexion con la base de datos
                    Cn.Conexiones.Open();
                    //Esta consulta nos permite mostrar el Nombre del usuario de acuerdo al contador que se esta utilizando
                    string s = "SELECT Usuario.Nombre FROM Comentarios INNER JOIN Usuario ON Usuario.ID_Usuario = Comentarios.ID_Usuario WHERE Comentarios.I_seq =" + contador + "";
                    Comando = new SqlCommand(s, Cn.Conexiones);
                    Nombre = Comando.ExecuteScalar().ToString();
                    //Estas consultas nos permiten mostrar el Apellidos del usuario de acuerdo al contador que se esta utilizando
                    s = "SELECT Usuario.Ape_P FROM Comentarios INNER JOIN Usuario ON Usuario.ID_Usuario = Comentarios.ID_Usuario WHERE Comentarios.I_seq =" + contador + "";
                    Comando = new SqlCommand(s, Cn.Conexiones);
                    ApellidoPaterno = Comando.ExecuteScalar().ToString();
                    s = "SELECT Usuario.Ape_M FROM Comentarios INNER JOIN Usuario ON Usuario.ID_Usuario = Comentarios.ID_Usuario WHERE Comentarios.I_seq =" + contador + "";
                    Comando = new SqlCommand(s, Cn.Conexiones);
                    ApellidoMaterno = Comando.ExecuteScalar().ToString();
                    //Esta consulta nos permite mostrar el Comentario del usuario de acuerdo al contador que se esta utilizando
                    s = "SELECT Comentarios.Descripcion FROM Comentarios INNER JOIN Usuario ON Usuario.ID_Usuario = Comentarios.ID_Usuario WHERE Comentarios.I_seq =" + contador + "";
                    Comando = new SqlCommand(s, Cn.Conexiones);
                    Descripcion = Comando.ExecuteScalar().ToString();
                    //Esta consulta nos permite mostrar la Fecha en que se publico de acuerdo al contador que se esta utilizando
                    s = "SELECT Comentarios.Fecha FROM Comentarios INNER JOIN Usuario ON Usuario.ID_Usuario = Comentarios.ID_Usuario WHERE Comentarios.I_seq =" + contador + "";
                    Comando = new SqlCommand(s, Cn.Conexiones);
                    Fecha = Comando.ExecuteScalar().ToString();
                    Cn.Conexiones.Close();

                    //Creamos la instancia del boton
                    /*
                     Estos objetos los vamos a utilizar para crear
                     de forma dinamica los elementos que seran requeridos
                     que en este caso son los Labels y un pictureBox.
                     */
                    Label temp = new Label();
                    Label Comentario = new Label();
                    Label FechaPublicada = new Label();
                    PictureBox picture = new PictureBox();

                    //Posicion de los elementos recien instanciados
                    //Colocamos las propiedades del lblNombre
                    picture.Height = 72;
                    picture.Width = 91;
                    picture.Location = new Point(16, PIImagen);
                    PIImagen += 150;
                    picture.Name = "ptbPerfil" + conteo.ToString();
                    picture.Image = Properties.Resources.user1;
                    picture.SizeMode = PictureBoxSizeMode.Zoom;

                    temp.Height = 18;
                    temp.Width = 389;
                    temp.Location = new Point(13, PINombre);
                    PINombre += 150;
                    temp.Name = "lblNombre" + conteo.ToString();
                    temp.Text = Nombre + " " + ApellidoPaterno + " " + ApellidoMaterno;
                    temp.Font = new Font("Arial", 12);

                    Comentario.Height = 72;
                    Comentario.Width = 458;
                    Comentario.Location = new Point(113, PIComentario);
                    PIComentario += 150;
                    Comentario.Name = "lblComentario" + conteo.ToString();
                    Comentario.Text = Descripcion;
                    Comentario.Font = new Font("Arial", 12f);

                    FechaPublicada.Height = 18;
                    FechaPublicada.Width = 240;
                    FechaPublicada.Location = new Point(408, PIFecha);
                    PIFecha += 150;
                    FechaPublicada.Name = "lblComentario" + conteo.ToString();
                    FechaPublicada.Text = "Fecha de Publicación: " + Fecha;
                    FechaPublicada.Font = new Font("Arial", 12f);

                    //Aumentamos ambos contadores
                    conteo++;
                    contador++;

                    //Adicionamos el boton a la forma
                    /*
                     Ahora agregamos a nuestra interfaz los elementos que 
                     hemos especificado sus respectivas caracteristicas
                     */
                    panel1.Controls.Add(Comentario);
                    panel1.Controls.Add(temp);
                    panel1.Controls.Add(FechaPublicada);
                    panel1.Controls.Add(picture);
                }
                else
                {
                    bandera = false;                    
                }
            }
        }

        private void FrComentarios_Load(object sender, EventArgs e)
        {
            //Muestra el ID del Usuario
            lblID.Text = LocalID.ToString();
        }

        private void btnOcultarComentarios_Click(object sender, EventArgs e)
        {
            //Limpiamos la seccion de comentarios
            panel1.Controls.Clear();
        }
    }
}
