using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados.Classes
{
    // Clase hija
    public class Vendedor : Empleado
    {
        // Uso de internal para aplicar encapsulamiento
        internal Vendedor(string nombre, int dni, double sueldo_base) : base(nombre, dni, sueldo_base) { }
        // Función derivada con otro factor de comisión
        public override void sumarSueldoAdicional(int factor)
        {
            Sueldo_base += factor * 1.4f;
        }
    }
}
