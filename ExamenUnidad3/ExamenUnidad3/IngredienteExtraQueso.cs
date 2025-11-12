using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad3
{
    class IngredienteExtraQueso : RecetaDecorator
    {
        public IngredienteExtraQueso(IRecetaComponent receta): base(receta) { }
        public override string Descripcion => receta.Descripcion + " + Extra Queso";
        public override double Costo => receta.Costo + 10.0;
    }
}
