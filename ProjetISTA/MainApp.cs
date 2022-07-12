using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetISTA
{
    public partial class MainApp : Form
    {
        LGS L = new LGS();
       
        Connect C = new Connect();
        public MainApp()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void btnNC_Click(object sender, EventArgs e)
        {
            Ajout_Client AC = new Ajout_Client();
            this.Hide();
            AC.Show();
        }

        private void btnNP_Click(object sender, EventArgs e)
        {
            Ajout_Produit AP = new Ajout_Produit();
            this.Hide();
            AP.Show();
        }

        

        private void btnGC_Click(object sender, EventArgs e)
        {
            Gestion_Client GC = new Gestion_Client();
            this.Hide();
            GC.Show();
        }

        private void btnGP_Click(object sender, EventArgs e)
        {
            Gestion_Produit GP = new Gestion_Produit();
            this.Hide();
            GP.Show();
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            Gestion_Commande GC = new Gestion_Commande();
            this.Hide();
            GC.Show();
        }

       

        private void btnDiscon_Click(object sender, EventArgs e)
        {
            this.Hide();
            LGS LoginScreen = new LGS();
            LoginScreen.Show();
        }

        private void btnCloseAPP_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            Gestion_vente GV = new Gestion_vente();
            this.Hide();
            GV.Show();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            
                gunaLabel1.Text = Convert.ToString(LGS.idu);
               


            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Profile_User pu = new Profile_User();
            this.Hide();
            pu.Show();
        }
    }
}
