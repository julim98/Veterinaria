using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelo
{
    class Raza
    {
        private string nombre;
        private string denominacion;
        private double peso_Minimo_Hembra;
        private double peso_Minimo_Macho;
        private double altura_Media_Hembra;
        private double altura_Media_Macho;
        private string nota_Cuidados;

        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public string Denominacion
        {
            set { this.denominacion = value; }
            get { return this.denominacion; }
        }

        public double Peso_Minimo_Hembra
        {
            set { this.peso_Minimo_Hembra = value; }
            get { return this.peso_Minimo_Hembra; }
        }

        public double Peso_Minimo_Macho
        {
            set { this.peso_Minimo_Macho = value; }
            get { return this.peso_Minimo_Macho; }
        }

        public double Altura_Media_Hembra
        {
            set { this.altura_Media_Hembra = value; }
            get { return this.altura_Media_Hembra; }
        }

        public double Altura_Media_Macho
        {
            set { this.altura_Media_Macho = value; }
            get { return this.altura_Media_Macho; }
        }

        public string Nota_Cuidados
        {
            set { this.nota_Cuidados = value; }
            get { return this.nota_Cuidados; }
        }
    }
}
