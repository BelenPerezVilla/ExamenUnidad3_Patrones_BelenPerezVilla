using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCocina
{
    class IngredienteExtra : RecetaDecorator
    {
        private string ingrediente;
        private double precio;

        public IngredienteExtra(IReceta receta, string ingrediente, double precio)
            : base(receta)
        {
            this.ingrediente = ingrediente;
            this.precio = precio;
        }

        public override string Nombre => receta.Nombre + " + " + ingrediente;
        public override string Descripcion => receta.Descripcion + $" (agregado: {ingrediente})";
        public override double Costo => receta.Costo + precio;
    }
}
