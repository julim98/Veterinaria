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
    public partial class Frm_Informe_Razas : Form
    {
        public Frm_Informe_Razas()
        {
            InitializeComponent();
        }

        private void Frm_Informe_Razas_Load(object sender, EventArgs e)
        {
            Conexion_BD _BD = new Conexion_BD() { cadena_conexion = "Initial Catalog=_BD_VETERINARIA_ULTIMA" };
            DataTable tabla = new DataTable();
            string sql;
            sql = @"SELECT R.id_raza, denominacion
                   FROM razas R 
                   INNER JOIN perros P ON R.id_raza = P.id_raza
                   INNER JOIN consultas C ON P.nro_historia_clinica = C.nro_historia_clinica";
            tabla = _BD.ejecutar_consulta(sql);
            //Se asigna al BindingSource el conjunto de datos
            this.razasBindingSource.DataSource = tabla;
            this.reportViewer1.RefreshReport();
        }
    }
}
