using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace ProjetISTA
{
  
    public partial class Modifié_Utilisateur : Form
    {
        Connect C = new Connect();
        //Gestion_Utilisateurs gu = new Gestion_Utilisateurs();
        public Modifié_Utilisateur()
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

        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_Utilisateurs Gu = new Gestion_Utilisateurs();
            Gu.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnModifié_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcmdpCli.Text == "" && txtmdpCli.Text == "")
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
                        C.Cmd.CommandText = "update UserLog set PassN = '" + txtmdpCli.Text + "'where UserN ='" + txtNomCli.Text + "'  ";
                        C.Cmd.ExecuteNonQuery();

                        MessageBox.Show("Utilisateur Modifié Avec Sucess");
                        BackMenu_Click(sender, e);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }



           

        }

        private void Modifié_Utilisateur_Load(object sender, EventArgs e)
        {
            try {
                if (Gestion_Utilisateurs.idn != null)
                {
                    C.Connection();
                    C.Cmd = C.Cnx.CreateCommand();
                    C.Cmd.CommandText = "select * from UserLog where UserN ='" + Gestion_Utilisateurs.idn + "'";
                    C.Dr = C.Cmd.ExecuteReader();
                    while (C.Dr.Read())
                    {
                        txtNomCli.Text = C.Dr[0].ToString();
                        txtmdpCli.Text = C.Dr[1].ToString();
                        txtcmdpCli.Text = C.Dr[1].ToString();
                    }

                    C.Deconnection();

                }
                else
                {
                    MessageBox.Show("fuck off");

                }

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
           
           
            //MessageBox.Show(Gestion_Utilisateurs.idn);
        }
    }
}
