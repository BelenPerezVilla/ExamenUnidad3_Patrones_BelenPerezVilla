using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCocina
{
    class RecetaEnchiladas : RecetaBase
    {
        public RecetaEnchiladas()
        {
            IngredientesBase.AddRange(new[] { "Tortillas", "Pollo", "Salsa verde", "Queso", "Crema" });
        }

        public override string Nombre => "Enchiladas Verdes";
        public override string Descripcion => "Deliciosas enchiladas bañadas en salsa verde con pollo y crema.";
        public override double Costo => 80;
    }
}
