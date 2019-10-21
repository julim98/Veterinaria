using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelo
{
    class Diagnostico
    {
        private string nombre;
        private string descripcion;

        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public string Descripcion
        {
            set { this.descripcion = value; }
            get { return this.descripcion; }
        }
    }
}
