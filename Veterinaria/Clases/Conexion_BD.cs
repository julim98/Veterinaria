using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Veterinaria.ConexionDB
{
    class Conexion_BD
    {
        public enum estado_BE { correcto, error }
        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        static string cadena_conexion = "Provider=SQLNCLI11;Data Source=DESKTOP-K8CJ3KA;Integrated Security=SSPI;Initial Catalog=_BD_VETERINARIA2";

        private void conectar()
        {
            conexion.ConnectionString = cadena_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
        }
        private void desconectar()
        {
            conexion.Close();
        }
        public DataTable ejecutar_consulta(string sql)
        {
            conectar();
            DataTable tabla = new DataTable();
            cmd.CommandText = sql;
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;
        }
        public estado_BE insertar(string sql)
        {
            this.conectar();
            this.cmd.CommandText = sql;
            this.cmd.ExecuteNonQuery();
            this.desconectar();
            return estado_BE.correcto;
        }
        public estado_BE modificar(string sql)
        {
            this.conectar();
            this.cmd.CommandText = sql;
            this.cmd.ExecuteNonQuery();
            this.desconectar();
            return estado_BE.correcto;
        }
        public estado_BE borrar(string sql)
        {
            this.conectar();
            this.cmd.CommandText = sql;
            this.cmd.ExecuteNonQuery();
            this.desconectar();
            return estado_BE.correcto;
        }
    }
}
