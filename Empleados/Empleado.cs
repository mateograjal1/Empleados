using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public class Empleado : Persona
    {
        private decimal sueldo;
        private decimal subsidioTransporte;

        public decimal Sueldo { get => sueldo; set => sueldo = value; }
        public decimal SubsidioTransporte { get => subsidioTransporte; set => subsidioTransporte = value; }

        public Empleado(string nombre, string apellido, ushort edad, decimal sueldo, decimal subsidioTransporte):base(nombre, apellido, edad)
        {
            this.sueldo = sueldo;
            this.subsidioTransporte = subsidioTransporte;
        }
    }
}
