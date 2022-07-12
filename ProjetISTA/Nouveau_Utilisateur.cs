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
    public partial class Nouveau_Utilisateur : Form
    {
        Connect C = new Connect();
        public Nouveau_Utilisateur()
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


        private void Nouveau_Utilisateur_Load(object sender, EventArgs e)
        {
           // TypeUserList.Items.Add("Guest");
            TypeUserList.Items.Add("user");
            TypeUserList.Items.Add("admin");
        }

        private void btnCloseAPP_Click(object sender, EventArgs e)
        {
             this.Hide();
            Menu MA = new Menu();
            MA.Show();
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu MA = new Menu();
            MA.Show();
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            try {
                if (txtNomCli.Text=="" && txtmdpCli.Text=="" && txtcmdpCli.Text=="" && TypeUserList.Text=="")
                {
                    MessageBox.Show("Tous les champs sont requise");
                }
                else
                {
                    if (txtmdpCli.Text != txtcmdpCli.Text)
                    {
                        MessageBox.Show("Le mot se passe et confirmation mot de passe ne sont pas identique");
                    }
                    else
                    {
                        C.Connection();
                        C.Cmd = C.Cnx.CreateCommand();
                        C.Cmd.CommandText = "INSERT INTO UserLog VALUES('" + txtNomCli.Text + "','" + txtmdpCli.Text + "','" + TypeUserList.Text + "')";
                        C.Cmd.ExecuteNonQuery();
                        C.Deconnection();
                        MessageBox.Show("Utilisateur Ajouter Avec Sucess");
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
