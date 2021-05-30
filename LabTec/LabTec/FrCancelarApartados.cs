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
    public partial class FrCancelarApartados : Form
    {
        public FrCancelarApartados(int id)
        {

            idusuario = id;
            InitializeComponent();
        }
        int idusuario;
        DataTable dt;
        SqlDataAdapter da;
        Funciones.Conexion Con = new Funciones.Conexion();

        private void FrCancelarApartados_Load(object sender, EventArgs e)
        {
            try
            {
                cargar(dataGridView1);
                cargar1(dataGridView2);

            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
        public void cargar(DataGridView dgv)
        {
            
            Con.Conexiones.Open();
            string s = string.Format("SELECT * FROM Prestamo_Proyectores where ID_Usuario={0}", idusuario);

            da = new SqlDataAdapter(s, Con.Conexiones);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            Con.Conexiones.Close();
        }

        public void cargar1(DataGridView dgv1)
        {

            int idusuario = 0;
            Con.Conexiones.Open();
            string s = string.Format("SELECT * FROM Prestamo_Lab where ID_Usuario={0}", idusuario);

            da = new SqlDataAdapter(s, Con.Conexiones);
            dt = new DataTable();
            da.Fill(dt);
            dgv1.DataSource = dt;
            Con.Conexiones.Close();
        }

        private void eliminarProyector_Click(object sender, EventArgs e)
        {
            try
            {
                string registro = dataGridView1.CurrentCell.Value.ToString();
                string columna = dataGridView1.CurrentCell.OwningColumn.Name.ToString();
                if (columna == "ID_PP")
                    try
                    {
                        Con.Conexiones.Open();
                        string s = string.Format("DELETE FROM  Prestamo_Proyectores WHERE {0}='{1}';", columna, registro);
                        SqlCommand comando = new SqlCommand(s, Con.Conexiones);
                        comando.ExecuteNonQuery();
                        Con.Conexiones.Close();
                    }
                    catch
                    {
                        Con.Conexiones.Close();
                        MessageBox.Show("El usuario no existe");
                    }
                else { MessageBox.Show("Tienes que seleccionar el id de la cita que se deese eliminar"); }
            }
            catch { MessageBox.Show("Tienes que seleccionar algun id"); }


            cargar(dataGridView1);
        }

        private void eliminarLab_Click(object sender, EventArgs e)
        {
            try
            {
                string registro = dataGridView2.CurrentCell.Value.ToString();
                string columna = dataGridView2.CurrentCell.OwningColumn.Name.ToString();
                if (columna == "ID_PL")
                    try
                    {
                        Con.Conexiones.Open();
                        string s = string.Format("DELETE FROM  Prestamo_Lab WHERE {0}='{1}';", columna, registro);
                        SqlCommand comando = new SqlCommand(s, Con.Conexiones);
                        comando.ExecuteNonQuery();
                        Con.Conexiones.Close();
                    }
                    catch
                    {
                        Con.Conexiones.Close();
                        MessageBox.Show("El usuario no existe");
                    }
                else { MessageBox.Show("Tienes que seleccionar el id que deseas eliminar"); }
            }
            catch { MessageBox.Show("Tienes que seleccionar algun id"); }


            cargar1(dataGridView2);
        }
    }
}
