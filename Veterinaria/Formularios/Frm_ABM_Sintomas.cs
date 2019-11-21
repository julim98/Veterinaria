using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.Clases;

namespace Veterinaria.Formularios
{
    public partial class Frm_ABM_Sintomas : Form
    {

        public enum modo { registrar, modificar }
        public modo control_modo { get; set; }
        public string id_sintoma { get; set; }

        Negocios.NG_Sintomas negocio = new Negocios.NG_Sintomas();

        public Frm_ABM_Sintomas()
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
                    negocio.modificar(id_sintoma, Txt_Nombre.Text.Trim());

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

        private void Frm_ABM_Sintomas_Load(object sender, EventArgs e)
        {
            if (control_modo == modo.modificar)
            {
                Txt_Nombre.Text = negocio.recuperar_sintoma(id_sintoma).Rows[0]["descripcion"].ToString();
                Btn_Guardar.AutoSize = true;
                Btn_Guardar.Text = "Modificar";
            }
        }
    }
}
