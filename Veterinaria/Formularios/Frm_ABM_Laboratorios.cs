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

namespace Veterinaria.Vista
{
    public partial class Frm_ABM_Laboratorios : Form
    {
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
            Combo.CargarCombo(ref Cmb_Razon_Social, "razon_social", "nombre", "id_razon_social");
        }
    }
}
