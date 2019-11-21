using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria;
using Veterinaria.Negocios;
using Veterinaria.Vista;
using Veterinaria.Clases;

namespace Veterinaria.Formularios
{
    
    
    public partial class Frm_Modificar_Perro : Form
    {
        NG_Perros ng_perros = new NG_Perros();

        public string nro_historia_clinica { get; set; }

        public Frm_Modificar_Perro()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Perro_Load(object sender, EventArgs e)
        {
            this.recuperar_datos(this.nro_historia_clinica);
            cargar_combos();
        }

        public void cargar_combos()
        {
            ng_perros.CargarCombo(ref Cmb_Dueño, "dueños", "apellido", "id_dueño");
            ng_perros.CargarCombo(ref cmb_sucursal, "sucursales", "nombre", "id_sucursal");
            ng_perros.CargarCombo(ref Cmb_Raza, "razas", "denominacion", "id_raza");
        }

        private void Btn_Nuevo_Dueño_Click(object sender, EventArgs e)
        {
            Frm_ABM_Dueños pantalla = new Frm_ABM_Dueños();
            AddOwnedForm(pantalla);
            pantalla.negocio = ng_perros;
            pantalla.Show();
            this.Hide();
        }

        private void Btn_Nueva_Raza_Click(object sender, EventArgs e)
        {
            Frm_ABM_Razas pantalla = new Frm_ABM_Razas();
            AddOwnedForm(pantalla);
            pantalla.negocio = ng_perros;
            pantalla.Show();
            this.Hide();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            ng_perros.modificar(this.cmb_sucursal.SelectedValue.ToString(),
                Cmb_Raza.SelectedValue.ToString(),
                Cmb_Dueño.SelectedValue.ToString(),
                Txt_Nombre.Text, Txt_Fecha_Nacimiento.Text, Txt_Peso.Text, Txt_Altura.Text
                , this.nro_historia_clinica);
        }
        private void recuperar_datos(string nro_historia_clinica)
        {
            DataTable tabla = new DataTable();
            tabla = ng_perros.recuperar_datos_x_nro(nro_historia_clinica);
            this.Txt_Nombre.Text = tabla.Rows[0]["nombre"].ToString();
            this.txt_nroC.Text = tabla.Rows[0]["nro_historia_clinica"].ToString();
            this.Txt_Peso.Text = tabla.Rows[0]["peso"].ToString();
            this.Txt_Fecha_Nacimiento.Text = tabla.Rows[0]["fecha_nacimiento"].ToString();
            this.Txt_Altura.Text = tabla.Rows[0]["altura"].ToString();
            this.cmb_sucursal.SelectedValue = int.Parse(tabla.Rows[0]["id_sucursal"].ToString());
            this.Cmb_Raza.SelectedValue = int.Parse(tabla.Rows[0]["id_raza"].ToString());
            this.Cmb_Dueño.SelectedValue = int.Parse(tabla.Rows[0]["id_dueño"].ToString());

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            ng_perros.transaccion_rollback();
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            ng_perros.transaccion_rollback();
            this.Dispose();
        }
    }
}
