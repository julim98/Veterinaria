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
    public partial class Frm_Reporte_Sintomas : Form
    {
        public Frm_Reporte_Sintomas()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Sintomas_Load(object sender, EventArgs e)
        {
            Conexion_BD _BD = new Conexion_BD() { cadena_conexion = "Initial Catalog=BD_VETERINARIA" };
            DataTable tabla = new DataTable();
            string sql;
            sql = @"SELECT *
                   FROM sintomas";
            tabla = _BD.ejecutar_consulta(sql);
            //Se asigna al BindingSource el conjunto de datos
            this.datossintomasBindingSource.DataSource = tabla;
            //Se refresca el reporte para que se visualice en pantalla
            reportViewer1.RefreshReport();
        }
    }
}
