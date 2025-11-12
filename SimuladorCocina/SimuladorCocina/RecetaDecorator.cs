using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCocina
{
    class RecetaDecorator : IReceta
    {
        protected IReceta receta;
        public RecetaDecorator(IReceta receta)
        {
            this.receta = receta;
        }

        public virtual string Nombre => receta.Nombre;
        public virtual string Descripcion => receta.Descripcion;
        public virtual double Costo => receta.Costo;
    }
}
