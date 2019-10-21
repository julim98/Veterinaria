using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria;
using System.Windows.Forms;
using System.Data;

namespace Veterinaria.Negocios
{
    class NG_Empleados
    {
        public void insertar(string nombre, string apellido, string tipo_doc, string nro_doc, string nacimiento, string ingreso, string matricula, string sucursal)
        {
            string sql_insert = @"insert into empleados (
                                tipo_doc, nro_doc, id_sucursal, nombre, apellido, 
                                fecha_nacimiento, fecha_ingreso, matricula)
                                values (" +
                                tipo_doc.ToString() + ", " +
                                nro_doc.ToString() + ", " +
                                sucursal.ToString() + ", '" +
                                nombre.ToString() + "', " +
                                apellido.ToString() + "', '" +
                                nacimiento.ToString() + "', '" +
                                ingreso.ToString() + "', " +
                                matricula.ToString() +
                                ")";

            Conexion_BD _BD = new Conexion_BD();
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
            Conexion_BD _BD = new Conexion_BD();

            if (nro_doc.Trim() == "")
            {
                comando = @"select E.apellido, E.nombre, D.nombre as tipo_documento, 
                    E.nro_doc, E.matricula, E.fecha_nacimiento,S.nombre as sucursal,
                    E.fecha_ingreso
                    from empleados E 
                    join tipo_documento D on E.tipo_doc = D.id_tipo_documento
                    join sucursales S on S.id_sucursal = E.id_sucursal";
                return _BD.ejecutar_consulta(comando);
            }

            comando = @"select E.apellido, E.nombre, D.nombre as tipo_documento, 
                E.nro_doc, E.matricula, E.fecha_nacimiento,S.nombre as sucursal,
                E.fecha_ingreso
                from empleados E 
                join tipo_documento D on E.tipo_doc = D.id_tipo_documento
                join sucursales S on S.id_sucursal = E.id_sucursal
                where E.nro_doc = " + nro_doc.Trim() + " and E.tipo_doc = " + tipo_doc;
            return _BD.ejecutar_consulta(comando);
        }
        public DataTable datos_combo()
        {
            Conexion_BD _BD = new Conexion_BD();
            return _BD.ejecutar_consulta("select * from tipo_documento");
        }
    }
}
