using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarbtn_Click(object sender, EventArgs e)
        {
            string[] nombre = new string[] { nombretxt.Text };

            string[] edad = new string[] { edadtxt.Text };

            foreach (var y in nombre)
            {
                foreach (var x in edad)
                {
                    unir_combobox.Items.Add(y + "  " + x);

                    Z_A_combobox.Items.Add(y + "  " + x);
                 
                    A_Z_combobox.Items.Add(y + "  " + x);
           

                }
            }
           
                nombretxt.Clear();
            edadtxt.Clear();

        }

        
           
        
    }
}
