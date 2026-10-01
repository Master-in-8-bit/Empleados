using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados.Classes
{
    // Clase base
    public class Empleado
    {
        // Uso de internal para aplicar encapsulamiento
        internal string Nombre { get; set; }
        internal int DNI {  get; set; }
        internal double Sueldo_base { get; set; }
        internal Empleado(string nombre, int dni, double sueldo_base) {
            Nombre = nombre;
            DNI = dni;
            Sueldo_base = sueldo_base;
        }
        // Función base para aplicar poliformismo
        public virtual void sumarSueldoAdicional(int factor)
        {
            Sueldo_base += factor * 1;
        }
    }
}
