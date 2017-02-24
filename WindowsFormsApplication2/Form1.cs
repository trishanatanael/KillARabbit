using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Rabbit_MouseDown(object sender, MouseEventArgs e)
        {
            this.Rabbit.Font = new System.Drawing.Font("Arial",30F, System.Drawing.FontStyle.Bold);
            this.Rabbit.BackColor = System.Drawing.SystemColors.ScrollBar;


        }
        public Random r = new Random();
        private void Rabbit_MouseUp(object sender, MouseEventArgs e)
        {
            int x = r.Next(0, 925);
            int y = r.Next(0, 445);
            this.Rabbit.Location = new System.Drawing.Point(x,y);
            this.Rabbit.BackColor = System.Drawing.SystemColors.WindowFrame;
        }

    }
}
