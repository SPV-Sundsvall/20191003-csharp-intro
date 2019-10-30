using CalcApp.BusinessLogic;
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

            string op = ((Button)sender).Text;
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int answer = calc.Add(x, y);

            ShowResult(x, y, answer, op);
        }

        private void ShowResult(int x, int y, int answer, string operation)
        {
            listBox1.Items.Add(string.Format("{0} {3} {1} = {2}", x, y, answer, operation));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string op = ((Button)sender).Text;
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int answer = calc.Sub(x, y);

            ShowResult(x,y,answer, op);
        }
    }

    
}
