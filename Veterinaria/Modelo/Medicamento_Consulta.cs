using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelo
{
    class Medicamento_Consulta
    {
        private int nro_Historia_Clinica;
        private Sucursal sucursal;
        private Consulta consulta;
        private Medicamento medicamento;
        private string dosis;
        private string periocidad;

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

        public Medicamento Medicamento
        {
            set { this.medicamento = value; }
            get { return this.medicamento; }
        }

        public string Dosis
        {
            set { this.dosis = value; }
            get { return this.dosis; }
        } 

        public string Periocidad
        {
            set { this.periocidad = value; }
            get { return this.periocidad; }
        }
    }
}
