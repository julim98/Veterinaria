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

namespace Veterinaria
{
    public partial class Frm_Escritorio : Form
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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

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

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Pnl_Contenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {

        }


        

        private void Btn_Cerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Maximizar_Click_1(object sender, EventArgs e)
        {
            /*Btn_Cerrar.Visible = false;
            Btn_Restaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;*/
            
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

        private void Pnl_Barra_Superior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }
    }
}
