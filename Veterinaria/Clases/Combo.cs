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
            try
            {
                Conexion_BD conexion = new Conexion_BD();
                string consulta = "SELECT * FROM " + nombreTabla;
                combo.DataSource = conexion.ejecutar_consulta(consulta);
                combo.DisplayMember = descripcion;
                combo.ValueMember = pk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
