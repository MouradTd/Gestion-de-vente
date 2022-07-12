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

namespace ProjetISTA
{
    public partial class Facture : Form
    {
        Connect C = new Connect();
        public Facture()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            C.Connection();
            C.Cmd = C.Cnx.CreateCommand();
            C.Cmd.CommandText = "select c.Nom_Cl ,v.Nom_vendeur , v.date_fac ,p.Nom_Pr ,d.Quantite,p.Prix_Pr,v.Desc_fac,v.sale,v.Total_vente from Produit p ,Detail_Cmd d , Client c ,Vente v  where v.Id_vente ='" + Gestion_Commande.idv + "' and  p.Id_Pr = d.Id_Pr and d.Id_vente = v.Id_vente and v.Id_client = c.Id_Cl";
            SqlDataAdapter da = new SqlDataAdapter(C.Cmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];
            C.Deconnection();


            CrystalReport1 crt = new CrystalReport1();
            crt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = crt;
            crystalReportViewer1.Refresh();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_Commande GC = new Gestion_Commande();
            GC.Show();
        }

        private void Facture_Load(object sender, EventArgs e)
        {
            //kan hna ila makhdmch
            
           

        }
    }
}
