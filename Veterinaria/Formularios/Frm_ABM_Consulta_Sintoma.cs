﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria.Formularios
{
    public partial class Frm_ABM_Consulta_Sintoma : Form
    {

        Negocios.NG_Consultas negocio = new Negocios.NG_Consultas();
        public DataTable sintomas_consulta { get; set; }

        public Frm_ABM_Consulta_Sintoma()
        {
            InitializeComponent();
        }

        private void cargar_tabla()
        {
            DataTable datos = negocio.obtener_sintomas();
            if (datos.IsInitialized)
            {
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    tbl_sintomas.Rows.Add();
                    tbl_sintomas.Rows[i].Cells[0].Value = datos.Rows[i]["id_sintoma"].ToString();
                    tbl_sintomas.Rows[i].Cells[1].Value = (sintomas_consulta.Select("id_sintoma = " + datos.Rows[i]["id_sintoma"].ToString()).Length == 1);
                    tbl_sintomas.Rows[i].Cells[2].Value = datos.Rows[i]["descripcion"].ToString();
                }
            }
            else
                MessageBox.Show("No existen diagnosticos");
        }
    

        private void Frm_ABM_Consulta_Sintoma_Load(object sender, EventArgs e)
        {
            cargar_tabla();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Vista.Frm_ABM_Consultas dueño = (Vista.Frm_ABM_Consultas)Owner;
            dueño.tabla_sintomas.Rows.Clear();
            bool esta_checkeado;
            for (int i = 0; i < tbl_sintomas.Rows.Count; i++)
            {
                esta_checkeado = (bool)tbl_sintomas.Rows[i].Cells[1].Value;
                if (esta_checkeado)
                {
                    DataRow fila = sintomas_consulta.NewRow();
                    fila[0] = tbl_sintomas.Rows[i].Cells[0].Value.ToString();
                    fila[1] = tbl_sintomas.Rows[i].Cells[2].Value.ToString();
                    sintomas_consulta.Rows.Add(fila);
                }
            }

            dueño.tabla_sintomas = sintomas_consulta;
            dueño.cargar_sintomas();
            Close();
        }
    }
}
