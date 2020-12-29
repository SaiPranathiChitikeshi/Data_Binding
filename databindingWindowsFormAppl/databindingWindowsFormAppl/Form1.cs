using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databindingWindowsFormAppl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if((ID!=) ||(PWD.AccessibleName != "Prana")){
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Sucess");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
