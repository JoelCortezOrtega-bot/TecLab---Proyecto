﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTec
{
    public partial class FrMenu : Form
    {
        public FrMenu()
        {
            InitializeComponent();
            diseño();
        }

        public string MaestroAdmin { get; set; }


        public void diseño()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

        }

        public void EsconderMenu()
        {
            if (panel2.Visible == true)
                panel2.Visible = false;
            if (panel3.Visible == true)
                panel3.Visible = false;
            if (panel4.Visible == true)
                panel4.Visible = false;
            if (panel5.Visible == true)
                panel5.Visible = false;
            if (panel6.Visible == true)
                panel6.Visible = false;
        }

        private void mostrarpanel(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                EsconderMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            mostrarpanel(panel2);

        }

        private void btn_comentarios_Click(object sender, EventArgs e)
        {
            mostrarpanel(panel3);

        }

        private void btn_laboratorios_Click(object sender, EventArgs e)
        {
            mostrarpanel(panel4);

        }

        private void btn_proyectores_Click(object sender, EventArgs e)
        {
            mostrarpanel(panel5);

        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            mostrarpanel(panel6);

        }


        private void FrMenu_Load(object sender, EventArgs e)
        {
            LabTec.Operaciones.Operaciones op = new LabTec.Operaciones.Operaciones();
            MessageBox.Show(MaestroAdmin);
            if (MaestroAdmin=="2")
            {
                
                Agregar_laboratorio.Visible = false;
                Eliminar_laboratorio.Visible = false;
                Modificar_Laboratorio.Visible = false;
                Agregar_proyectores.Visible = false;
                Eliminar_proyectores.Visible = false;
                Modificar_proyectores.Visible = false;
                btn_usuarios.Visible = false;
                Buscar_usuarios.Visible = false;
                Agregar_usuarios.Visible = false;
                Eliminar_usuarios.Visible = false;
                Modificar_usuarios.Visible = false;
             
            }
        }

        private void Mi_perfil_Click(object sender, EventArgs e)
        {

            //  Abrirchild(NombreDeFormaParaAbrir());
        }
    }
}
