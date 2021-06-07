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
    public partial class FrInicio : Form
    {
        public FrInicio()
        {
            InitializeComponent();
            //Muestra una breve descripcion en los cuadros de texto
            //Indica al usuario que debe colocar su ID y Contraseña
            ttlpMensajes.SetToolTip(txtIDUsuario, "Ingrese su ID.");
            ttlpMensajes.SetToolTip(txtClave, "Ingrese su contraseña.");
            //Indica que ese es el boton de salida
            ttlpMensajes.SetToolTip(pBoxCerrar, "Salir.");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Objeto de la clase Operaciones
           LabTec.Operaciones.Operaciones op = new LabTec.Operaciones.Operaciones();

            try
            {
                //FrInicio
                //Asigna los valor capturadores de los txtbox en las variables 
                int IDUsuario = Convert.ToInt32(txtIDUsuario.Text);
                string Clave = txtClave.Text;
                //Llama al metodo Login de la clase Operaciones
                op.Login(IDUsuario, Clave);
            }
            //Se encarga de atrapar cualquier error relacionado con valores no validos
            catch (FormatException)
            {
                string mensaje = "Por favor, no ingrese los datos correctos.";
                MessageBox.Show(mensaje, "Error de formato",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                //Limpia los txt 
                txtIDUsuario.Clear();
                txtClave.Clear();
            }
        }

        private void pBoxCerrar_Click(object sender, EventArgs e)
        {
            //Cerrar la Aplicacion
            this.Close();
        }

        private void lblContraOl_MouseHover(object sender, EventArgs e)
        {
            //Cuando el usuario coloque la flecha del mouse Cambiar de color y se marcara el texto 
            //con una linea debajo del texto
            lblContraOl.ForeColor = Color.Blue;
            lblContraOl.Font = new System.Drawing.Font(lblContraOl.Font, FontStyle.Underline);
        }

        private void lblContraOl_MouseLeave(object sender, EventArgs e)
        {
            //Cuando el usuario la flecha del mouse deje el texto volvera a los cambios predeterminados.
            lblContraOl.ForeColor = Color.Black;
            lblContraOl.Font = new System.Drawing.Font(lblContraOl.Font, FontStyle.Regular);
        }

        private void lblContraOl_Click(object sender, EventArgs e)
        {
            //Abre la ventana del formulario de Recuperacion de la Clave
            FrRecuperarClave fr = new FrRecuperarClave();
            fr.Show();
        }
    }
}
