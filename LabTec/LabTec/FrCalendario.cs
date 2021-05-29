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
    public partial class FrCalendario : Form
    {
        //Consejo Y X (asi funciona el datatable)
        int UltimoDia = 0;
        int Numero = 0;
        int ano = 0;
        int mes = 0;
        int TotalDispositivosLabs = 0;
        double MitadDisLabs = 0;
        string LocalTipo="";
        public FrCalendario()
        {
            InitializeComponent();
        }

        private void FrCalendario_Load(object sender, EventArgs e)
        {
            DataTable fechas=MetodoMesYear();
            DataTable nombres = MetodoNombreProy();
            ano = Convert.ToInt32(fechas.Rows[0][1]);
            mes = Convert.ToInt32(fechas.Rows[0][0]);
            TotalDispositivosLabs = Convert.ToInt32(MetodoCantProyec())*11;
            MitadDisLabs = TotalDispositivosLabs/2;
            MitadDisLabs = Math.Ceiling(MitadDisLabs);
            LocalTipo = "";
            CrearCalendario(UltimoDia,fechas.Rows[0][1], fechas.Rows[0][0]);
        }
        string MetodoCantProyec()
        {
            //Conseguimos el total de proyectores
            Conexion Conex = new Conexion();
            string Cadena;
            Conex.Conexiones.Open();
            if (LocalTipo=="Laboratorio")
            {
                Cadena = "select Count(ID_Lap) from Laboratorios";
            }
            else
            {
                Cadena = "select Count(ID_Proyector) from Proyectores";
            }
            SqlCommand cmd = new SqlCommand(Cadena, Conex.Conexiones);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            return dt.Rows[0][0].ToString();
        }
         DataTable MetodoMesYear()
        {
            //Conseguimos el mes y an~o actual y ponemos el titulo en el calendario
            Conexion Conex = new Conexion();
            Conex.Conexiones.Open();
            string Cadena = "Select Month(getdate()) as Month,Year(getdate()) as Year";
            SqlCommand cmd = new SqlCommand(Cadena, Conex.Conexiones);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            var Year = dt.Rows[0][1];
            var Mes = dt.Rows[0][0];
            UltimoDia = DateTime.DaysInMonth(Convert.ToInt32(Year), Convert.ToInt32(Mes));

            //Pasamos a texto el mes
            string fullMonthName = new DateTime(Convert.ToInt32(Year), Convert.ToInt32(Mes), 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
            lblMesTitulo.Text = fullMonthName.First().ToString().ToUpper() + fullMonthName.Substring(1) + "  " + Year;

            return dt;
        }
        DataTable MetodoNombreProy()
        {
            //Conseguimos los nombres de los proyectores
            Conexion Conex = new Conexion();
            Conex.Conexiones.Open();
            string Cadena = "";
            if (LocalTipo == "Laboratorio")
            {
                Cadena = "select ID_Lap from Laboratorios";

            }
            else
            {
                Cadena = "select ID_Proyector from Proyectores";
            }
            SqlCommand cmd = new SqlCommand(Cadena, Conex.Conexiones);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            return dt;
        }

        DataTable MetodoHorasApartadas(int year, int mes, string dia)
        {
            Conexion Conex = new Conexion();
            Conex.Conexiones.Open();
            string Cadena="";
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
        private void CrearCalendario(int ultimodia,object year, object mes)
        {
            Conexion Conex = new Conexion();

            //Colorear Calendario
            Conex.Conexiones.Open();
            string ColorComando;
            if (LocalTipo == "Laboratorio")
            {
                ColorComando = "select Day(Fecha)as Dia, COUNT(Fecha) as Cantidad from Prestamo_Lab where Month(Fecha)="+mes+" group by Fecha";

            }
            else
            {
                ColorComando = "select Day(Fecha)as Dia, COUNT(Fecha) as Cantidad from Prestamo_Proyectores where Month(Fecha)="+mes+" group by Fecha";
            }
            SqlCommand cmd2 = new SqlCommand(ColorComando, Conex.Conexiones);
            SqlDataAdapter dr2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            dr2.Fill(dt2);
            Conex.Conexiones.Close();
            //Variable Auxiliar para manipular la tabla generada para colorear
            int Aux = 0;

            //Creacion del picturebox fake
            DateTime date = new DateTime(Convert.ToInt32(year), Convert.ToInt32(mes), 1);
            var AuxVacio=(int) date.DayOfWeek;
            //MessageBox.Show(AuxVacio.ToString());
            for (int j = 0; j < AuxVacio; j++)
            {
                PictureBox pboxVacio = new PictureBox();
                pboxVacio.Name = Convert.ToString(j + "Vacio");
                pboxVacio.Width = 100;
                pboxVacio.Height = 100;
                flowPanelCalendario.Controls.Add(pboxVacio);
            }

            //Creacion del picturebox
            for (int i = 0; i < ultimodia; i++)
            {
                Numero = Numero + 1;
                PictureBox pbox = new PictureBox();
                pbox.Name = Convert.ToString(i + 1);
                pbox.Paint += new PaintEventHandler(pboxPaint);
                pbox.Click += new EventHandler(pboxClick);
                pbox.Width = 100;
                pbox.Height = 100;
                //MessageBox.Show(dt2.Rows[Aux][1].ToString());
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
            FrCalendarioHorario horario = new FrCalendarioHorario(MetodoCantProyec(), pbxName, MetodoNombreProy(),MetodoHorasApartadas(ano,mes,pbxName),ano,mes, MetodoHorasRestriccion(ano, mes, pbxName));
            horario.ShowDialog();
        }

        private void btnSiguienteMes_Click(object sender, EventArgs e)
        {
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

        private void btnAnteriorMes_Click(object sender, EventArgs e)
        {
            mes--;
            if (mes==0)
            {
                ano--;
                mes =12;
            }
            
            UltimoDia = DateTime.DaysInMonth(Convert.ToInt32(ano), Convert.ToInt32(mes));

            //Pasamos a texto el mes
            string fullMonthName = new DateTime(Convert.ToInt32(ano), Convert.ToInt32(mes), 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
            lblMesTitulo.Text = fullMonthName.First().ToString().ToUpper() + fullMonthName.Substring(1)+"  "+ano;
            flowPanelCalendario.Controls.Clear();
            CrearCalendario(UltimoDia, ano, mes);
        }
    }
}
