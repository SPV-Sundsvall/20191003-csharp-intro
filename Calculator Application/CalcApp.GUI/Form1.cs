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
        public Form1()
        {
            InitializeComponent();

            button1.Text = "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ta de två talen
            //gör beräkningen "+"
            //visa svaret i listboxen
            //hmm..hur kommer jag nu vidare??

            CalculatorEngine calc;
            calc = new CalculatorEngine();

            int x;
            int y;
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);

            int answer;
            answer = calc.Add(x, y);

            listBox1.Items.Add(answer);
        }
    }

    public class CalculatorEngine
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
