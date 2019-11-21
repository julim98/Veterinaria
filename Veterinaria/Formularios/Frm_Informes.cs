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
            Frm_Reporte_Empleados pantalla = new Frm_Reporte_Empleados();
            pantalla.ShowDialog();
        }

        private void btn_vacunas_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Vacunas pantalla = new Frm_Reporte_Vacunas();
            pantalla.ShowDialog();
        }

        private void btn_medicamentos_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Medicamentos pantalla = new Frm_Reporte_Medicamentos();
            pantalla.ShowDialog();
        }

        private void btn_razas_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Razas pantalla = new Frm_Reporte_Razas();
            pantalla.ShowDialog();
        }

        private void btn_diagnosticos_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Sintomas pantalla = new Frm_Reporte_Sintomas();
            pantalla.ShowDialog();
        }

        private void btn_dueños_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Dueños pantalla = new Frm_Reporte_Dueños();
            pantalla.ShowDialog();
        }

        private void btn_laboratorios_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Laboratorios pantalla = new Frm_Reporte_Laboratorios();
            pantalla.ShowDialog();
        }

        private void btn_perros_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Perros pantalla = new Frm_Reporte_Perros();
            pantalla.ShowDialog();
        }

        private void btn_medicamentos_Click_1(object sender, EventArgs e)
        {
            Frm_Reporte_Medicamentos pantalla = new Frm_Reporte_Medicamentos();
            pantalla.ShowDialog();
        }
    }
}
