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
    public partial class Frm_ABM_Vacunas : Form
    {
        public enum modo { registrar, modificar }
        public modo control_modo { get; set; }
        public string id_vacuna { get; set; }
        public Frm_ABM_Vacunas()
        {
            InitializeComponent();
        }
    }
}