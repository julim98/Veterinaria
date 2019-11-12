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
using Veterinaria.Clases;

namespace Veterinaria.Formularios
{
    public partial class Frm_Modificar_Empleado : Form
    {
        NG_Empleados empleados = new NG_Empleados();
        Combo Combo = new Combo();

        public string tipo_doc { get; set; }

        public string nro_doc { get; set; }

        public Frm_Modificar_Empleado()
        {
            InitializeComponent();
        }
        private void recuperar_datos(string tipo_doc, string nro_doc)
        {
            DataTable tabla = new DataTable();
            tabla = empleados.recuperar_datos_empleados(tipo_doc, nro_doc);
            this.Txt_Nombre.Text = tabla.Rows[0]["nombre"].ToString();
            this.Txt_Apellido.Text = tabla.Rows[0]["apellido"].ToString();
            this.Txt_Fecha_Ingreso.Text = tabla.Rows[0]["fecha_ingreso"].ToString();
            this.Txt_Fecha_Nacimiento.Text = tabla.Rows[0]["fecha_nacimiento"].ToString();
            this.Txt_Matricula.Text = tabla.Rows[0]["matricula"].ToString();
            this.Cmb_Sucursal.SelectedValue = int.Parse(tabla.Rows[0]["id_sucursal"].ToString());
            this.Cmb_Tipo_Documento.SelectedValue = int.Parse(tabla.Rows[0]["tipo_doc"].ToString());
            this.Txt_Nro_Documento.Text = tabla.Rows[0]["nro_doc"].ToString();
        }

        private void Frm_Modificar_Empleado_Load(object sender, EventArgs e)
        {
            Combo.CargarCombo(ref Cmb_Tipo_Documento, "tipos_documentos", "nombre_tipo_doc", "id_tipo_documento");
            Combo.CargarCombo(ref Cmb_Sucursal, "sucursales", "nombre", "id_sucursal");
            recuperar_datos(this.tipo_doc, this.nro_doc);
            
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            empleados.modificar_empleado(Cmb_Tipo_Documento.SelectedValue.ToString(), Txt_Nro_Documento.Text, Cmb_Sucursal.SelectedValue.ToString(),
                Txt_Nombre.Text, Txt_Apellido.Text, Txt_Fecha_Nacimiento.Text, Txt_Fecha_Ingreso.Text, Txt_Matricula.Text, tipo_doc, nro_doc);
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

