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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Cierra la ventana
            this.Close();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            LabTec.Operaciones.Operaciones op = new LabTec.Operaciones.Operaciones();
            op.Correo1 = txtCorreo.Text;
            op.RecuperarCorreo();
        }
    }
}
