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
    public partial class Frm_Configuracion : Form
    {
        public Frm_Configuracion()
        {
            InitializeComponent();
        }

        private void Btn_Laboratorios_Click(object sender, EventArgs e)
        {
            Frm_Laboratorios pantalla = new Frm_Laboratorios();
            pantalla.Show();
        }

        private void Btn_Empleados_Click(object sender, EventArgs e)
        {
            Frm_Empleados pantalla = new Frm_Empleados();
            pantalla.Show();
        }

        private void Btn_Sucursales_Click(object sender, EventArgs e)
        {
            Frm_ABM_Sucursales pantalla = new Frm_ABM_Sucursales();
            pantalla.Show();
        }
    }
}
