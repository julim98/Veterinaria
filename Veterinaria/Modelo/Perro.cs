using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelo
{
    class Perro
    {
        private int nro_Historia_Clinica;
        private string nombre;
        private DateTime fecha_Nacimiento;
        private Raza raza;
        private double peso;
        private double altura;
        private Dueño dueño;

        public int Nro_Historia_Clinica
        {
            set { this.nro_Historia_Clinica = value; }
            get { return this.nro_Historia_Clinica; }
        }

        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public DateTime Fecha_Nacimiento
        {
            set { this.fecha_Nacimiento = value; }
            get { return this.fecha_Nacimiento; }
        }

        public Raza Raza
        {
            set { this.raza = value; }
            get { return this.raza; }
        }

        public double Peso
        {
            set { this.peso = value; }
            get { return this.peso; }
        }

        public double Altura
        {
            set { this.altura = value; }
            get { return this.altura; }
        }

        public Dueño Dueño
        {
            set { this.dueño = value; }
            get { return this.dueño; }
        }
    }
}
