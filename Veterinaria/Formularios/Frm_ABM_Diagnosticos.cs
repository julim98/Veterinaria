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
using Veterinaria.Clases;

namespace Veterinaria.Vista
{
    public partial class Frm_ABM_Diagnosticos : Form
    {

        public enum modo {registrar, modificar}
        public modo control_modo { get; set; }
        public string id_diagnostico { get; set; }

        Negocios.NG_Diagnosticos negocio = new Negocios.NG_Diagnosticos();

        public Frm_ABM_Diagnosticos()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                if (control_modo is modo.registrar)

                    negocio.registrar(Txt_Nombre.Text.Trim());
                else
                    negocio.modificar(id_diagnostico, Txt_Nombre.Text.Trim());

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

        private void Frm_ABM_Diagnosticos_Load(object sender, EventArgs e)
        {
            if (control_modo == modo.modificar)
            {
                Txt_Nombre.Text = negocio.recuperar_diagnostico(id_diagnostico).Rows[0]["descripcion"].ToString();
                Btn_Guardar.AutoSize = true;
                Btn_Guardar.Text = "Modificar";
            }
        }
    }
}
