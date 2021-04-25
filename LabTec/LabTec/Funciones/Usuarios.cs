using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTec.Operaciones
{
    class Usuarios
    {
        private int IDUsuario;
        private string Nombre;
        private string ApellidoP;
        private string ApellidoM;
        private string Genero;
        private string Correo;
        private string Clave;
        private int Rol;
        private string Estado;

        public int IDUsuario1 { get => IDUsuario; set => IDUsuario = value; }
        public string Clave1 { get => Clave; set => Clave = value; }

        public string Correo1 { get => Correo; set => Correo = value; }
    }
}
