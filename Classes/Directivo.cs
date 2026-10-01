using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados.Classes
{
    // Clase hija
    public class Directivo : Empleado
    {
        // Uso de internal para aplicar encapsulamiento
        internal Directivo(string nombre, int dni, double sueldo_base) : base(nombre, dni, sueldo_base) { }
        // Función derivada con otro factor de bono
        public override void sumarSueldoAdicional(int factor)
        {
            Sueldo_base += factor * 1.7f;
        }
    }
}
