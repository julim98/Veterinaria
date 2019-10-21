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
    public partial class Frm_Laboratorios : Form
    {
        public Frm_Laboratorios()
        {
            InitializeComponent();
        }

        private void Tbl_Laboratorios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Cerrar_ABM_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Frm_ABM_Laboratorios pantalla = new Frm_ABM_Laboratorios();
            pantalla.Show();
        }

        private void Frm_Laboratorios_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
