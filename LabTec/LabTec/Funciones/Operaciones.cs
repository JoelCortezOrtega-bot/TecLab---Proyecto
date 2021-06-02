using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;//Libreria utilizada para mandar MensajeBox
using System.Data.SqlClient;//Libreraria para manejar las bases de datos
//Librerias requeridas para mandar un correo
using System.Net;
using System.Net.Mail;

namespace LabTec.Operaciones
{
    //La clase Operaciones hereda todos los atributos declarados en clase Usuarios
    class Operaciones:Usuarios
    {
        //Creamos objeto de la clase Conexion para utilizar SqlConnection que fue declarado
        LabTec.Funciones.Conexion Cn = new LabTec.Funciones.Conexion();
        //Creamos un objeto de la clase SqlCommand para ejecutar cualquier funcion o procedimiento de SQL
        SqlCommand Comando = new SqlCommand();

        //Guardamos el resultado de Comando en esta variable auxiliar
        public string B_activo;

        //Constructor de la clase Operaciones
        public Operaciones(){}
        
        public void Login(int IDUsuario, string Clave)
        {
            //Verifica si los datos recibidos estan vacios
            if (IDUsuario != 0 || Clave != "")
            {
                //Indicamos al comando la conexión
                Comando.Connection = Cn.Conexiones;
                //Abrimos la conexion
                Cn.Conexiones.Open();
                //Asignamos al comando la consulta de B_activo
                Comando.CommandText = "SELECT dbo.fn_VerificacionUsuario("+ IDUsuario +", '"+ Clave +"')";
                //Guardamos el resultado en la variable auxiliar
                B_activo = (Comando.ExecuteScalar()).ToString();
                //Enviara al usuario a la seccion del Administrador
                if (B_activo == "1")
                {
             
                    FrMenu Menu = new FrMenu(IDUsuario);
                    Menu.MaestroAdmin = B_activo;
                    Menu.Show();
                    MessageBox.Show("Bienvenido Administrador.");
                }
                //Enviara al usuario a la seccion del Maestro
                else if (B_activo == "2")
                {
                   
                    FrMenu Menu = new FrMenu(IDUsuario);
                    Menu.MaestroAdmin = B_activo;
                    Menu.Show();
                    MessageBox.Show("Bienvenido Maestro.");
                }
                else
                {
                    //Indica al usuario que no se encuentra registrado en la BD
                    MessageBox.Show("El usuario no existe.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Por favor, llene todos los campos del formulario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void RecuperarCorreo()
        {

            //Indicamos al comando la conexión
            Comando.Connection = Cn.Conexiones;
            //Abrimos la conexion
            Cn.Conexiones.Open();
            //Asignamos al comando la consulta de B_activo
            //Utiliza la funcion se encuentra en la base de datos para verificar si el correo ingresado 
            //concuerda alguno ya existen
            Comando.CommandText = "SELECT dbo.fn_VerificacionCorreo('" + Correo1 + "')";
            //Guardamos el resultado en la variable auxiliar
            B_activo = (Comando.ExecuteScalar()).ToString();
            if (B_activo == "Si")
            {
                //Creamos objeto de la clase MailMassage
                MailMessage mmsg = new MailMessage();
                //Agregamos el correo al vamos a enviar el mensaje
                mmsg.To.Add(Correo1);
                //Indicamos el Motivo de nuestro correo
                mmsg.Subject = "Recuperaracion de Contraseña";
                //
                mmsg.SubjectEncoding = Encoding.UTF8;
                //Asignamos al comando la consulta de B_activo
                Comando.CommandText = "SELECT dbo.fn_RecuperarClave('" + Correo1 + "')";
                //Guardamos el resultado en la variable auxiliar
                B_activo = (Comando.ExecuteScalar()).ToString();
                //Asigamos el contenido del mensaje
                mmsg.Body = "¡Hola! \n\nEste mensaje es para recuperar la contraseña de tu cuenta." + "\nTu clave es: " + B_activo + "\nSi no has solicitado restablecer tu contraseña, puedes ignorar este correo electrónico.";
                //
                mmsg.BodyEncoding = Encoding.UTF8;
                //INDICA QUE EL CONTENIDO DEL MENSAJE ES EN HTML
                mmsg.IsBodyHtml = true;
                //Indicamos quien esta enviando el correo.
                mmsg.From = new MailAddress("Departamento91@outlook.es");

                //Creamos obtje de la clase SmtpClient
                SmtpClient cliente = new SmtpClient();
                cliente.Credentials = new NetworkCredential("Departamento91@outlook.es", "/DepartamentoITT/");

                //Puerto
                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.Host = "smtp.office365.com";

                try
                {
                    cliente.Send(mmsg);
                }
                catch(Exception)
                {
                    //Mensaje indicando al usuario que no se puede mandar el correo por cualquier motivo
                    MessageBox.Show("Se aproducido un error al enviar el mensaje.","Advertencia.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Mensaje enviado. Por favor revise su correo electronico.","Recuperación",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                //Muestra un mensaje indicando al usuario en caso de no encontrar el error.
                MessageBox.Show("No se ha encontrado el correo","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        public void AgregarLabs(int IDLab, string Nombre, int IDEstLab)
        {
            //Indicamos al comando la conexión
            Comando.Connection = Cn.Conexiones;
            //Abrimos la conexion
            Cn.Conexiones.Open();
            //Asignamos al comando la consulta de B_activo
            //Utiliza la funcion se encuentra en la base de datos para verificar si el correo ingresado 
            //concuerda alguno ya existen
            Comando.CommandText = "SELECT dbo.fn_VerificacionLaboratorio(" + IDLab + ")";
            //Guardamos el resultado en la variable auxiliar
            B_activo = (Comando.ExecuteScalar()).ToString();
            if (B_activo == "Si")
            {
                //Mensaje Indicando al Usuario que ya existe un laboratorio con ese ID
                MessageBox.Show("Ya existe un laboratorio con ese ID.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Asignamos a nuestro Sqlcommand cree un comando de SQLServer
                Comando = Cn.Conexiones.CreateCommand();
                //Indicamos a nuestro Sqlcommand el tipo de operacion que va realizar
                Comando.CommandType = CommandType.Text;
                //Utiliza la funcion se encuentra en la base de datos para verificar si el correo ingresado 
                //concuerda alguno ya existen
                Comando.CommandText = "INSERT INTO Laboratorios (ID_Lap,Nombre,ID_EstLab) VALUES (" + IDLab + ",'" + Nombre + "'," + IDEstLab + ")";
                //Ejecutamos nuestro comando
                Comando.ExecuteNonQuery();
                //Cerramos la conexion
                Cn.Conexiones.Close();
                //Enviamos un mensaje al usuario indicando que se ha agragado el usuario
                MessageBox.Show("Se ha agregado con exito.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void EliminarLabs(int IDLab)
        {
            //Indicamos al comando la conexión
            Comando.Connection = Cn.Conexiones;
            //Abrimos la conexion
            Cn.Conexiones.Open();
            //Asignamos al comando la consulta de B_activo
            //Utiliza la funcion se encuentra en la base de datos para verificar si el correo ingresado 
            //concuerda alguno ya existen
            Comando.CommandText = "SELECT dbo.fn_VerificacionLaboratorio(" + IDLab + ")";
            //Guardamos el resultado en la variable auxiliar
            B_activo = (Comando.ExecuteScalar()).ToString();
            //Cerramos la conexion
            Cn.Conexiones.Close();
            if (B_activo == "Si")
            {
                //Abrimos la conexion
                Cn.Conexiones.Open();
                //Asignamos al comando la consulta de B_activo
                //Utiliza la funcion se encuentra en la base de datos para verificar si el correo ingresado 
                //concuerda alguno ya existen
                Comando.CommandText = "SELECT dbo.fn_PrestamoVerificacionLaboratorio(" + IDLab + ")";
                //Guardamos el resultado en la variable auxiliar
                B_activo = (Comando.ExecuteScalar()).ToString();
                //Cerramos la conexion
                Cn.Conexiones.Close();
                if (B_activo == "Si")
                {
                    //Mensaje Indicando al Usuario que el laboratorio esta asignado a un maestro
                    MessageBox.Show("No se ha encontrado ese laboratorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Abrimos la conexion
                    Cn.Conexiones.Open();
                    //Asignamos a nuestro Sqlcommand cree un comando de SQLServer
                    Comando = Cn.Conexiones.CreateCommand();
                    //Indicamos a nuestro Sqlcommand el tipo de operacion que va realizar
                    Comando.CommandType = CommandType.Text;
                    //Utiliza la funcion se encuentra en la base de datos para verificar si el correo ingresado 
                    //concuerda alguno ya existen
                    Comando.CommandText = "DELETE FROM Laboratorios WHERE  ID_Lap = " + IDLab + "";
                    //Ejecutamos nuestro comando
                    Comando.ExecuteNonQuery();
                    //Cerramos la conexion
                    Cn.Conexiones.Close();
                    //Enviamos un mensaje al usuario indicando que se ha agragado el usuario
                    MessageBox.Show("Se ha eliminado con exito.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //Mensaje Indicando al Usuario que NO exista un laboratorio con ese ID
                MessageBox.Show("No se ha encontrado ese laboratorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void AgregarComentario(string Comentario, int ID)
        {
            //Abrimos la conexion
            Cn.Conexiones.Open();
            //Asignamos a nuestro Sqlcommand cree un comando de SQLServer
            Comando = Cn.Conexiones.CreateCommand();
            //Indicamos a nuestro Sqlcommand el tipo de operacion que va realizar
            Comando.CommandType = CommandType.Text;
            //Utiliza la funcion se encuentra en la base de datos para verificar si el correo ingresado 
            //concuerda alguno ya existen
            Comando.CommandText = "INSERT INTO Comentarios(ID_Usuario,Descripcion,Fecha) VALUES(" + ID + ",'" + Comentario + "',GETDATE())";
            //Ejecutamos nuestro comando
            Comando.ExecuteNonQuery();
            //Cerramos la conexion
            Cn.Conexiones.Close();
            //Mensaje de Aceptacion
            MessageBox.Show("Se ha agregado exitosamente su comentario.","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void ModificarPerfil(int ID, string Nombre, string AP, string AM, int Dep, string Genero, string Correo)
        {
            //Verifica si alguno de los txt se encuentra vacio
            if (Nombre == "" || AP == "" || AM == "" || Correo == "" || Genero == "" || Dep == 0)
            {
                //Llamamos al metodo static txtVacios
                MessageBox.Show("Por favor relleno todos los cuadros de texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cn.Conexiones.Open();
                //Asignamos a nuestro Sqlcommand cree un comando de SQLServer
                Comando = Cn.Conexiones.CreateCommand();
                //Indicamos a nuestro Sqlcommand el tipo de operacion que va realizar
                Comando.CommandType = CommandType.Text;
                //Utiliza la funcion se encuentra en la base de datos para verificar si el correo ingresado 
                //concuerda alguno ya existen
                Comando.CommandText = "UPDATE Usuario SET Nombre = '" + Nombre + "', Ape_P = '" + AP + "', Ape_M ='" + AM + "', ID_Dep = " + Dep + ", Genero = '" + Genero + "', Correo = '" + Correo + "'  WHERE CustomerID = " + ID + ";";
                //Ejecutamos nuestro comando
                Comando.ExecuteNonQuery();
                //Cerramos la conexion
                Cn.Conexiones.Close();
                //Enviamos un mensaje al usuario indicando que se ha agragado el usuario
                MessageBox.Show("Se ha modificado con exito.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
