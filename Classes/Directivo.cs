using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados.Classes
{
    // Clase hija
    public class Directivo : Empleado
    {
        // Uso de internal para aplicar encapsulamiento
        internal Directivo(string nombre, int dni, double sueldo_base, int factor) : base(nombre, dni, sueldo_base, factor)
        {
            tipo = "Directivo";
        }
        // Función derivada con otro factor de bono
        public override double sumarSueldoAdicional()
        {
            return Sueldo_base + (Factor * 1.7f);
        }
    }
}
