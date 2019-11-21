using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Clases;
using System.Data;
using System.Windows.Forms;

namespace Veterinaria.Negocios
{
    class NG_Diagnosticos
    {

        Conexion_BD _BD = new Conexion_BD();

        public void registrar(string descripcion)
        {
            string comando = "insert into diagnosticos (descripcion) " +
                "values ('" + descripcion +
                "')";
            if (_BD.insertar(comando) == Conexion_BD.estado_BE.correcto)
            {
                MessageBox.Show("Se cargó correctamente");
            }
        }

        public void modificar(string pk, string descripcion)
        {
            string comando = "update diagnosticos set descripcion = '" + descripcion + 
                "' where id_diagnostico = " + pk;

            if (_BD.modificar(comando) == Conexion_BD.estado_BE.correcto)
                MessageBox.Show("Se modificó correctamente");
        }

        public void borrar(string pk)
        {
            string comando = "delete from diagnosticos where id_diagnostico = " + pk;

            if(_BD.borrar(comando) == Conexion_BD.estado_BE.correcto)
                MessageBox.Show("Se borró correctamente");
        }

        public DataTable recuperar_diagnostico(string pk)
        {
            string comando = "select * from diagnosticos where id_diagnostico = " + pk;
            return _BD.ejecutar_consulta(comando);
        }

        public DataTable buscar_diagnosticos(string nombre)
        { 
            string comando = "select * from diagnosticos";

            if (nombre != "")
                comando += " where descripcion like '%" + nombre + "%'";

            return _BD.ejecutar_consulta(comando);
        }
    }
}
