using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetISTA
{
    public partial class Menu : Form
    {
        

        Connect C = new Connect();

        public Menu()
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


        private void gunaButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            LGS LoginScreen = new LGS();
            LoginScreen.Show();
        }
        void FillShart()
        {
            C.Connection();
                DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Nom_Pr, Quantite_Pr FROM Produit", C.Cnx);
            //C.Cmd = new SqlCommand("SELECT Nom_Pr, Quantite_Pr FROM Produit", C.Cnx);
            //C.Dr = C.Cmd.ExecuteReader();
            //dt.Load(da);
            da.Fill(dt);
                chart1.DataSource = dt;
              
                
                    chart1.Series["Quantité"].XValueMember = "Nom_Pr";
                    chart1.Series["Quantité"].YValueMembers = "Quantite_Pr";
                    chart1.Titles.Add("Produit Disponible aux stock");

            C.Deconnection();  
        }
       
        void FillGrid()
        {
            C.Connection();

            DataTable dt = new DataTable("Data");
            SqlDataAdapter Da = new SqlDataAdapter("select v.* ,c.Id_Cmd , c.Id_Pr ,c.Prix as 'Prix Unitaire',c.Quantite from Vente v , Detail_Cmd c where v.Id_vente = c.Id_vente", C.Cnx);
            Da.Fill(dt);
            gunaDataGridView1.DataSource = dt;
            C.Deconnection();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            FillGrid();
            C.Connection();
            C.Cmd = C.Cnx.CreateCommand();
            C.Cmd.CommandText = "SELECT UserN ,TypeUser FROM UserLog where UserN = '"+ Convert.ToString(LGS.idu)+"'";
            C.Dr = C.Cmd.ExecuteReader();
            while (C.Dr.Read())
            {
                gunaLabel3.Text = C.Dr[0].ToString();
                gunaLabel4.Text = C.Dr[1].ToString();


            }
            C.Deconnection();
            
            FillShart();

            C.Connection();
            C.Cmd = C.Cnx.CreateCommand();
            C.Cmd.CommandText = "select sum(Total_vente) as 'Total de vente' from Vente ";
            C.Dr = C.Cmd.ExecuteReader();
            while (C.Dr.Read())
            {
                gunaLabel17.Text = C.Dr[0].ToString();
            }
            C.Deconnection();

            C.Connection();
            C.Cmd = C.Cnx.CreateCommand();
            C.Cmd.CommandText = "select COUNT(*) from Vente";
            C.Dr = C.Cmd.ExecuteReader();
            while (C.Dr.Read())
            {
                gunaLabel19.Text = C.Dr[0].ToString();
            }
            C.Deconnection();


            C.Connection();
            C.Cmd = C.Cnx.CreateCommand();
            C.Cmd.CommandText = "select max(Quantite) as 'Produits le plus vendus',p.Nom_Pr from detail_cmd c,Produit p where p.Id_Pr = c.Id_Pr group by p.Nom_Pr ";
            C.Dr = C.Cmd.ExecuteReader();
            while (C.Dr.Read())
            {
                gunaLabel13.Text = C.Dr[0].ToString();
                gunaLabel14.Text = C.Dr[1].ToString();

            }
            C.Deconnection();


            C.Connection();
            C.Cmd = C.Cnx.CreateCommand();
            C.Cmd.CommandText = "select sum(case when sale like '%Online%' then 1 else 0 end) as'online'from Vente ; ";
            C.Dr = C.Cmd.ExecuteReader();
            while (C.Dr.Read())
            {
                gunaLabel18.Text = C.Dr[0].ToString();
            }
            C.Deconnection();


            C.Connection();
            C.Cmd = C.Cnx.CreateCommand();
            C.Cmd.CommandText = "select sum(case when sale like '%SurPlace%' then 1 else 0 end) as'Surplace' from Vente ; ";
            C.Dr = C.Cmd.ExecuteReader();
            while (C.Dr.Read())
            {
                gunaLabel16.Text = C.Dr[0].ToString();
            }
            C.Deconnection();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Nouveau_Utilisateur Nu = new Nouveau_Utilisateur();
            this.Hide();
            Nu.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Gestion_Utilisateurs gu = new Gestion_Utilisateurs();
            this.Hide();
            gu.Show();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Ajout_Client Aj = new Ajout_Client();
            this.Close();
            Aj.Show();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Gestion_Client GC = new Gestion_Client();
            GC.Show();
            this.Close();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            Ajout_Produit Aj = new Ajout_Produit();
            Aj.Show();
            this.Close();
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            Gestion_Produit Gp = new Gestion_Produit();
            Gp.Show();
            this.Hide();
        }

        private void gunaButton14_Click(object sender, EventArgs e)
        {
            Gestion_vente GV = new Gestion_vente();
            GV.Show();
            this.Hide();
        }

        private void gunaButton13_Click(object sender, EventArgs e)
        {
            Gestion_Commande gc = new Gestion_Commande();
            gc.Show();
            this.Hide();
        }
    }
}
