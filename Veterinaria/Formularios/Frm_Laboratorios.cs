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

namespace Veterinaria.Vista
{
    public partial class Frm_Laboratorios : Form
    {
        public Frm_Laboratorios()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_ABM_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Frm_ABM_Laboratorios pantalla = new Frm_ABM_Laboratorios();
            pantalla.Show();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            NG_Laboratorios negocio = new NG_Laboratorios();
            DataTable tabla = new DataTable();

            tabla = negocio.obtener_datos_tabla();
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existe ningun laboratorio");
                return;
            }

            if (Txt_Nombre.Text != "")
            {
                tabla = negocio.obtener_datos_tabla(Txt_Nombre.Text.Trim());
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningun laboratorio que coincida con \"" + Txt_Nombre.Text.Trim() + "\"");
                    return;
                }
            }

            cargar_grilla(tabla);
        }

        private void cargar_grilla(DataTable tabla)
        {
            
            Tbl_Laboratorios.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Tbl_Laboratorios.Rows.Add();
                Tbl_Laboratorios.Rows[i].Cells[0].Value = tabla.Rows[i]["razon_social"].ToString();
                Tbl_Laboratorios.Rows[i].Cells[1].Value = tabla.Rows[i]["direccion"].ToString();
                Tbl_Laboratorios.Rows[i].Cells[2].Value = tabla.Rows[i]["id_laboratorio"].ToString();
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Frm_ABM_Laboratorios pantalla = new Frm_ABM_Laboratorios();
            pantalla.id_l = Tbl_Laboratorios.CurrentRow.Cells["id_lab"].Value.ToString();
            pantalla.Show();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Tbl_Laboratorios.CurrentRow != null)
            {
                if (MessageBox.Show("¿Esta seguro de borrar este laboratorio?"
                , "Importante"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NG_Laboratorios negocio = new NG_Laboratorios();
                    negocio.borrar_laboratorio(Tbl_Laboratorios.CurrentRow.Cells["id_lab"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Seleccione primero una fila de la grilla, para modificar"
                    , "Importante", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
