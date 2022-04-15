using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grundrechnungsarten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Berechnen_Click(object sender, EventArgs e)
        {
            int z1, z2;
            Int32.TryParse(Txt_Zahl1.Text, out z1); 
            Int32.TryParse(Txt_Zahl2.Text, out z2); 

            Lbl_Plus.Text = (z1 + z2).ToString();
            Lbl_Minus.Text = (z1 - z2).ToString();
            Lbl_Mal.Text = (z1 * z2).ToString();
            Lbl_Div.Text = (z2 != 0) ? (z1 / z2).ToString() : "0";




        }

        private void Btn_Ende_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
