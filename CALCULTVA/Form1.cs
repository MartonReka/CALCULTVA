using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULTVA
{
    public partial class Form1 : Form
    {
        double val1, tva1, val2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calculeaza_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(valoare.Text);
            tva1 = Convert.ToDouble(TVA.Text);
            val2 = val1 + val1 * tva1 / 100;
            valtva.Text = "Valoarea produsului cu TVA este:\n" + Convert.ToString(val2);

        }
    }
}
