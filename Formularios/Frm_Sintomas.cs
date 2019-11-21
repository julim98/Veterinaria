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
    public partial class Frm_Sintomas : Form
    {

        NG_Sintomas negocio = new NG_Sintomas();

        public Frm_Sintomas()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            DataTable datos = negocio.buscar_sintomas(Txt_Nombre.Text.Trim());

            if (datos.Rows.Count == 0)
            {
                if (Txt_Nombre.Text.Trim() == "")
                    MessageBox.Show("No existe ningun sintoma");
                else
                    MessageBox.Show("No se encontro ningun sintoma que coincida con " + Txt_Nombre.Text.Trim());
            }
            else
            {
                Tbl_Sintomas.Rows.Clear();
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    Tbl_Sintomas.Rows.Add();
                    Tbl_Sintomas.Rows[i].Cells[0].Value = datos.Rows[i]["descripcion"].ToString();
                    Tbl_Sintomas.Rows[i].Cells[1].Value = datos.Rows[i]["id_sintoma"].ToString();
                }
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Frm_ABM_Sintomas pantalla = new Frm_ABM_Sintomas();
            pantalla.control_modo = Frm_ABM_Sintomas.modo.registrar;
            pantalla.Show();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Tbl_Sintomas.CurrentRow != null)
            {
                Frm_ABM_Sintomas pantalla = new Frm_ABM_Sintomas();
                pantalla.control_modo = Frm_ABM_Sintomas.modo.modificar;
                pantalla.id_sintoma = Tbl_Sintomas.CurrentRow.Cells["id_sintoma"].Value.ToString();
                pantalla.Show();
            }
            else
                MessageBox.Show("Seleccione que sintoma desea modificar");
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult confimacion = MessageBox.Show("Realmente desea eliminar " + Tbl_Sintomas.CurrentRow.Cells[0].Value.ToString() + "?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confimacion == DialogResult.No)
                return;
            if (Tbl_Sintomas.CurrentRow != null)
            {
                negocio.borrar(Tbl_Sintomas.CurrentRow.Cells["id_sintoma"].Value.ToString());
            }
            else
                MessageBox.Show("Seleccione que sintoma desea eliminar");
        }

        private void Btn_Cerrar_ABM_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
