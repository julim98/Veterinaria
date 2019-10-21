using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelo
{
    class Laboratorio
    {
        private string razon_Social;
        private string direccion;

        public string Razon_Social
        {
            set { this.razon_Social = value; }
            get { return this.razon_Social; }
        }

        public string Direccion
        {
            set { this.direccion = value; }
            get { return this.direccion; }
        }
    }
}
