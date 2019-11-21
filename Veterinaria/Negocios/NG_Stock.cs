using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Veterinaria.Negocios
{
    class NG_Stock
    {

        Conexion_BD _BD = new Conexion_BD();

        public DataTable cargar_datos(string id_medicamento, string id_sucursal)
        {
            string comando = "select M.nombre_med as nombre, S.nombre as sucursal, MS.*" +
                "from medicamentos_sucursal MS " +
                "join medicamentos M on MS.id_medicamento = M.id_medicamento " +
                "join sucursales S on MS.id_sucursal = S.id_sucursal " +
                "where MS.id_medicamento = " +
                id_medicamento + " and MS.id_sucursal = " + id_sucursal;
            return _BD.ejecutar_consulta(comando);
        }

        public void modificar_stock(string id_medicamento, string id_sucursal, string stock_actual, string stock_minimo)
        {
            string sql = "update medicamentos_sucursal " +
                "set " +
                "stock_actual = " + stock_actual + ", " +
                "stock_minimo = " + stock_minimo + " " +
                "where id_medicamento = " + id_medicamento +
                " and id_sucursal = " + id_sucursal;
            _BD.modificar(sql);
        }
    }
}
