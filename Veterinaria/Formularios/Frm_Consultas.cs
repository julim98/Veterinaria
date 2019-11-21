using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria.Vista
{
    public partial class Frm_Consultas : Form
    {
        public Frm_Consultas()
        {
            InitializeComponent();
        }

        Negocios.NG_Consultas negocio = new Negocios.NG_Consultas();

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Frm_ABM_Consultas pantalla = new Frm_ABM_Consultas();
            pantalla.Show();
        }

        private void Btn_Cerrar_ABM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = negocio.obtener_consultas();
            Tbl_Consultas.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Tbl_Consultas.Rows.Add();
                Tbl_Consultas.Rows[i].Cells[0].Value = tabla.Rows[i]["nro_historia_clinica"].ToString();
                Tbl_Consultas.Rows[i].Cells[1].Value = tabla.Rows[i]["sucursal"].ToString();
                Tbl_Consultas.Rows[i].Cells[2].Value = tabla.Rows[i]["empleado"].ToString();
                Tbl_Consultas.Rows[i].Cells[3].Value = tabla.Rows[i]["fecha_entrada"].ToString();
                Tbl_Consultas.Rows[i].Cells[4].Value = tabla.Rows[i]["fecha_salida"].ToString();

            }
        }
    }
}

