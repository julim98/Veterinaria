using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.Clases;
using Veterinaria.Negocios;

namespace Veterinaria.Vista
{
    public partial class Frm_ABM_Laboratorios : Form
    {
        public string id_l { get; set; }

        public Frm_ABM_Laboratorios()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_ABM_Laboratorios_Load(object sender, EventArgs e)
        {
            Combo.CargarCombo(ref Cmb_Razon_Social, "laboratorios", "razon_social", "id_laboratorio");
            if (id_l != null)
                cargar_laboratorio();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            NG_Laboratorios negocio = new NG_Laboratorios();
            if (id_l == null)
                negocio.guardar_laboratorio(Txt_Nombre.Text.Trim(), Cmb_Razon_Social.Text.Trim(), Txt_Direccion.Text.Trim());
            else
                negocio.modificar_laboratorio(Txt_Nombre.Text.Trim(), Cmb_Razon_Social.Text.Trim(), Txt_Direccion.Text.Trim(), id_l);
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cargar_laboratorio()
        {
            NG_Laboratorios negocio = new NG_Laboratorios();
            DataTable datos = negocio.obtener_laboratorio(id_l);
            Txt_Nombre.Text = datos.Rows[0]["nombre_lab"].ToString();
            Txt_Direccion.Text = datos.Rows[0]["direccion"].ToString();
            Cmb_Razon_Social.SelectedText = datos.Rows[0]["razon_social"].ToString();
        }
    }
}
