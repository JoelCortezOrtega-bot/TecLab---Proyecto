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
        int[] HorasOcupadas;


        public FrCalendario()
        {
            InitializeComponent();
        }

        private void FrCalendario_Load(object sender, EventArgs e)
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
            lblMesTitulo.Text = fullMonthName.First().ToString().ToUpper() + fullMonthName.Substring(1);
            Conex.Conexiones.Close();

            CrearCalendario(UltimoDia,Year,Mes);
        }
        private void CrearCalendario(int ultimodia,object year, object mes)
        {
            Conexion Conex = new Conexion();

            //Colorear Calendario
            Conex.Conexiones.Open();
            string ColorComando = "select Day(Fecha)as Dia, COUNT(Fecha) as Cantidad from Prestamo_Proyectores where Month(Fecha)=Month(getdate()) group by Fecha";
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

                //Seleccion de color del dia en el calendario
                if (Convert.ToInt32(dt2.Rows[Aux][0]) == (i + 1))
                {

                    if (Convert.ToInt32(dt2.Rows[Aux][1]) == 15)
                    {
                        pbox.BackColor = Color.DarkRed;
                    }
                    else if ((Convert.ToInt32(dt2.Rows[Aux][1])) <= 14 && (Convert.ToInt32(dt2.Rows[Aux][1]) ) >= 8)
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

        void pboxClick(object sender, EventArgs e)
        {
            string pbxName = ((PictureBox)sender).Name;
            string Cadena = "Select ";
            MessageBox.Show(pbxName);
        }
    }
}
