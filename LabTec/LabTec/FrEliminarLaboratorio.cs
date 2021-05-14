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
    public partial class FrEliminarLaboratorio : Form
    {
        public FrEliminarLaboratorio()
        {
            InitializeComponent();
        }

        private void FrEliminarLaboratorio_Load(object sender, EventArgs e)
        {
            //Creamos un objeto de la clase de VistasDeLasTablas
            LabTec.Funciones.VistasDeLasTablas Cn = new LabTec.Funciones.VistasDeLasTablas();
            //Cargamos los datos de la funcion actualizar laboratorio en nuestro DataView
            dgvLaboratorios.DataSource = Cn.ActualizarLaboratorio();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cierra la ventana
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Creamos las variables para almcenar los datos ingresados por el usuario
            int ID_Lab;

            try
            {
                //Asignamos los valores a nuestras variables
                ID_Lab = Convert.ToInt32(txtIdLaboratorio.Text);

                //Creamos nuestro objeto de la clase Operaciones
                LabTec.Operaciones.Operaciones op = new LabTec.Operaciones.Operaciones();
                //Llamamos a nuestro metodo Eliminar Laboratorios, enviando los valores ingresados
                //Por el usuario
                op.EliminarLabs(ID_Lab);

            }
            catch (FormatException)
            {
                //Verifica si alguno de los txt se encuentra vacio
                if (string.IsNullOrEmpty(txtIdLaboratorio.Text))
                {
                    //Llamamos al metodo static txtVacios
                    //Envia el siguiente mensaje.
                    MessageBox.Show("Por favor rellenar todos los cuadros de texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
        }
    }
}
