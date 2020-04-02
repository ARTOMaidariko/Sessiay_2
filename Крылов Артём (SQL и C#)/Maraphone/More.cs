using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maraphone
{
    public partial class More : Form
    {
        public More()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            TimeSpan time1;
            DateTime initial_time = Convert.ToDateTime(" 21.10.2017 6:00 ");
            DateTime current_time = DateTime.Now;
            time1 = initial_time - current_time;
            this.time1.Text = time1.Days.ToString() + " дней " + time1.Hours.ToString() + " часов и " + time1.Minutes.ToString() + "минут до старта марафона!";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Main Main = new Main();
            Main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info Info = new Info();
            Info.Show();
            this.Hide();
        }
    }
}
