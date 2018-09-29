using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public class Persona
    {
        private string nombre, apellido;
        private ushort edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public ushort Edad { get => edad; set => edad = value; }

        public Persona(string nombre, string apellido, ushort edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public override string ToString()
        {
            return "Nombre " + Nombre + " " + Apellido + ". Edad: " + Edad + " años";
        }
    }
}
