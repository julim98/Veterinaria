using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Veterinaria;
using Veterinaria.Clases;

namespace Veterinaria.Negocios
{
    public class NG_Perros

    {
        Conexion_BD _BD = new Conexion_BD();

        public void Insertar(
            string nro_historia_clinica,
            string id_sucursal,
            string id_raza,
            string id_dueño,
            string nombre,
            string fecha_nacimiento,
            string peso,
            string altura)
        {
            string sql_insert = "";
            sql_insert = "INSERT INTO perros (id_sucursal, id_raza, id_dueño, nombre, fecha_nacimiento, peso, altura) "
                + "VALUES ("
                + "'"+ id_sucursal + "',"
                + "'"+ id_raza + "',"
                + "'" + id_dueño + "', "
                + "'"+ nombre +"',"
                + "'" + fecha_nacimiento + "', "
                + "'" + peso + "', "
                + "'" + altura + "')";

            if (_BD.insertar(sql_insert) ==
               Conexion_BD.estado_BE.correcto)
            {
                MessageBox.Show("Se cargó correctamente los datos");
            }
            else
            {
                MessageBox.Show("No se cargó correctamente los datos");
            }

        } 
        public void modificar(string id_sucursal
                                   , string id_raza
                                   , string id_dueño
                                   , string nombre
                                   , string fecha_nacimiento
                                   , string peso
                                   , string altura
                                   , string nro_historia_clin)
            {
                string sql_update = "";

                sql_update = @"UPDATE perros
                           SET "
                               + "id_sucursal = '" + id_sucursal + "'"
                               + ", id_raza = '" + id_raza + "'"
                               + ", id_dueño = '" + id_dueño+ "'"
                               + ", nombre = '" + nombre + "'"
                               + ", fecha_nacimiento = '" + fecha_nacimiento + "'"
                               + ", peso = '"+ peso + "'"
                               + ",altura = '"+ altura + "'"
                               + "WHERE nro_historia_clinica = " + nro_historia_clin;
                if (_BD.modificar(sql_update) == Conexion_BD.estado_BE.correcto)
                {
                    MessageBox.Show("Se grabó correctamente");
                }
                else
                {
                    MessageBox.Show("No se grabó");
                }
        }
        public void borrar(string nro_historia_clinica)
            {


                string sql_borrar = "";

                sql_borrar = @"DELETE FROM perros
                            WHERE nro_historia_clinica = " + nro_historia_clinica;

                if (_BD.borrar(sql_borrar) == Conexion_BD.estado_BE.correcto)
                {
                    MessageBox.Show("Se borró correctamente");
                }
                else
                {
                    MessageBox.Show("No se puedo borrar");
                }
            }
        public DataTable consultar_x_dueño(string dueño)
        {
            string sql = @"SELECT perros.* 
                             FROM perros join dueños ON perros.id_dueño = dueños.id_dueño 
                             WHERE dueños.apellido like '%" + dueño + "%'";
            return _BD.ejecutar_consulta(sql);
        }
        public DataTable consultar_x_nombre(string nombre)
        {
            string sql = @"SELECT *
                             FROM perros
                             WHERE perros.nombre like '%" + nombre + "%'";
            return _BD.ejecutar_consulta(sql);
        }
        public DataTable consultar_x_todos()
        {
            string sql = @"SELECT *
                             FROM perros";
            return _BD.ejecutar_consulta(sql);
        }

        public DataTable consultar_x_dueño_nombre(string dueño, string nombre)
        {
            string sql = @"SELECT *
                             FROM perros JOIN dueños ON perros.id_dueño = dueños.id_dueño
                             WHERE dueños.apellido like '%" + dueño + "%' AND perros.nombre like '%" + nombre + "%'";
            return _BD.ejecutar_consulta(sql);
        }
        public DataTable recuperar_datos_x_nro(string nro)
        {
            return _BD.ejecutar_consulta("SELECT * FROM perros WHERE nro_historia_clinica=" + nro);
        }
        public int max_nro_hc()
        {
            string sql = "";
            DataTable max = new DataTable();

            sql = "SELECT MAX(nro_historia_clinica)  FROM perros";
            max = _BD.ejecutar_consulta(sql);
            if (max.IsInitialized)
                return 0;
            return int.Parse(max.Rows[0][0].ToString());
        }
        public void transaccion_inicio()
        {
            _BD.inicio_transaccion();
        }

        public void transaccion_fin()
        {
            _BD.cerrar_transaccion();
        }

        public void transaccion_commit()
        {
            _BD.commit();
        }

        public void transaccion_rollback()
        {
            _BD.rollback();
        }

        public void Insertar_Dueño(string nombre, string apellido, string telefono)
        {
            string sql = "";
            sql = "INSERT INTO dueños(nombre, apellido, telefono) "
                + "VALUES ('" + nombre + "', '" + apellido + "', '"
                + telefono + "')";

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

        public void Insertar_Raza(string denominacion,
                            
                            string nota_cuidados)
        {
            string sql = "";

            sql = @"INSERT INTO razas(denominacion, nota_cuidados)"
                    + "VALUES ('" + denominacion + "', '"
                    + nota_cuidados + "')";

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

        public void CargarCombo(ref ComboBox combo, string nombreTabla, string descripcion, string pk)
        {
            if (no_hay_datos(nombreTabla))
                return;

            try
            {
                string consulta = "SELECT * FROM " + nombreTabla;
                combo.DataSource = _BD.ejecutar_consulta(consulta);
                combo.DisplayMember = descripcion;
                combo.ValueMember = pk;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar " + combo.Name + ", CargarCombo");
            }
        }

        public void CargarCombo(ref ComboBox combo, string nombreTabla, string descripcion, string pk, string datos_obligatorios)
        {
            if (no_hay_datos(nombreTabla))
            {
                MessageBox.Show("No existen " + datos_obligatorios);
                return;
            }

            try
            {
                string consulta = "SELECT * FROM " + nombreTabla;
                combo.DataSource = _BD.ejecutar_consulta(consulta);
                combo.DisplayMember = descripcion;
                combo.ValueMember = pk;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar " + combo.Name + ", CargarCombo");
            }
        }
        bool no_hay_datos(string tabla)
        {
            string sql = "select * from " + tabla;
            if (_BD.ejecutar_consulta(sql).Rows.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
    

    

