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
    public partial class All_Info : Form
    {
        Connect C = new Connect();
        public All_Info()
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
            this.Hide();
            Gestion_Commande GC = new Gestion_Commande();
            GC.Show();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_Commande GC = new Gestion_Commande();
            GC.Show();
        }

        private void All_Info_Load(object sender, EventArgs e)
        {
            C.Connection();

            DataTable dt = new DataTable("informations");
            SqlDataAdapter Da = new SqlDataAdapter("select  v.Id_vente,v.Id_client,x.Nom_Cl,x.Prenom_Cl,v.Desc_fac,v.date_fac,v.Nom_vendeur,v.Total_vente, c.Quantite,c.Prix as 'Prix Unitaire',p.Nom_Pr from Vente v , Detail_Cmd c ,Produit p ,Client x where  v.Id_vente= '"+ Gestion_Commande.idv+"' and v.Id_vente = c.Id_vente and c.Id_Pr = p.Id_Pr and x.Id_Cl = v.Id_client ", C.Cnx);
            Da.Fill(dt);
            gunaDataGridView1.DataSource = dt;
            C.Deconnection();
        }
    }
}
