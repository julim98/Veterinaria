using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelo
{
    class Diagnostico_Consulta
    {
        private int nro_Historia_Clinica;
        private Sucursal sucursal;
        private Consulta consulta;
        private Diagnostico diagnostico;

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

        public Consulta Consulta
        {
            set { this.consulta = value; }
            get { return this.consulta; }
        }

        public Diagnostico Diagnostico
        {
            set { this.diagnostico = value; }
            get { return this.diagnostico; }
        }
    }
}
