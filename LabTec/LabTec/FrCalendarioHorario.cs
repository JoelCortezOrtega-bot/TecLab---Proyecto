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
        //Varialbles de Apoyo 
        //Estas variables se utilizan para manejar el Dia, Hora, Mes y Año de forma local
        //Ademas de solicitar el ID ingresado por el usuario en el inicio de sesión
        int LocalCantidadProy;
        string LocalDia;
        int LocalMes;
        int LocalAño;
        string LocalTipo;
        int LocalNumUsuario;
        int LocalMesActual;
        DataTable LocalNombres;
        DataTable LocalHoras;
        DataTable LocalRestriccion;
        List<string> ListaApartados = new List<string>();
        int HoraInicial = 6;
        int HoraFinal = 22;

        //Este método recibe todos los datos que hemos declarado con antelación
        public FrCalendarioHorario(string cantidadProy, string nombreForm, DataTable nombres, DataTable horas, int year, int month, DataTable restriccion,int NumUsuario, int mesactual)
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
            LocalMesActual = mesactual;
            LocalRestriccion = restriccion;
            LocalNumUsuario = NumUsuario;
        }


        //Este metodo cargara el metodo Creación de Horario
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
            //Lista para saber cuales horas tendran descanso
            List<string> descanso = new List<string>();
            //For que maneja las Horas
            for (int i = HoraInicial; i < HoraFinal; i++)
            {
                //TITULO DE HORA
                TimeSpan result = TimeSpan.FromHours(i);
                string fromTimeString = "HORA: " + result.ToString("hh':'mm");
                //Arial 14
                tlpHorario.Controls.Add(new Label { Text = fromTimeString, Anchor = AnchorStyles.None, Font = new Font("Corbel", 12), AutoSize = true }, 0, ContadorRenglon);
                ContadorRenglon++;
                //For que maneja los proyectores/laboratorios
                for (int j = 0; j < LocalCantidadProy; j++)
                {
                    //0 es menor al numero de horas apartadas en el dia [Y] el nombre de ID_Proyector de las horas apartadas es igual al nombre del ID_Proyector actual en el for [Y] La hora a la que se aparta es igual a la hora que se maneja en el for de arriba
                    //0<19
                    if ((LocalMes-LocalMesActual)<2)
                    {
                    //If que nos permitirar saber si no esta disponible debido alas horas
                        if ((ContadorHoras < LocalHoras.Rows.Count) && (Convert.ToString(LocalHoras.Rows[ContadorHoras][0]) == Convert.ToString(LocalNombres.Rows[j][0])) && (LocalHoras.Rows[ContadorHoras][1].ToString() == result.ToString("hh':'mm':'ss")))
                        {
                            descanso.Add(Convert.ToString(LocalNombres.Rows[j][0]) + (i + 1));
                            color = Color.Brown;
                            texto = "NO DISPONIBLE";
                            activado = false;
                            ContadorHoras++;
                        }
                        //En caso de que sea falso se realizara otro if con otra condicion para saber si esta en descanso
                        else if (descanso.Contains(Convert.ToString(LocalNombres.Rows[j][0]) + (i)) && LocalTipo=="Proyector")
                        {
                            if (i > 7)
                            {
                                //Foreach que nos permitire desplegar los tipos de horario si se cumple la condicion que tiene que tener año,mes y dia 
                                foreach (Control c in tlpHorario.Controls)
                                {
                                    //Condicion a cumplir para que se pueda mostrar
                                    if (Convert.ToString(c.Tag) == (LocalAño + "-" + LocalMes + "-" + LocalDia + "/" + (i - 2)) && c.Name == Convert.ToString(LocalNombres.Rows[j][0]))
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
                        //En caso de que no cumpla la condicion se pone disponible
                        else
                        {
                            color = Color.SpringGreen;
                            texto = "DISPONIBLE";
                            activado = true;
                        }
                    }
                    //En otro caso de no de no cumplir condiciones significa que no es apartable debido a que ya fue selecionaod
                    else
                    {
                        color = Color.GhostWhite;
                        texto = "NO APARTABLE";
                        activado = false;
                    }
                    tlpHorario.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    //tlpHorario.Controls.Add(new Button{ Text = (LocalNombres.Rows[j][0].ToString() + "    " + texto), Font = new Font("Arial", 14), Width = 294, Height = 28, BackColor = color, Enabled = activado, Name = LocalNombres.Rows[j][0].ToString(), Tag = LocalAño + "-" + LocalMes + "-" + LocalDia + "/" + i, },0,ContadorRenglon);
                    
                    Button btn= new Button { Text = (LocalNombres.Rows[j][0].ToString() + "    " + texto), Font = new Font("Corbel", 12), Width = 294, Height = 28, BackColor = color, Enabled = activado, Name = LocalNombres.Rows[j][0].ToString(), Tag = LocalAño + "-" + LocalMes + "-" + LocalDia + "/" + i, };
                    btn.Click += new EventHandler(btnClick);
                    tlpHorario.Controls.Add(btn, 0, ContadorRenglon);
                    ContadorRenglon++;
                }

            } 
            //Boton Clik
            void btnClick(object sender, EventArgs e)
            {
                //Se le agrega nombre  y fecha selecionado
                string btnName = ((Button)sender).Name;
                var btnFecha = ((Button)sender).Tag;
                Button btn = (Button)sender;
                //If que nos permitira saber si ya esta selecionado o si esta disponible 
                if (btn.BackColor==Color.SpringGreen)
                {
                    //si es verdadero y el color es SpringGreen se realiza lo siguiente
                    btn.BackColor = Color.Orange;
                    btn.Text= btnName + "    " + "SELECCIONADO";
                    ListaApartados.Add(btnFecha+"/"+btnName);
                }
                else
                {
                    //En caso contrario de que no cumpla la condicion se realiza lo siguiente
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
        //Boton cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        //FORMATO 
        //[0]= Fecha [1]=Hora [2]=ID Proyector
        //Boton para ingresar
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Auxiliar para mandar mensaje de aviso que se agrego correctamente
            int Auxiliar = 0;
            if (ListaApartados.Count == 0)
            {
            // Mensaje  de error, indicando conflicto, sugiriendo seleccionar un dispositivo
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
                
                //Bucle para recorrer elementos de lista de apartados
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
                
                // si advertencia es falso iniciara un bucle foreach
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

                        //Conversion a Hora Final
                        TimeSpan AuxHoraFinal = TimeSpan.FromHours(Convert.ToDouble(separado[1]) + 1);
                        AuxHoraFinal.ToString("hh':'mm':'ss");

                        //Condicion para confirmar que no este apartado esta fecha
                        string AuxCadena;
                        if (LocalTipo == "Laboratorio")
                        {
                        // Seleccion de la tabla Prestamo_Lab  cuando la hora y fecha y ID sean las definidas.
                            AuxCadena = "select * from Prestamo_Lab where Hora_Entrada='" + AuxHoraInicial.ToString("hh':'mm':'ss") + "' and Fecha='" + separado[0] + "' and ID_Lap=" + separado[2];

                        }
                        else
                        {
                        // Seleccion de la tabla Prestamo_Proyectores  cuando la hora y fecha y ID sean las definidas.
                            AuxCadena = "select * from Prestamo_Proyectores where Hora_Entrada='" + AuxHoraInicial.ToString("hh':'mm':'ss") + "' and Fecha='" + separado[0] + "' and ID_Proyector=" + separado[2];

                        }
                        
                        // Se crea una instancia SqlCommand pasando el string con el comando SQL y la referencia a la conexión
                        SqlCommand cmd = new SqlCommand(AuxCadena, Conex.Conexiones);
                        // Recuperacion de los datos generados                         
                        SqlDataAdapter dr = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dr.Fill(dt);
                        // Se cierra la conexion de la base de datos
                        Conex.Conexiones.Close();
                        if (dt.Rows.Count > 0)
                        {
                        // Mensaje de error que indica que el proyector se encuentra ya se encuentra apartado, mostrando la hora y fel proyector marcando conflicto
                            MessageBox.Show("Esta hora ya se encuentra apartada.\r\nFavor de escoger otra hora. \r\n[Conflicto => Hora:" + AuxHoraInicial.ToString("hh':'mm':'ss") + " Proyector: " + separado[2], "Conflicto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                        {
                            Auxiliar = 1;
                            // Abrir conexion con la base de datos
                            Conex.Conexiones.Open();
                            string Cadena;
                            // En caso de elegir Local tipo laboratorio
                            if (LocalTipo == "Laboratorio")
                            {
                            // Cadeba donde se insertan los valores en la tabla Prestamo_Lab
                                Cadena = "insert into Prestamo_Lab values ("+LocalNumUsuario+"," + separado[2] + ",'" + separado[0] + "','" + AuxHoraInicial.ToString("hh':'mm':'ss") + "','" + AuxHoraFinal.ToString("hh':'mm':'ss") + "','" + GeneradorCodigo() + "')";
                            }
                            else
                            {
                            // Cadeba donde se insertan los valores en la tabla Prestamo_Proyectores
                                Cadena = "insert into Prestamo_Proyectores values (" + LocalNumUsuario + "," + separado[2] + ",'" + separado[0] + "','" + AuxHoraInicial.ToString("hh':'mm':'ss") + "','" + AuxHoraFinal.ToString("hh':'mm':'ss") + "','" + GeneradorCodigo() + "')";
                            }
                            
                            // Se crea una instancia SqlCommand pasando el string con el comando SQL y la referencia a la conexión
                            cmd = new SqlCommand(Cadena, Conex.Conexiones);
                            //Llamamos ExecuteNonQuery para enviar comandos
                            cmd.ExecuteNonQuery();
                            // Se cierra la conexion de la base de datos
                            Conex.Conexiones.Close();
                        }

                    }
                    if (Auxiliar == 1)
                    {
                // Mensaje que confirma que se ha llevado con exito el apartado del proyector                
                        MessageBox.Show("Se han apartado los proyectores correctamente.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                // Mensaje en caso de error, indicando conflicto y sugerirendo no pedir el mismo proyector 2 horas seguidas
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
