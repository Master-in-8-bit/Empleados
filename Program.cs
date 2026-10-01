using Empleados.Classes;
namespace Empleados
{
    internal class Program
    {
        static List<Empleado> listaEmpleados = new List<Empleado>();
        static void Main(string[] args)
        {
            bool notexit = true;
            while (notexit)
            {
                Console.WriteLine();
                Console.WriteLine("Qué desea hacer?");
                Console.WriteLine("\t1 - Agregar empleados");
                Console.WriteLine("\t2 - Modificar empleado");
                Console.WriteLine("\t3 - Eliminar empleado");
                Console.WriteLine("\t4 - Mostrar sueldos adicionales");
                Console.WriteLine("\t5 - Salir");
                Console.Write("? = ");
                int op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Ingresar();
                        break;
                    case 2:
                        Calcular();
                        break;
                    case 3:
                        Reiniciar();
                        break;
                    case 4:
                        notexit = false;
                        break;
                    default:
                        Console.WriteLine("Esa no es una opción dentro de la lista, presione cualquier tecla para volver a elegir");
                        Console.ReadKey();
                        break;

                }
                Console.Clear();
            }
        }
        static void Ingresar()
        {
            string nombre;
            int dni;
            int op;
            bool tipo;
            double sueldo_base;
            Console.WriteLine("Ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el DNI del empleado");
            dni = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Ingrese el tipo de empleado");
                Console.WriteLine("\t1 - Vendedor");
                Console.WriteLine("\t2 - Directivo");
                op = Convert.ToInt32(Console.ReadLine());
                tipo = op == 1 ? true : false;
            } while (op != 1 && op != 2);
            Console.WriteLine("Ingrese el sueldo base del empleado");
            sueldo_base = Convert.ToDouble(Console.ReadLine());
            if (tipo)
            {
                listaEmpleados.Add(new Vendedor(nombre, dni, sueldo_base));
            }
            else
            {
                listaEmpleados.Add(new Directivo(nombre, dni, sueldo_base));
            }
        }
        static void Calcular()
        {
            foreach (var empleado in listaEmpleados)
            {
                empleado.sumarSueldoAdicional()
            }
        }
        static void Reiniciar()
        {

        }
    }
}
