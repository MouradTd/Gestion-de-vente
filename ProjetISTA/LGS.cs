using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetISTA
{
    public partial class LGS : Form
    {
        public static string idu;
        public static string Usertype;
        
        Connect C = new Connect();
        int i = 3;
        public void ClearFieldds()
        {
            UserTxt.Clear();
            PassTxt.Clear();
        }
        public LGS()
        {
            InitializeComponent();
            HidePass.Hide();
        }
        public void UserText_Enter(object sender, EventArgs e)
        {
            if (UserTxt.Text == "Nom Utilisateur")
            {
                UserTxt.Text = "";
            }
        }
        public void PassText_Enter(object sender, EventArgs e)
        {
            if (PassTxt.Text == "Mot De Passe")
            {
                PassTxt.Text = "";
            }
        }
        private void SeePass_Click(object sender, EventArgs e)
        {
            PassTxt.PasswordChar = '\0';
            SeePass.Hide();
            HidePass.Show();
        }
        private void HidePass_Click(object sender, EventArgs e)
        {
            PassTxt.PasswordChar = '*';
            HidePass.Hide();
            SeePass.Show();
        }
        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ConnectBTN_Click(object sender, EventArgs e)
        {
            if (UserTxt.Text == "" | PassTxt.Text == "")
            {
                MessageBox.Show("Entrez-Vous Informations :)");
            }
            else
            {
                i = i - 1;
                if (i > 0)
                {
                    C.Connection();
                    C.Cmd = C.Cnx.CreateCommand();
                    C.Cmd.CommandText = "SELECT COUNT(*) FROM UserLog WHERE UserN='" + UserTxt.Text + "' AND PassN='" + PassTxt.Text + "'";
                    int i = Convert.ToInt32(C.Cmd.ExecuteScalar());
                    C.Deconnection();
                    if (i > 0)
                    {
                        C.Connection();
                        C.Cmd = C.Cnx.CreateCommand();
                        C.Cmd.CommandText = "SELECT TypeUser FROM UserLog WHERE UserN='" + UserTxt.Text + "' AND PassN='" + PassTxt.Text + "'";
                        C.Dr = C.Cmd.ExecuteReader();
                        while (C.Dr.Read())
                        {
                            idu = UserTxt.Text;
                            Usertype = C.Dr[0].ToString();
                        }
                        if (Usertype == "admin")
                        {
                            Menu Mn = new Menu();
                            this.Hide();
                            Mn.Show();

                        }
                        else if (Usertype == "user")
                        {
                            MainApp MA = new MainApp();

                            this.Hide();
                            MA.Show();
                        }
                        C.Deconnection();
                    }
                    AttentionLabel.Text = "Attention, Il Vous Restes " + (i) + " Essaie !!!";
                }
            }
                /*
                try
                {
                    if (UserTxt.Text == "" | PassTxt.Text == "")
                    {
                        MessageBox.Show("Entrez-Vous Informations :)");
                    }
                    else
                    {
                        i = i - 1;
                        if (i > 0)
                        {
                            C.Connection();
                            C.Cmd = C.Cnx.CreateCommand();
                            C.Cmd.CommandText = "SELECT (*) FROM UserLog WHERE UserN='" + UserTxt.Text + "' AND PassN='" + PassTxt.Text + "'";
                            int i = Convert.ToInt32(C.Cmd.ExecuteScalar());
                            C.Deconnection();
                            if (i > 0)
                            {
                                C.Connection();
                                C.Cmd = C.Cnx.CreateCommand();
                                C.Cmd.CommandText = "SELECT TyprUser FROM UserLog WHERE UserN='" + UserTxt.Text + "' AND PassN='" + PassTxt.Text + "'";
                                while (C.Dr.Read())
                                {
                                    Usertype = C.Dr[0].ToString();
                                }
                                if (Usertype == "admin")
                                {
                                    Menu Mn = new Menu();
                                    this.Hide();
                                    Mn.Show();

                                }
                                else if (Usertype == "User")
                                {
                                    MainApp MA = new MainApp();

                                    this.Hide();
                                    MA.Show();
                                }
                                C.Deconnection();
                            }
                            AttentionLabel.Text = "Attention, Il Vous Restes " + (i) + " Essaie !!!";
                        }
                        else
                        {
                            MessageBox.Show("L'Application Va Se Fermer :(");
                            ClearFieldds();
                            Application.Exit();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Une Erreur Est Detecte !!!!");
                }*/
            }

        private void btnCloseAPP_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}