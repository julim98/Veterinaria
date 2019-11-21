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
using Veterinaria.Negocios;
using Veterinaria.Clases;

namespace Veterinaria.Vista
{
    public partial class Frm_ABM_Medicamentos : Form
    {
        public string id_m { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Rectangle sizeGripRectangle;
        bool inSizeDrag = false;
        const int GRIP_SIZE = 15;

        int w = 0;
        int h = 0;

        public Frm_ABM_Medicamentos()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Pnl_Barra_Superior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            NG_Medicamentos medicamentos = new NG_Medicamentos();
            if (id_m != null)
                medicamentos.modificar_medicamento(id_m, Txt_Nombre.Text, Cmb_Laboratorio.SelectedValue.ToString(), Txt_Descripcion.Text);
            else
            {
                medicamentos.cargar_medicamento(Txt_Nombre.Text.Trim(), Cmb_Laboratorio.SelectedValue.ToString(), Txt_Descripcion.Text.Trim());
                medicamentos.medicamento_x_sucursal();
            }
            this.Dispose();
        }

        private void cargar_combo()
        {
            Combo.CargarCombo(ref Cmb_Laboratorio, "laboratorios", "razon_social", "id_laboratorio");
        }

        private void Frm_ABM_Medicamentos_Load(object sender, EventArgs e)
        {
            cargar_combo();
            if (id_m != null)
            {
                cargar_combo();

                NG_Medicamentos medicamentos = new NG_Medicamentos();
                medicamentos.recuperar_medicamento(ref Txt_Nombre, ref Txt_Descripcion);
            }
        }
    }
}
