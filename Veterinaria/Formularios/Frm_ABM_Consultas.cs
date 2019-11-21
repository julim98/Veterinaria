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

namespace Veterinaria.Vista
{
    public partial class Frm_ABM_Consultas : Form
    {
        Negocios.NG_Consultas negocio = new Negocios.NG_Consultas();
        public DataTable tabla_diagnosticos = new DataTable();
        public DataTable tabla_sintomas = new DataTable();

        public Frm_ABM_Consultas()
        {
            InitializeComponent();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_ABM_Consultas_Load(object sender, EventArgs e)
        {
            label_fecha.Text = "Fecha: " + DateTime.Today.ToShortDateString();
            tabla_diagnosticos.Columns.Add("id_diagnostico", typeof(String));
            tabla_diagnosticos.Columns.Add("descripcion", typeof(String));
            tabla_sintomas.Columns.Add("id_sintoma", typeof(String));
            tabla_sintomas.Columns.Add("descripcion", typeof(String));
            Clases.Combo.CargarCombo(ref Cmb_Empleado, "empleados", "apellido", "nro_doc");
            Clases.Combo.CargarCombo(ref Cmb_Sucursal, "sucursales", "nombre", "id_sucursal");
        }

        private void btn_modificar_diagnosticos_Click(object sender, EventArgs e)
        {
            tbl_diagnosticos.Rows.Clear();
            Formularios.Frm_ABM_Consulta_Diagnostico formulario = new Formularios.Frm_ABM_Consulta_Diagnostico();
            formulario.diagnosticos_consulta = tabla_diagnosticos;
            formulario.Show(this);
        }

        private void btn_modificar_sintomas_Click(object sender, EventArgs e)
        {
            tbl_sintomas.Rows.Clear();
            Formularios.Frm_ABM_Consulta_Sintoma formulario = new Formularios.Frm_ABM_Consulta_Sintoma();
            formulario.sintomas_consulta = tabla_sintomas;
            formulario.Show(this);
        }

        public void cargar_diagnosticos()
        {
            for (int i = 0; i < tabla_diagnosticos.Rows.Count; i++)
            {
                tbl_diagnosticos.Rows.Add();
                tbl_diagnosticos.Rows[i].Cells[0].Value = tabla_diagnosticos.Rows[i]["id_diagnostico"].ToString();
                tbl_diagnosticos.Rows[i].Cells[1].Value = tabla_diagnosticos.Rows[i]["descripcion"].ToString();
            }
        }
        public void cargar_sintomas()
        {
            for (int i = 0; i < tabla_sintomas.Rows.Count; i++)
            {
                tbl_sintomas.Rows.Add();
                tbl_sintomas.Rows[i].Cells[0].Value = tabla_sintomas.Rows[i]["id_sintoma"].ToString();
                tbl_sintomas.Rows[i].Cells[1].Value = tabla_sintomas.Rows[i]["descripcion"].ToString();
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            DataTable tabla = (DataTable)Cmb_Empleado.DataSource;
            DataRow fila_empleado = tabla.Select("nro_doc = " + Cmb_Empleado.SelectedValue.ToString())[0];
            negocio.cargar_consulta(Txt_Nro_Historia_Clinica.Text.Trim(), Cmb_Sucursal.SelectedValue.ToString(), fila_empleado["tipo_doc"].ToString(), Cmb_Empleado.SelectedValue.ToString(), DateTime.Today.ToShortDateString().TrimEnd());
            string id_consulta = negocio.obtener_id_consulta();
            for (int i = 0; i < tbl_diagnosticos.Rows.Count; i++)
            {
                negocio.cargar_diagnosticos_consulta(Txt_Nro_Historia_Clinica.Text.Trim(), Cmb_Sucursal.SelectedValue.ToString(), id_consulta, tbl_diagnosticos.Rows[i].Cells[0].Value.ToString());

            }
            for (int i = 0; i < tbl_diagnosticos.Rows.Count; i++)
            {
                negocio.cargar_sintomas_consulta(Txt_Nro_Historia_Clinica.Text.Trim(), Cmb_Sucursal.SelectedValue.ToString(), id_consulta, tbl_sintomas.Rows[i].Cells[0].Value.ToString());

            }
            MessageBox.Show("Se cargo correctamente");

            Close();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
