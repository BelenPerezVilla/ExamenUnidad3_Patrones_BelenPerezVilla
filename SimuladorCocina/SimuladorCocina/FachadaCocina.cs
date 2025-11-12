using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCocina
{
    public class FachadaCocina : ICocina
    {
        private IReceta recetaSeleccionada;
        private RecetaBase recetaBase;

        public void MostrarMenu()
        {
            Console.WriteLine("============== MENÚ DE RECETAS DISPONIBLES =============");
            Console.WriteLine("1. Enchiladas Verdes - $80");
            Console.WriteLine("2. Hamburguesa Clásica - $90");
            Console.WriteLine("3. Sopa de Verduras - $50");
            Console.WriteLine("========================================================");
        }

        public void SeleccionarReceta(int opcion)
        {
            switch (opcion)
            {
                case 1: recetaBase = new RecetaEnchiladas(); break;
                case 2: recetaBase = new RecetaHamburguesa(); break;
                case 3: recetaBase = new RecetaSopaVerduras(); break;
                default:
                    Console.WriteLine("Opción no válida."); return;
            }

            recetaSeleccionada = recetaBase;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nReceta seleccionada: {recetaBase.Nombre}");
            Console.WriteLine($"Descripción: {recetaBase.Descripcion}");
            Console.ResetColor();
        }

        public void PersonalizarReceta()
        {
            if (recetaSeleccionada == null)
            {
                Console.WriteLine("Primero selecciona una receta.");
                return;
            }

            Console.Write("\n¿Deseas agregar ingredientes extra? (s/n): ");
            if (Console.ReadLine()?.ToLower() == "s")
            {
                bool continuar = true;
                while (continuar)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=========== INGREDIENTES RECOMENDADOS ===========");
                    Console.ResetColor();
                    Console.WriteLine("1. Queso Extra (+$10)");
                    Console.WriteLine("2. Aguacate (+$8)");
                    Console.WriteLine("3. Chile Verde (+$5)");
                    Console.WriteLine("4. Otro ingrediente personalizado");
                    Console.WriteLine("5. Terminar personalización");
                    Console.Write("Elige una opción: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            recetaSeleccionada = new IngredienteExtra(recetaSeleccionada, "Queso Extra", 10);
                            break;
                        case "2":
                            recetaSeleccionada = new IngredienteExtra(recetaSeleccionada, "Aguacate", 8);
                            break;
                        case "3":
                            recetaSeleccionada = new IngredienteExtra(recetaSeleccionada, "Chile Verde", 5);
                            break;
                        case "4":
                            Console.Write("Escribe el nombre del nuevo ingrediente: ");
                            string nuevoIng = Console.ReadLine();
                            Console.Write("Precio aproximado: $");
                            if (double.TryParse(Console.ReadLine(), out double precio))
                            {
                                recetaSeleccionada = new IngredienteExtra(recetaSeleccionada, nuevoIng, precio);
                                Console.WriteLine($"Se agregó: {nuevoIng} (+${precio})");
                            }
                            else
                                Console.WriteLine("Precio inválido.");
                            break;
                        case "5":
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }

                    if (continuar)
                    {
                        Console.WriteLine("\nPresiona una tecla para continuar...");
                        Console.ReadKey();
                    }
                }
            }
        }

        public void MostrarRecetarioFinal()
        {
            if (recetaSeleccionada == null)
            {
                Console.WriteLine("⚠No hay receta seleccionada.");
                return;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("================= RECETARIO FINAL =================");
            Console.ResetColor();
            Console.WriteLine($"Receta: {recetaBase.Nombre}");
            Console.WriteLine($"Ingredientes base: {string.Join(", ", recetaBase.IngredientesBase)}");
            Console.WriteLine($"Ingredientes agregados: {recetaSeleccionada.Nombre.Replace(recetaBase.Nombre, "").Trim()}");
            Console.WriteLine($"Precio total: ${recetaSeleccionada.Costo}");
            Console.WriteLine("====================================================");
        }
    }
}
