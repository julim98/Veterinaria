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
    public partial class Frm_ABM_Consulta_Diagnostico : Form
    {

        Negocios.NG_Consultas negocio = new Negocios.NG_Consultas();
        public string historia_clinica { get; set; }
        public string id_sucursal { get; set; }

        public Frm_ABM_Consulta_Diagnostico()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Consulta_Diagnostico_Load(object sender, EventArgs e)
        {
            cargar_tabla();
        }

        private void cargar_tabla()
        {
            DataTable datos = negocio.obtener_diagnosticos();
            DataTable seleccionados = negocio.obtener_diagnosticos_consulta(historia_clinica, id_sucursal);
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                tbl_diagnosticos.Rows.Add();
                tbl_diagnosticos.Rows[i].Cells[0].Value = datos.Rows[i]["id_diagnostico"].ToString();
                tbl_diagnosticos.Rows[i].Cells[1].Value = (seleccionados.Select("id_diagnostico = " + datos.Rows[i]["id_diagnostico"].ToString()).Length == 1);
                tbl_diagnosticos.Rows[i].Cells[2].Value = datos.Rows[i]["descripcion"].ToString();
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            DataTable seleccionados = negocio.obtener_diagnosticos_consulta(historia_clinica, id_sucursal);
            bool esta_checkeado;
            for (int i = 0; i < tbl_diagnosticos.Rows.Count; i++)
            {
                esta_checkeado = (bool)tbl_diagnosticos.Rows[i].Cells[1].Value;
                if (esta_checkeado)
                {

                }
            }
        }
    }
}
