using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria.Clases
{
    class tratamientos_especiales
    {
        public enum resultado_validacion { correcta, incorrecta }


        public static bool validacion_textos(params TextBox[] lista)
        {
            for (int i = 0; i < lista.Count(); i++)
            {
                if(lista[i].Text.Trim() == "")
                {
                    MessageBox.Show("El " + lista[i].Name + " está vacío");
                    lista[i].Focus();
                    return true;
                }
            }
            return false;
        }

        public static bool validacion_combos(params ComboBox[] lista)
        {
            for (int i = 0; i < lista.Count(); i++)
            {
                if (lista[i].SelectedIndex == -1)
                {
                    MessageBox.Show("El " + lista[i].Name + " no tiene selección");
                    lista[i].Focus();
                    return true;
                }
            }
            return false;
        }
    }
}