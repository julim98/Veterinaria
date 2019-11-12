using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria.Formularios
{
    public partial class Frm_Informes : Form
    {
        public Frm_Informes()
        {
            InitializeComponent();
        }

        private void Frm_Informes_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Empleados_Click(object sender, EventArgs e)
        {
            Frm_Informe_Empleados pantalla = new Frm_Informe_Empleados();
            pantalla.ShowDialog();
        }

        private void btn_vacunas_Click(object sender, EventArgs e)
        {
            Frm_Informe_Vacunas pantalla = new Frm_Informe_Vacunas();
            pantalla.ShowDialog();
        }

        private void btn_medicamentos_Click(object sender, EventArgs e)
        {
            Frm_Informe_Medicamentos pantalla = new Frm_Informe_Medicamentos();
            pantalla.ShowDialog();
        }

        private void btn_razas_Click(object sender, EventArgs e)
        {
            Frm_Informe_Razas pantalla = new Frm_Informe_Razas();
            pantalla.ShowDialog();
        }
    }
}
