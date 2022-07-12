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
    public partial class Gestion_Utilisateurs : Form
    {
        Connect C = new Connect();
       public static string idn;
        public Gestion_Utilisateurs()
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


        private void LoadData1()
        {
            C.Connection();

            DataTable dt = new DataTable("UserLog");
            SqlDataAdapter Da = new SqlDataAdapter("select * from UserLog", C.Cnx);
            Da.Fill(dt);
            gunaDataGridView1.DataSource = dt;
            C.Deconnection();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Menu Me = new Menu();
            Me.Show();




        }



        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnCloseAPP_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();

        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nouveau_Utilisateur NA = new Nouveau_Utilisateur();
            NA.Show();

        }

        private void Gestion_Utilisateurs_Load(object sender, EventArgs e)
        {
            LoadData1();

        }

        private void UserTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserTxt.Text))
            {
                LoadData1();
            }
            else
            {
                try
                {
                    C.Connection();

                    C.Cmd = C.Cnx.CreateCommand();
                    C.Cmd.CommandText = "select * from UserLog where UserN ='" + UserTxt.Text + "'";
                    C.Dr = C.Cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(C.Dr);


                    gunaDataGridView1.DataSource = dt;

                    C.Deconnection();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            if (idn!=null)
            {
                C.Connection();
                C.Cmd = C.Cnx.CreateCommand();
                C.Cmd.CommandText = "delete from UserLog where Usern ='"+idn+"'";
                C.Cmd.ExecuteNonQuery();
                C.Deconnection();
                MessageBox.Show("deleted succcesfuly");
                LoadData1();

            }
            else
            {
                MessageBox.Show("Vous devez dabord selectionner un utilisateur");

            }


        }

        

        private void gunaDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             idn = gunaDataGridView1.Rows[e.RowIndex].Cells["UserN"].FormattedValue.ToString();
            

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modifié_Utilisateur MU = new Modifié_Utilisateur();
            MU.Show();
        }
    }
}
