using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCocina
{
    public interface IReceta
    {
        string Nombre {  get; }
        string Descripcion { get; }
        double Costo {  get; }
    }
}
