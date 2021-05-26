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
    public partial class FrModificarProyectores : Form
    {
        public FrModificarProyectores()
        {
            InitializeComponent();
        }

        DataTable dt;
        SqlDataAdapter da;
        Funciones.Conexion Con = new Funciones.Conexion();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        string time = DateTime.Now.ToString("HH:mm:ss");

        private void FrModificarProyectores_Load(object sender, EventArgs e)
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

        //funcion de cargar, que carga la informacion al datagriedview
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

        public void cargarBusqueda(DataGridView dgv)
        {
            //toma el valor de la columna selecionada
            string columna = dataGridView1.CurrentCell.OwningColumn.Name.ToString();
            Con.Conexiones.Open();
            //toma el texto del textbox para buscarla
            string buscar = buscarTxt.Text;
            //comando de sql para buscar un dato en cierta columna
            string s = string.Format("SELECT * FROM Proyectores WHERE {0} = '{1}'", columna, buscar);

            da = new SqlDataAdapter(s, Con.Conexiones);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            Con.Conexiones.Close();

        }


        private void BloquearDesbloquear()
        {
            if (buscarTxt.Enabled == true) { buscarTxt.Enabled = false; }
            else { buscarTxt.Enabled = true; }

            if (buscarBtn.Enabled == true) { buscarBtn.Enabled = false; }
            else { buscarBtn.Enabled = true; }

            if (IdTxt.Enabled == true) { IdTxt.Enabled = false; }
            else { IdTxt.Enabled = true; }

            if (NombreTxt.Enabled == true) { NombreTxt.Enabled = false; }
            else { NombreTxt.Enabled = true; }

            if (DescripcionTxt.Enabled == true) { DescripcionTxt.Enabled = false; }
            else { DescripcionTxt.Enabled = true; }

            if (EstadoTxt.Enabled == true) { EstadoTxt.Enabled = false; }
            else { EstadoTxt.Enabled = true; }

            if (modificarBtn.Enabled == true) { modificarBtn.Enabled = false; }
            else { modificarBtn.Enabled = true; }

        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(buscarTxt.Text))
            {
                try
                {
                    cargarBusqueda(dataGridView1);
                    string i = dt.Rows.Count.ToString();
                    if (i == "1")
                    {
                        BloquearDesbloquear();

                        IdTxt.Text = buscarTxt.Text;
                        NombreTxt.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                        DescripcionTxt.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                        EstadoTxt.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();

                    }
                    else if (i == "0")
                    {
                        buscarTxt.Enabled = true;
                        buscarBtn.Enabled = true;


                        IdTxt.Enabled = false;
                        NombreTxt.Enabled = false;
                        DescripcionTxt.Enabled = false;
                        EstadoTxt.Enabled = false;
                        modificarBtn.Enabled = false;
                        cargar(dataGridView1);
                        MessageBox.Show("No existe este numero de id");
                    }

                }

                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);

                }
            }
            else
            {

                MessageBox.Show("Tienes que llenar el id para buscar");
            }
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Desea eliminar al Proyector con ID: " + IdTxt.Text, "Eliminar", MessageBoxButtons.YesNo);
            if (!string.IsNullOrWhiteSpace(IdTxt.Text))
            {
                //si se clickea si
                if (dialog == DialogResult.Yes)
                {
                    string condicion1 = "select*from  Prestamo_Proyectores where '" + date + "' = Fecha and '" + time + "' >= Hora_Entrada and '" + time + "' <= Hora_salida and " + "ID_Proyector=" + IdTxt.Text;
                    using (SqlCommand cmd = new SqlCommand(condicion1))
                    {
                        cmd.Connection = Con.Conexiones;
                        Con.Conexiones.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {

                            try
                            {

                                Con.Conexiones.Close();
                                BloquearDesbloquear();
                                cargar(dataGridView1);
                                buscarTxt.Text = "";
                                IdTxt.Text = "";
                                NombreTxt.Text = "";
                                DescripcionTxt.Text = "";
                                EstadoTxt.Text = "";
                                MessageBox.Show("El Proyector aun esta activo, solo se puede completar esta accion si esta inactivo");
                            }


                            catch (Exception exc)
                            {
                                Con.Conexiones.Close();
                                MessageBox.Show(exc.Message);
                            }

                        }

                        else
                        {
                            MessageBox.Show(time);
                            Con.Conexiones.Close();
                            Con.Conexiones.Open();
                            string s = string.Format("UPDATE proyectores  SET " +
                            "ID_Proyector={0}," +
                            "Nombre='{1}'," +
                            "Descripcion='{2}'," +
                            "ID_EstadoProyector='{3}'" +
                            "WHERE ID_Proyector='{4}';", IdTxt.Text, NombreTxt.Text, DescripcionTxt.Text, EstadoTxt.Text, buscarTxt.Text);
                            SqlCommand comando = new SqlCommand(s, Con.Conexiones);
                            comando.ExecuteNonQuery();
                            Con.Conexiones.Close();

                            BloquearDesbloquear();

                            buscarTxt.Text = "";

                            IdTxt.Text = "";
                            NombreTxt.Text = "";
                            DescripcionTxt.Text = "";
                            EstadoTxt.Text = "";

                            cargar(dataGridView1);

                        }
                    }
                }

                else if (dialog == DialogResult.No)
                {

                }
            }
        }
    }
}
