using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados.Classes
{
    // Clase padre
    public class Empleado
    {
        // Uso de internal para aplicar encapsulamiento
        internal string Nombre { get; set; }
        internal int DNI {  get; set; }
        internal double Sueldo_base { get; set; }
        internal int Factor { get; set; }
        internal string tipo = "Empleado";
        internal Empleado(string nombre, int dni, double sueldo_base, int factor)
        {
            Nombre = nombre;
            DNI = dni;
            Sueldo_base = sueldo_base;
            Factor = factor;
        }
        // Función base para aplicar poliformismo
        public virtual double sumarSueldoAdicional()
        {
            return Sueldo_base + (Factor * 1);
        }
    }
}
