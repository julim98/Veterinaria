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

        public resultado_validacion validar(Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox)item).CausesValidation == true)
                    {
                        if (((TextBox)item).Text == "")
                        {
                            MessageBox.Show("El " + ((TextBox)item).Name + " está vacío");
                            ((TextBox)item).Focus();
                            return resultado_validacion.incorrecta;
                        }

                    }
                }
                if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox)item).CausesValidation == true)
                    {
                        if ((((ComboBox)item).SelectedIndex == -1))
                        {
                            MessageBox.Show("El " + ((ComboBox)item).Name + " no tiene selección");
                            ((ComboBox)item).Focus();
                            return resultado_validacion.incorrecta;
                        }
                    }
                }
            }
            return resultado_validacion.correcta;
        }


        public static bool validacion_textos(params TextBox[] lista)
        {
            for (int i = 0; i < lista.Count(); i++)
            {
                if(lista[i].Text == "")
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