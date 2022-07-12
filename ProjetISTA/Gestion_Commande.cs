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
    public partial class Gestion_Commande : Form
    {
        Connect C = new Connect();
        public static string idv;
        Add_venteDataContext db = new Add_venteDataContext();
        public Gestion_Commande()
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

        public void Loaddata()
        {
            C.Connection();

            DataTable dt = new DataTable("Vente");
            SqlDataAdapter Da = new SqlDataAdapter("select * from Vente", C.Cnx);
            Da.Fill(dt);
            gunaDataGridView1.DataSource = dt;
            C.Deconnection();

        }
        private void Gestion_Commande_Load(object sender, EventArgs e)
        {
            Loaddata();

        }

        private void UserTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

       

        

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
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

        private void BtnAjoutCmd_Click(object sender, EventArgs e)
        {
            Gestion_vente AC = new Gestion_vente();
            this.Hide();
            AC.Show();
        }

        

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idv = gunaDataGridView1.Rows[e.RowIndex].Cells["Id_vente"].FormattedValue.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SupCmd_Click(object sender, EventArgs e)
        {
            try
            {
               db.CMD_del1(Convert.ToInt32(idv));
                MessageBox.Show("Supprimer Avec success");
                Loaddata();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            All_Info AI = new All_Info();
            this.Hide();
            AI.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Facture F = new Facture();
            this.Hide();
            F.Show();
        }

        private void btnCloseAPP_Click(object sender, EventArgs e)
        {

        }
    }
}
