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
        string B_activo;

        //Constructor de la clase Operaciones
        public Operaciones(){}

        public void Login()
        {
            //Verifica si los datos recibidos estan vacios
            if (IDUsuario1 != 0 || Clave1 != "")
            {
                //Indicamos al comando la conexión
                Comando.Connection = Cn.Conexiones;
                //Abrimos la conexion
                Cn.Conexiones.Open();
                //Asignamos al comando la consulta de B_activo
                Comando.CommandText = "SELECT dbo.fn_VerificacionUsuario("+ IDUsuario1 +", '"+ Clave1 +"')";
                //Guardamos el resultado en la variable auxiliar
                B_activo = (Comando.ExecuteScalar()).ToString();
                if (B_activo == "1")
                {
                    MessageBox.Show("Bienvenido Administrador.");
                }
                else if (B_activo == "2")
                {
                    MessageBox.Show("Bienvenido Maestro.");
                }
                else
                {
                    MessageBox.Show("El usuario no existe.");
                }

            }
            else
            {
                MessageBox.Show("Por favor, llene todos los campos del formulario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void RecuperarCorreo()
        {
            //Variable auxiliar
            string Descripcion;

            //Indicamos al comando la conexión
            Comando.Connection = Cn.Conexiones;
            //Abrimos la conexion
            Cn.Conexiones.Open();
            //Asignamos al comando la consulta de B_activo
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
                mmsg.Body = "Tu clave es: " + B_activo;
                //
                mmsg.BodyEncoding = Encoding.UTF8;
                //INDICA QUE EL CONTENIDO DEL MENSAJE ES EN HTML
                mmsg.IsBodyHtml = true;
                //Indicamos quien esta enviando el correo.
                mmsg.From = new MailAddress("Departamento91@outlook.es");

                //Creamos obtje de la clase SmtpClient
                SmtpClient cliente = new SmtpClient();
                cliente.Credentials = new NetworkCredential("Departamento91@outlook.es", "/DepartamentoITT/");

                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.Host = "smtp.office365.com";

                try
                {
                    cliente.Send(mmsg);
                }
                catch
                {
                    MessageBox.Show("Error al enviar");
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado el correo");
            }
        }
    }
}
