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
        int LocalID;

        public FrModificarLaboratorio()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                //Asignacion de Valores
                LocalID = Convert.ToInt32(txtBuscarID.Text);
                if(LocalID != 0)
                {
                    //Llamamos el metodo para BuscarLaboratorio
                    BuscarLaboratorio(LocalID);
                }
                else
                {
                    //Mensaje Indicando al Usuario que no existe un laboratorio con ese ID
                    MessageBox.Show("Por favor no deje el cuadro de texto vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                string mensaje = "Por favor, no ingrese los datos correctos.";
                MessageBox.Show(mensaje, "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                Cn.Conexiones.Open();
                //Indicamos al comando la conexión
                Comando.Connection = Cn.Conexiones;
                //Abrimos la conexion
                //Asignamos al comando la consulta de B_activo
                //Utiliza la funcion se encuentra en la base de datos para verificar si el correo ingresado 
                //concuerda alguno ya existen
                Comando.CommandText = "SELECT COUNT(*) FROM Prestamo_Lab WHERE ID_Usuario = " + ID + "";
                ResultadoSQL = (Comando.ExecuteScalar()).ToString();
                Cn.Conexiones.Close();
                if(Convert.ToInt32(ResultadoSQL) == 0)
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
                    //Habilitamos los comandos
                    txtIDLab.Enabled = true;
                    txtNombre.Enabled = true;
                    cmbEstadoLab.Enabled = true;
                }
                else
                {
                    //Mensaje Indicando al Usuario que no existe un laboratorio con ese ID
                    MessageBox.Show("El labortario esta apartado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Cerrar la pestaña
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Variables Auxiliares 
            int EstadoLaboratorio;

            //Asignamos el estado del laboratorio
            EstadoLaboratorio = EstadoLap();

            if (txtIDLab.Text == "" || txtNombre.Text == "" || cmbEstadoLab.Text == "" || EstadoLaboratorio == 0)
            {
                //Mensaje Indicando al Usuario que no existe un laboratorio con ese ID
                MessageBox.Show("Por favor no deje ningun recuadro vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Comando.CommandText = "UPDATE Laboratorios SET Nombre = '" + txtNombre.Text + "', ID_EstLab = " + EstadoLaboratorio + ", ID_Lap = " + Convert.ToUInt32(txtIDLab.Text) + "  WHERE ID_Lap = " + LocalID + ";";
                //Ejecutamos nuestro comando
                Comando.ExecuteNonQuery();
                //Cerramos la conexion
                Cn.Conexiones.Close();
                //Enviamos un mensaje al usuario indicando que se ha agragado el usuario
                MessageBox.Show("Se ha modificado con exito.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Cambiamos el estado de Visible a falso
                txtIDLab.Clear();
                txtNombre.Clear();
                cmbEstadoLab.Text = "";
                txtBuscarID.Clear();
                grbDatosLab.Visible = false;
                //Creamos un objeto de la clase de VistasDeLasTablas
                LabTec.Funciones.VistasDeLasTablas Cm = new LabTec.Funciones.VistasDeLasTablas();
                //Cargamos los datos de la funcion actualizar laboratorio en nuestro DataView
                dgvLaboratorios.DataSource = Cm.ActualizarLaboratorio();
            }
        }

        public int EstadoLap()
        {
            int IDDep = 0;

            if (cmbEstadoLab.Text == "Disponible")
            {
                IDDep = 1;
            }
            if (cmbEstadoLab.Text  == "Fuera de Servicio")
            {
                IDDep = 2;
            }
            if (cmbEstadoLab.Text == "Mantenimiento")
            {
                IDDep = 3;
            }

            return IDDep;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Desea cancelar la operacion? ", "Advertencia", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                //Cambiamos el estado de Visible a falso
                txtIDLab.Clear();
                txtNombre.Clear();
                cmbEstadoLab.Text = "";
                txtBuscarID.Clear();
                grbDatosLab.Visible = false;
            }
        }
    }
}
