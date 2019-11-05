﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using Veterinaria.Vista;
using Veterinaria.Negocios;
using Veterinaria.Clases;
using Veterinaria;

namespace Veterinaria
{
    public partial class Frm_ABM_Perro : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Rectangle sizeGripRectangle;
        bool inSizeDrag = false;
        const int GRIP_SIZE = 15;

        int w = 0;
        int h = 0;

        NG_Perros ng_perros = new NG_Perros();


        public Frm_ABM_Perro()
        {
            InitializeComponent();
            Cmb_Dueño.Refresh();
            
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            transaccion.rollback();
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

        
        private void Frm_ABM_Perro_Load(object sender, EventArgs e)

        {
            transaccion.inicio();
            txt_nroC.Text = (ng_perros.max_nro_hc()+1).ToString();
            Combo.CargarCombo(ref Cmb_Dueño, "dueños", "apellido", "id_dueño");
            Combo.CargarCombo(ref cmb_sucursal, "sucursales", "nombre", "id_sucursal");
            Combo.CargarCombo(ref Cmb_Raza, "razas", "denominacion", "id_raza");
        }

        private void Btn_Nuevo_Dueño_Click_1(object sender, EventArgs e)
        {
            Frm_ABM_Dueños pantalla = new Frm_ABM_Dueños();
            pantalla.Show();
            this.Dispose();

        }

        private void Btn_Nueva_Raza_Click_1(object sender, EventArgs e)
        {
            Frm_ABM_Razas pantalla = new Frm_ABM_Razas();
            pantalla.Show();
            this.Dispose();
        }

        private void Btn_Guardar_Click_1(object sender, EventArgs e)
        {
            NG_Perros perros = new NG_Perros();
            NG_Transaccion transaccion = new NG_Transaccion();
            perros.Insertar(this.txt_nroC.Text,cmb_sucursal.SelectedValue.ToString(),
                Cmb_Raza.SelectedValue.ToString(), Cmb_Dueño.SelectedValue.ToString(),
                this.Txt_Nombre.Text,
                this.Txt_Fecha_Nacimiento.Text,
                this.Txt_Peso.Text,
                this.Txt_Altura.Text);
            transaccion.fin();
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            NG_Transaccion transaccion = new NG_Transaccion();
            transaccion.rollback();
            this.Dispose();
        }
    }
}
