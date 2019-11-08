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
using Veterinaria.Negocios;

namespace Veterinaria.Vista
{
    public partial class Frm_ABM_Empleados : Form
    {
        public Frm_ABM_Empleados()
        {
            InitializeComponent();
        }


        private void cargarCombos()
        {
            Combo.CargarCombo(ref Cmb_Sucursal, "sucursales", "nombre", "id_sucursal", "sucursales");
            Combo.CargarCombo(ref Cmb_Tipo_Documento, "tipos_documentos", "nombre_tipo_doc", "id_tipo_documento", "tipos de documento");
        }


        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            tratamientos_especiales tratamiento = new tratamientos_especiales();

            if (tratamiento.validar(this.Controls) == tratamientos_especiales.resultado_validacion.incorrecta)
            {
                return;
            }

            NG_Empleados negocio = new NG_Empleados();
            negocio.insertar(
                Txt_Nombre.Text.Trim(),
                Txt_Apellido.Text.Trim(),
                Cmb_Tipo_Documento.SelectedValue.ToString(),
                Txt_Nro_Documento.Text.Trim(),
                Txt_Fecha_Nacimiento.Text,
                Txt_Fecha_Ingreso.Text,
                Txt_Matricula.Text.Trim(),
                Cmb_Sucursal.SelectedValue.ToString());
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_ABM_Empleados_Load(object sender, EventArgs e)
        {
            cargarCombos();
        }
    }
}