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
    public partial class Profile_User : Form
    {
        Connect C = new Connect();
        public Profile_User()
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


        private void btnCloseAPP_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void btnDiscon_Click(object sender, EventArgs e)
        {
            this.Hide();
            LGS LoginScreen = new LGS();
            LoginScreen.Show();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainApp MA = new MainApp();
            MA.Show();
        }

        private void Profile_User_Load(object sender, EventArgs e)
        {
            C.Connection();
            C.Cmd = C.Cnx.CreateCommand();
            C.Cmd.CommandText = "SELECT UserN ,PassN FROM UserLog where UserN = '" + Convert.ToString(LGS.idu) + "'";
            C.Dr = C.Cmd.ExecuteReader();
            while (C.Dr.Read())
            {
                txtUsername.Text = C.Dr[0].ToString();
                txtpass.Text = C.Dr[1].ToString();


            }
            C.Deconnection();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" && txtpass.Text == "" && txtCpass.Text == "")
                {
                    MessageBox.Show("Tous les champs sont requise");
                }
                else
                {
                    if (guna2TextBox1.Text != txtCpass.Text)
                    {
                        MessageBox.Show("Le mot se passe et confirmation mot de passe ne sont pas identique");
                    }
                    else
                    {
                        C.Connection();
                        C.Cmd = C.Cnx.CreateCommand();
                        C.Cmd.CommandText = "update UserLog set PassN = '" + txtpass.Text + "'where UserN ='" + txtUsername.Text + "'  ";
                        C.Cmd.ExecuteNonQuery();

                        MessageBox.Show("Utilisateur Modifié Avec Sucess");
                        
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
