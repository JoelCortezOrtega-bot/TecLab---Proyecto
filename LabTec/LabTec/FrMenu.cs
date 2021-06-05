using System;
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
        int LocalNumUsuario;
        public FrMenu(int numusuario)
        {
            InitializeComponent();
            LocalNumUsuario = numusuario;
            diseño();
        }
        // esto toma la variable de si es admin o maestro
        public string MaestroAdmin { get; set; }


        //oculta los paneles al inicio del form
        public void diseño()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

        }

        //este metodo es el que oculta otros metodos cuando se llama en mostrarpanel()
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
        // utiliza a escondermenu() para esconder los paneles no seleccionados
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

        //estos botones son los que despliegan las funcionalidades de cada seccion (Usuario despliega: Agregar, eliminar, modificar, etc)
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

        //el metodo se carga cuando inicia la forma
        private void FrMenu_Load(object sender, EventArgs e)
        {
            //este if oculta algunos botones si el usuario es maestro
            LabTec.Operaciones.Operaciones op = new LabTec.Operaciones.Operaciones();
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

        private Form formaactiva = null;

        //este es el metodo que toma la forma y la abre en el panel
        private void Abrirchild(Form childform)
        {
            if (formaactiva != null)
                formaactiva.Close();
            formaactiva = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            Panelchild.Controls.Add(childform);
            Panelchild.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        
        private void Modificar_contraseña_Click(object sender, EventArgs e)
        {
            //Abrirchild(new NombreDeFormaParaAbrir());
        }
        //este es el boton para cambiar entre formas, existe uno de estos para cada forma
        private void Agregar_usuarios_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrAgregarUsuarios());
        }

        private void Eliminar_usuarios_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrEliminarUsuarios());
        }

        private void Modificar_usuarios_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrModificarUsuarios());
        }

        private void Agregar_laboratorio_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrAgregarLaboratorios());
        }

        private void Eliminar_laboratorio_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrEliminarLaboratorio());
        }

        private void Agregar_proyectores_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrAgregarProyectores());
        }

        private void Eliminar_proyectores_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrEliminarProyectores());
        }

        private void Modificar_proyectores_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrModificarProyectores());
        }

        private void Calendario_laboratorios_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrCalendario(LocalNumUsuario,"Laboratorio"));
        }

        private void Calendario_proyectores_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrCalendario(LocalNumUsuario,"Proyector"));
        }

        private void Cancelar_apartados_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrCancelarApartados(LocalNumUsuario));
        }

        private void Modificar_contraseña_Click_1(object sender, EventArgs e)
        {
            Abrirchild(new FrModificarClave(LocalNumUsuario));
        }

        private void Ver_comentarios_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrComentarios(LocalNumUsuario));
        }

        private void Ver_Perfil_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrPerfil(LocalNumUsuario));
        }

        private void Buscar_usuarios_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrListaUsuarios());
        }

        private void Buscar_proyectores_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrListaUsuarios());
        }

        private void Buscar_laboratorio_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrListaUsuarios());
        }

        private void Modificar_Laboratorio_Click(object sender, EventArgs e)
        {
            Abrirchild(new FrModificarLaboratorio());
        }
    }
}
