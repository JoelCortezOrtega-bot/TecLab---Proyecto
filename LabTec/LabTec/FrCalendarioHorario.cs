using LabTec.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LabTec
{
    public partial class FrCalendarioHorario : Form
    {
        int LocalCantidadProy;
        string LocalDia;
        int LocalMes;
        int LocalAño;
        string LocalTipo;
        int LocalNumUsuario;
        DataTable LocalNombres;
        DataTable LocalHoras;
        DataTable LocalRestriccion;
        List<string> ListaApartados = new List<string>();
        int HoraInicial = 6;
        int HoraFinal = 22;


        public FrCalendarioHorario(string cantidadProy, string nombreForm, DataTable nombres, DataTable horas, int year, int month, DataTable restriccion,int NumUsuario)
        {
            InitializeComponent();
            LocalCantidadProy = Convert.ToInt32(cantidadProy);
            this.Text = "DIA " + nombreForm;
            LocalNombres = nombres;
            LocalHoras = horas;
            LocalMes = month;
            LocalAño = year;
            LocalDia = nombreForm;
            LocalTipo = "";
            LocalRestriccion = restriccion;
            LocalNumUsuario = NumUsuario;
        }



        private void FrCalendarioHorario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LocalRestriccion;
            CreacionHorario();
        }

        void CreacionHorario()
        {
            int ContadorRenglon = 0;
            int ContadorHoras = 0;
            //For-El limite del for depende de las horas habiles en la escuela. 
            Color color = new Color();
            string texto = "";
            bool activado = false;
            //Lista para saber cuales horas tendran descanso
            List<string> descanso = new List<string>();
            //For que maneja las Horas
            for (int i = HoraInicial; i < HoraFinal; i++)
            {
                //TITULO DE HORA
                TimeSpan result = TimeSpan.FromHours(i);
                string fromTimeString = "HORA: " + result.ToString("hh':'mm");
                tlpHorario.Controls.Add(new Label { Text = fromTimeString, Anchor = AnchorStyles.None, Font = new Font("Arial", 14), AutoSize = true }, 0, ContadorRenglon);
                ContadorRenglon++;
                //For que maneja los proyectores/laboratorios
                for (int j = 0; j < LocalCantidadProy; j++)
                {
                    //0 es menor al numero de horas apartadas en el dia [Y] el nombre de ID_Proyector de las horas apartadas es igual al nombre del ID_Proyector actual en el for [Y] La hora a la que se aparta es igual a la hora que se maneja en el for de arriba
                    //0<19
                    if ((ContadorHoras < LocalHoras.Rows.Count) && (Convert.ToString(LocalHoras.Rows[ContadorHoras][0]) == Convert.ToString(LocalNombres.Rows[j][0])) && (LocalHoras.Rows[ContadorHoras][1].ToString() == result.ToString("hh':'mm':'ss")))
                    {
                        descanso.Add(Convert.ToString(LocalNombres.Rows[j][0])+(i+1));
                        color = Color.Brown;
                        texto = "NO DISPONIBLE";
                        activado = false;
                        ContadorHoras++;
                    }
                    else if (descanso.Contains(Convert.ToString(LocalNombres.Rows[j][0]) + (i)))
                    {
                        if (i>7)
                        {
                            foreach (Control c in tlpHorario.Controls)
                            {
                                
                                if (Convert.ToString(c.Tag)==(LocalAño + "-" + LocalMes + "-" + LocalDia + "/" + (i-2)) && c.Name== Convert.ToString(LocalNombres.Rows[j][0]))
                                {
                                    c.BackColor = Color.Purple;
                                    c.Text = LocalNombres.Rows[j][0].ToString() + "    " + "DESCANSANDO";
                                    c.Enabled = false;

                                }
                            }

                        }
                        
                        color = Color.Purple;
                        texto = "DESCANSANDO";
                        activado = false;
                    }
                    else
                    {
                        color = Color.SpringGreen;
                        texto = "DISPONIBLE";
                        activado = true;
                    }
                    tlpHorario.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    //tlpHorario.Controls.Add(new Button{ Text = (LocalNombres.Rows[j][0].ToString() + "    " + texto), Font = new Font("Arial", 14), Width = 294, Height = 28, BackColor = color, Enabled = activado, Name = LocalNombres.Rows[j][0].ToString(), Tag = LocalAño + "-" + LocalMes + "-" + LocalDia + "/" + i, },0,ContadorRenglon);
                    
                    Button btn= new Button { Text = (LocalNombres.Rows[j][0].ToString() + "    " + texto), Font = new Font("Arial", 14), Width = 294, Height = 28, BackColor = color, Enabled = activado, Name = LocalNombres.Rows[j][0].ToString(), Tag = LocalAño + "-" + LocalMes + "-" + LocalDia + "/" + i, };
                    btn.Click += new EventHandler(btnClick);
                    tlpHorario.Controls.Add(btn, 0, ContadorRenglon);
                    ContadorRenglon++;
                }

            } 
            void btnClick(object sender, EventArgs e)
            {
                string btnName = ((Button)sender).Name;
                var btnFecha = ((Button)sender).Tag;
                Button btn = (Button)sender;
                if (btn.BackColor==Color.SpringGreen)
                {
                    
                    btn.BackColor = Color.Orange;
                    btn.Text= btnName + "    " + "SELECCIONADO";
                    ListaApartados.Add(btnFecha+"/"+btnName);
                }
                else
                {
                    btn.BackColor = Color.SpringGreen;
                    btn.Text = btnName + "    " + "DISPONIBLE";
                    ListaApartados.Remove(btnFecha + "/" + btnName);
                }
            }
            //TableLayoutPanel panel = new TableLayoutPanel();
            //panel.RowCount = 5;
            //panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            //panel.Height = 400;
            //panel.Width = 300;
            //panel.Location = new Point(440, 16);
            //panel.RowCount = panel.RowCount + 1;
            //panel.BackColor = Color.Black;
            //panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            //panel.Controls.Add(new Label() { Text = "Street, City, State" }, 1, panel.RowCount - 1);
            //panel.Controls.Add(new Label() { Text = "888888888888" }, 2, panel.RowCount - 1);
            //panel.Controls.Add(new Label() { Text = "xxxxxxx@gmail.com" }, 3, panel.RowCount - 1);
            //this.Controls.Add(panel);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        //FORMATO 
        //[0]= Fecha [1]=Hora [2]=ID Proyector
        //
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Auxiliar para mandar mensaje de aviso que se agrego correctamente
            int Auxiliar = 0;
            if (ListaApartados.Count == 0)
            {
                MessageBox.Show("Selecciona un dispositivo", "Conflicto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //
                //RESTRICCION DE APARTADO
                //
                //1.Revisar que
                string AuxAntiguo = "";
                bool Advertencia = false;
                ListaApartados.Sort();
                foreach (var owo in ListaApartados)
                {
                    string[] separado = owo.Split('/');
                    if (AuxAntiguo == "")
                    {
                        AuxAntiguo = separado[1];
                    }
                    else
                    {
                        if ((Convert.ToInt32(AuxAntiguo) + 1) == Convert.ToInt32(separado[1]))
                        {
                            Advertencia = true;
                        }
                    }
                }

                if (Advertencia == false)
                {
                    foreach (var Aux in ListaApartados)
                    {
                        string[] separado = Aux.Split('/');
                        Conexion Conex = new Conexion();
                        Conex.Conexiones.Open();

                        //Conversion a Hora Inicial
                        TimeSpan AuxHoraInicial = TimeSpan.FromHours(Convert.ToDouble(separado[1]));
                        AuxHoraInicial.ToString("hh':'mm':'ss");

                        //Conver a Hora Final
                        TimeSpan AuxHoraFinal = TimeSpan.FromHours(Convert.ToDouble(separado[1]) + 1);
                        AuxHoraFinal.ToString("hh':'mm':'ss");

                        //Condicion para confirmar que no este apartado esta fecha
                        string AuxCadena;
                        if (LocalTipo == "Laboratorio")
                        {
                            AuxCadena = "select * from Prestamo_Lab where Hora_Entrada='" + AuxHoraInicial.ToString("hh':'mm':'ss") + "' and Fecha='" + separado[0] + "' and ID_Lap=" + separado[2];

                        }
                        else
                        {
                            AuxCadena = "select * from Prestamo_Proyectores where Hora_Entrada='" + AuxHoraInicial.ToString("hh':'mm':'ss") + "' and Fecha='" + separado[0] + "' and ID_Proyector=" + separado[2];

                        }
                        SqlCommand cmd = new SqlCommand(AuxCadena, Conex.Conexiones);
                        SqlDataAdapter dr = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dr.Fill(dt);
                        Conex.Conexiones.Close();
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Esta hora ya se encuentra apartada.\r\nFavor de escoger otra hora. \r\n[Conflicto => Hora:" + AuxHoraInicial.ToString("hh':'mm':'ss") + " Proyector: " + separado[2], "Conflicto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                        {
                            Auxiliar = 1;
                            Conex.Conexiones.Open();
                            string Cadena;
                            if (LocalTipo == "Laboratorio")
                            {
                                Cadena = "insert into Prestamo_Lab values ("+LocalNumUsuario+"," + separado[2] + ",'" + separado[0] + "','" + AuxHoraInicial.ToString("hh':'mm':'ss") + "','" + AuxHoraFinal.ToString("hh':'mm':'ss") + "','" + GeneradorCodigo() + "')";
                            }
                            else
                            {
                                Cadena = "insert into Prestamo_Proyectores values (" + LocalNumUsuario + "," + separado[2] + ",'" + separado[0] + "','" + AuxHoraInicial.ToString("hh':'mm':'ss") + "','" + AuxHoraFinal.ToString("hh':'mm':'ss") + "','" + GeneradorCodigo() + "')";
                            }
                            cmd = new SqlCommand(Cadena, Conex.Conexiones);
                            cmd.ExecuteNonQuery();
                            Conex.Conexiones.Close();
                        }

                    }
                    if (Auxiliar == 1)
                    {
                        MessageBox.Show("Se han apartado los proyectores correctamente.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Recuerda que no puedes pedir el mismo proyector dos horas seguidas.\r\nFavor de escoger otra proyector.", "Conflicto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        # region    CodigoApartado
        //Funcion para hacer el codigo compartir.
        public string GeneradorCodigo()
        {
            string Codigo = "";
            Random ran = new Random();
            string UnoLetra = Convert.ToString((char)(((int)'A') + ran.Next(1, 26)));
            string DosLetra = Convert.ToString((char)(((int)'A') + ran.Next(1, 26)));
            string TresLetra = Convert.ToString((char)(((int)'A') + ran.Next(1, 26)));
            Codigo = UnoLetra + DosLetra + ran.Next(0, 9) + Convert.ToChar(35 + ran.Next(0, 4)).ToString() + Convert.ToChar(35 + ran.Next(0, 4)).ToString() + TresLetra + ran.Next(0, 9) + ran.Next(0, 9);
            return Codigo;
        }
        #endregion
    }
}