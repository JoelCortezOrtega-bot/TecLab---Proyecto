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
    public partial class FrModificarUsuarios : Form
    {
        public FrModificarUsuarios()
        {
            InitializeComponent();
        }

        DataTable dt;
        SqlDataAdapter da;
        Funciones.Conexion Con = new Funciones.Conexion();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        string time = DateTime.Now.ToString("HH:mm:ss");


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

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
            string buscar = buscarTxt.Text;
            //comando de sql para buscar un dato en cierta columna
            string s = string.Format("SELECT * FROM Usuario WHERE ID_Usuario ={0}", buscar);
            da = new SqlDataAdapter(s, Con.Conexiones);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            Con.Conexiones.Close();

        }

        //este metodo se ejecuta cuando inicia la forma
        private void FrModificarUsuarios_Load(object sender, EventArgs e)
        {
            //evita que el combobox se puedan agregar datos diferentes
            rolUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            generoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            estadoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;

            //intenta ejecutar el metodo cargar
            try
            {
                cargar(dataGridView1);

            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //accion click del boton para buscar
        private void buscarBtn_Click(object sender, EventArgs e)
        {
            //si todos los cuadros estan llenados entra en el if
            if (!string.IsNullOrWhiteSpace(buscarTxt.Text))
            {
                //intenta cargar el metodo buscar
                try
                {
                    cargarBusqueda(dataGridView1);
                    string i = dt.Rows.Count.ToString();
                    //si solo hay un resultado al momento de buscar en el datagriedview entra en el if
                    if (i == "1")
                    {
                        //Ejecut el metodo bloqueardesbloquear
                        BloquearDesbloquear();

                        //Toma los valores actuales del usuario que se busco y los coloca en su respectivo textbox/combobox
                        idUsuario.Text = buscarTxt.Text;
                        nombreUsuario.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                        apellidoPaterno.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                        apellidoMaterno.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                        generoUsuario.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                        correoUsuario.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                        claveUsuario.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                        rolUsuario.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                        estadoUsuario.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
                    }
                    //si hay mas de 2 resultados solo te deja usar el boton y barra de buscar 
                    else if (i == "0")
                    {
                        buscarTxt.Enabled = true;
                        buscarTxt.Enabled = true;

                        idUsuario.Enabled = false;
                        nombreUsuario.Enabled = false;
                        apellidoPaterno.Enabled = false;
                        apellidoMaterno.Enabled = false;
                        rolUsuario.Enabled = false;
                        generoUsuario.Enabled = false;
                        claveUsuario.Enabled = false;
                        correoUsuario.Enabled = false;
                        estadoUsuario.Enabled = false;
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

            //se ejecuta si no se llena el textbox de buscar
            else
            {

                MessageBox.Show("Tienes que llenar el id para buscar");


            }


        }

        //accion del click en boton modificar
        private void modificarBtn_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Desea modificar al usuario con numero de control: " + idUsuario.Text, "Eliminar", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                string condicion1 = "select*from Usuario where ID_Usuario=" + idUsuario.Text + " and Estado='T'";
                string condicion2 = "select*from Prestamo_Proyectores where ID_Usuario =" + idUsuario.Text + " and '" + date + "'>= Fecha and '" + time + "' <= Hora_salida   ";
                using (SqlCommand cmd = new SqlCommand(condicion1))
                {
                    cmd.Connection = Con.Conexiones;
                    Con.Conexiones.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {

                        dr.Close();
                        Con.Conexiones.Close();
                        BloquearDesbloquear();
                        cargar(dataGridView1);
                        buscarTxt.Text = ""; idUsuario.Text = ""; nombreUsuario.Text = "";
                        apellidoPaterno.Text = ""; apellidoMaterno.Text = ""; rolUsuario.Text = "";
                        generoUsuario.Text = ""; claveUsuario.Text = ""; correoUsuario.Text = "";
                        estadoUsuario.Text = "";
                        MessageBox.Show("El usuario aun esta activo, solo se puede completar esta accion si esta inactivo");

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
                                Con.Conexiones.Close();
                                BloquearDesbloquear();
                                cargar(dataGridView1);
                                buscarTxt.Text = ""; idUsuario.Text = ""; nombreUsuario.Text = "";
                                apellidoPaterno.Text = ""; apellidoMaterno.Text = ""; rolUsuario.Text = "";
                                generoUsuario.Text = ""; claveUsuario.Text = ""; correoUsuario.Text = "";
                                estadoUsuario.Text = "";
                                MessageBox.Show("El usuario tiene un proyector activo");

                            }

                            else
                            {
                                dr2.Close();

                                Con.Conexiones.Close();
                                Con.Conexiones.Open();
                                string s = string.Format("UPDATE Usuario  SET " +
                                "ID_Usuario={0}," +
                                "Nombre='{1}'," +
                                "Ape_P='{2}'," +
                                "Ape_M='{3}'," +
                                "Genero='{4}'," +
                                "Correo='{5}'," +
                                "Clave='{6}'," +
                                "ID_Rol={7}," +
                                "Estado='{8}'" +
                                "WHERE ID_Usuario='{9}';", idUsuario.Text, nombreUsuario.Text, apellidoPaterno.Text, apellidoMaterno.Text,
                                generoUsuario.Text, correoUsuario.Text, claveUsuario.Text, rolUsuario.Text, estadoUsuario.Text, buscarTxt.Text);
                                SqlCommand comando = new SqlCommand(s, Con.Conexiones);
                                comando.ExecuteNonQuery();
                                Con.Conexiones.Close();

                                BloquearDesbloquear();

                                buscarTxt.Text = "";

                                idUsuario.Text = "";
                                nombreUsuario.Text = "";
                                apellidoPaterno.Text = "";
                                apellidoMaterno.Text = "";
                                rolUsuario.Text = "";
                                generoUsuario.Text = "";
                                claveUsuario.Text = "";
                                correoUsuario.Text = "";
                                estadoUsuario.Text = "";

                                cargar(dataGridView1);

                            }
                        }
                    }
                }
            }

            else if (dialog == DialogResult.No)
            {

            }


        }

        //este metodo bloquea/desbloquea los botones y textbox de para "buscar" y los que son para "modificar" porque no puedes buscar y modificar a la vez
        private void BloquearDesbloquear()
        {
            if (buscarTxt.Enabled == true) { buscarTxt.Enabled = false; }
            else { buscarTxt.Enabled = true; }

            if (buscarBtn.Enabled == true) { buscarBtn.Enabled = false; }
            else { buscarBtn.Enabled = true; }

            if (idUsuario.Enabled == true) { idUsuario.Enabled = false; }
            else { idUsuario.Enabled = true; }

            if (nombreUsuario.Enabled == true) { nombreUsuario.Enabled = false; }
            else { nombreUsuario.Enabled = true; }

            if (apellidoMaterno.Enabled == true) { apellidoMaterno.Enabled = false; }
            else { apellidoMaterno.Enabled = true; }

            if (apellidoPaterno.Enabled == true) { apellidoPaterno.Enabled = false; }
            else { apellidoPaterno.Enabled = true; }

            if (rolUsuario.Enabled == true) { rolUsuario.Enabled = false; }
            else { rolUsuario.Enabled = true; }

            if (generoUsuario.Enabled == true) { generoUsuario.Enabled = false; }
            else { generoUsuario.Enabled = true; }

            if (claveUsuario.Enabled == true) { claveUsuario.Enabled = false; }
            else { claveUsuario.Enabled = true; }

            if (correoUsuario.Enabled == true) { correoUsuario.Enabled = false; }
            else { correoUsuario.Enabled = true; }

            if (estadoUsuario.Enabled == true) { estadoUsuario.Enabled = false; }
            else { estadoUsuario.Enabled = true; }

            if (modificarBtn.Enabled == true) { modificarBtn.Enabled = false; }
            else { modificarBtn.Enabled = true; }


        }



    }
}
