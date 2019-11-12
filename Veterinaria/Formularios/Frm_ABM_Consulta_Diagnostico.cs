using System;
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
    public partial class Frm_ABM_Consulta_Diagnostico : Form
    {

        string historia_clinica { get; set; }

        public Frm_ABM_Consulta_Diagnostico()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Consulta_Diagnostico_Load(object sender, EventArgs e)
        {
            tbl_diagnosticos.Columns[1].
        }
    }
}
