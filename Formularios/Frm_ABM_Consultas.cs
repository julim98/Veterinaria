using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Veterinaria.Vista
{
    public partial class Frm_ABM_Consultas : Form
    {

        public Frm_ABM_Consultas()
        {
            InitializeComponent();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_ABM_Consultas_Load(object sender, EventArgs e)
        {
            label_fecha.Text = "Fecha: " + DateTime.Today.ToShortDateString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
