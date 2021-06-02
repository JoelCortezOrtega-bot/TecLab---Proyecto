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
    public partial class FrModificarClave : Form
    {
        int LocalID;

        public FrModificarClave(int ID)
        {
            InitializeComponent();
            LocalID = ID;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaramos nuestro objeto de la clase Operaciones
                Operaciones.Operaciones op = new Operaciones.Operaciones();
                //Variables Auxiliares
                string ClaveVieja, ClaveNueva, ClaveRepetida;
                //Asignacion de Valores
                ClaveVieja = txtClaveActual.Text;
                ClaveRepetida = txtClaveNRepetir.Text;
                ClaveNueva = txtClaveNueva.Text;
                //LLamamos al metodo de la clase Operaciones
                op.ModificarClave(LocalID, ClaveNueva, ClaveVieja, ClaveRepetida);
            }
            catch(FormatException)
            {
                string mensaje = "Por favor, no ingrese los datos correctos.";
                MessageBox.Show(mensaje, "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Limpiar los cuadros de texto
                txtClaveActual.Clear();
                txtClaveNRepetir.Clear();
                txtClaveNueva.Clear();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Volver al menu principal
            this.Close();
        }
    }
}
