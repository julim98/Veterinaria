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
    public partial class Frm_Medicamentos : Form
    {

        string id_sucursal { get; set; }

        public Frm_Medicamentos()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_ABM_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Frm_ABM_Medicamentos pantalla = new Frm_ABM_Medicamentos();
            AddOwnedForm(pantalla);
            pantalla.Show();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            NG_Medicamentos medicamentos = new NG_Medicamentos();
            medicamentos.cargarTabla(ref Tbl_Medicamentos, Txt_Nombre.Text, cmb_sucursal.SelectedValue.ToString());
            id_sucursal = cmb_sucursal.SelectedValue.ToString();
        }

        private void Frm_Medicamentos_Load(object sender, EventArgs e)
        {
            Clases.Combo.CargarCombo(ref cmb_sucursal, "sucursales", "nombre", "id_sucursal", "sucursales");
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Tbl_Medicamentos.CurrentRow != null)
            {
                Frm_ABM_Medicamentos medicamentos = new Frm_ABM_Medicamentos();
                medicamentos.id_m = Tbl_Medicamentos.CurrentRow.Cells["id_medicamento"].Value.ToString();
                medicamentos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione primero un medicamento para modificar"
                    , "Importante", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Tbl_Medicamentos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione primero un medicamento para eliminar"
                    , "Importante", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return;
            }

            NG_Medicamentos medicamentos = new NG_Medicamentos();
            medicamentos.borrar(Tbl_Medicamentos.CurrentRow.Cells["id_medicamento"].Value.ToString());
            Tbl_Medicamentos.Refresh();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            Formularios.Frm_ABM_Stock stock = new Formularios.Frm_ABM_Stock();
            stock.id_medicamento = Tbl_Medicamentos.CurrentRow.Cells["id_medicamento"].Value.ToString();
            stock.id_sucursal = id_sucursal;
            stock.Show();
        }
    }
}