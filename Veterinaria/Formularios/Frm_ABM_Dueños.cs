using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Veterinaria.Negocios;

namespace Veterinaria.Vista
{
    public partial class Frm_ABM_Dueños : Form
    {
        public NG_Perros negocio { get; set; }
        public Frm_ABM_Dueños()
        {
            InitializeComponent();
        }

        private void borrar_parametros()
        {
            Txt_Nombre.Text = "";
            Txt_Apellido.Text = "";
            Txt_Telefono.Text = "";
        }

        private void Frm_ABM_Dueños_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Frm_ABM_Perro dueño = (Frm_ABM_Perro)Owner;
            dueño.Show();
            this.Dispose();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            negocio.Insertar_Dueño(Txt_Nombre.Text , Txt_Apellido.Text, Txt_Telefono.Text);
            Frm_ABM_Perro dueño = (Frm_ABM_Perro)Owner;
            dueño.cargar_combos();
            dueño.Show();
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Frm_ABM_Perro dueño = (Frm_ABM_Perro)Owner;
            dueño.Show();
            this.Dispose();
        }
    }
}
