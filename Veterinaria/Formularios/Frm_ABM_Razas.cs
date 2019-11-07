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
                return;
            negocio.Insertar_Raza(
                Txt_Denominacion.Text,
                Txt_Peso_Minimo_Hembra.Text,
                Txt_Peso_Minimo_Macho.Text,
                Txt_Altura_Media_Hembra.Text,
                Txt_Altura_Media_Macho.Text,
                Txt_Cuidados.Text);
            Frm_ABM_Perro dueño = (Frm_ABM_Perro)Owner;
            dueño.cargar_combos();
            dueño.Show();
            this.Dispose();
        }

        private bool validacion()
        {
            return Clases.tratamientos_especiales.validacion_textos(Txt_Denominacion,
                Txt_Peso_Minimo_Hembra,
                Txt_Peso_Minimo_Macho,
                Txt_Altura_Media_Macho,
                Txt_Altura_Media_Hembra)
                ||
                Clases.tratamientos_especiales.validacion_combos();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Frm_ABM_Perro dueño = (Frm_ABM_Perro)Owner;
            dueño.Show();
            this.Dispose();
        }
    }
}
