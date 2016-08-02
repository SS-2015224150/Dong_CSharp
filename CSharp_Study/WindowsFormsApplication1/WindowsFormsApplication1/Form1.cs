using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Click += Form1_Click;
        }

        void Form1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("마우스눌림");
        }
    }
}
