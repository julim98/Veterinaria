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
    }
}