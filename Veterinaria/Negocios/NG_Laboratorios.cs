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

        public void guardar_laboratorio(string nombre, string razon_social, string direccion)
        {

            string sql = "insert into laboratorios (nombre_lab, razon_social, direccion) " +
            "values('" + nombre + "', '"+ razon_social + "', '" + direccion + "')";
            try
            {
                _BD.insertar(sql);
                MessageBox.Show("Se guardó correctamente");
            }
            catch(Exception)
            {
                MessageBox.Show("No se pudo guardar correctamente");
            }

        }
        public void modificar_laboratorio(string nombre, string razon_social, string direccion, string id)
        {
            string sql = "update laboratorios set nombre_lab = '" + nombre + "', razon_social = '" + razon_social + "', direccion = '" + direccion + "' where id_laboratorio " + id;
            try
            {
                _BD.insertar(sql);
                MessageBox.Show("Se modificó correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo modificar correctamente");
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
            string sql = "delete from laboratorios where id_laboratorio = " + id_lab;
            try
            {
                _BD.insertar(sql);
                MessageBox.Show("Se borró correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo borrar correctamente");
            }
        }

        public DataTable obtener_laboratorio(string id_lab)
        {
            string sql = "select * from laboratorios where id_laboratorio = " + id_lab;
            return _BD.ejecutar_consulta(sql);
        }
    }
}
