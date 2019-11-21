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

namespace Veterinaria.Vista
{
    public partial class Frm_Diagnosticos : Form
    {
        NG_Diagnosticos negocio = new NG_Diagnosticos();

        public Frm_Diagnosticos()
        {
            InitializeComponent();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Frm_ABM_Diagnosticos pantalla = new Frm_ABM_Diagnosticos();
            pantalla.control_modo = Frm_ABM_Diagnosticos.modo.registrar;
            pantalla.Show();
        }

        private void Btn_Cerrar_ABM_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Tbl_Diagnosticos.CurrentRow != null)
            {
                Frm_ABM_Diagnosticos pantalla = new Frm_ABM_Diagnosticos();
                pantalla.control_modo = Frm_ABM_Diagnosticos.modo.modificar;
                pantalla.id_diagnostico = Tbl_Diagnosticos.CurrentRow.Cells["id_diagnostico"].Value.ToString();
                pantalla.Show();
            }
            else
                MessageBox.Show("Seleccione que diagnostico desea modificar");
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
                for (int i = 0 ; i < datos.Rows.Count ; i++)
                {
                    Tbl_Diagnosticos.Rows.Add();
                    Tbl_Diagnosticos.Rows[i].Cells[0].Value = datos.Rows[i]["descripcion"].ToString();
                    Tbl_Diagnosticos.Rows[i].Cells[1].Value = datos.Rows[i]["id_diagnostico"].ToString();
                }
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {

            DialogResult confimacion = MessageBox.Show("Realmente desea eliminar " + Tbl_Diagnosticos.CurrentRow.Cells[0].Value.ToString() + "?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confimacion == DialogResult.No)
                return;
            if (Tbl_Diagnosticos.CurrentRow != null)
            {
                negocio.borrar(Tbl_Diagnosticos.CurrentRow.Cells["id_diagnostico"].Value.ToString());
            }
            else
                MessageBox.Show("Seleccione que diagnostico desea eliminar");
        }
    }
}
