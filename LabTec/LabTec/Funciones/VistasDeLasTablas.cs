using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;//Libreraria para manejar las bases de datos

namespace LabTec.Funciones
{
    class VistasDeLasTablas
    {
        //Creamos objeto de la clase Conexion para utilizar SqlConnection que fue declarado
        LabTec.Funciones.Conexion Cn = new LabTec.Funciones.Conexion();
        //Creamos un objeto de la clase SqlCommand para ejecutar cualquier funcion o procedimiento de SQL
        SqlCommand Comando = new SqlCommand();
        SqlDataAdapter sd;
        DataTable dt;

        public DataTable ActualizarLaboratorio()
        {
            //Indicamos al comando la conexión
            Comando.Connection = Cn.Conexiones;
            //Abrimos la conexion
            Cn.Conexiones.Open();
            //Asiganmos la consutla a nuestra variable SqlDataAdapter
            sd = new SqlDataAdapter("SELECT Laboratorios.ID_Lap AS 'ID Laboratorio', Laboratorios.Nombre AS 'Nombre', Estado_Lab.Nombre AS 'Estado del Laboratorio' FROM Laboratorios INNER JOIN Estado_Lab ON Laboratorios.ID_EstLab = Estado_Lab.ID_EstLab;", Cn.Conexiones);
            dt = new DataTable();
            sd.Fill(dt);
            //Cerramos la conexion
            Cn.Conexiones.Close();
            //Devuelve una consulta de la base de datos
            return dt;
        }
    }
}
