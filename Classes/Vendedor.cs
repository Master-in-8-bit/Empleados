using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados.Classes
{
    // Clase hija
    public class Vendedor : Empleado
    {
        // Uso de internal para aplicar encapsulamiento
        internal Vendedor(string nombre, int dni, double sueldo_base, int factor) : base(nombre, dni, sueldo_base, factor)
        {
            tipo = "Vendedor";
        }
        // Función derivada con otro factor de comisión
        public override double sumarSueldoAdicional()
        {
            return Sueldo_base + (Factor * 1.4f);
        }
    }
}
