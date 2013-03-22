using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chap4Pro4_Swap
{
    public partial class Form1 : Form
    {
        Elephant Lucinda;
        Elephant Lloyd;

        public Form1()
        {
            InitializeComponent();
            Lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LloydB1_Click(object sender, EventArgs e)
        {
            Lloyd.WhoAmI();
        }

        private void LucindaB2_Click(object sender, EventArgs e)
        {
            Lucinda.WhoAmI();
        }

        private void SwapB3_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = Lloyd;
            Lloyd = Lucinda;
            Lucinda = holder;
            MessageBox.Show("Objects Swapped!!!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ///Lloyd.TellMe("Hi", Lucinda);
            Lloyd.SpeakTo(Lucinda, "Hello");

            //Lloyd = Lucinda;
            //Lloyd.EarSize = 4321;
            //Lloyd.WhoAmI();
        }
    }
}
