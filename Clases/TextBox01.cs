using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria.Clases

{
    class TextBox01 : TextBox
    {
        public bool validar { get; set; }
        public string nombre_tabla { get; set; }
        public string nombre_campo { get; set; }
    }
}
