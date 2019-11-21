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
    public partial class Frm_Vacunas : Form
    {
        public Frm_Vacunas()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            DataTable datos = negocio.buscar_diagnosticos(Txt_Nombre.Text.Trim());

            if (datos.Rows.Count == 0)
            {
                if (Txt_Nombre.Text.Trim() == "")
                    MessageBox.Show("No existe ningun diagnostico");
                else
                    MessageBox.Show("No se encontro ningun diagnostico que coincida con " + Txt_Nombre.Text.Trim());
            }
            else
            {
                Tbl_Diagnosticos.Rows.Clear();
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    Tbl_Diagnosticos.Rows.Add();
                    Tbl_Diagnosticos.Rows[i].Cells[0].Value = datos.Rows[i]["descripcion"].ToString();
                    Tbl_Diagnosticos.Rows[i].Cells[1].Value = datos.Rows[i]["id_diagnostico"].ToString();
                }
            }
        }
    }
}
