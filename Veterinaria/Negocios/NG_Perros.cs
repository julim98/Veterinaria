﻿using System;
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
    class NG_Perros

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
    }
}
    

    

