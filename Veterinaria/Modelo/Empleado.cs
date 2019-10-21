using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelo
{
    class Empleado
    {
        private string tipo_Doc;
        private int nro_Doc;
        private string nombre;
        private string apellido;
        private DateTime fecha_Nacimiento;
        private DateTime fecha_Ingreso;
        private int matricula;
        private Sucursal sucursal;

        public string Tipo_Doc
        {
            set { this.tipo_Doc = value; }
            get { return this.tipo_Doc; }
        }

        public int Nro_Doc
        {
            set { this.nro_Doc = value; }
            get { return this.nro_Doc; }
        }

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

        public DateTime Fecha_Nacimiento
        {
            set { this.fecha_Nacimiento = value; }
            get { return this.fecha_Nacimiento; }
        }

        public DateTime Fecha_Ingreso
        {
            set { this.fecha_Ingreso = value; }
            get { return this.fecha_Ingreso; }
        }

        public int Matricula
        {
            set { this.matricula = value; }
            get { return this.matricula; }
        }

        public Sucursal Sucursal
        {
            set { this.sucursal = value; }
            get { return this.sucursal; }
        }
    }
}
