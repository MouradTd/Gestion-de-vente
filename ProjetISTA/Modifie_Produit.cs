using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetISTA
{
    public partial class Modifie_Produit : Form
    {
        Connect C = new Connect();
        public string path;
        public Byte[] imgdata;
        public Modifie_Produit()
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

        private void Modifie_Produit_Load(object sender, EventArgs e)
        {
           
            try
            {
                if (Gestion_Produit.IdPro != null)
                {
                    C.Connection();
                    C.Cmd = C.Cnx.CreateCommand();
                    C.Cmd.CommandText = "Select p.* ,c.Id_Cat  from Produit p, Categorie c where p.id_Cat = C.id_Cat and p.Id_Pr = " + Gestion_Produit.IdPro + "";
                    C.Dr = C.Cmd.ExecuteReader();
                    while (C.Dr.Read())
                    {
                        //combosVilleCli.Text = C.Dr[1].ToString();
                        txtNomProduit.Text = C.Dr["Nom_Pr"].ToString();
                        //CategorieList.Text =  C.Dr["Nom_Cat"];
                        txtDescProduit.Text = C.Dr["Description_Pr"].ToString();
                        txtQteStock.Text = C.Dr["Quantite_Pr"].ToString();
                        txtPrixPro.Text = C.Dr["Prix_Pr"].ToString();

                    }

                    C.Deconnection();
                   
                    try
                    {
                        C.Connection();
                        DataTable dt = new DataTable();
                        C.Cmd = new SqlCommand("SELECT id_Cat, Name_Cat FROM Categorie", C.Cnx);
                        C.Dr = C.Cmd.ExecuteReader();
                        dt.Load(C.Dr);
                        CategorieList.DataSource = dt;
                        CategorieList.ValueMember = "id_Cat";
                        CategorieList.DisplayMember = "Name_Cat";
                        C.Deconnection();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    

                    C.Connection();
                    C.Cmd = C.Cnx.CreateCommand();
                    C.Cmd.CommandText = "select c.Name_Cat ,p.Id_Cat from Categorie c , Produit p where c.Id_Cat = p.Id_Cat and p.Id_Pr = '"+ Gestion_Produit.IdPro + "'";
                    C.Dr = C.Cmd.ExecuteReader();
                    while (C.Dr.Read())
                    {

                        CategorieList.Text = C.Dr[0].ToString();

                    }
                    C.Deconnection();

                }
                else
                {
                    MessageBox.Show("Erreur");

                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

       
        private void Update(int id_Cat, string txtNom, int txtQte, string Descpt,  double Prix)
        {
            
                C.Connection();
                C.Cmd = new SqlCommand("update Produit set Id_Cat = " + id_Cat + ", Nom_Pr = '" + txtNom + "', Quantite_Pr = " + txtQte + ", Description_Pr = '" + Descpt + "', Img_Pr = @imgdata, Prix_Pr = " + Prix + " where Id_Pr = " + Convert.ToInt32(Gestion_Produit.IdPro) + " ", C.Cnx);
            C.Cmd.Parameters.Add("@imgdata",SqlDbType.VarBinary).Value=imgdata;
                C.Cmd.ExecuteNonQuery();
                C.Deconnection();
           
            
           
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            Gestion_Produit.IdPro = -1;
            this.Hide();
            MainApp MA = new MainApp();
            MA.Show();
        }

        private void btnCloseAPP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_Produit GP = new Gestion_Produit();
            GP.Show();

        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        byte[] ConverterImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {

                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }

        }

        private void BtnEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                    Update(Convert.ToInt32(CategorieList.SelectedValue.ToString()), txtNomProduit.Text, Convert.ToInt32(txtQteStock.Text), txtDescProduit.Text,  Convert.ToDouble(txtPrixPro.Text));
             



                MessageBox.Show("Modifié avec sucess");
                
                

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void importimg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files (*.jpg;*.jpeg) |*.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgproduit.Image = Image.FromFile(ofd.FileName);
                    path = ofd.FileName;
                    imgdata = File.ReadAllBytes(ofd.FileName);
                    CameraList.Text = ofd.FileName;


                }
            }
        }

        private void BackMenu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_Produit GP = new Gestion_Produit();
            GP.Show();
        }
        public void ClearInputs() 
        {
            txtNomProduit.Clear();
            txtDescProduit.Clear();
            txtQteStock.Clear();
            txtPrixPro.Clear();
            imgproduit.Image = null;

        }
    }
}
