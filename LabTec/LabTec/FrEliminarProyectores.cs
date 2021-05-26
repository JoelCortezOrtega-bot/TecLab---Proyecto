using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTec
{
    public partial class FrEliminarProyectores : Form
    {
        public FrEliminarProyectores()
        {
            InitializeComponent();
        }


        DataTable dt;
        SqlDataAdapter da;
        Funciones.Conexion Con = new Funciones.Conexion();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        string time = DateTime.Now.ToString("HH:mm:ss");

        //Carga la informacion de la base de datos a el datagridview
        public void cargar(DataGridView dgv)
        {

            Con.Conexiones.Open();
            string s = string.Format("SELECT * FROM Proyectores");
            da = new SqlDataAdapter(s, Con.Conexiones);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;


            Con.Conexiones.Close();

        }

        //carga la informacion de la base de datos, en base a el dato seleccionado
        public void cargarBusqueda(DataGridView dgv)
        {
            //toma el valor de la columna selecionada
            string columna = dataGridView1.CurrentCell.OwningColumn.Name.ToString();
            Con.Conexiones.Open();
            //toma el texto del textbox para buscarla
            string buscar = buscartxt.Text;
            //comando de sql para buscar un dato en cierta columna
            string s = string.Format("SELECT * FROM Proyectores WHERE {0} LIKE '%{1}%'", columna, buscar);

            da = new SqlDataAdapter(s, Con.Conexiones);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            Con.Conexiones.Close();

        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(buscartxt.Text))
            {
                try
                {
                    cargarBusqueda(dataGridView1);
                }

                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);

                }
            }
            else
            {
                try
                {
                    cargar(dataGridView1);
                }

                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);

                }
            }
            buscartxt.Text = "";
        }

        private void Eliminarbtn_Click(object sender, EventArgs e)
        {

            //cuadro de texto con opciones si y no
            DialogResult dialog = MessageBox.Show("Desea eliminar al Proyector con ID: " + eliminartxt.Text, "Eliminar", MessageBoxButtons.YesNo);
            if (!string.IsNullOrWhiteSpace(eliminartxt.Text))
            {
                //si se clickea si
                if (dialog == DialogResult.Yes)
                {
                    string condicion1 = "select*from  Prestamo_Proyectores where '" + date + "' = Fecha and '" + time + "' >= Hora_Entrada and '" + time + "' <= Hora_salida and " + "ID_Proyector=" + eliminartxt.Text;
                    using (SqlCommand cmd = new SqlCommand(condicion1))
                    {
                        cmd.Connection = Con.Conexiones;
                        Con.Conexiones.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            dr.Close();
                            try
                            {

                                Con.Conexiones.Close();
                                MessageBox.Show("El Proyector aun esta activo, solo se puede completar esta accion si esta inactivo");

                            }
                            catch (Exception exc)
                            {
                                Con.Conexiones.Close();
                                MessageBox.Show(exc.Message + "xd");
                            }




                        }

                        else
                        {
                            dr.Close();
                            string s = string.Format("delete from Proyectores where ID_Proyector={0}", eliminartxt.Text);
                            SqlCommand comando = new SqlCommand(s, Con.Conexiones);
                            comando.ExecuteNonQuery();
                            Con.Conexiones.Close();
                            cargarBusqueda(dataGridView1);

                        }

                    }
                }
                // si se clickea no
                else if (dialog == DialogResult.No)
                {

                }
            }
            else MessageBox.Show("Tienes que llenar el campo");

        }

        private void FrEliminarProyectores_Load(object sender, EventArgs e)
        {


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
