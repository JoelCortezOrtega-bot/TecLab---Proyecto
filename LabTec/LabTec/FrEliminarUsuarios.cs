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
    public partial class FrEliminarUsuarios : Form
    {
        public FrEliminarUsuarios()
        {
            InitializeComponent();
        }

        //En esta variable se guardara la tabla
        DataTable dt;
        //En esta variable se guarda el adaptador 
        SqlDataAdapter da;
        // aqui se carga la conexion a la base de datos de funciones/Conexion.cs
        Funciones.Conexion Con = new Funciones.Conexion();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        string time = DateTime.Now.ToString("HH:mm:ss");

        //Este metodo se ejecuta cuando se carga la forma
        private void FrEliminarUsuarios_Load(object sender, EventArgs e)
        {
            // intenta cargar el metodo cargar (carga la base de datos en el datagridview)
            try
            {
                cargar(dataGridView1);

            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //boton para buscar
        private void buscarbtn_Click(object sender, EventArgs e)
        {

            // si no esta vacia la barra de buscar hace esto
            if (!string.IsNullOrWhiteSpace(buscartxt.Text))
            {
                // intenta cargar el metodo CargarBusqueda (Toma el la informacion del textbox, la busca en la columna seleccionada y carga el datagriedview)
                try
                {
                    cargarBusqueda(dataGridView1);
                }

                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);

                }
            }
            // en caso de que este vacia hace esto
            else
            {
                // intenta cargar el metodo cargar
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

        //Carga la informacion de la base de datos a el datagridview
        public void cargar(DataGridView dgv)
        {

            Con.Conexiones.Open();
            string s = string.Format("SELECT * FROM Usuario");
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
            string s = string.Format("SELECT * FROM Usuario WHERE {0} LIKE '%{1}%'", columna, buscar);

            da = new SqlDataAdapter(s, Con.Conexiones);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            Con.Conexiones.Close();

        }

        private void Eliminarbtn_Click(object sender, EventArgs e)
        {
            //cuadro de texto con opciones si y no
            DialogResult dialog = MessageBox.Show("Desea eliminar al usuario con numero de control: " + eliminartxt.Text, "Eliminar", MessageBoxButtons.YesNo);
            if (!string.IsNullOrWhiteSpace(eliminartxt.Text))
            {
                //si se clickea si
                if (dialog == DialogResult.Yes)
                {

                    string condicion1 = "select*from Usuario where ID_Usuario=" + eliminartxt.Text + " and Estado='T'";
                    string condicion2 = "select*from Prestamo_Proyectores where ID_Usuario =" + eliminartxt.Text + " and '" + date + "'>= Fecha and '" + time + "' <= Hora_salida   ";
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

                                MessageBox.Show("El usuario aun esta activo, solo se puede completar esta accion si esta inactivo");
                                Con.Conexiones.Close();
                            }
                            catch (Exception exc)
                            {
                                Con.Conexiones.Close();
                                MessageBox.Show(exc.Message + "xd");
                            }


                        }

                        else
                        {
                            Con.Conexiones.Close();
                            using (SqlCommand cmd2 = new SqlCommand(condicion2))
                            {
                                cmd2.Connection = Con.Conexiones;
                                Con.Conexiones.Open();
                                SqlDataReader dr2 = cmd2.ExecuteReader();

                                if (dr2.Read())
                                {
                                    dr2.Close();
                                    try
                                    {

                                        MessageBox.Show("El usuario tiene un proyector activo");
                                        Con.Conexiones.Close();
                                    }
                                    catch (Exception exc)
                                    {
                                        Con.Conexiones.Close();
                                        MessageBox.Show(exc.Message + "xd");
                                    }


                                }

                                else
                                {
                                    try
                                    {
                                        Con.Conexiones.Close();
                                        Con.Conexiones.Open();
                                        string s = string.Format("delete from Usuario where ID_Usuario={0}", eliminartxt.Text);
                                        SqlCommand comando = new SqlCommand(s, Con.Conexiones);
                                        comando.ExecuteNonQuery();
                                        Con.Conexiones.Close();
                                        cargarBusqueda(dataGridView1);
                                    }
                                    catch (Exception exc)
                                    {
                                        Con.Conexiones.Close();
                                        MessageBox.Show("El usuario no existe");
                                    }


                                }

                            }

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
        
    }
}
