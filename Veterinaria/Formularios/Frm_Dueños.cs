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
    public partial class Frm_Dueños : Form
    {
        public Frm_Dueños()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_ABM_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
