using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad3
{
    class FachadaCocina : ICocina
    {
        private IRecetaComponent recetaSeleccionada;

        public void MostrarMenu()
        {
            Console.WriteLine("===============MENÚ DE RECETAS DISPONIBLES=========");
            Console.WriteLine("1. Chilaquiles Verdes - $65");
            Console.WriteLine("2. Pasta Alfredo - $80");
            Console.WriteLine("3. Tacos al Pastor - $50");
        }
        public void SeleccionarReceta(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    recetaSeleccionada = new RecetaChilaquiles();
                    break;
                case 2:
                    recetaSeleccionada = new RecetaPastaAlfredo();
                    break;
                case 3:
                    recetaSeleccionada = new RecetaTacosAlPastor();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }
            Console.WriteLine($"Receta seleccionada: {recetaSeleccionada.Descripcion}");

        }
        public void PersonalizarReceta()
        {
            if(recetaSeleccionada == null)
            {
                Console.WriteLine("Primero selecciona una receta");
                return;
            }
            Console.Write("¿Deseas agregar ingredientes extra? (s/n): ");
            if (Console.ReadLine().ToLower() == "s")
            {
                bool continuar = true;
                while (continuar)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("========================================================");
                    Console.WriteLine("            SELECCIONA UN INGREDIENTE PARA AGREGAR      ");
                    Console.WriteLine("========================================================");
                    Console.ResetColor();

                    Console.WriteLine("1. Extra Queso (+$10)");
                    Console.WriteLine("2. Aguacate (+$8)");
                    Console.WriteLine("3. Chile Verde (+$5)");
                    Console.WriteLine("4. Terminar personalización");
                    Console.WriteLine("--------------------------------------------------------");
                    Console.Write("Ingresa tu opción: ");

                    string opcion = Console.ReadLine();
                    switch (opcion)
                    {
                        case "1":
                            recetaSeleccionada = new IngredienteExtraQueso(recetaSeleccionada);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nSe agregó: Extra Queso (+$10)");
                            Console.ResetColor();
                            break;

                        case "2":
                            recetaSeleccionada = new IngredienteAguacate(recetaSeleccionada);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nSe agregó: Aguacate (+$8)");
                            Console.ResetColor();
                            break;

                        case "3":
                            recetaSeleccionada = new IngredienteChileVerde(recetaSeleccionada);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nSe agregó: Chile Verde (+$5)");
                            Console.ResetColor();
                            break;

                        case "4":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nFinalizando personalización...");
                            Console.ResetColor();
                            continuar = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nOpción no válida. Intenta nuevamente.");
                            Console.ResetColor();
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
        public void MostrarCuentaFinal()
        {
            Console.WriteLine($"\nPedido final: {recetaSeleccionada.Descripcion}");
            Console.WriteLine($"Total a pagar: ${recetaSeleccionada.Costo}");
            Console.WriteLine("Gracias por usar el simulador de cocina.");
        }
    }
}
