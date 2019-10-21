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
    public partial class Frm_Medicamentos : Form
    {
        public Frm_Medicamentos()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_ABM_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Frm_ABM_Medicamentos pantalla = new Frm_ABM_Medicamentos();
            pantalla.Show();
        }
    }
}
