using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad3
{
    class IngredienteChileVerde : RecetaDecorator
    {
        public IngredienteChileVerde(IRecetaComponent receta) : base(receta)
        {
        }

        public override string Descripcion => receta.Descripcion + " + Chile Verde";
        public override double Costo => receta.Costo + 5.0;
    }
}
