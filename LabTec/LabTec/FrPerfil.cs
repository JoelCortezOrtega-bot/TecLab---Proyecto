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
    public partial class FrPerfil : Form
    {

        int LocalID;

        public FrPerfil(int ID)
        {
            LocalID = ID;
            InitializeComponent();
        }

        private void FrPerfil_Load(object sender, EventArgs e)
        {
            //Variables Auxiliares
            string ID_Rol, ID_Dep;
            string Nombre, ApeP, ApeM, Correo;
            string Genero, Estado, Clave;

            //Asignamos lblID
            lblID.Text = LocalID.ToString();

            //Creamos objeto de la clase Conexion para utilizar SqlConnection que fue declarado
            LabTec.Funciones.Conexion Cn = new LabTec.Funciones.Conexion();
            //Creamos un objeto de la clase SqlCommand para ejecutar cualquier funcion o procedimiento de SQL
            SqlCommand Comando = new SqlCommand();

            //Realizamos las consultas de nuestra base de datos
            Cn.Conexiones.Open();
            string s = "SELECT Nombre FROM Usuario WHERE ID_Usuario =" + LocalID + "";
            Comando = new SqlCommand(s, Cn.Conexiones);
            Nombre = Comando.ExecuteScalar().ToString();
            s = "SELECT Ape_P FROM Usuario WHERE ID_Usuario =" + LocalID + "";
            Comando = new SqlCommand(s, Cn.Conexiones);
            ApeP = Comando.ExecuteScalar().ToString();
            s = "SELECT Ape_M FROM Usuario WHERE ID_Usuario =" + LocalID + "";
            Comando = new SqlCommand(s, Cn.Conexiones);
            ApeM = Comando.ExecuteScalar().ToString();
            s = "SELECT Genero FROM Usuario WHERE ID_Usuario =" + LocalID + "";
            Comando = new SqlCommand(s, Cn.Conexiones);
            Genero = Comando.ExecuteScalar().ToString();
            s = "SELECT Correo FROM Usuario WHERE ID_Usuario =" + LocalID + "";
            Comando = new SqlCommand(s, Cn.Conexiones);
            Correo = Comando.ExecuteScalar().ToString();
            s = "SELECT Rol.Nombre FROM Usuario INNER JOIN Rol ON Usuario.ID_Rol = Rol.ID_Rol WHERE ID_Usuario =" + LocalID + "";
            Comando = new SqlCommand(s, Cn.Conexiones);
            ID_Rol = Comando.ExecuteScalar().ToString();
            s = "SELECT Departamento.Nombre FROM Usuario INNER JOIN Departamento ON Usuario.ID_Dep = Departamento.ID_Dep WHERE ID_Usuario =" + LocalID + "";
            Comando = new SqlCommand(s, Cn.Conexiones);
            ID_Dep = Comando.ExecuteScalar().ToString();
            s = "SELECT Departamento.Nombre FROM Usuario INNER JOIN Departamento ON Usuario.ID_Dep = Departamento.ID_Dep WHERE ID_Usuario =" + LocalID + "";
            Comando = new SqlCommand(s, Cn.Conexiones);
            ID_Dep = Comando.ExecuteScalar().ToString();
            s = "SELECT Clave FROM Usuario WHERE ID_Usuario =" + LocalID + "";
            Comando = new SqlCommand(s, Cn.Conexiones);
            Clave = Comando.ExecuteScalar().ToString();
            s = "SELECT Estado FROM Usuario WHERE ID_Usuario =" + LocalID + "";
            Comando = new SqlCommand(s, Cn.Conexiones);
            Estado = Comando.ExecuteScalar().ToString();
            Cn.Conexiones.Close();

            //Asignamos los valores de la BD a los labels
            lblNombre.Text = "Nombre: " + Nombre;
            lblApeP.Text = "Apellido paterno: " +  ApeP;
            lblApeM.Text = "Apellido materno: " + ApeM;
            lblClave.Text = "Contraseña: " + Clave;
            lblDepartamento.Text = "Departamento: " + ID_Dep;
            lblRol.Text = "Rol: " + ID_Rol;

            if(Genero == "F")
            {
                lblGenero.Text = "Genero: Femenino";
            }
            else
            {
                lblGenero.Text = "Genero: Masculino";
            }
            if (Estado == "T")
            {
                lblEstado.Text = "Estado: Activo";
            }
            else
            {
                lblEstado.Text = "Estado: Inactivo";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cierre de la aplicacion
            this.Close();
        }
    }
}
