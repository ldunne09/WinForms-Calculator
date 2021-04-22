using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Calculator
{
    public partial class Form1 : Form
    {
        float results;
       // float number2;
        bool isOP = false;
        string OPCheck;
        Button btn = new Button();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOP)
            {
                textBox1.Clear();
            }
            btn = (Button)sender;
            textBox1.Text += btn.Text;
            isOP = false;
        }
        private void operand_Click(object sender, EventArgs e)
        {
            btn = (Button)sender;
            if (results != 0)
            {
                equalsBTN.PerformClick();
                OPCheck = btn.Text;
                lblStore.Text = results + " " + OPCheck.ToString();
                isOP = true;
            }
            else
            {
                OPCheck = btn.Text;
                results = float.Parse(textBox1.Text);
                lblStore.Text = results + " " + OPCheck.ToString();
                isOP = true;
            }
        }
        private void ce_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0"; 
        }
        private void c_Click(object sender, EventArgs e)
        {
            lblStore.Text = "";
            textBox1.Text = "0";
            results = 0; 
        }
        private void equals_Click(object sender, EventArgs e)
        {
            switch (OPCheck)
            {
                case "+":
                    textBox1.Text = (results + float.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (results * float.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (results - float.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (results / float.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            results = float.Parse(textBox1.Text);
            lblStore.Text = "";
        }
    }
}
