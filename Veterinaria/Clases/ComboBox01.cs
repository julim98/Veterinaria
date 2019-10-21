using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria;
using Veterinaria.Clases;
using Veterinaria.ConexionDB;

namespace Veterinaria.Clases
{
    class ComboBox01 : ComboBox
    {
        Conexion_BD _BD = new Conexion_BD();
        //propiedad para cargar el combo
        public string nombre_tabla_cargar { get; set; }
        public string pk { get; set; }
        public string descriptor { get; set; }
        //propiedades para transferencia de datos a un campo de tabla
        //para porcesos de insert o update
        public bool validar { get; set; }
        public string nombre_tabla { get; set; }
        public string nombre_campo { get; set; }

        public void Cargar()
        {
            string sql = "SELECT * FROM " + this.nombre_tabla_cargar.Trim();
            this.DisplayMember = descriptor;
            this.ValueMember = pk;
            this.DataSource = _BD.ejecutar_consulta(sql);
        }
        public void Cargar(string nom_tabla
                           , string _pk
                           , string _descriptor)
        {
            string sql = "SELECT * FROM " + nom_tabla.Trim();
            this.DisplayMember = _descriptor;
            this.ValueMember = _pk;
            this.DataSource = _BD.ejecutar_consulta(sql);
        }
    }
}
