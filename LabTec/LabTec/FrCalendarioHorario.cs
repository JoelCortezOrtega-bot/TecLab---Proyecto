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
        DataTable LocalNombres;
        DataTable LocalHoras;
        List<string> ListaApartados = new List<string>();
        int HoraInicial = 6;
        int HoraFinal = 22;


        public FrCalendarioHorario(string cantidadProy, string nombreForm, DataTable nombres, DataTable horas, int year, int month)
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
        }



        private void FrCalendarioHorario_Load(object sender, EventArgs e)
        {
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
            for (int i = HoraInicial; i < HoraFinal; i++)
            {
                //TITULO DE HORA
                TimeSpan result = TimeSpan.FromHours(i);
                string fromTimeString = "HORA: " + result.ToString("hh':'mm");
                tlpHorario.Controls.Add(new Label { Text = fromTimeString, Anchor = AnchorStyles.None, Font = new Font("Arial", 14), AutoSize = true }, 0, ContadorRenglon);
                ContadorRenglon++;

                for (int j = 0; j < LocalCantidadProy; j++)
                {
                    if ((ContadorHoras < LocalHoras.Rows.Count) && (Convert.ToString(LocalHoras.Rows[ContadorHoras][0]) == Convert.ToString(LocalNombres.Rows[j][0])) && (LocalHoras.Rows[ContadorHoras][1].ToString() == result.ToString("hh':'mm':'ss")))
                    {
                        color = Color.Brown;
                        texto = "NO DISPONIBLE";
                        activado = false;
                        ContadorHoras++;
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
                    if (LocalTipo=="Laboratorio")
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
                        if (LocalTipo=="Laboratorio")
                        {
                            Cadena = "insert into Prestamo_Lab values (18210844," + separado[2] + ",'" + separado[0] + "','" + AuxHoraInicial.ToString("hh':'mm':'ss") + "','" + AuxHoraFinal.ToString("hh':'mm':'ss") + "','ABC123DEF777')";
                        }
                        else
                        {
                            Cadena = "insert into Prestamo_Proyectores values (18210844," + separado[2] + ",'" + separado[0] + "','" + AuxHoraInicial.ToString("hh':'mm':'ss") + "','" + AuxHoraFinal.ToString("hh':'mm':'ss") + "','ABC123DEF777')";
                        }
                        cmd = new SqlCommand(Cadena, Conex.Conexiones);
                        cmd.ExecuteNonQuery();
                        Conex.Conexiones.Close();
                    }

                }
                if (Auxiliar==1)
                {
                    MessageBox.Show("Se han apartado los proyectores correctamente.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
           
        }
    }
}