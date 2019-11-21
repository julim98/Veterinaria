using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Negocios
{
    class NG_Transaccion
    {

        Conexion_BD conexion { get; set; }

        public void transaccion_inicio()
        {
            conexion.inicio_transaccion();
        }

        public void transaccion_fin()
        {
            conexion.cerrar_transaccion();
        }

        public void transaccion_commit()
        {
            conexion.commit();
        }

        public void transaccion_rollback()
        {
            conexion.rollback();
        }

    }
}
