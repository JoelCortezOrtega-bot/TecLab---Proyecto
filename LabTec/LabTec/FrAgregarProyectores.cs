using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LabTec
{
    public partial class FrAgregarProyectores : Form
    {
        public FrAgregarProyectores()
        {
            InitializeComponent();
        }

        DataTable dt;
        SqlDataAdapter da;
        Funciones.Conexion Con = new Funciones.Conexion();

        public void cargar(DataGridView dgv)
        {

            Con.Conexiones.Open();
            string s = string.Format("SELECT Proyectores.ID_Proyector AS 'ID Proyector', Proyectores.Nombre, Proyectores.Descripcion, Estado_Proyector.Nombre AS  'Estado del Proyector' FROM Proyectores INNER JOIN Estado_Proyector ON Proyectores.ID_EstadoProyector = Estado_Proyector.ID_EstadoProyector");



            da = new SqlDataAdapter(s, Con.Conexiones);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;


            Con.Conexiones.Close();

     

        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            string id = IdTxt.Text;
            string nombre = NombreTxt.Text;
            string descripcion = DescripcionTxt.Text;
            string estado = EstadoTxt.Text;

            if (string.IsNullOrWhiteSpace(IdTxt.Text) || string.IsNullOrWhiteSpace(NombreTxt.Text) || string.IsNullOrWhiteSpace(DescripcionTxt.Text) || string.IsNullOrWhiteSpace(EstadoTxt.Text))
            {
                MessageBox.Show("Uno o mas campos estan en blanco, llenalos para poder registrar");

            }
            else
            {


                try
                {
                    Con.Conexiones.Open();
                    string s = string.Format("INSERT INTO Proyectores VALUES ('{0}','{1}','{2}','{3}') ", id, nombre, descripcion, estado);
                    SqlCommand comando = new SqlCommand(s, Con.Conexiones);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("El proyetor: " + nombre + " agregado correctamente");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                Con.Conexiones.Close();
            }


            try
            {
                cargar(dataGridView1);

            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void IdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btmAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrAgregarProyectores_Load(object sender, EventArgs e)
        {
            EstadoTxt.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                cargar(dataGridView1);
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
