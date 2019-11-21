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
    public partial class Frm_Reporte_Medicamentos : Form
    {
        public Frm_Reporte_Medicamentos()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Medicamentos_Load(object sender, EventArgs e)
        {
            Conexion_BD _BD = new Conexion_BD() { cadena_conexion = "Initial Catalog=BD_VETERINARIA" };
            DataTable tabla = new DataTable();
            string sql;
            sql = @"SELECT id_medicamento, nombre_med, id_laboratorio as laboratorio
                   FROM medicamentos M INNER JOIN laboratorios L 
                   ON M.id_laboratorio=L.id_laboratorio";
            tabla = _BD.ejecutar_consulta(sql);
            //Se asigna al BindingSource el conjunto de datos
            this.datosmedicamentosBindingSource.DataSource = tabla;
            //Se refresca el reporte para que se visualice en pantalla
            reportViewer1.RefreshReport();
        }
    }
}
