using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MLApp;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimplify_Click(object sender, EventArgs e)
        {
            MLApp.MLApp matlab=new MLApp.MLApp();
            matlab.Visible = 0;
            MessageBox.Show(matlab.Execute("syms "+txtVariable.Text+";simplify("+txtEquation.Text+");disp(ans)"));
        }
    }
}
