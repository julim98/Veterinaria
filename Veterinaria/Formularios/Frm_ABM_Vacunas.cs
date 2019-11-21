using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.Negocios;
using Veterinaria.Clases;

namespace Veterinaria.Formularios
{
    public partial class Frm_ABM_Vacunas : Form
    {
        public enum modo { registrar, modificar }
        public modo control_modo { get; set; }
        public string id_vacuna { get; set; }
        public Frm_ABM_Vacunas()
        {
            InitializeComponent();
        }
        NG_Vacunas negocio = new NG_Vacunas();
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                if (control_modo is modo.registrar)

                    negocio.registrar(Txt_Nombre.Text.Trim());
                else
                    negocio.modificar(id_vacuna, Txt_Nombre.Text.Trim());

                Close();
            }
        }
        public bool validacion()
        {
            return !(tratamientos_especiales.validacion_textos(Txt_Nombre));
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
