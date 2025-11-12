using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCocina
{
    class RecetaHamburguesa : RecetaBase
    {
        public RecetaHamburguesa()
        {
            IngredientesBase.AddRange(new[] { "Pan", "Carne", "Lechuga", "Tomate", "Queso" });
        }

        public override string Nombre => "Hamburguesa Clásica";
        public override string Descripcion => "Hamburguesa tradicional con carne jugosa y vegetales frescos.";
        public override double Costo => 90;
    }
}
