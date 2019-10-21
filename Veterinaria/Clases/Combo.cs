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
                OleDbCommand cmd = new OleDbCommand();
                OleDbConnection cn = new OleDbConnection("Provider=SQLNCLI11;Data Source=DESKTOP-K8CJ3KA;Integrated Security=SSPI;Initial Catalog=_BD_VETERINARIA2");

                string consulta = "SELECT * FROM " + nombreTabla;
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                DataTable tabla = new DataTable();
                cmd.Connection = cn;

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();

                
                combo.DataSource = tabla;

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
