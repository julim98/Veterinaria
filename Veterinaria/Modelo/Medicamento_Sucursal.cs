using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Modelo
{
    class Medicamento_Sucursal
    {
        private Medicamento medicamento;
        private Sucursal sucursal;
        private int stock_Actual;
        private int stock_Minimo;

        public Medicamento Medicamento
        {
            set { this.medicamento = value; }
            get { return this.medicamento; }
        }

        public Sucursal Sucursal
        {
            set { this.sucursal = value; }
            get { return this.sucursal; }
        }

        public int Stock_Actual
        {
            set { this.stock_Actual = value; }
            get { return this.stock_Actual; }
        }

        public int Stock_Minimo
        {
            set { this.stock_Minimo = value; }
            get { return this.stock_Minimo; }
        }
    }
}
