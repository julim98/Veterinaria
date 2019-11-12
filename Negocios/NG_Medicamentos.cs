using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Veterinaria.Negocios
{
    class NG_Medicamentos
    {
        Conexion_BD _BD = new Conexion_BD();

        public void cargarTabla(ref DataGridView tabla, string nombreMedicamento, string sucursal)
        {
            tabla.Rows.Clear();
            string consulta = "select * " +
                    "from medicamentos M " +
                    "join laboratorios L  on M.id_laboratorio = L.id_laboratorio " +
                    "join medicamentos_sucursal MS on MS.id_medicamento = M.id_medicamento " +
                    "AND MS.id_sucursal = " + sucursal;

            if (nombreMedicamento.Trim() != "")
                consulta = consulta + " where M.nombre_med like '%" + nombreMedicamento + "%'";

            DataTable datos = _BD.ejecutar_consulta(consulta);
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                tabla.Rows.Add();
                tabla.Rows[i].Cells[0].Value = datos.Rows[i]["nombre_med"];
                tabla.Rows[i].Cells[1].Value = datos.Rows[i]["descripcion"];
                tabla.Rows[i].Cells[2].Value = datos.Rows[i]["razon_social"];
                tabla.Rows[i].Cells[3].Value = datos.Rows[i]["stock_minimo"];
                tabla.Rows[i].Cells[4].Value = datos.Rows[i]["stock_actual"];
                tabla.Rows[i].Cells[5].Value = "-";
                tabla.Rows[i].Cells[6].Value = datos.Rows[i]["id_medicamento"];
            }
        }

        public void cargar_medicamento(string nombre_med, string id_laboratorio, string descripcion)
        {
            string sql_insert = "insert into medicamentos(nombre_med, id_laboratorio, descripcion) " +
                "Values ('" +
                nombre_med + "', " +
                id_laboratorio + ", '" +
                descripcion + "')";

            if (_BD.insertar(sql_insert) ==
               Conexion_BD.estado_BE.correcto)
            {
                MessageBox.Show("Se cargó correctamente los datos.");
            }
            else
            {
                MessageBox.Show("No se cargó correctamente los datos.");
            }
        }

        public void recuperar_medicamento(ref TextBox nombre, ref RichTextBox desc)
        {
            DataTable datos = _BD.ejecutar_consulta("select * from medicamentos");
            nombre.Text = datos.Rows[0]["nombre_med"].ToString();
            desc.Text = datos.Rows[0]["descripcion"].ToString();
        }

        public void modificar_medicamento(string id_medicamento, string nombre_med, string id_lab, string desc)
        {
            string sql = "update medicamentos " +
                "set " +
                "nombre_med = '" + nombre_med +
                "', id_laboratorio = " + id_lab +
                ", descripcion = '" + desc +
                "' where id_medicamento = " + id_medicamento;

            if (_BD.modificar(sql) == Conexion_BD.estado_BE.correcto)
            {
                MessageBox.Show("Se actualizó correctamente");
            }
            else
            {
                MessageBox.Show("No se actualizó");
            }
        }

        public void borrar(string id_medicamento)
        {
            string sql_borrar = "";
            sql_borrar = "DELETE FROM medicamentos_sucursal " +
                "WHERE id_medicamento = " + id_medicamento + " ; \n" + 
                "DELETE FROM medicamentos " +
                "WHERE id_medicamento = " + id_medicamento;

            if (_BD.borrar(sql_borrar) == Conexion_BD.estado_BE.correcto)
            {
                MessageBox.Show("Se borró correctamente");
            }
            else
            {
                MessageBox.Show("No se puedo borrar");
            }
        }

        public void medicamento_x_sucursal()
        {
            DataTable id_sucursales = _BD.ejecutar_consulta("select id_sucursal from sucursales");
            string id_medicamento = _BD.ejecutar_consulta("select MAX(id_medicamento) from medicamentos").Rows[0][0].ToString();
            for (int i = 0; i < id_sucursales.Rows.Count; i++)
            {
                string id_sucursal = id_sucursales.Rows[i][0].ToString();
                string sql = "insert into medicamentos_sucursal values (" + id_medicamento + ", " + id_sucursal + ", 0, 0)";
                _BD.insertar(sql);
            }
        }
    }
}
