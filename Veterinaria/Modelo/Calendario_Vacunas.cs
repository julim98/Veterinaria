using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelo
{
    class Calendario_Vacunas
    {
        private int nro_Historia_Clinica;
        private Sucursal sucursal;
        private Vacuna vacuna;
        private DateTime fecha_Prevista;
        private DateTime fecha_Real;
        private Laboratorio laboratorio;
        private string dosis;
        private Empleado empleado;

        public int Nro_Historia_Clinica
        {
            set { this.nro_Historia_Clinica = value; }
            get { return this.nro_Historia_Clinica; }
        }

        public Sucursal Sucursal
        {
            set { this.sucursal = value; }
            get { return this.sucursal; }
        }

        public Vacuna Vacuna
        {
            set { this.vacuna = value; }
            get { return this.vacuna; }
        }

        public DateTime Fecha_Prevista
        {
            set { this.fecha_Prevista = value; }
            get { return this.fecha_Prevista; }
        }

        public DateTime Fecha_Real
        {
            set { this.fecha_Real = value; }
            get { return this.fecha_Real; }
        }

        public Laboratorio Laboratorio
        {
            set { this.laboratorio = value; }
            get { return this.laboratorio; }
        }

        public string Dosis
        {
            set { this.dosis = value; }
            get { return this.dosis; }
        }

        public Empleado Empleado
        {
            set { this.empleado = value; }
            get { return this.empleado; }
        }
    }      
}
