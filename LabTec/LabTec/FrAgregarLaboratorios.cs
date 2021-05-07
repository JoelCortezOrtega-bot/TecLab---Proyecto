using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTec
{
    public partial class FrAgregarLaboratorios : Form
    {
        public FrAgregarLaboratorios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Creamos las variables para almcenar los datos ingresados por el usuario
            int ID_Lab;
            string Nombre;
            int ID_EstLab = 0;

            //Asignamos a nuestra variable el valor de vuelto por la funcion EstadoLaboratorio
            ID_EstLab = EstadoLaboratorio();

            //Asignamos los valores a nuestras variables
            try
            {
                ID_Lab = Convert.ToInt32(txtIdLaboratorio.Text);
                Nombre = txtNombre.Text;

                //Creamos nuestro objeto de la clase Operaciones
                LabTec.Operaciones.Operaciones op = new LabTec.Operaciones.Operaciones();
                //Llamamos a nuestro metodo Agregar Laboratorios, enviando los valores ingresados
                //Por el usuario
                op.AgregarLabs(ID_Lab, Nombre, ID_EstLab);

            }
            catch (FormatException)
            {
                //Verifica si alguno de los txt se encuentra vacio
                if (txtIdLaboratorio.Text == "" || txtIdLaboratorio.Text == "" || ID_EstLab == 0)
                {
                    //Llamamos al metodo static txtVacios
                    txtVacios(txtIdLaboratorio.Text, txtNombre.Text, ID_EstLab);
                }
                //En caso de ninguno se encuentre vacio, mostrara el siguiente mensaje
                else
                {
                    string mensaje = "Por favor, no ingrese los datos correctos.";
                    MessageBox.Show(mensaje, "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                //Creamos un objeto de la clase de VistasDeLasTablas
                LabTec.Funciones.VistasDeLasTablas Cn = new LabTec.Funciones.VistasDeLasTablas();
                //Cargamos los datos de la funcion actualizar laboratorio en nuestro DataView
                dgvLaboratorios.DataSource = Cn.ActualizarLaboratorio();
                //Limpamos los cuadros de texto
                txtIdLaboratorio.Clear();
                txtNombre.Clear();
                cmbEstadoLab.Text = "";
            }
        }

        public int EstadoLaboratorio()
        {
            //Variable que va ha devoler el estado seleccionado por el usuario
            int IDEL = 0;
            //Verifica el valor que tiene nuestro combox 
            if (cmbEstadoLab.Text == "Disponible")
            {
                IDEL = 1;
            }
            if (cmbEstadoLab.Text == "Fuera de Servicio")
            {
                IDEL = 2;
            }
            if (cmbEstadoLab.Text == "Mantenimiento")
            {
                IDEL = 3;
            }
            return IDEL;
        }

        //Excepcion personalizada
        static void txtVacios(string IDLab, string Nombre, int Estado)//Recibe el ID y Contraseña
        {
            //Verifica si los cuadros de txt ambos estan vacios
            if (IDLab == "" && Nombre == "" && Estado == 0)
            {
                //Envia el siguiente mensaje.
                MessageBox.Show("Por favor rellenar todos los cuadros de texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Verifica si el txt de la contraseña esta vacio
                if (Nombre == "")
                {
                    MessageBox.Show("Por favor, no deje el recuadro de Nombre vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (IDLab == "")
                {
                    MessageBox.Show("Por favor, no deje el recuadro del Número del laboratorio vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Verifica si el txt de la usuario esta vacio
                if (Estado == 0)
                {
                    MessageBox.Show("Por favor, seleccione un Estado para el laboratorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btmAtras_Click(object sender, EventArgs e)
        {
            //Cierra la ventana
            this.Close();
        }

        private void FrAgregarLaboratorios_Load(object sender, EventArgs e)
        {
            //Creamos un objeto de la clase de VistasDeLasTablas
            LabTec.Funciones.VistasDeLasTablas Cn = new LabTec.Funciones.VistasDeLasTablas();
            //Cargamos los datos de la funcion actualizar laboratorio en nuestro DataView
            dgvLaboratorios.DataSource = Cn.ActualizarLaboratorio();
        }
    }
}
