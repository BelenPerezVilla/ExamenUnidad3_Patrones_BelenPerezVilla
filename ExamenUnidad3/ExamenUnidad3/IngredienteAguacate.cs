using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad3
{
   public class IngredienteAguacate : RecetaDecorator
    {
        public IngredienteAguacate(IRecetaComponent receta) : base(receta){}

        public override string Descripcion => receta.Descripcion + " + Aguacate";
        public override double Costo => receta.Costo + 8.0;

    }
}
