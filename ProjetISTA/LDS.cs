using System;
using System.Windows.Forms;

namespace ProjetISTA
{
    public partial class LDS : Form
    {
        public LDS()
        {
            InitializeComponent();
        }
        private void loadingtimer_Tick(object sender, EventArgs e)
        {
            loading2.Width += 5;
            if (loading2.Width >= loading1.Width)
            {
                loadingtimer.Stop();
                this.Hide();
                LGS LG1 = new LGS();
                LG1.Show();
            }
        }
    }
}
