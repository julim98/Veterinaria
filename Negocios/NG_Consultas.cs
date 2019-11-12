using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Veterinaria.Negocios
{
    class NG_Consultas
    {
        Conexion_BD _BD = new Conexion_BD();

        public void cargar()
        {

        }

        public void eliminar()
        {

        }

        public DataTable obtener_diagnosticos()
        {
            string comando = "select * from diagnosticos";
            return _BD.ejecutar_consulta(comando);
        }

        public DataTable obtener_diagnosticos_consulta(string historia_clinica, string id_sucursal)
        {
            string comando = "select id_diagnostico from diagnostico_consulta where nro_historia_clinica = " + historia_clinica +
                " AND id_sucursal = " + id_sucursal;
            return _BD.ejecutar_consulta(comando);
        }

    }
}
