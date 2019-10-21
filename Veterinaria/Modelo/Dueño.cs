using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelo
{
    class Dueño
    {
        private string nombre;
        private string apellido;
        private int telefono;

        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public string Apellido
        {
            set { this.apellido = value; }
            get { return this.apellido; }
        }

        public int Telefono
        {
            set { this.telefono = value; }
            get { return this.telefono; }
        }
    }
}
