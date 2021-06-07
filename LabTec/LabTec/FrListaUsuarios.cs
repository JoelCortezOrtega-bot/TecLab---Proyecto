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
        //Coords para cololar los elementos en el panel
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
        string Id = "";
        string Estado = "";
        string Cantidad = "";
        string Descripcion = "";

        //Variables para comparar
        int Columnas = 0;
        int Filas = 0;
        string Cadena = "";
        bool texto = false;
        string generador = "";

        public FrListaUsuarios()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Verificacion para saber que quiere buscar el usuario
            if (radiobtnUsuarios.Checked==true)
            {
                BuscadorUsuarios();
            }
            else if (radiobtnProyectores.Checked==true)
            {
                BuscadorProyectores();
            }
            else if (radiobtnLaboratorios.Checked==true)
            {
                BuscadorLaboratorios();
            }
            else
            {
                MessageBox.Show("Selecciona una opcion.","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        //BUSCADOR
        //PARA
        //USUARIOS
        private void BuscadorUsuarios()
        {
            if (txtBusqueda.Text == "")
            {
                switch (cBoxTiposBusqueda.Text)
                {
                    case "Predeterminado":
                        Cadena = "select Rol.Nombre,Usuario.Nombre, Usuario.Ape_P, Usuario.Ape_M,Usuario.Correo,Departamento.Nombre from Usuario  inner join Departamento on Usuario.ID_Dep=Departamento.ID_Dep inner join Rol on Rol.ID_Rol=Usuario.ID_Rol";
                        break;
                    case "Alfabeticamente":
                        Cadena = "select Rol.Nombre,Usuario.Nombre, Usuario.Ape_P, Usuario.Ape_M,Usuario.Correo,Departamento.Nombre from Usuario  inner join Departamento on Usuario.ID_Dep=Departamento.ID_Dep inner join Rol on Rol.ID_Rol=Usuario.ID_Rol order by Usuario.Nombre";
                        break;
                    case "Departamentos":
                        Cadena = "select Rol.Nombre,Usuario.Nombre, Usuario.Ape_P, Usuario.Ape_M,Usuario.Correo,Departamento.Nombre from Usuario  inner join Departamento on Usuario.ID_Dep=Departamento.ID_Dep inner join Rol on Rol.ID_Rol=Usuario.ID_Rol order by Departamento.Nombre";
                        break;
                    default:
                        Cadena = "select Rol.Nombre,Usuario.Nombre, Usuario.Ape_P, Usuario.Ape_M,Usuario.Correo,Departamento.Nombre from Usuario  inner join Departamento on Usuario.ID_Dep=Departamento.ID_Dep inner join Rol on Rol.ID_Rol=Usuario.ID_Rol";
                        break;
                }
            }
            else
            {
                Cadena = "select Rol.Nombre,Usuario.Nombre, Usuario.Ape_P, Usuario.Ape_M,Usuario.Correo,Departamento.Nombre from Usuario  inner join Departamento on Usuario.ID_Dep=Departamento.ID_Dep inner join Rol on Rol.ID_Rol=Usuario.ID_Rol where Rol.Nombre like '%'+@Tipo+'%' or Usuario.Nombre like '%'+@Tipo+'%' or Usuario.Ape_P like '%'+@Tipo+'%' or Usuario.Ape_M like '%'+@Tipo+'%' or Usuario.Correo like '%'+@Tipo+'%' or Departamento.Nombre like '%'+@Tipo+'%'";
                texto = true;
            }
            generador = "Usuario";
            GeneracionTabla(texto,Cadena,generador);
        }

        //BUSCADOR
        //PARA
        //PROYECTORES
        private void BuscadorProyectores()
        {
            if (txtBusqueda.Text == "")
            {
                Cadena = "select Proyectores.ID_Proyector,Proyectores.Nombre,Estado_Proyector.Nombre,Proyectores.Descripcion from Proyectores inner join Estado_Proyector on Proyectores.ID_EstadoProyector=Estado_Proyector.ID_EstadoProyector";
            }
            else
            {
                Cadena = "select Proyectores.ID_Proyector,Proyectores.Nombre,Estado_Proyector.Nombre,Proyectores.Descripcion from Proyectores inner join Estado_Proyector on Proyectores.ID_EstadoProyector=Estado_Proyector.ID_EstadoProyector where Proyectores.ID_Proyector like '%'+@Tipo+'%' or Proyectores.Nombre like '%'+@Tipo+'%' or Estado_Proyector.Nombre like '%'+@Tipo+'%' or Proyectores.Descripcion like '%'+@Tipo+'%'";
                texto = true;
            }
            generador = "Proyectores";
            GeneracionTabla(texto, Cadena, generador);
        }

        //BUSCADOR
        //PARA
        //LABORATORIO
        private void BuscadorLaboratorios()
        {
            if (txtBusqueda.Text == "")
            {
                Cadena = "select Laboratorios.ID_Lap,Laboratorios.Nombre,Estado_Lab.Nombre from Laboratorios inner join Estado_Lab on Laboratorios.ID_EstLab=Estado_Lab.ID_EstLab";
            }
            else
            {
                Cadena = "select Laboratorios.ID_Lap,Laboratorios.Nombre,Estado_Lab.Nombre from Laboratorios inner join Estado_Lab on Laboratorios.ID_EstLab=Estado_Lab.ID_EstLab where Laboratorios.ID_Lap like '%'+@Tipo+'%' or Laboratorios.Nombre like '%'+@Tipo+'%' or Estado_Lab.Nombre like '%'+@Tipo+'%'";
                texto = true;
            }
            generador = "Laboratorio";
            GeneracionTabla(texto, Cadena, generador);
        }

        private void GeneracionTabla(bool text,string cadena,string gen)
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

            //Creamos el comando de SQL
            SqlCommand cmd = new SqlCommand(Cadena, ConectarBD.Conexiones);

            //IF en caso de que haya texto en el buscador
            if (text == true)
            {
                cmd.Parameters.Add(new SqlParameter("@Tipo", txtBusqueda.Text));
            }

            //Generamos la tabla
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            ConectarBD.Conexiones.Close();

            //Contamos las filas y columnas
            Filas = dt.Rows.Count;
            Columnas = dt.Columns.Count;
            //Se imprimira de manera diferente dependiendo de que se desea buscar (Usuario, proyector o laboratorio)
            if (gen=="Usuario")
            {
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
            else if (gen == "Laboratorio")
            {
                for (int i = 0; i < Filas; i++)
                {
                    Id = dt.Rows[i][0].ToString();
                    Nombre= dt.Rows[i][1].ToString();
                    Estado= dt.Rows[i][2].ToString();
                    //Agregar: Cantidad de PC

                    Imagen(gen);
                    TextoLab(Id,Nombre,Estado);
                }
            }
            else if (gen=="Proyectores")
            {
                for (int i = 0; i < Filas; i++)
                {
                    Id= dt.Rows[i][0].ToString();
                    Nombre= dt.Rows[i][1].ToString();
                    Estado= dt.Rows[i][2].ToString();
                    Descripcion= dt.Rows[i][3].ToString();

                    Imagen(gen);
                    TextoProyector(Id, Nombre, Estado,Descripcion);
                }
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
            //Lucida Console
            TextoNombre.Font = new Font("Calibri", 10, FontStyle.Regular);
            panelPrincipal.Controls.Add(TextoNombre);
            Y = Y + 33;
            
            //Correo
            Label TextoCorreo = new Label();
            TextoCorreo.Text = "Correo: " + correo;
            TextoCorreo.Location = new Point(X, Y);
            TextoCorreo.AutoSize = true;
            TextoCorreo.Font = new Font("Calibri", 10, FontStyle.Regular);
            panelPrincipal.Controls.Add(TextoCorreo);
            Y = Y + 33;

            //Departamento
            //Y = Y + 33;
            Label TextoDepto = new Label();
            TextoDepto.Text = "Departamento: " + depto;
            TextoDepto.Location = new Point(X, Y);
            TextoDepto.AutoSize = true;
            TextoDepto.Font = new Font("Calibri", 10, FontStyle.Regular);
            panelPrincipal.Controls.Add(TextoDepto);
            Y = Y + 35; //45
            //Separacion entre cada bloque
            Label Separacion = new Label();
            Separacion.Location=new Point(0,Y);
            Separacion.AutoSize = false;
            Separacion.BackColor = Color.MidnightBlue;
            Separacion.Height =5;
            Separacion.Width =panelPrincipal.Width;
            panelPrincipal.Controls.Add(Separacion);
            Y = Y + 10;
        }

        private void TextoLab(string id, string nombre, string estado)
        {
            //ID
            Label TextoID = new Label();
            TextoID.Text = "ID: "+ id;
            TextoID.Location = new Point(X, Y);
            TextoID.AutoSize = true;
            TextoID.Font = new Font("Calibri", 10, FontStyle.Regular);
            panelPrincipal.Controls.Add(TextoID);
            Y = Y + 33;

            //Nombre
            Label TextoNombre = new Label();
            TextoNombre.Text = "Nombre: " + nombre;
            TextoNombre.Location = new Point(X, Y);
            TextoNombre.AutoSize = true;
            TextoNombre.Font = new Font("Calibri", 10, FontStyle.Regular);
            panelPrincipal.Controls.Add(TextoNombre);
            Y = Y + 33;

            //Estado
            Label TextoEstado = new Label();
            TextoEstado.Text = "Estado: " + Estado;
            TextoEstado.Location = new Point(X, Y);
            TextoEstado.AutoSize = true;
            TextoEstado.Font = new Font("Calibri", 10, FontStyle.Regular);
            panelPrincipal.Controls.Add(TextoEstado);
            Y = Y + 35; //45
            
            //Separacion entre cada bloque
            Label Separacion = new Label();
            Separacion.Location = new Point(0, Y);
            Separacion.AutoSize = false;
            Separacion.BackColor = Color.MidnightBlue;
            Separacion.Height = 5;
            Separacion.Width = panelPrincipal.Width;
            panelPrincipal.Controls.Add(Separacion);
            Y = Y + 10;
        }

        private void TextoProyector(string id, string nombre, string estado, string descripcion)
        {
            //ID
            Label TextoID = new Label();
            TextoID.Text = "ID: " + id;
            TextoID.Location = new Point(X, Y);
            TextoID.AutoSize = true;
            TextoID.Font = new Font("Calibri", 10, FontStyle.Regular);
            panelPrincipal.Controls.Add(TextoID);
            Y = Y + 20;

            //Nombre
            Label TextoNombre = new Label();
            TextoNombre.Text = "Nombre: " + nombre;
            TextoNombre.Location = new Point(X, Y);
            TextoNombre.AutoSize = true;
            TextoNombre.Font = new Font("Calibri", 10, FontStyle.Regular);
            panelPrincipal.Controls.Add(TextoNombre);
            Y = Y + 20;

            //Estado
            Label TextoEstado = new Label();
            TextoEstado.Text = "Estado: " + Estado;
            TextoEstado.Location = new Point(X, Y);
            TextoEstado.AutoSize = true;
            TextoEstado.Font = new Font("Calibri", 10, FontStyle.Regular);
            panelPrincipal.Controls.Add(TextoEstado);
            Y = Y + 20;

            //Descripcion
            Label TextoDesc = new Label();
            TextoDesc.Text = "Descripcion: " + descripcion;
            TextoDesc.Location = new Point(X, Y);
            TextoDesc.AutoSize = true;
            TextoDesc.Font = new Font("Calibri", 10, FontStyle.Regular);
            panelPrincipal.Controls.Add(TextoDesc);
            Y = Y + 80;

            //Separacion entre cada bloque
            Label Separacion = new Label();
            Separacion.Location = new Point(0, Y);
            Separacion.AutoSize = false;
            Separacion.BackColor = Color.MidnightBlue;
            Separacion.Height = 5;
            Separacion.Width = panelPrincipal.Width;
            panelPrincipal.Controls.Add(Separacion);
            Y = Y + 20;
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
            else if(Tipo=="Maestro")
            {
                Imagen.Image = Properties.Resources.LetraM;
            }
            else if (Tipo == "Laboratorio")
            {
                Imagen.Image = Properties.Resources.LetraL;
            }
            else if (Tipo == "Proyectores")
            {
                Imagen.Image = Properties.Resources.LetraP;
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
            if (Tipo== "Proyectores")
            {
                iY = iY + 60;
            }
        }

        //Evento cuando se presiona el radiobutton de laboratorios para que modifique el combobox (cboxTiposBusqueda)
        private void radiobtnLaboratorios_MouseClick(object sender, MouseEventArgs e)
        {
            //Limpiara el combobox (cboxTiposBusqueda) para luego poner las opciones y agregarlas
            cBoxTiposBusqueda.Items.Clear();
            cBoxTiposBusqueda.Enabled = false;
            cBoxTiposBusqueda.Text = "No disponible";
        }
        //Evento cuando se presiona el radiobutton de Usuarios para que modifique el combobox (cboxTiposBusqueda)
        private void radiobtnUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            //Limpiara el combobox (cboxTiposBusqueda) para luego poner las opciones y agregarlas
            cBoxTiposBusqueda.Items.Clear();
            cBoxTiposBusqueda.Enabled = true;
            cBoxTiposBusqueda.Text = "Selecciona una opcion";
            cBoxTiposBusqueda.Items.Add("Predeterminado");
            cBoxTiposBusqueda.Items.Add("Alfabeticamente");
            cBoxTiposBusqueda.Items.Add("Departamentos");
        }

        private void radiobtnProyectores_MouseClick(object sender, MouseEventArgs e)
        {
            //Limpiara el combobox (cboxTiposBusqueda) para luego poner las opciones y agregarlas
            cBoxTiposBusqueda.Items.Clear();
            cBoxTiposBusqueda.Enabled = false;
            cBoxTiposBusqueda.Text = "No disponible";
        }

        private void FrListaUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
