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
    public partial class FrRecuperarClave : Form
    {
        public FrRecuperarClave()
        {
            InitializeComponent();
            //Muestra una breve descripcion en los cuadros de texto
            //Indica al usuario que debe colocar su correo electronico
            tltDescripcion.SetToolTip(txtCorreo, "Ingrese su correo electronico.");
            //Indica que ese es el boton de salida
            tltDescripcion.SetToolTip(btnCancelar, "Volver al Inicio de Sesión.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Cierra la ventana
            this.Close();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            //Creacion del Objeto de la clase Operaciones
            LabTec.Operaciones.Operaciones op = new LabTec.Operaciones.Operaciones();

            try
            {
                //Asignamos los valores capturados a sus respectivas variables
                op.Correo1 = txtCorreo.Text;
                op.RecuperarCorreo();
            }
            //Se encarga de atrapar cualquier error relacionado con valores no validos
            catch (FormatException)
            {
                if(txtCorreo.Text == "")
                {
                    //Verifica si alguno de los txt se encuentra vacio
                    MessageBox.Show("Por favor, no deje el cuadro de texto vacio.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                //Limpia el cuadro de texto del Correo
                txtCorreo.Clear();
            }
        }
    }
}
