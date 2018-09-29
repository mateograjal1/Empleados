using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * •Crear una clase Persona que tenga como atributos el nombre y la edad con su respectivo constructor. Definir un método que 
 * retorne en una variable tipo string un mensaje similar al siguiente: “nombre: Pepito Pérez. Edad: 99 años”

•Plantear una segunda clase Empleado que herede de la clase Persona. Añadir un atributo sueldo y el método para obtener el subsidio 
de transporte correspondiente.

•Elaborar un aplicativo donde: Defina un objeto de la clase Empleado. Por medio de botones llamar a sus métodos respectivos y 
mostrar los resultados correspondientes.*/

namespace Empleados
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmpleadosUI());
        }
    }
}
