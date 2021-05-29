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
        //Conexion de Joel
        //Declaramos Objeto para realizar la conexion con la base de datos
        public SqlConnection Conexiones = new SqlConnection("Data Source=DESKTOP-EOJJH72\\SQLEXPRESS;Initial Catalog=LabTec;Integrated Security=True");

        //CONEXION DE FERNANDO
        //NO BORRAR
        //Dije que no lo borraran :T .... solo comentenlo...paro
        //public SqlConnection Conexiones = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=LabTec;Integrated Security= True");

        //(Para evitar ponerlo cada vez que quiera usar mi BD local, solo comenten la conexion que no sea suya)

        //Conexion Javier
        //public SqlConnection Conexiones = new SqlConnection("Data Source=localhost\\MSSQLSERVER01;Initial Catalog=LabTec;Integrated Security=True");

    }
}
