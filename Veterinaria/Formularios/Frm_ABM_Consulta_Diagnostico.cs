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
        public DataTable diagnosticos_consulta { get; set; }

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
            if (datos.IsInitialized)
            {
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    tbl_diagnosticos.Rows.Add();
                    DataGridViewCheckBoxCell celda = (DataGridViewCheckBoxCell)tbl_diagnosticos.Rows[i].Cells[1];
                    bool existe = diagnosticos_consulta.Select("id_diagnostico = " + datos.Rows[i]["id_diagnostico"].ToString()).Length == 1;
                    tbl_diagnosticos.Rows[i].Cells[0].Value = datos.Rows[i]["id_diagnostico"].ToString();
                    celda.Value = existe;
                    tbl_diagnosticos.Rows[i].Cells[2].Value = datos.Rows[i]["descripcion"].ToString();
                }
            }
            else
                MessageBox.Show("No existen diagnosticos");
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Vista.Frm_ABM_Consultas dueño = (Vista.Frm_ABM_Consultas)Owner;
            dueño.tabla_sintomas.Rows.Clear();
            bool esta_checkeado;
            for (int i = 0; i < tbl_diagnosticos.Rows.Count; i++)
            {
                esta_checkeado = (bool)tbl_diagnosticos.Rows[i].Cells[1].Value;
                if (esta_checkeado)
                {
                    DataRow fila = diagnosticos_consulta.NewRow();
                    fila["id_diagnostico"] = tbl_diagnosticos.Rows[i].Cells[0].Value;
                    fila["descripcion"] = tbl_diagnosticos.Rows[i].Cells[2].Value;
                    diagnosticos_consulta.Rows.Add(fila);
                }
            }

            dueño.tabla_diagnosticos = diagnosticos_consulta;
            dueño.cargar_diagnosticos();
            Close();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
