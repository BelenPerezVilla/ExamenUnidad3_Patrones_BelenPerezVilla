using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad3
{
    public interface ICocina
    {
        void MostrarMenu();
        void SeleccionarReceta(int opcion);
        void PersonalizarReceta();
        void MostrarCuentaFinal();
    }
}
