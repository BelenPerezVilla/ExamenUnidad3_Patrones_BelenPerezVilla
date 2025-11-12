using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCocina
{
    public abstract class RecetaBase : IReceta
    {
        public abstract string Nombre { get; }
        public abstract string Descripcion { get; }
        public abstract double Costo { get; }

        public List<string> IngredientesBase { get; protected set; } = new List<string>();
    }
}
