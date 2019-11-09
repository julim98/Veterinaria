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
using Veterinaria.Vista;

namespace Veterinaria
{
    public partial class Frm_Escritorio : Form
    {
        public Frm_Escritorio()
        {
            InitializeComponent();
        }        

        private void Btn_Maximizar_Click(object sender, EventArgs e)
        {
            Btn_Maximizar.Visible = false;
            Btn_Restaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void AbrirFormsHijos(object Form_Hijo)
        {
            if (Pnl_Contenedor.Controls.Count > 0)            
                Pnl_Contenedor.Controls.RemoveAt(0);
                Form formHijo = Form_Hijo as Form;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                formHijo.Dock = DockStyle.Fill;
                Pnl_Contenedor.Controls.Add(formHijo);
                Pnl_Contenedor.Tag = formHijo;
                formHijo.Show();            
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {

        }        

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Restaurar_Click_1(object sender, EventArgs e)
        {
            /*Btn_Restaurar.Visible = false;
            Btn_Maximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;*/
            
        }

        private void Btn_Perros_Click_1(object sender, EventArgs e)
        {
            AbrirFormsHijos(new Frm_Perros());
        }

        private void Btn_Configuracion_Click_1(object sender, EventArgs e)
        {
            AbrirFormsHijos(new Frm_Configuracion());
        }

        private void Btn_Consultas_Click_1(object sender, EventArgs e)
        {
            AbrirFormsHijos(new Frm_Consultas());
        }

        private void Btn_Diagnosticos_Click(object sender, EventArgs e)
        {
            AbrirFormsHijos(new Frm_Diagnosticos());
        }

        private void Btn_Medicamentos_Click(object sender, EventArgs e)
        {
            AbrirFormsHijos(new Frm_Medicamentos());
        }

        private void Btn_Informes_Click(object sender, EventArgs e)
        {
            //AbrirFormsHijos(new Frm_Informes());
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Sintomas_Click(object sender, EventArgs e)
        {
            AbrirFormsHijos(new Formularios.Frm_sintomas());
        }
    }
}
