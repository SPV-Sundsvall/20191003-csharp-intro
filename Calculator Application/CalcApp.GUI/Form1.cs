using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcApp.GUI
{
    public partial class Form1 : Form
    {
        CalculatorEngine calc = new CalculatorEngine();

        public Form1()
        {
            InitializeComponent();

            button1.Text = "+";
            button2.Text = "-";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ta de två talen
            //gör beräkningen "+"
            //visa svaret i listboxen
            //hmm..hur kommer jag nu vidare??


            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int answer = calc.Add(x, y);

            ShowResult(x, y, answer);
        }

        private void ShowResult(int x, int y, int answer)
        {
            listBox1.Items.Add(string.Format("{0} + {1} = {2}", x, y, answer));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int answer = calc.Sub(x, y);

            ShowResult(x,y,answer);
        }
    }

    public class CalculatorEngine
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Sub(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
