using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad3
{
   public abstract class RecetaDecorator: IRecetaComponent
    {
        protected IRecetaComponent receta;

        public RecetaDecorator(IRecetaComponent receta)
        {
            this.receta = receta;
        }
        public virtual string Descripcion => receta.Descripcion;
        public virtual double Costo => receta.Costo;
    }
}
