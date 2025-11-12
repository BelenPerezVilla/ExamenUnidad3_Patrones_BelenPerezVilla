using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCocina
{
    public interface ICocina
    {
        void MostrarMenu();
        void SeleccionarReceta(int opcion);
        void PersonalizarReceta();
        void MostrarRecetarioFinal();
    }
}
