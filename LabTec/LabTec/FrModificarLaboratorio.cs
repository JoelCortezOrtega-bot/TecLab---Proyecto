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
    public partial class FrModificarLaboratorio : Form
    {
        //Creamos objeto de la clase Conexion para utilizar SqlConnection que fue declarado
        LabTec.Funciones.Conexion Cn = new LabTec.Funciones.Conexion();
        //Creamos un objeto de la clase SqlCommand para ejecutar cualquier funcion o procedimiento de SQL
        SqlCommand Comando = new SqlCommand();
        //Variable Auxiliar para almacenar las consultas
        string ResultadoSQL;

        public FrModificarLaboratorio()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Variables Auxiliares
            int ID;
            //Asignacion de Valores
            ID = Convert.ToInt32(txtBuscarID.Text);
            //Llamamos el metodo para BuscarLaboratori
            BuscarLaboratorio(ID);
        }

        public void BuscarLaboratorio(int ID)
        {
            //Variables Auxiliares
            string Nombre, EstadoLab;

            Cn.Conexiones.Open();
            //Indicamos al comando la conexión
            Comando.Connection = Cn.Conexiones;
            //Abrimos la conexion
            //Asignamos al comando la consulta de B_activo
            //Utiliza la funcion se encuentra en la base de datos para verificar si el correo ingresado 
            //concuerda alguno ya existen
            Comando.CommandText = "SELECT dbo.fn_VerificacionLaboratorio(" + ID + ")";
            ResultadoSQL = (Comando.ExecuteScalar()).ToString();
            Cn.Conexiones.Close();
            if (ResultadoSQL == "Si")
            {
                //Realizamos las consultas para obtener el Nombre y Estado del Laboratorio
                Cn.Conexiones.Open();
                ResultadoSQL = "SELECT Estado_Lab.Nombre FROM Laboratorios INNER JOIN Estado_Lab ON Laboratorios.ID_EstLab = Estado_Lab.ID_EstLab WHERE Laboratorios.ID_Lap = " + ID + "";
                Comando = new SqlCommand(ResultadoSQL, Cn.Conexiones);
                EstadoLab = Comando.ExecuteScalar().ToString();
                ResultadoSQL = "SELECT Nombre FROM Laboratorios WHERE ID_Lap = " + ID + "";
                Comando = new SqlCommand(ResultadoSQL, Cn.Conexiones);
                Nombre = Comando.ExecuteScalar().ToString();
                Cn.Conexiones.Close();
                //Desplegamos los resultado en la seccion de Datos Generales del Form
                grbDatosLab.Visible = true;
                txtIDLab.Text = ID.ToString();
                txtNombre.Text = Nombre;
                cmbEstadoLab.Text = EstadoLab;
            }
            else
            {
                //Mensaje Indicando al Usuario que no existe un laboratorio con ese ID
                MessageBox.Show("No existe un laboratorio con ese ID.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrModificarLaboratorio_Load(object sender, EventArgs e)
        {
            //Creamos un objeto de la clase de VistasDeLasTablas
            LabTec.Funciones.VistasDeLasTablas Cn = new LabTec.Funciones.VistasDeLasTablas();
            //Cargamos los datos de la funcion actualizar laboratorio en nuestro DataView
            dgvLaboratorios.DataSource = Cn.ActualizarLaboratorio();
        }
    }
}
