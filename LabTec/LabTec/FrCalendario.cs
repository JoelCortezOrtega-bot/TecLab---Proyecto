using LabTec.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTec
{
    //Clase FrCalendario hereda de la clase Form
    public partial class FrCalendario : Form
    {
        //Consejo Y X (asi funciona el datatable)
        //Declaracion de variables
        int UltimoDia = 0;//Variable de ultimo dia
        int Numero = 0;//variable numero 
        int ano = 0;//variable de año
        int mes = 0;//variable de mes
        int mesactual = 0;//variable del mes actual
        int TotalDispositivosLabs = 0;//variaable de todos los dias disponibles
        double MitadDisLabs = 0;//Variable para la mitad de los lavoratorios disponibles
        string LocalTipo = "";//Variable que guarda el tipo de usuario (Proyector o Laboratorio) 
        int LocalNumUsuario;//variable que guarda el numero de usuario
        string DiaActual;//variable para el dia actual

        //Contructor de FrCalendario que resibe dos parametros
        public FrCalendario(int NumUsuario, string Tipo)
        {
            InitializeComponent();
            //Se guarda el tipo de usuario que es (Proyector o Laboratorio) y su numero de usuario
            LocalTipo = Tipo;//La variable LocalTipo guarda el valor del parametro Tipo
            LocalNumUsuario = NumUsuario;//La variable LocalNumUsuario guarda el valor del parametro NumUsuario
            DiaActual = DateTime.Now.ToString("d");//DiaActual se le asigna la fecha actual
            DiaActual = DiaActual.Remove(2);//DiaActual se le asigna unicamnete el dia quitando valores no requeridos
        }

        //Metodo void de FrCalendario
        private void FrCalendario_Load(object sender, EventArgs e)
        {
            //Se consigue las fechas y nombres de los Proyectores o Laboratorios
            DataTable fechas = MetodoMesYear();//Se le asigna el valor retornado del metodo MetodoMesYear a fecha 
            DataTable nombres = MetodoNombreProy();//Se le asigna el valor retornado del metodo MetodoNombreProy a nombres
            //Se guarda el año y mes.
            ano = Convert.ToInt32(fechas.Rows[0][1]);
            mes = Convert.ToInt32(fechas.Rows[0][0]);
            mesactual = mes;//Mesactual Guarda el valor de mes
            //Se guarda el total de dispositivos y se multiplica por las horas (Esto es para poner diferentes colores en los dias)
            TotalDispositivosLabs = Convert.ToInt32(MetodoCantProyec()) * 11;
            //Se realiza una serie de operaciones para saber la mitad de las usos.
            MitadDisLabs = TotalDispositivosLabs / 2;//Se le asigna a MitadDisLabs el valor octenido de la dicvidir entre dos a TotalDispositivosLabs
            MitadDisLabs = Math.Ceiling(MitadDisLabs);//Se redondea a un valor igual o mayor al numero octenido
            LocalTipo = "";//La variable LocalTipo se vacia 
            CrearCalendario(UltimoDia, fechas.Rows[0][1], fechas.Rows[0][0]);//Se envian los datos de UltimoDia y fechas
        }

        //Metodo de tipo string de MetodoCanyyProec
        string MetodoCantProyec()
        {
            //Conseguimos el total de proyectores
            Conexion Conex = new Conexion();//Se crea objeto de la clase conexion
            string Cadena;//Se declara variable cadena
            Conex.Conexiones.Open();//Se habre la conexion con la base de datos
            if (LocalTipo == "Laboratorio")//Si la variable LocalTipo es igual a "Laboratorio"
            {
                Cadena = "select Count(ID_Lap) from Laboratorios";//Cadena se iguala al texto "select Count(ID_Lap) from Laboratorios"
            }
            else//En caso contrario
            {
                Cadena = "select Count(ID_Proyector) from Proyectores";//Cadena se iguala al texto "select Count(ID_Proyector) from Proyectores"
            }
            SqlCommand cmd = new SqlCommand(Cadena, Conex.Conexiones);//Se crea un objeto de la clase SqlCommand, la cual resive el valor de la variable Cadena y el objeto conex
            SqlDataAdapter dr = new SqlDataAdapter(cmd);//Se crea un objeto de la clase SqlDataAdapter y resive el valor del objeto cmd 
            DataTable dt = new DataTable();//Se crea el obejto de la clase DataTable
            dr.Fill(dt);//Se agregan o actualizan datos de la tabla
            return dt.Rows[0][0].ToString();//Se retorna el obejto dt con la colecion de filas de la tabla
        }

        //Metodo de DataTable para los meses y años
        DataTable MetodoMesYear()
        {
            //Conseguimos el mes y año actual y ponemos el titulo en el calendario
            Conexion Conex = new Conexion();//Se crea objeto de la clase conexion
            Conex.Conexiones.Open();//Se habre la conexion con la base de datos
            string Cadena = "Select Month(getdate()) as Month,Year(getdate()) as Year";//Se declara la variable y se iguala a "Select Month(getdate()) as Month,Year(getdate()) as Year"
            SqlCommand cmd = new SqlCommand(Cadena, Conex.Conexiones);//Se crea un objeto de la clase SqlCommand, la cual resive el valor de la variable Cadena y el objeto conex
            SqlDataAdapter dr = new SqlDataAdapter(cmd);//Se crea un objeto de la clase SqlDataAdapter y resive el valor del objeto cmd 
            DataTable dt = new DataTable();//Se crea el obejto de la clase DataTable
            dr.Fill(dt);//Se agregan o actualizan datos de la tabla
            var Year = dt.Rows[0][1];//Se decalra la variable Year la cual se igual al objeto dt junto con la colecion de filas de la tabla
            var Mes = dt.Rows[0][0];//Se declara la variable Mes la cual se igual al objeto dt junto con la colecion de filas de la tabla
            UltimoDia = DateTime.DaysInMonth(Convert.ToInt32(Year), Convert.ToInt32(Mes));//Se iguala la variable UltimoDia a los valores del año y el mes

            //Pasamos a texto el mes
            string fullMonthName = new DateTime(Convert.ToInt32(Year), Convert.ToInt32(Mes), 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
            lblMesTitulo.Text = fullMonthName.First().ToString().ToUpper() + fullMonthName.Substring(1) + "  " + Year;//Se imprime el mes

            return dt;//Se retorna el obejto dt
        }

        //Metodo para seleccionar lavoratorio
        DataTable MetodoNombreProy()
        {
            //Conseguimos los nombres de los proyectores
            Conexion Conex = new Conexion();//Se crea objeto de la clase conexion
            Conex.Conexiones.Open();//Se habre la conexion con la base de datos
            string Cadena = "";//Se declara la variable Cadena en blanco
            if (LocalTipo == "Laboratorio")//Si LocalTipo es igual a "Laboratorio"
            {
                Cadena = "select ID_Lap from Laboratorios";//Cadena es igual a "select ID_Lap from Laboratorios"

            }
            else//En caso contrario
            {
                Cadena = "select ID_Proyector from Proyectores";//Cadena es igual a "select ID_Proyector from Proyectores"
            }
            SqlCommand cmd = new SqlCommand(Cadena, Conex.Conexiones);//Se crea un objeto de la clase SqlCommand, la cual resive el valor de la variable Cadena y el objeto conex
            SqlDataAdapter dr = new SqlDataAdapter(cmd);//Se crea un objeto de la clase SqlDataAdapter y resive el valor del objeto cmd 
            DataTable dt = new DataTable();//Se crea el obejto de la clase DataTable
            dr.Fill(dt);//Se agregan o actualizan datos de la tabla
            return dt;//Se retorna el obejto dt
        }

        //Metodo para visualizar las horas aaprtadas de los laboratorios
        /*
        Dentro de esta parte del código el objeto SqlCommand realiza un llamado a la variable cadena y ala 
        conexión dentro de nuestro servidor, y el SqlDataAdapter almacena los datos para poder ingresar estos 
        datos almacenados a una tabla donde se retornará esta tabla 
        */
        DataTable MetodoHorasApartadas(int year, int mes, string dia)
        {
            Conexion Conex = new Conexion();//Se crea objeto de la clase conexion
            Conex.Conexiones.Open();
            string Cadena = "";
            if (LocalTipo == "Laboratorio")
            {
                Cadena = "select ID_Lap,Hora_Entrada from Prestamo_Lab where Fecha=('" + year + "-" + mes + "-" + dia + "') order by Hora_Entrada, ID_Lap";
            }
            else
            {
                Cadena = "select ID_Proyector,Hora_Entrada from Prestamo_Proyectores where Fecha=('" + year + "-" + mes + "-" + dia + "') order by Hora_Entrada, ID_Proyector";
            }

            SqlCommand cmd = new SqlCommand(Cadena, Conex.Conexiones);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            Conex.Conexiones.Close();
            return dt;
        }

        /*
         Aquí creamos un método de tipo DataTable donde se llamará MetodoHorasRestriccion, en donde los parámetros que pediremos 
         se realizarán de manera general la llamada de la conexión de nuestro servidor a nuestra base de datos y de hay poder 
         almacenar un comando de sql para poder almacenarse dentro de la DataTable que se está llamando a este método. 
         Despues de esta parte del código se usa la misma técnica para poder llenar y almacenar una tabla de datos con 
         la cual retornaran estos datos hacia el código principal.     
        */

        DataTable MetodoHorasRestriccion(int year, int mes, string dia)
        {
            Conexion Conex = new Conexion();
            Conex.Conexiones.Open();
            string Cadena="";
            //Esta tabla sirve para hacer la restriccion de descanso del proyector
            //if (LocalTipo == "Proyector")
            //{
                Cadena = "select ID_Proyector,Hora_Entrada from Prestamo_Proyectores where Fecha=('" + year + "-" + mes + "-" + dia + "') order by ID_Proyector, Hora_Entrada";
            //}

            SqlCommand cmd9 = new SqlCommand(Cadena, Conex.Conexiones);
            SqlDataAdapter dr9 = new SqlDataAdapter(cmd9);
            DataTable dt9 = new DataTable();
            dr9.Fill(dt9);
            Conex.Conexiones.Close();
            return dt9;
        }


        /*
        En este método llamado crearcalendario se utiliza parámetros especifico donde se utilizara 
        para más adelante en la cual dentro del mismo se crea un objeto llamado conexión en la cual 
        lo llamaremos conex donde llamaremos esa conexión para abrirlo y cerrar la conexión de 
        nuestra base de datos al código y después de que se abra se colorea el calendario dentro 
        de nuestro programa en la cual pregunta que si el el valor del dato LocalTipo es igual a 
        Laboratorio entonces se asignará el nuevo valor como se visualiza en el código, 
        en tal caso de que no se cumpla la condición entonces realizará otra acción que hará 
        lo mismo pero con otra serie de pasos a seguir.            
        */
        private void CrearCalendario(int ultimodia, object year, object mes)
        {
            Conexion Conex = new Conexion();

            //Colorear Calendario
            Conex.Conexiones.Open();
            string ColorComando;
            if (LocalTipo == "Laboratorio")
            {
                ColorComando = "select Day(Fecha)as Dia, COUNT(Fecha) as Cantidad from Prestamo_Lab where Month(Fecha)=" + mes + " group by Fecha";

            }
            else
            {
                ColorComando = "select Day(Fecha)as Dia, COUNT(Fecha) as Cantidad from Prestamo_Proyectores where Month(Fecha)=" + mes + " group by Fecha";
            }
            /*
             Aquí se se crea un objeto SqlCommand en la cual se llamará cmd2, 
             creamos otro objeto tipo SqlDataAdapter llamado dr2 y otro tipo 
             Datatable llamado dt2 donde se utilizara para la obtención de datos 
             necesarios, además declaramos una variables auxiliar para manipular 
             las mismas tablas que generamos.
             */
            SqlCommand cmd2 = new SqlCommand(ColorComando, Conex.Conexiones);
            SqlDataAdapter dr2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            dr2.Fill(dt2);
            Conex.Conexiones.Close();
            //Variable Auxiliar para manipular la tabla generada para colorear
            int Aux = 0;

            /*
             Creamos un objeto DateTime llamado date, una variable var
             donde su tipo de valor no es fijo pero que utilizaremos para un valor 
             date con tipos de datos int, una vez hecho eso creamos un ciclo for para 
             poder declarar el nombre, el tamaño del pboxVacio y el flowPanelCalendario 
             donde se mostrarán los picturebox que ocuparemos.
             */

            //Creacion del picturebox fake
            DateTime date = new DateTime(Convert.ToInt32(year), Convert.ToInt32(mes), 1);
            var AuxVacio=(int) date.DayOfWeek;
            //MessageBox.Show(AuxVacio.ToString());
            for (int j = 0; j < AuxVacio; j++)
            {
                PictureBox pboxVacio = new PictureBox();
                pboxVacio.Name = Convert.ToString(j + "Vacio");
                pboxVacio.Width = (flowPanelCalendario.Width/7)-9;
                pboxVacio.Height = flowPanelCalendario.Height/5;
                //pboxVacio.Width = 100;
                //pboxVacio.Height = 100;
                flowPanelCalendario.Controls.Add(pboxVacio);
            }

            /*
             Después creamos otro picturebox donde utilizaremos otro ciclo for para declarar el objeto PictureBox, 
             el id del picturebox, el nombre del mismo, su color, el evento click del mismo botón, el ancho 
             y altura del mismo, para cada uno de los picturebox que ocupemos dentro de nuestro programa, y
             dentro de sí en un ciclo preguntamos que si el valor auxiliar si es igual a 6 o a 0 entonces 
             realizará una acción donde preguntara para cada uno de los si es necesario declarar el valor 
             AuxVacio como 0 o si lo incrementaremos en caso contrario solo incrementara su valor.
             */

            //Creacion del picturebox
            for (int i = 0; i < ultimodia; i++)
            {
                Numero = Numero + 1;
                PictureBox pbox = new PictureBox();
                pbox.Name = Convert.ToString(i + 1);
                pbox.Paint += new PaintEventHandler(pboxPaint);
                pbox.Click += new EventHandler(pboxClick);
                pbox.Width = (flowPanelCalendario.Width / 7)-9;
                pbox.Height = flowPanelCalendario.Height / 5;
                //pbox.Width = 100;
                //pbox.Height = 100;
                //Condicion para que sabados y domingos no se pueda apartar
                /*
                 Después en esta otra condición se realiza la pregunta que si los días pasado al actual no se 
                 puedan abrir si en caso de que se cumpla la condición entonces no estará disponible el pbox 
                 en caso contrario estará accesible, después esta otra condición donde si el color seleccionado
                 es el color n el calendario si es así entonces se realizara una pregunta si el total de diapositivas
                 es igual o mayor al mismo valor si es así entonces el color será de color rojo oscuro si no es 
                 así pregunta si el valor es menor si es así entonces el color será naranja oscuro, si no es así 
                 entonces el color será verde oscuro, aquí se incrementara un valor auxiliar y se hará otra condición 
                 de que si el auxiliar es igual a la cantidad de datos de la tabla si es así entonces el auxiliar 
                 se decrementara y sigue progresando.
                 */
                if (AuxVacio==6 || AuxVacio==0)
                {
                    if (AuxVacio==6)
                    {
                        AuxVacio = 0;
                    }
                    else
                    {
                        AuxVacio++;
                    }
                    pbox.Enabled = false;
                }
                else
                {
                    AuxVacio++;
                }
                //Condicion para que los dias pasados al actual no se puedan abrir
                if ((Convert.ToInt32(DiaActual)-1)>i && Convert.ToInt32(mes)==mesactual)
                {
                    pbox.Enabled = false;
                }
                //Seleccion de color del dia en el calendario
                if (dt2.Rows.Count>0 && Convert.ToInt32(dt2.Rows[Aux][0]) == (i + 1))
                {
                    if (Convert.ToInt32(dt2.Rows[Aux][1]) >= TotalDispositivosLabs)
                    {
                        pbox.BackColor = Color.DarkRed;
                    }
                    else if ((Convert.ToInt32(dt2.Rows[Aux][1])) < TotalDispositivosLabs && (Convert.ToInt32(dt2.Rows[Aux][1]) ) >= MitadDisLabs)
                    {
                        pbox.BackColor = Color.DarkOrange;
                    }
                    else
                    {
                        pbox.BackColor = Color.DarkGreen;
                    }
                    Aux = Aux + 1;
                    if ((Aux == dt2.Rows.Count))
                    {
                        Aux = Aux - 1;
                    }
                }
                else
                {
                    pbox.BackColor = Color.DarkGreen;
                }
                flowPanelCalendario.Controls.Add(pbox);
            }
        }

        //Metodo para escribir el numero del dia en el calendario.
        void pboxPaint(object sender, PaintEventArgs e)
        {
            //Asignamos la fuente Arial tamaño 14
            using (Font myFont = new Font("Arial", 14))
            {
                string pbxName = ((PictureBox)sender).Name;
                e.Graphics.DrawString(pbxName, myFont, Brushes.Black, new Point(2, 2));
                Pen pen = new Pen(Color.Black, 2);
                e.Graphics.DrawRectangle(pen, 0, 0, 100, 100);
            }
        }
        
        //Metodo para asignar el evento que tendra cada dia del calendario.
        void pboxClick(object sender, EventArgs e)
        {
            string pbxName = ((PictureBox)sender).Name;
            FrCalendarioHorario horario = new FrCalendarioHorario(MetodoCantProyec(), pbxName, MetodoNombreProy(),MetodoHorasApartadas(ano,mes,pbxName),ano,mes, MetodoHorasRestriccion(ano, mes, pbxName),LocalNumUsuario,mesactual);
            horario.ShowDialog();
        }

        //Metodo utilizado para cambiar al mes siguiente
        private void btnSiguienteMes_Click(object sender, EventArgs e)
        {
            //Contador de Meses
            mes++;
            if (mes==13)
            {
                ano++;
                mes = 1;
            }
            UltimoDia = DateTime.DaysInMonth(Convert.ToInt32(ano), Convert.ToInt32(mes));

            //Pasamos a texto el mes
            string fullMonthName = new DateTime(Convert.ToInt32(ano), Convert.ToInt32(mes), 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
            lblMesTitulo.Text = fullMonthName.First().ToString().ToUpper() + fullMonthName.Substring(1) + "  " + ano;
            flowPanelCalendario.Controls.Clear();
            CrearCalendario(UltimoDia,ano,mes);
        }


        //Metodo utilizado para cambiar al mes anterior
        private void btnAnteriorMes_Click(object sender, EventArgs e)
        {
            if (mes>mesactual)
            {
                mes--;
                if (mes == 0)
                {
                    ano--;
                    mes = 12;
                }
                    UltimoDia = DateTime.DaysInMonth(Convert.ToInt32(ano), Convert.ToInt32(mes));

                    //Pasamos a texto el mes
                    string fullMonthName = new DateTime(Convert.ToInt32(ano), Convert.ToInt32(mes), 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
                    lblMesTitulo.Text = fullMonthName.First().ToString().ToUpper() + fullMonthName.Substring(1) + "  " + ano;
                    flowPanelCalendario.Controls.Clear();
                    CrearCalendario(UltimoDia, ano, mes);
                
            }
           
        }
    }
}
