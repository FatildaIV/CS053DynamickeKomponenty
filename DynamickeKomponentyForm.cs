using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS051DynamickeKomponenty
{
    public partial class DynamickeKomponentyForm : Form
    {
        public DynamickeKomponentyForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DynamickeKomponentyForm_Click(object sender, EventArgs e)
        {
            
        }

        private class AnimovanyObjekt
        {
            public int dx { get; set; }
            public int dy { get; set; }

            public AnimovanyObjekt(int dx, int dy)
            {
                this.dx = dx;
                this.dy = dy;
            }
        }

        private void DynamickeKomponentyForm_MouseClick(object sender, MouseEventArgs e)
        {
            var checkbox = new CheckBox();
            checkbox.Top = e.Y;
            checkbox.Left = e.X;
            checkbox.Tag = new AnimovanyObjekt(5, 5);
            this.Controls.Add(checkbox);

        }

        private void animaceTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(CheckBox))

                {
                    CheckBox ch = (c as CheckBox);
                    ch.Top += (ch.Tag as AnimovanyObjekt).dy;
                    ch.Left += (ch.Tag as AnimovanyObjekt).dx;
                    if (ch.Top >= this.Height || ch.Top <= 0)
                    {
                        (ch.Tag as AnimovanyObjekt).dy *= -1;
                    }
                    if (ch.Left >= this.Width || ch.Left <= 0)
                    {
                        (ch.Tag as AnimovanyObjekt).dx *= -1;
                    }
                }                
            }
        }
    }
}
