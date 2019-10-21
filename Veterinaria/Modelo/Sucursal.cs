using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelo
    {
    class Sucursal
    {
        private string nombre;
        private Empleado supervisor;
        private Empleado supervisor_Suplente;

        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public Empleado Supervisor
        {
            set { this.supervisor = value; }
            get { return this.supervisor; }
        }

        public Empleado Supervisor_Suplente
        {
            set { this.supervisor_Suplente = value; }
            get { return this.supervisor_Suplente; }
        }
    }
}
