using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCocina
{
    public class RecetaSopaVerduras:RecetaBase
    {
        public RecetaSopaVerduras()
        {
            IngredientesBase.AddRange(new[] { "Zanahoria", "Papa", "Calabaza", "Agua", "Sal" });
        }

        public override string Nombre => "Sopa de Verduras";
        public override string Descripcion => "Sopa ligera con verduras cocidas en caldo natural.";
        public override double Costo => 50;
    }
}
