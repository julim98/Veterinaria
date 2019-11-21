using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.Negocios;

namespace Veterinaria.Vista
{
    public partial class Frm_ABM_Razas : Form
    {
        public NG_Perros negocio { get; set; }

        public Frm_ABM_Razas()
        {
            InitializeComponent();
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
            if (validacion())
            {
                negocio.Insertar_Raza(
                Txt_Denominacion.Text,
                Txt_Cuidados.Text);
                Frm_ABM_Perro dueño = (Frm_ABM_Perro)Owner;
                dueño.cargar_combos();
                dueño.Show();
                this.Dispose();
            }
            
        }

        private bool validacion()
        {
            return !(Clases.tratamientos_especiales.validacion_textos(Txt_Denominacion)
                ||
                Clases.tratamientos_especiales.validacion_combos());
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Frm_ABM_Perro dueño = (Frm_ABM_Perro)Owner;
            dueño.Show();
            this.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
