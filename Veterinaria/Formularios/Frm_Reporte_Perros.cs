using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria.Formularios
{
    public partial class Frm_Reporte_Perros : Form
    {
        public Frm_Reporte_Perros()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Perros_Load(object sender, EventArgs e)
        {
            Conexion_BD _BD = new Conexion_BD() { cadena_conexion = "Initial Catalog=BD_VETERINARIA" };
            DataTable tabla = new DataTable();
            string sql;
            sql = @"SELECT nro_historia_clinica, p.nombre, p.id_raza, p.id_dueño
                   FROM perros p
                   INNER JOIN razas r ON p.id_raza=r.id_raza
                   INNER JOIN dueños d ON p.id_dueño=d.id_dueño";
            tabla = _BD.ejecutar_consulta(sql);
            //Se asigna al BindingSource el conjunto de datos
            this.datosperrosBindingSource.DataSource = tabla;
            //Se refresca el reporte para que se visualice en pantalla
            reportViewer1.RefreshReport();
        }
    }
}
