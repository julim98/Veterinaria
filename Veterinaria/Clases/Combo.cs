using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Windows.Forms;

namespace Veterinaria.Clases
{
    class Combo
    {
        public static void CargarCombo(ref ComboBox combo, string nombreTabla, string descripcion, string pk)
        {
            if (no_hay_datos())
                return;

            try
            {
                Conexion_BD conexion = new Conexion_BD();
                string consulta = "SELECT * FROM " + nombreTabla;
                combo.DataSource = conexion.ejecutar_consulta(consulta);
                combo.DisplayMember = descripcion;
                combo.ValueMember = pk;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar " + combo.Name + ", CargarCombo");
            }

            bool no_hay_datos()
            {
                Conexion_BD _BD = new Conexion_BD();
                string sql = "select * from " + nombreTabla;
                if (_BD.ejecutar_consulta(sql).Rows.Count == 0)
                {
                    return true;
                }
                return false;
            }
        }

        public static void CargarCombo(ref ComboBox combo, string nombreTabla, string descripcion, string pk, string datos_obligatorios)
        {
            if (no_hay_datos())
            {
                MessageBox.Show("No existen " + datos_obligatorios);
                return;
            }

            try
            {
                Conexion_BD conexion = new Conexion_BD();
                string consulta = "SELECT * FROM " + nombreTabla;
                combo.DataSource = conexion.ejecutar_consulta(consulta);
                combo.DisplayMember = descripcion;
                combo.ValueMember = pk;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar " + combo.Name + ", CargarCombo");
            }

            bool no_hay_datos()
            {
                Conexion_BD _BD = new Conexion_BD();
                string sql = "select * from " + nombreTabla;
                if (_BD.ejecutar_consulta(sql).Rows.Count == 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}