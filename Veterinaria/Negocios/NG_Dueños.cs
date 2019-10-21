using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria;
using System.Windows.Forms;

namespace Veterinaria.Negocios
{
    class NG_Dueños
    {
        public void Insertar(string nombre, string apellido, string telefono)
        {
            string sql = "";
            sql = "INSERT INTO dueños(nombre, apellido, telefono) "
                + "VALUES ('" + nombre + "', '" + apellido + "', '"
                + telefono + "')";

            Conexion_BD _BD = new Conexion_BD();
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
    
    }
}
