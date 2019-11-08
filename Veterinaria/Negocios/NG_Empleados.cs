using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria;
using System.Windows.Forms;
using System.Data;
using Veterinaria.Formularios;

namespace Veterinaria.Negocios
{
    class NG_Empleados
    {
        Conexion_BD _BD = new Conexion_BD();
        
        public void insertar(string nombre, string apellido, string tipo_doc, string nro_doc, string nacimiento, string ingreso, string matricula, string sucursal)
        {
            string sql_insert = @"insert into empleados (
                                tipo_doc, nro_doc, id_sucursal, nombre, apellido, 
                                fecha_nacimiento, fecha_ingreso, matricula)
                                values (" +
                                tipo_doc.ToString() + ", " +
                                nro_doc.ToString() + ", " +
                                sucursal.ToString() + ", '" +
                                nombre.ToString() + "', '" +
                                apellido.ToString() + "', '" +
                                nacimiento.ToString() + "', '" +
                                ingreso.ToString() + "', " +
                                matricula.ToString() +
                                ")";

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

        public DataTable tabla_empleados(string tipo_doc, string nro_doc)
        {
            string comando = "";

            if (nro_doc.Trim() == "")
            {
                comando = @"select E.apellido, E.nombre, D.nombre_tipo_doc as tipo_documento, D.id_tipo_documento,
                    E.nro_doc, E.matricula, E.fecha_nacimiento,S.nombre as sucursal,
                    E.fecha_ingreso
                    from empleados E 
                    join tipos_documentos D on E.tipo_doc = D.id_tipo_documento
                    join sucursales S on S.id_sucursal = E.id_sucursal
                    where E.tipo_doc = " + tipo_doc;
                return _BD.ejecutar_consulta(comando);
            }

            comando = @"select E.apellido, E.nombre, D.nombre_tipo_doc as tipo_documento, D.id_tipo_documento,
                E.nro_doc, E.matricula, E.fecha_nacimiento,S.nombre as sucursal,
                E.fecha_ingreso, D.id_tipo_documento
                from empleados E 
                join tipos_documentos D on E.tipo_doc = D.id_tipo_documento
                join sucursales S on S.id_sucursal = E.id_sucursal
                where E.nro_doc = " + nro_doc.Trim() + " and E.tipo_doc = " + tipo_doc;
            return _BD.ejecutar_consulta(comando);
        }

        public void modificar_empleado(string tipo_doc
                                    , string nro_doc
                                    , string id_sucursal
                                    , string nombre
                                    , string apellido
                                    , string fecha_nacimiento
                                    , string fecha_ingreso
                                    , string matricula
                                    , string tipo_doc_viejo
                                    , string nro_doc_viejo)
        {
            string sql_update = "";

            sql_update = @"UPDATE empleados
                           SET "
                           + "tipo_doc = '" + tipo_doc + "'"
                           + ", nro_doc = '" + nro_doc + "'"
                           + ", id_sucursal = '" + id_sucursal + "'"
                           + ", nombre = '" + nombre + "'"
                           + ", apellido = '" + apellido + "'"
                           + ", fecha_nacimiento = '" + fecha_nacimiento + "'"
                           + ",fecha_ingreso = '" + fecha_ingreso + "'"
                           + ",matricula = '" + matricula + "'"
                           + "WHERE tipo_doc=" + tipo_doc_viejo + "and nro_doc=" + nro_doc_viejo;
            if (_BD.modificar(sql_update) == Conexion_BD.estado_BE.correcto)
            {
                MessageBox.Show("Se grabó correctamente");
            }
            else
            {
                MessageBox.Show("No se grabó");
            }
        }
       public void borrar_empleado(string tipo_doc, string nro_doc)
            {


                string sql_borrar = "";

                sql_borrar = @"DELETE FROM empleados
                            WHERE tipo_doc=" + tipo_doc + "and nro_doc=" + nro_doc;

                if (_BD.borrar(sql_borrar) == Conexion_BD.estado_BE.correcto)
                {
                    MessageBox.Show("Se borró correctamente");
                }
                else
                {
                    MessageBox.Show("No se puedo borrar");
                }
            }
        public DataTable recuperar_datos_empleados(string tipo_doc, string nro_doc)
        {
            return _BD.ejecutar_consulta("SELECT * FROM empleados WHERE tipo_doc ="+ tipo_doc +"and nro_doc="+nro_doc);
        }
    }

    }

