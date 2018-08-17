using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qwiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Button b1 = new Button();
            b1.Text = "b1";
            Controls.Add(b1);
            b1.Width = button1.Width;
            b1.Left = button1.Left;
            b1.Top = button1.Top + button1.Height;


            Button b2 = new Button();
            b2.Text = "b2";
            Controls.Add(b2);
            b2.Width = button1.Width;
            b2.Left = button1.Left;
            b2.Top = button1.Top - button1.Height;


            TextBox T2 = new TextBox();
            T2.Text = "T2";
            Controls.Add( T2);
            T2.Width = button1.Width;
            T2.Left = button1.Left - button1.Left;
            T2.Top = button1.Top ;

            TextBox T1 = new TextBox();
            T1.Text = " T1";
            Controls.Add(T1);
            T1.Width = button1.Width;
            T1.Left = button1.Left + button1.Left;
            T1.Top = button1.Top;
        }
    }
}
