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

       
    }
}