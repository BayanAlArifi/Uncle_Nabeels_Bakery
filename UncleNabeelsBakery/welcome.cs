using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UncleNabeelsBakery
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DragDrop mainframe = new DragDrop();
            mainframe.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DragDrop mainframe = new DragDrop();
            mainframe.Show();
            this.Hide();
        }
    }
}
