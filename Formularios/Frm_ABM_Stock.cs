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

namespace Veterinaria.Formularios
{
    public partial class Frm_ABM_Stock : Form
    {

        public string id_medicamento { get; set; }
        public string id_sucursal { get; set; }

        NG_Stock negocio = new NG_Stock();

        public Frm_ABM_Stock()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Stock_Load(object sender, EventArgs e)
        {
            cargar_datos();
        }

        private void cargar_datos()
        {
            DataTable tabla = negocio.cargar_datos(id_medicamento, id_sucursal);
            Txt_Nombre.Text = tabla.Rows[0]["nombre"].ToString();
            Txt_Sucursal.Text = tabla.Rows[0]["sucursal"].ToString();
            Txt_Stock_Actual.Text = tabla.Rows[0]["stock_actual"].ToString();
            Txt_Stock_Minimo.Text = tabla.Rows[0]["stock_minimo"].ToString();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            negocio.modificar_stock(id_medicamento, id_sucursal, Txt_Stock_Actual.Text.Trim(), Txt_Stock_Minimo.Text.Trim());
            this.Close();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
