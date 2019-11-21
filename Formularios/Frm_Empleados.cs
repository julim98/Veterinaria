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
using Veterinaria.Clases;
using Veterinaria.Negocios;
using Veterinaria.Formularios;

namespace Veterinaria.Vista
{
    public partial class Frm_Empleados : Form
    {
        public Frm_Empleados()
        {
            InitializeComponent();
        }

        private void cargar_combo()
        {
            Combo.CargarCombo(ref Cmb_Tipo_Documento, "tipos_documentos", "nombre_tipo_doc", "id_tipo_documento" );
        }

        private void Btn_Cerrar_ABM_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Frm_ABM_Empleados pantalla = new Frm_ABM_Empleados();
            pantalla.Show();
        }

        private void Frm_Empleados_Load(object sender, EventArgs e)
        {
            cargar_combo();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            NG_Empleados negocio = new NG_Empleados();
            DataTable tabla = negocio.tabla_empleados(
                Cmb_Tipo_Documento.SelectedValue.ToString(),
                txt_nro_documento.Text.Trim()
                );
            cargar_grilla(tabla);

        }
        private void cargar_grilla(DataTable tabla)
        {
            Tbl_Empleados.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Tbl_Empleados.Rows.Add();
                Tbl_Empleados.Rows[i].Cells[0].Value = tabla.Rows[i]["apellido"].ToString();
                Tbl_Empleados.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                Tbl_Empleados.Rows[i].Cells[2].Value = tabla.Rows[i]["tipo_documento"].ToString();
                Tbl_Empleados.Rows[i].Cells[3].Value = tabla.Rows[i]["nro_doc"].ToString();
                Tbl_Empleados.Rows[i].Cells[4].Value = tabla.Rows[i]["matricula"].ToString();
                Tbl_Empleados.Rows[i].Cells[5].Value = tabla.Rows[i]["fecha_nacimiento"].ToString();
                Tbl_Empleados.Rows[i].Cells[6].Value = tabla.Rows[i]["sucursal"].ToString();
                Tbl_Empleados.Rows[i].Cells[7].Value = tabla.Rows[i]["fecha_ingreso"].ToString();
                Tbl_Empleados.Rows[i].Cells[8].Value = tabla.Rows[i]["id_tipo_documento"].ToString();
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Tbl_Empleados.CurrentRow != null)
            {
                Frm_Modificar_Empleado empleado = new Frm_Modificar_Empleado();
                empleado.tipo_doc = Tbl_Empleados.CurrentRow.Cells["id_tipo_doc"].Value.ToString();
                empleado.nro_doc = Tbl_Empleados.CurrentRow.Cells["NroDocumento"].Value.ToString();
                empleado.ShowDialog();
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
            if (Tbl_Empleados.CurrentRow != null)
            {
                if (MessageBox.Show("¿Esta seguro de borrar este empleado?"
                , "Importante"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NG_Empleados empleados = new NG_Empleados();
                    empleados.borrar_empleado(Tbl_Empleados.CurrentRow.Cells["id_tipo_doc"].Value.ToString(),Tbl_Empleados.CurrentRow.Cells["NroDocumento"].Value.ToString());
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
