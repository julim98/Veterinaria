using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelo
{
    class Consulta
    {
        private int nro_Historia_Clinica;
        private Sucursal sucursal;
        private Empleado empleado;
        private DateTime fecha_Hora_Entrada;
        private DateTime fecha_Hora_Salida;

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

        public Empleado Empleado
        {
            set { this.empleado = value; }
            get { return this.empleado; }
        }


        public DateTime Fecha_Hora_Entrada
        {
            set { this.fecha_Hora_Entrada = value; }
            get { return this.fecha_Hora_Entrada; }
        }

        public DateTime Fecha_Hora_Salida
        {
            set { this.fecha_Hora_Salida = value; }
            get { return this.fecha_Hora_Salida; }
        }
    }
}
