using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad3
{
   public abstract class RecetaBase : IRecetaComponent
    {
        public abstract string Descripcion {  get; }
        public abstract double Costo { get; }
    }
}
