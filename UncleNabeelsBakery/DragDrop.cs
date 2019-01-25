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
    public partial class DragDrop : Form
    {
        int type;
        public DragDrop()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.OneOverThree.MouseDown += OneOverThree_MouseDown;
            this.OneOverSix.MouseDown += OneOverSix_MouseDown;
            this.OneOverTwo.MouseDown += OneOverTwo_MouseDown;
        }

        protected override void OnGiveFeedback(GiveFeedbackEventArgs e)
        {
            e.UseDefaultCursors = false;
        }

        protected override void OnDragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
                e.Effect = DragDropEffects.Copy;
        }

        protected override void OnDragDrop(DragEventArgs e)
        {
            //Convert mouse position screen coordinates to client coordinates
            int x = this.PointToClient(new Point(e.X, e.Y)).X;
            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            //If coordinates are withing the picturebox -> show the drag drop effect
            switch (type)
            {
                case 1:
                    if (x >= 454 && x <= 454 + 372 &&
                        y >= 482 && y <= 482 + 189)
                    {
                        OneOverTwo.Location = new Point(454, 482);
                        OneOverTwo.SendToBack();
                    }
                    break;
                case 2:
                    if (x >= 630 && x <= 630 + 190 &&
                        y >= 325 && y <= 325 + 171)
                    {
                        OneOverSix.Location = new Point(630, 325);
                        OneOverSix.SendToBack();
                    }
                    break;
                case 3:
                    if (x >= 456 && x <= 456 + 276 &&
                        y >= 303 && y <= 303 + 190)
                    {
                        OneOverThree.Location = new Point(456, 303);
                        OneOverThree.SendToBack();
                    }
                    break;
                default:
                    break;
            }
        }

        // 1 OVER 3
        private void OneOverThree_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                type = 3;
                var dragImage = (Bitmap)OneOverThree.Image;
                IntPtr icon = dragImage.GetHicon();
                Cursor.Current = new Cursor(icon);
                DoDragDrop(OneOverThree.Image, DragDropEffects.Copy);
                DestroyIcon(icon);
            }
        }

        // 1 OVER 6
        private void OneOverSix_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                type = 2;
                var dragImage = (Bitmap)OneOverSix.Image;
                IntPtr icon = dragImage.GetHicon();
                Cursor.Current = new Cursor(icon);
                DoDragDrop(OneOverSix.Image, DragDropEffects.Copy);
                DestroyIcon(icon);
            }
        }

        // 1 OVER 2
        private void OneOverTwo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                type = 1;
                var dragImage = (Bitmap)OneOverTwo.Image;
                IntPtr icon = dragImage.GetHicon();
                Cursor.Current = new Cursor(icon);
                DoDragDrop(OneOverTwo.Image, DragDropEffects.Copy);
                DestroyIcon(icon);
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        extern static bool DestroyIcon(IntPtr handle);

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            welcome mainframe = new welcome();
            mainframe.Show();
            this.Hide();
        }
    }
}
