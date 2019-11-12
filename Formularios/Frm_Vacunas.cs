using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.Negocios;

namespace Veterinaria.Formularios
{
    public partial class Frm_Vacunas : Form
    {
        NG_Vacunas negocio = new NG_Vacunas();
        public Frm_Vacunas()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            DataTable datos = negocio.buscar_vacunas(Txt_Nombre.Text.Trim());

            if (datos.Rows.Count == 0)
            {
                if (Txt_Nombre.Text.Trim() == "")
                    MessageBox.Show("No existe ninguna vacuna");
                else
                    MessageBox.Show("No se encontro ninguna vacuna que coincida con " + Txt_Nombre.Text.Trim());
            }
            else
            {
                Tbl_Vacunas.Rows.Clear();
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    Tbl_Vacunas.Rows.Add();
                    Tbl_Vacunas.Rows[i].Cells[0].Value = datos.Rows[i]["id_vacuna"].ToString();
                    Tbl_Vacunas.Rows[i].Cells[1].Value = datos.Rows[i]["descripcion"].ToString();
                }
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Frm_ABM_Vacunas pantalla = new Frm_ABM_Vacunas();
            pantalla.control_modo = Frm_ABM_Vacunas.modo.registrar;
            pantalla.Show();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Tbl_Vacunas.CurrentRow != null)
            {
                Frm_ABM_Vacunas pantalla = new Frm_ABM_Vacunas();
                pantalla.control_modo = Frm_ABM_Vacunas.modo.modificar;
                pantalla.id_vacuna = Tbl_Vacunas.CurrentRow.Cells["id_vacuna"].Value.ToString();
                pantalla.Show();
            }
            else
                MessageBox.Show("Seleccione que vacuna desea modificar");
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult confimacion = MessageBox.Show("Realmente desea eliminar " + Tbl_Vacunas.CurrentRow.Cells[0].Value.ToString() + "?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confimacion == DialogResult.No)
                return;
            if (Tbl_Vacunas.CurrentRow != null)
            {
                negocio.borrar(Tbl_Vacunas.CurrentRow.Cells["id_vacuna"].Value.ToString());
            }
            else
                MessageBox.Show("Seleccione que vacuna desea eliminar");
        }

        private void Btn_Cerrar_ABM_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
