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
    public partial class Frm_Consultas : Form
    {
        public Frm_Consultas()
        {
            InitializeComponent();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Frm_ABM_Consultas pantalla = new Frm_ABM_Consultas();
            pantalla.Show();
        }

        private void Btn_Cerrar_ABM_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
