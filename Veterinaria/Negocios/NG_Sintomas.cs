using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Veterinaria.Negocios
{
    class NG_Sintomas
    {
        Conexion_BD _BD = new Conexion_BD();

        public void registrar(string descripcion)
        {
            string comando = "insert into sintomas (descripcion) " +
                "values ('" + descripcion +
                "')";
            if (_BD.insertar(comando) == Conexion_BD.estado_BE.correcto)
            {
                MessageBox.Show("Se cargó correctamente");
            }
        }

        public void modificar(string pk, string descripcion)
        {
            string comando = "update sintomas set descripcion = '" + descripcion +
                "' where id_sintoma = " + pk;

            if (_BD.modificar(comando) == Conexion_BD.estado_BE.correcto)
                MessageBox.Show("Se modificó correctamente");
        }

        public void borrar(string pk)
        {
            string comando = "delete from sintomas where id_sintoma = " + pk;

            if (_BD.borrar(comando) == Conexion_BD.estado_BE.correcto)
                MessageBox.Show("Se borró correctamente");
        }

        public DataTable recuperar_sintoma(string pk)
        {
            string comando = "select * from sintomas where id_sintoma = " + pk;
            return _BD.ejecutar_consulta(comando);
        }

        public DataTable buscar_sintomas(string nombre)
        {
            string comando = "select * from sintomas";

            if (nombre != "")
                comando += " where descripcion like '%" + nombre + "%'";

            return _BD.ejecutar_consulta(comando);
        }
    }
}
