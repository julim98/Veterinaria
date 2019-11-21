﻿using System;
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

        public void cargar_consulta(string historia_clinica, string id_sucursal, string tipo_doc, string nro_doc, string fecha_entrada)
        {
            string comando = "insert into consultas (nro_historia_clinica, id_sucursal, tipo_doc_empleado, nro_doc_empleado, fecha_entrada) values(" + historia_clinica
               + ", "+ id_sucursal + ", " + tipo_doc + ", " + nro_doc + ", " + fecha_entrada + ")";
            _BD.insertar(comando);
        }
        public void cargar_sintomas_consulta(string historia_clinica, string id_sucursal, string id_consulta, string id_sintoma)
        {
            string comando = "insert into sintomas_consulta (nro_historia_clinica, id_sucursal, id_consulta, id_sintoma) values(" + historia_clinica
               + ", " + id_sucursal + ", " + id_consulta + ", " + id_sintoma  + ")";
            _BD.insertar(comando);
        }

        public void cargar_diagnosticos_consulta(string historia_clinica, string id_sucursal, string id_consulta, string id_diagnostico)
        {
            string comando = "insert into diagnostico_consulta (nro_historia_clinica, id_sucursal, id_consulta, id_diagnostico) values(" + historia_clinica
               + ", " + id_sucursal + ", " + id_consulta + ", " + id_diagnostico + ")";
            _BD.insertar(comando);
        }

        public string obtener_id_consulta()
        {
            string a = _BD.ejecutar_consulta("select MAX(id_consulta) from consultas").Rows[0][0].ToString();
            if (a != null)
                return a;
            else
                return "0";
        }

        public void eliminar()
        {

        }

        public DataTable obtener_diagnosticos()
        {
            string comando = "select * from diagnosticos";
            return _BD.ejecutar_consulta(comando);
        }

        public DataTable obtener_sintomas()
        {
            string comando = "select * from sintomas";
            return _BD.ejecutar_consulta(comando);
        }

        public DataTable obtener_consultas()
        {
            string comando = "select S.nombre as sucursal, E.apellido as empleado, C.* from consultas C join empleados E on C.tipo_doc_empleado = E.tipo_doc AND C.nro_doc_empleado = E.nro_doc join sucursales S on C.id_sucursal = S.id_sucursal";
            return _BD.ejecutar_consulta(comando);
        }
    }
}
