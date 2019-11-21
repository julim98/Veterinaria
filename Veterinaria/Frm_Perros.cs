using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class Frm_Perros : Form
    {
        public Frm_Perros()
        {
            InitializeComponent();
        }

        private void Frm_Perros_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Dueño_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Nombr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Buscar_Click_1(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Nombr_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Txt_Dueño_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Btn_Modificar_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_Eliminar_Click_1(object sender, EventArgs e)
        {

        }


        private void Btn_Cerrar_ABM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Frm_ABM_Perro form = new Frm_ABM_Perro();
            form.Show();
        }
    }
}
