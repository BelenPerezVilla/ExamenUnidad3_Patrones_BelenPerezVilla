using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICocina cocina = new FachadaCocina();
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=======  BIENVENIDOS A FONDITA BELENCITA ========");
                Console.WriteLine("1. Ver menú y seleccionar receta");
                Console.WriteLine("2. Personalizar receta");
                Console.WriteLine("3. Mostrar cuenta final");
                Console.WriteLine("4. Salir");
                Console.WriteLine("=================================================");
                Console.Write("Selecciona una opción: ");
                string opcion = Console.ReadLine();

                Console.Clear();

                switch (opcion)
                {
                    case "1":
                        cocina.MostrarMenu();
                        Console.Write("Elige una receta (1-3): ");
                        if (int.TryParse(Console.ReadLine(), out int op))
                            cocina.SeleccionarReceta(op);
                        else
                            Console.WriteLine("Entrada inválida.");
                        break;

                    case "2":
                        cocina.PersonalizarReceta();
                        break;

                    case "3":
                        cocina.MostrarCuentaFinal();
                        break;

                    case "4":
                        salir = true;
                        Console.WriteLine("Saliendo del simulador...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                if (!salir)
                {
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
