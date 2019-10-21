using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.ConexionDB;
using System.Windows.Forms;

namespace Veterinaria.Negocios
{
    class NG_Razas
    {
        public void Insertar(string denominacion,
                            string peso_minimo_hembra,
                            string peso_minimo_macho,
                            string altura_media_hembra,
                            string altura_media_macho,
                            string nota_cuidados)
        {
            string sql = "";

            sql = @"INSERT INTO razas(denominacion, peso_minimo_hembra,
                 peso_minimo_macho, altura_media_hembra, altura_media_macho, nota_cuidados)"
                    + "VALUES ('" + denominacion + "', '"
                    + peso_minimo_hembra + "','"
                    + peso_minimo_macho + "', '"
                    + altura_media_hembra + "', '"
                    + altura_media_macho + "', '"
                    + nota_cuidados + "')";

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
