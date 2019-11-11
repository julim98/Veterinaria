using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Veterinaria.Negocios
{
    class NG_Laboratorios
    {
        Conexion_BD _BD = new Conexion_BD();

        public void guardar_laboratorio(string razon_social, string direccion)
        {

            string sql = "insert into laboratorios (razon_social, direccion) " +
            "values('" + razon_social + "', '" + direccion + "')";
            if (_BD.insertar(sql) ==
               Conexion_BD.estado_BE.correcto)
            {
                MessageBox.Show("Se cargó correctamente los datos");
            }
            else
            {
                MessageBox.Show("No se cargó correctamente los datos");
            }

        }
        public void modificar_laboratorio(string razon_social, string direccion, string id)
        {
            string sql = "update laboratorios set razon_social = '" + razon_social + "', direccion = '" + direccion + "' where id_laboratorio = " + id;
            if (_BD.modificar(sql) ==
                Conexion_BD.estado_BE.correcto)
            {
                MessageBox.Show("Se cargó correctamente los datos");
            }
            else
            {
                MessageBox.Show("No se cargó correctamente los datos");
            }

        }

        public DataTable obtener_datos_tabla()
        {
            string sql = "select * from laboratorios";
            return _BD.ejecutar_consulta(sql);
        }

        public DataTable obtener_datos_tabla(string nombre)
        {
            string sql = "select * from laboratorios where nombre_lab like '%" + nombre + "%'";
            return _BD.ejecutar_consulta(sql);
        }

        public void borrar_laboratorio(string id_lab)
        {
            string sql = "update medicamentos set id_laboratorio = null where id_laboratorio = " + id_lab + "; \n" +
                "delete from laboratorios where id_laboratorio = " + id_lab;
            if (_BD.borrar(sql) ==
               Conexion_BD.estado_BE.correcto)
            {
                MessageBox.Show("Se cargó correctamente los datos");
            }
        }

        public DataTable obtener_laboratorio(string id_lab)
        {
            string sql = "select * from laboratorios where id_laboratorio = " + id_lab;
            return _BD.ejecutar_consulta(sql);
        }
    }
}
