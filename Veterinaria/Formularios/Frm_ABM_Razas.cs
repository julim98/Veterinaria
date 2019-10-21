using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.Negocios;

namespace Veterinaria.Vista
{
    public partial class Frm_ABM_Razas : Form
    {
        public Frm_ABM_Razas()
        {
            InitializeComponent();
        }

        private void Cmb_Sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Nro_Historia_Clinica_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            NG_Razas _Razas = new NG_Razas();
            _Razas.Insertar(
                Txt_Denominacion.Text,
                Txt_Peso_Minimo_Hembra.Text,
                Txt_Peso_Minimo_Macho.Text,
                Txt_Altura_Media_Hembra.Text,
                Txt_Altura_Media_Macho.Text,
                Txt_Cuidados.Text);
            Frm_ABM_Perro pantalla = new Frm_ABM_Perro();
            pantalla.Show();
            this.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
