using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winter_v0._2_menu
{
    public partial class msg : Form
    {
        public msg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            int frequency = 300;

            // Set the Duration
            int duration = 500;

            // Play beep sound once
            Console.Beep(frequency, duration);
        }

        private void msg_Load(object sender, EventArgs e)
        {

        }
    }
}
