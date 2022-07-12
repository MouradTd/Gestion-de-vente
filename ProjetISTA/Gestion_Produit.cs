using ClosedXML.Excel;
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
    public partial class Gestion_Produit : Form
    {
        Connect C = new Connect();
        public static int IdPro = -1;
        public static int IdCat;
        public static Byte Img;

        public Gestion_Produit()
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

        private void guna2Button7_Click(object sender, EventArgs e)
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
        

        

        private void btnCloseAPP_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Minimized;

        }

        public void FillGridView() 
        {
            gunaDataGridView1.Rows.Clear();
            C.Connection();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id_Pr");   
            dt.Columns.Add("Id_Cat");   
            dt.Columns.Add("Nom_Pr");   
            dt.Columns.Add("Quantite_Pr");
            dt.Columns.Add("Description_Pr");
            dt.Columns.Add("Img_Pr");
            dt.Columns.Add("Prix_Pr");
            C.Cmd = new SqlCommand("Select P.*,c.Id_Cat, c.Name_Cat  from Produit p, Categorie c where p.id_Cat = C.id_Cat ", C.Cnx);
            C.Dr= C.Cmd.ExecuteReader();
            while (C.Dr.Read())
            {
                gunaDataGridView1.Rows.Add(C.Dr["Id_Pr"].ToString(), C.Dr["Id_Cat"].ToString(), C.Dr["Nom_Pr"].ToString() ,C.Dr["Name_Cat"].ToString(), C.Dr["Quantite_Pr"].ToString(),C.Dr["Description_Pr"].ToString(),C.Dr["Prix_Pr"].ToString(), C.Dr["Img_Pr"].ToString());
            }
            C.Dr.Close();
            C.Deconnection();

        }

        private void Gestion_Produit_Load(object sender, EventArgs e)
        {
            FillGridView();
        }

       

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdPro = Convert.ToInt32(gunaDataGridView1.Rows[e.RowIndex].Cells["Id_Pr"].FormattedValue.ToString());
                IdCat = Convert.ToInt32(gunaDataGridView1.Rows[e.RowIndex].Cells["Id_Cat"].FormattedValue.ToString());
               // Img = Convert.ToByte(gunaDataGridView1.Rows[e.RowIndex].Cells["Img_Pr"].Value); 

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void btnEditPr_Click(object sender, EventArgs e)
        {
            if (IdPro == -1) 
            {
                MessageBox.Show("select somthing first ");
            }
            else 
            {
                this.Hide();
                Modifie_Produit MP = new Modifie_Produit();
                MP.Show();
            }
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajout_Produit AP = new Ajout_Produit();
            AP.Show();
        }

        private void brnDelete_Click(object sender, EventArgs e)
        {

            if (IdPro != -1)
            {
                if (MessageBox.Show("Delete record", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                try
                {
                        C.Connection();
                        C.Cmd = C.Cnx.CreateCommand();
                        C.Cmd.CommandText = "delete from Produit where Id_Pr ='" + IdPro + "'";
                        C.Cmd.ExecuteNonQuery();
                        C.Deconnection();
                        MessageBox.Show("deleted succcesfuly");
                        FillGridView();
 
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            }
            else
            {
                MessageBox.Show("Vous devez dabord selectionner un Produit");

            }


        }

        private void btnGetImg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Image_Produit IP = new Image_Produit();
            IP.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
            if (gunaDataGridView1.Rows.Count > 0)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook wrk = xcelApp.Workbooks.Add(Type.Missing);
                    Microsoft.Office.Interop.Excel.Worksheet wrks = null;
                    xcelApp.Visible = true;
                    wrks = wrk.Sheets["Feuil1"];
                    wrks = wrk.ActiveSheet;
                    wrks.Name = "Produits";

                    for (int i = 1; i < gunaDataGridView1.Columns.Count + 1; i++)
                    {
                        wrks.Cells[1, i] = gunaDataGridView1.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < gunaDataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < gunaDataGridView1.Columns.Count; j++)
                        {
                            wrks.Cells[i + 2, j + 1] = gunaDataGridView1.Rows[i].Cells[j].Value.ToString();

                        }
                    }
                    wrk.SaveAs("Bureau\\Produits.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    xcelApp.Quit();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

               
            }
        }

        private void UserTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserTxt.Text))
            {
                FillGridView();
            }
            else
            {
                try
                {
                    C.Connection();

                    C.Cmd = C.Cnx.CreateCommand();
                    C.Cmd.CommandText = "select p.Nom_Pr,p.Quantite_Pr,p.Description_Pr,p.Prix_Pr,c.Name_Cat from Produit p , Categorie c where p.Nom_Pr ='"+UserTxt.Text+"' and p.Id_Cat = c.Id_Cat";
                    C.Dr = C.Cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(C.Dr);
                    //gunaDataGridView1.Rows.Add(C.Dr["Nom_Pr"].ToString(), C.Dr["Quantite_Pr"].ToString(), C.Dr["Description_Pr"].ToString(), C.Dr["Prix_Pr"].ToString(), C.Dr["Name_Cat"].ToString());

                    gunaDataGridView1.Refresh();
                    gunaDataGridView1.Rows.Clear();

                    gunaDataGridView1.DataSource = dt;

                    C.Deconnection();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
        }
    }
}
