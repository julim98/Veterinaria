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

namespace Veterinaria.Vista
{
    public partial class Frm_Empleados : Form
    {
        string cadena_conexion = "Provider=SQLNCLI11;Data Source=DESKTOP-K8CJ3KA;Integrated Security=SSPI;Initial Catalog=_BD_VETERINARIA";
        public Frm_Empleados()
        {
            InitializeComponent();
            cargar_combo();
        }

        private void cargar_combo()
        {
            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            string sql = "";
            DataTable tabla = new DataTable();

            sql = "SELECT nombre FROM empleados";
            conexion.ConnectionString = cadena_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            tabla.Load(cmd.ExecuteReader());
            conexion.Close();
            Cmb_Tipo_Documento.DataSource = tabla;
            Cmb_Tipo_Documento.DisplayMember = "nombre";
            Cmb_Tipo_Documento.ValueMember = "nombre";
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

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            NG_Empleados negocio = new NG_Empleados();
            DataTable tabla = negocio.tabla_empleados(
                Cmb_Tipo_Documento.SelectedIndex.ToString(),
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
            }
        }
<<<<<<< HEAD
=======

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            //Tbl_Empleados.SelectedRows;
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {

        }
>>>>>>> 4ca2ef0c29baec13e826e01344d70acccb634605
    }
}
