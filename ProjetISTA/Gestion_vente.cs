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
    public partial class Gestion_vente : Form
    {
        Connect C = new Connect();
        public static string id;
        public static string prix;
        public static string idpr;
        public static string Qte;
        Add_venteDataContext db = new Add_venteDataContext();
        public Gestion_vente()
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


        private void Gestion_vente_Load(object sender, EventArgs e)
        {
            gunaComboBox1.Items.Add("Online");
            gunaComboBox1.Items.Add("SurPlace");
            C.Connection();
            C.Cmd = C.Cnx.CreateCommand();
            C.Cmd.CommandText = "SELECT * FROM Region";
            C.Dr = C.Cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(C.Dr);
            gunaComboBox1ville.ValueMember = "reg_id";
            gunaComboBox1ville.DisplayMember = "reg_region";
            gunaComboBox1ville.DataSource = dt;
            C.Deconnection();


            C.Connection();
            C.Cmd = C.Cnx.CreateCommand();
            C.Cmd.CommandText = "SELECT Id_Pr,Nom_Pr,Quantite_Pr,Prix_Pr FROM Produit";
            C.Dr = C.Cmd.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(C.Dr);
            gunaDataGridView1.DataSource = dt2;
            
            C.Deconnection();
            AddHeaderCheckBox();



            Random rnd = new Random();
            int bill = rnd.Next(1, 99999999);
            guna2TextBox5.Text = Convert.ToString(bill);
            guna2TextBox7.Text = Convert.ToString(LGS.idu);


        }
        CheckBox HeaderCheckBox = null;
        private void AddHeaderCheckBox()
               {
             HeaderCheckBox = new CheckBox();
             HeaderCheckBox.Size=new Size(15,15);
             // Add the CheckBox into the DataGridView
             this.gunaDataGridView1.Controls.Add(HeaderCheckBox);
         }

        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
           bool IsHeaderCheckBoxClicked = true;
            
         foreach (DataGridViewRow Row in gunaDataGridView1.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["chk"]).Value = HCheckBox.Checked;
            gunaDataGridView1.RefreshEdit();
            
            IsHeaderCheckBoxClicked = false;
        }







       

        

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_Commande MA = new Gestion_Commande();
            MA.Show();
        }

       

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnCloseAPP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_Commande MA = new Gestion_Commande();
            MA.Show();

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcin.Text))
            {
                C.Connection();
                C.Cmd = C.Cnx.CreateCommand();
                C.Cmd.CommandText = "select * from Client where Cin_Cl ='" + txtcin.Text + "'";
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
                C.Cmd.CommandText = "select r.reg_region , c.City_Id from Client c ,Region r where c.City_Id = r.reg_id and c.Cin_Cl = '" + txtcin.Text + "'";
                C.Dr = C.Cmd.ExecuteReader();
                while (C.Dr.Read())
                {

                    gunaComboBox1ville.Text = C.Dr[0].ToString();

                }

                C.Deconnection();
            }
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            //try {
            //    Insert(Convert.ToInt32(id), guna2TextBox6.Text , gunaDateTimePicker1.Value, guna2TextBox7.Text, Convert.ToDecimal(labeltotal.Text));
            //    //Insert2();
            //    MessageBox.Show("vente insérer avec success");
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
            try
            {
                //db.CMD_Add1(Convert.ToInt32(id), guna2TextBox7.Text, Convert.ToDecimal(prix), guna2TextBox6.Text, /*DateTime.Now*/gunaDateTimePicker1.Value, Convert.ToInt32(idpr), Convert.ToInt32(txtQte.Text), Convert.ToDecimal(labeltotal.Text));
                //MessageBox.Show("vente insérer avec success");
                db.CMD_Add2(Convert.ToInt32(id), guna2TextBox7.Text, Convert.ToDecimal(prix), guna2TextBox6.Text, /*DateTime.Now*/gunaDateTimePicker1.Value, Convert.ToInt32(idpr), Convert.ToInt32(txtQte.Text), Convert.ToDecimal(labeltotal.Text),gunaComboBox1.Text);
                MessageBox.Show("vente insérer avec success");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prix = gunaDataGridView1.Rows[e.RowIndex].Cells["Prix_Pr"].FormattedValue.ToString();
            idpr = gunaDataGridView1.Rows[e.RowIndex].Cells["Id_Pr"].FormattedValue.ToString();
            Qte = gunaDataGridView1.Rows[e.RowIndex].Cells["Quantite_Pr"].FormattedValue.ToString();


            try
            {
                if ( Convert.ToInt32(Qte) > Convert.ToInt32(txtQte.Text))
                {
                    decimal num1 = decimal.Parse(prix);
                    decimal num2 = decimal.Parse(txtQte.Text);

                    labeltotal.Text = Convert.ToString(Convert.ToDecimal(num1) * Convert.ToDecimal(num2));
                }
                else
                {
                    MessageBox.Show("Impossible,Stock Insufissant");
                }
               
            }
            catch (Exception ex) { }
        }
    }
}
