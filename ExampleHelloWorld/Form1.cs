using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExampleHelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "ExampleHelloWorld";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Current Time: " + HelloWorldClassLib.TestClass.SystemTime();
        }
    }
}
