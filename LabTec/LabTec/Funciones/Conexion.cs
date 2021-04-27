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
    public class Conexion
    {
        //Declaramos Objeto para realizar la conexion con la base de datos
        //public SqlConnection Conexiones = new SqlConnection(
        //  "Data Source=DESKTOP-EOJJH72\\SQLEXPRESS;Initial Catalog=LabTec;Integrated Security=True");

        //CONEXION DE FERNANDO
        //NO BORRAR
        //(Para evitar ponerlo cada vez que quiera usar mi BD local, solo comenten la conexion que no sea suya)
        public SqlConnection Conexiones = new SqlConnection("Data Source=localhost\\MSSQLSERVER01;Initial Catalog=LabTec;Integrated Security=True");

    }
}
