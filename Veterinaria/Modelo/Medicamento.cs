using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelo
{
    class Medicamento
    {
        private string nombre;
        private string descripcion;
        private Laboratorio laboratorio;
        private DateTime fecha_Ultima_Compra;

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

        public Laboratorio Laboratorio
        {
            set { this.laboratorio = value; }
            get { return this.laboratorio; }
        }

        public DateTime Fecha_Ultima_Compra
        {
            set { this.fecha_Ultima_Compra = value; }
            get { return this.fecha_Ultima_Compra; }
        }
    }
}
