using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class Validation
    {
        public Validation()
        {

        }

        // Metod som förhindrar dubletter när man lägger till nya kategorier
        public void CheckDuplicate(TextBox tb, string str)
        {
            if (tb.Text.Equals(str))
            {
                MessageBox.Show(tb.Text + " finns redan");
                throw new Exception();
            }
        }

        public void CheckEmptyFields(TextBox tb1, ComboBox cb1, ComboBox cb2, TextBox tb2)
        {
            if (tb1.Text.Equals(""))
            {
                MessageBox.Show("Vänligen fyll i en URL");
                throw new Exception();
            }
            else if (cb1.SelectedIndex < 0) 
            {
                MessageBox.Show("Vänligen välj en uppdateringsfrekvens");
                throw new Exception();
            }
            else if(cb2.SelectedIndex < 0)
            {
                MessageBox.Show("Vänligen välj en kategori");
                throw new Exception();
            }
            else if(tb2.Text.Equals(""))
            {
                MessageBox.Show("Vänligen ange ett namn");
                throw new Exception();
            }
        }
    }
}