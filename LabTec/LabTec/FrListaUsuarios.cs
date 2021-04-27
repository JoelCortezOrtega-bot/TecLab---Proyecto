using LabTec.Funciones;
using LabTec.Operaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTec
{
    public partial class FrListaUsuarios : Form
    {
        //Variables que se usaran para guardar la informacion de la BD
        //Coords
        static int X = 112;
        static int Y = 13;

        static int iX = 3;
        static int iY = 8;
        //Variables normales
        string Nombre = "";
        string Tipo = "";
        string ApePat = "";
        string ApeMat = "";
        string Correo = "";
        string Depto = "";
        int Columnas = 0;
        int Filas = 0;
        bool texto = false;

        public FrListaUsuarios()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Reinicio
            X = 112;
            Y = 13;
            iX = 3;
            iY = 8;
            panelPrincipal.Controls.Clear();

            //Conectamos con la BD
            Conexion ConectarBD = new Conexion();
            ConectarBD.Conexiones.Open();
            string Cadena = "";
            if (txtBusqueda.Text == "")
            {
                switch (cBoxTiposBusqueda.Text)
                {
                    case "Predeterminado":
                        Cadena = "select Rol.Nombre,Usuario.Nombre, Usuario.Ape_P, Usuario.Ape_M,Usuario.Correo,Departamento.Nombre from Usuario inner join Maestros on Maestros.ID_Usuario=Usuario.ID_Usuario inner join Departamento on Maestros.ID_Dep=Departamento.ID_Dep inner join Rol on Rol.ID_Rol=Usuario.ID_Rol union select Rol.Nombre,Usuario.Nombre, Usuario.Ape_P, Usuario.Ape_M,Usuario.Correo,'No tiene' from Usuario inner join Rol on Rol.ID_Rol=Usuario.ID_Rol where Usuario.ID_Rol=2";
                        break;
                    case "Alfabeticamente":
                        Cadena = "select Rol.Nombre,Usuario.Nombre, Usuario.Ape_P, Usuario.Ape_M,Usuario.Correo,Departamento.Nombre from Usuario inner join Maestros on Maestros.ID_Usuario=Usuario.ID_Usuario inner join Departamento on Maestros.ID_Dep=Departamento.ID_Dep inner join Rol on Rol.ID_Rol=Usuario.ID_Rol union select Rol.Nombre,Usuario.Nombre, Usuario.Ape_P, Usuario.Ape_M,Usuario.Correo,'No tiene' from Usuario inner join Rol on Rol.ID_Rol=Usuario.ID_Rol where Usuario.ID_Rol=2 order by Usuario.Nombre";
                        break;
                    case "Departamentos":
                        Cadena = "select Rol.Nombre,Usuario.Nombre, Usuario.Ape_P, Usuario.Ape_M,Usuario.Correo,Departamento.Nombre from Usuario inner join Maestros on Maestros.ID_Usuario=Usuario.ID_Usuario inner join Departamento on Maestros.ID_Dep=Departamento.ID_Dep inner join Rol on Rol.ID_Rol=Usuario.ID_Rol union select Rol.Nombre,Usuario.Nombre, Usuario.Ape_P, Usuario.Ape_M,Usuario.Correo,'No tiene' from Usuario inner join Rol on Rol.ID_Rol=Usuario.ID_Rol where Usuario.ID_Rol=2 order by Departamento.Nombre";
                        break;
                    default:
                        Cadena = "select Rol.Nombre,Usuario.Nombre, Usuario.Ape_P, Usuario.Ape_M,Usuario.Correo,Departamento.Nombre from Usuario inner join Maestros on Maestros.ID_Usuario=Usuario.ID_Usuario inner join Departamento on Maestros.ID_Dep=Departamento.ID_Dep inner join Rol on Rol.ID_Rol=Usuario.ID_Rol union select Rol.Nombre,Usuario.Nombre, Usuario.Ape_P, Usuario.Ape_M,Usuario.Correo,'No tiene' from Usuario inner join Rol on Rol.ID_Rol=Usuario.ID_Rol where Usuario.ID_Rol=2 order by Departamento.Nombre";
                        break;
                }
            }
            else
            {
                Cadena = "Select Rol.Nombre,Usuario.Nombre, Usuario.Ape_P, Usuario.Ape_M,Usuario.Correo,Departamento.Nombre from Usuario inner join Maestros on Maestros.ID_Usuario=Usuario.ID_Usuario inner join Departamento on Maestros.ID_Dep=Departamento.ID_Dep inner join Rol on Rol.ID_Rol=Usuario.ID_Rol where Rol.Nombre like '%'+@Tipo+'%' or Usuario.Nombre like '%'+@Tipo+'%' or Usuario.Ape_P like '%'+@Tipo+'%' or Usuario.Ape_M like '%'+@Tipo+'%' or Usuario.Correo like '%'+@Tipo+'%' or Departamento.Nombre like '%'+@Tipo+'%' union select Rol.Nombre,Usuario.Nombre, Usuario.Ape_P, Usuario.Ape_M,Usuario.Correo,'No tiene' from Usuario inner join Rol on Rol.ID_Rol=Usuario.ID_Rol where Usuario.ID_Rol=2 and (Rol.Nombre like '%'+@Tipo+'%' or Usuario.Nombre like '%'+@Tipo+'%' or Usuario.Ape_P like '%'+@Tipo+'%' or Usuario.Ape_M like '%'+@Tipo+'%' or Usuario.Correo like '%'+@Tipo+'%')";
                texto = true;
            }
            //Creamos el comando de SQL
            SqlCommand cmd = new SqlCommand(Cadena, ConectarBD.Conexiones);
            //IF en caso de que haya texto en el buscador
            if (texto == true)
            {
                cmd.Parameters.Add(new SqlParameter("@Tipo", txtBusqueda.Text));
            }
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            ConectarBD.Conexiones.Close();

            Filas = dt.Rows.Count;
            Columnas = dt.Columns.Count;
            //Mandamos los valores al metodo correspondiente
            for (int i = 0; i < Filas; i++)
            {
                Tipo = dt.Rows[i][0].ToString();
                Nombre = dt.Rows[i][1].ToString();
                ApePat = dt.Rows[i][2].ToString();
                ApeMat = dt.Rows[i][3].ToString();
                Correo = dt.Rows[i][4].ToString();
                Depto = dt.Rows[i][5].ToString();

                Imagen(Tipo);
                Texto(Nombre, ApePat, ApeMat, Correo, Depto);
            }
        }
        //Metodo para crear los labels del perfil
        private void Texto(string nombre, string apepat, string apemat, string correo, string depto)
        {
            //Nombre
            Label TextoNombre = new Label();
            TextoNombre.Text = "Nombre: " + nombre + " " + apepat + " " + apemat;
            TextoNombre.Location = new Point(X, Y);
            TextoNombre.AutoSize = true;
            TextoNombre.Font = new Font("Lucida Console", 8, FontStyle.Regular);
            panelPrincipal.Controls.Add(TextoNombre);
            Y = Y + 25;
            
            //Correo
            Label TextoCorreo = new Label();
            TextoCorreo.Text = "Correo: " + correo;
            TextoCorreo.Location = new Point(X, Y);
            TextoCorreo.AutoSize = true;
            TextoCorreo.Font = new Font("Lucida Console", 8, FontStyle.Regular);
            panelPrincipal.Controls.Add(TextoCorreo);
            Y = Y + 25;

            //Departamento
            Y = Y + 25;
            Label TextoDepto = new Label();
            TextoDepto.Text = "Departamento: " + depto;
            TextoDepto.Location = new Point(X, Y);
            TextoDepto.AutoSize = true;
            TextoDepto.Font = new Font("Lucida Console", 8, FontStyle.Regular);
            panelPrincipal.Controls.Add(TextoDepto);
            Y = Y + 35;
        }

        //Metodo para crear la imagen del perfil
        private void Imagen(string Tipo)
        {
            
            PictureBox Imagen = new PictureBox();
            //Comparamos los valores para saber que imagen usaremos
            if (Tipo == "Administrador")
            {
                Imagen.Image = Properties.Resources.LetraA;
            }
            else
            {
                Imagen.Image = Properties.Resources.LetraM;
            }
            //Modificamos las propiedades para crear la imagen
            Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            Imagen.Name = "owo";
            Imagen.Width = 100;
            Imagen.Height = 100;
            Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            Imagen.Location = new Point(iX, iY);
            panelPrincipal.Controls.Add(Imagen);
            
            //Agregamos altura para que la imagen tengan separacion
            iY = iY + 110;
        }
    }
}
