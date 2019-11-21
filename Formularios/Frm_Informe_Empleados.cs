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
    public partial class Frm_Informe_Empleados : Form
    {
        public Frm_Informe_Empleados()
        {
            InitializeComponent();
        }

        private void Frm_Informe_Empleados_Load(object sender, EventArgs e)
        {
            Conexion_BD _BD = new Conexion_BD() { cadena_conexion = "Initial Catalog=_BD_VETERINARIA_ULTIMA" };
            DataTable tabla = new DataTable();
            string sql;
            sql = @"SELECT apellido, E.nombre, E.id_sucursal
                   FROM empleados E JOIN sucursales S ON E.id_sucursal = S.id_sucursal";
            tabla = _BD.ejecutar_consulta(sql);
            //Se asigna al BindingSource el conjunto de datos
            this.empleadosBindingSource.DataSource = tabla;
            this.reportViewer1.RefreshReport();
        }
    }
}
