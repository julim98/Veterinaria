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
using Veterinaria.Formularios;

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
            NG_Perros perros = new NG_Perros();
            DataTable tabla = new DataTable();

            if (Txt_Dueño.Text == ""
                && Txt_Nombre.Text == ""
                && Check_Todos.Checked == false)
            {
                MessageBox.Show("No seleccionó o cargó datos"
                    , "Importante"
                    , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Txt_Dueño.Focus();
                return;
            }
            if (Txt_Dueño.Text != ""
                && Txt_Nombre.Text == ""
                && Check_Todos.Checked == false)
            {
                tabla = perros.consultar_x_dueño(Txt_Dueño.Text);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos encontrados");
                    return;
                }
                cargar_grilla(tabla);
                return;
            }
            if (Txt_Dueño.Text == ""
                && Txt_Nombre.Text != ""
                && Check_Todos.Checked == false)
            {
                tabla = perros.consultar_x_nombre(Txt_Nombre.Text);

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se obtuvieron datos");
                    return;
                }
                cargar_grilla(tabla);
                return;
            }
            if (Txt_Dueño.Text != ""
                && Txt_Nombre.Text != ""
                && Check_Todos.Checked == false)
            {
                tabla = perros.consultar_x_dueño_nombre(Txt_Dueño.Text, Txt_Nombre.Text);

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se obtuvieron datos");
                    return;
                }
                cargar_grilla(tabla);
                return;
            }
            if (Check_Todos.Checked == true)
            {
                tabla = perros.consultar_x_todos();
                cargar_grilla(tabla);
            }
        }
        private void cargar_grilla(DataTable tabla)
        {
            Tbl_Perros.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Tbl_Perros.Rows.Add();
                Tbl_Perros.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                Tbl_Perros.Rows[i].Cells[2].Value = tabla.Rows[i]["fecha_nacimiento"].ToString();
                Tbl_Perros.Rows[i].Cells[0].Value = tabla.Rows[i]["nro_historia_clinica"].ToString();
                Tbl_Perros.Rows[i].Cells[7].Value = tabla.Rows[i]["id_sucursal"].ToString();
                Tbl_Perros.Rows[i].Cells[3].Value = tabla.Rows[i]["id_raza"].ToString();
                Tbl_Perros.Rows[i].Cells[4].Value = tabla.Rows[i]["id_dueño"].ToString();
                Tbl_Perros.Rows[i].Cells[5].Value = tabla.Rows[i]["peso"].ToString();
                Tbl_Perros.Rows[i].Cells[6].Value = tabla.Rows[i]["altura"].ToString();
            }
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
            if (Tbl_Perros.CurrentRow != null)
            {
                Frm_Modificar_Perro _Perro= new Frm_Modificar_Perro();
                _Perro.nro_historia_clinica = Tbl_Perros.CurrentRow.Cells["nro_historia_clinica"].Value.ToString();
                _Perro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione primero una fila de la grilla, para modificar"
                    , "Importante", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            if (Tbl_Perros.CurrentRow != null)
            {
                if (MessageBox.Show("¿Esta seguro de borrar este perro?"
                , "Importante"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NG_Perros _Perros = new NG_Perros();
                    _Perros.borrar(Tbl_Perros.CurrentRow.Cells["nro_historia_clinica"].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Seleccione primero una fila de la grilla, para modificar"
                    , "Importante", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
            }
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
