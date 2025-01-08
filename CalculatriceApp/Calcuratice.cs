using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatriceApp
{
    public partial class Calcuratice : Form
    {
        public Calcuratice()
        {
            InitializeComponent();
        }
        string operateur;
        private void button12_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "1";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "4";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "6";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "8";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "3";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "5";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "7";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "9";

        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "0";

        }

        private void button_virgule_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += ",";

        }

        private void button_egal_Click(object sender, EventArgs e)
        {
            //plus
            if (operateur == "+")
            {
                string[] chaine = textBox_resultat.Text.Split('+');
                textBox_resultat.Text +=Environment.NewLine+'='+Environment.NewLine+ (double.Parse(chaine[0]) + double.Parse(chaine[1])).ToString();
            }
            //moins
            if (operateur == "-")
            {
                string[] chaine = textBox_resultat.Text.Split('-');
                textBox_resultat.Text += Environment.NewLine + '=' + Environment.NewLine + (double.Parse(chaine[0]) - double.Parse(chaine[1])).ToString();
            }
            //multiple
            if (operateur == "*")
            {
                string[] chaine = textBox_resultat.Text.Split('*');
                textBox_resultat.Text += Environment.NewLine + '=' + Environment.NewLine + (double.Parse(chaine[0]) * double.Parse(chaine[1])).ToString();
            }
            // div
            if (operateur == "/")
            {
                string[] chaine = textBox_resultat.Text.Split('/');
                // verification si c'est different de zero
                if (double.Parse(chaine[1]) !=0)
                {
                    textBox_resultat.Text += Environment.NewLine + '=' + Environment.NewLine + (double.Parse(chaine[0]) / double.Parse(chaine[1])).ToString();

                }
                else
                {
                    textBox_resultat.Text += Environment.NewLine + '=' + Environment.NewLine + "La division sur 0 est impossible ";

                }
            }
        }

        private void button_effacer_Click(object sender, EventArgs e)
        {
            textBox_resultat.Clear();

        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "+";
            operateur = "+";
        }

        private void button_moin_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "-";
            operateur = "-";


        }

        private void button_multiple_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "*";
            operateur = "*";


        }

        private void butto_division_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "/";
            operateur = "/";


        }
    }
}
