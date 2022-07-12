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
    public partial class Gestion_Client : Form
    {
        Connect C = new Connect();
        public static string idcl;
        public static string idimg;
        public Gestion_Client()
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


        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MainApp MA = new MainApp();
            //MA.Show();
            if (LGS.Usertype == "admin")
            {
                this.Hide();
                Menu Me = new Menu();
                Me.Show();
            }
            else if (LGS.Usertype == "user")
            {
                this.Hide();
                MainApp MA = new MainApp();
                MA.Show();

            }
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            Ajout_Client AC = new Ajout_Client();
            this.Hide();
            AC.Show();
        }

        private void btnCloseAPP_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
        private void LoadData2()
        {
            C.Connection();

            DataTable dt = new DataTable("Client");
            SqlDataAdapter Da = new SqlDataAdapter("select Id_Cl,City_Id,Nom_Cl,Prenom_Cl,Tel_Cl,Email_Cl from Client", C.Cnx);
            Da.Fill(dt);
            gunaDataGridView1.DataSource = dt;
            C.Deconnection();

        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Gestion_Client_Load(object sender, EventArgs e)
        {
            LoadData2();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Image_Client IC = new Image_Client();
            this.Hide();
            IC.Show();
        }

        private void ClientTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClientTxt.Text))
            {
                LoadData2();
            }
            else
            {
                try
                {
                    C.Connection();

                    C.Cmd = C.Cnx.CreateCommand();
                    C.Cmd.CommandText = "select City_Id,Nom_Cl,Prenom_Cl,Tel_Cl,Email_Cl from Client where Nom_Cl ='" + ClientTxt.Text + "'";
                    C.Dr = C.Cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(C.Dr);


                    gunaDataGridView1.DataSource = dt;

                    C.Deconnection();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idcl = gunaDataGridView1.Rows[e.RowIndex].Cells["Nom_Cl"].FormattedValue.ToString();

                idimg = gunaDataGridView1.Rows[e.RowIndex].Cells["Id_Cl"].FormattedValue.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (idcl != null)
            {
                C.Connection();
                C.Cmd = C.Cnx.CreateCommand();
                C.Cmd.CommandText = "delete from Client where Nom_Cl ='" + idcl + "'";
                C.Cmd.ExecuteNonQuery();
                C.Deconnection();
                MessageBox.Show("deleted succcesfuly");
                LoadData2();

            }
            else
            {
                MessageBox.Show("Vous devez dabord selectionner un Client");

            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modifié_Client MC = new Modifié_Client();
            MC.Show();
        }
    }
}
