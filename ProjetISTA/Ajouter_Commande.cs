using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetISTA
{
    public partial class Ajouter_Commande : Form
    {
        Connect C = new Connect();
        public static string id;
        public static string prix;
        public Ajouter_Commande()
        {
            InitializeComponent();
        }

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

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_Commande GC = new Gestion_Commande();
            GC.Show();

        }

        private void txtCIN_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCIN.Text))
            {
                C.Connection();
                C.Cmd = C.Cnx.CreateCommand();
                C.Cmd.CommandText = "select * from Client where Cin_Cl ='" + txtCIN.Text + "'";
                // C.Cmd.CommandText = "select * from Client";
                C.Dr = C.Cmd.ExecuteReader();
                while (C.Dr.Read())
                {
                    id = C.Dr[0].ToString();

                    //guna2TextBox2.Text = C.Dr[0].ToString();
                    UserTxt.Text = C.Dr[1].ToString();
                    guna2TextBox1.Text = C.Dr[2].ToString();
                    guna2TextBox3.Text = C.Dr[4].ToString();
                    guna2TextBox4.Text = C.Dr[5].ToString();

                }
                C.Deconnection();
                C.Connection();
                C.Cmd = C.Cnx.CreateCommand();
                C.Cmd.CommandText = "select r.reg_region , c.City_Id from Client c ,Region r where c.City_Id = r.reg_id and c.Cin_Cl = '" + txtCIN.Text + "'";
                C.Dr = C.Cmd.ExecuteReader();
                while (C.Dr.Read())
                {

                    gunaComboBox1ville.Text = C.Dr[0].ToString();

                }

                C.Deconnection();
            }
        }
        public void recupereprx()
        {
            
        }

        private void Ajouter_Commande_Load(object sender, EventArgs e)
        {
            C.Connection();
            C.Cmd = C.Cnx.CreateCommand();
            C.Cmd.CommandText = "SELECT * FROM Produit";
            C.Dr = C.Cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(C.Dr);
            gunaComboBox1.ValueMember = "Id_Pr";
            gunaComboBox1.DisplayMember = "Nom_Pr";
            gunaComboBox1.DataSource = dt;
            C.Deconnection();
            

        }

        private void txtQteCMD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal num1 = decimal.Parse(txtQteCMD.Text);
                decimal num2 = decimal.Parse(txtPrixCMD.Text);

                txttotal.Text = Convert.ToString(Convert.ToDecimal(num1) * Convert.ToDecimal(num2));
            }
            catch(Exception ex) { }
            //int num1 = decimal.Parse(txtQteCMD.Text);
            //int num2 = int.Parse(txtPrixCMD.Text);
          

            //var sab = (Convert.ToInt32(txtPrixCMD.Text) * Convert.ToInt32(txtQteCMD.Text));
            //txttotal.Text = Convert.ToString(sab);

           

        }

  
        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            C.Connection();
            C.Cmd = C.Cnx.CreateCommand();
            C.Cmd.CommandText = "SELECT Prix_Pr FROM Produit where Nom_Pr = '" + gunaComboBox1.Text + "'";
            C.Dr = C.Cmd.ExecuteReader();
            while (C.Dr.Read())
            {
                txtPrixCMD.Text = C.Dr[0].ToString();
            }

            C.Deconnection();
        }
    }
}
