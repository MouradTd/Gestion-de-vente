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
using System.IO;
using System.Runtime.InteropServices;

namespace ProjetISTA
{
    public partial class Ajout_Produit : Form
    {
        public static int idCat;
        public string path;
        public Byte[] imgdata;
        
        Connect C = new Connect();
        public Ajout_Produit()
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

        public void Fillcombo()
        {
            /*
            C.Connection();
            C.Cmd = C.Cnx.CreateCommand();
            C.Cmd.CommandText = "SELECT * FROM Categorie";
            C.Dr = C.Cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(C.Dr);
            CategorieList.ValueMember = "ID_Cat";
            CategorieList.DisplayMember = "Description_Cat";
            CategorieList.DataSource = dt;
            C.Deconnection();
            */

            //EASY WAY
            C.Connection();
            try 
            {
                DataTable dt = new DataTable();
                C.Cmd = new SqlCommand("SELECT id_Cat, Name_Cat FROM Categorie", C.Cnx);
                C.Dr = C.Cmd.ExecuteReader();
                dt.Load(C.Dr);
                CategorieList.DataSource = dt;
                CategorieList.ValueMember = "id_Cat";
                CategorieList.DisplayMember = "Name_Cat";
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
            C.Deconnection();

        }
        private void Ajout_Produit_Load(object sender, EventArgs e)
        {
            //CategorieList.Items.Add("Android");
            //CategorieList.Items.Add("Gaming PC");
            Fillcombo();
        }
       

        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_Produit MA = new Gestion_Produit();
            MA.Show();
        }

        private void Insert(int id_Cat, string txtNom, int txtQte, string Descpt, decimal Prix)
        {
            try
            {
                //C.Connection();
                //C.Cmd = C.Cnx.CreateCommand();
                //C.Cmd.CommandText = "INSERT INTO Categorie( Description_Cat) VALUES( @Descpt)";
                //C.Cmd.Parameters.AddWithValue("@Descpt", Descpt);
                //C.Cmd.ExecuteNonQuery();
                //C.Deconnection();

                /*
                C.Connection();
                C.Cmd = C.Cnx.CreateCommand();
                C.Cmd.CommandText = "INSERT INTO Produit(id_Cat, Nom_Pr, Quantite_Pr, Description_Pr, Img_Pr, Prix_Pr) VALUES(@id_Cat, @Nom_Pr, @Quantite_Pr, @Description_Pr, @Img_Pr, @Prix_Pr";
                C.Cmd.Parameters.AddWithValue("@id_Cat", id_Cat);
                C.Cmd.Parameters.AddWithValue("@Nom_Pr", txtNom);
                C.Cmd.Parameters.AddWithValue("@Quantite_Pr", txtQte);
                C.Cmd.Parameters.AddWithValue("@Description_Pr", Descpt);
                C.Cmd.Parameters.AddWithValue("@Img_Pr", image);
                C.Cmd.Parameters.AddWithValue("@Prix_Pr", Prix);
                C.Cmd.ExecuteNonQuery();
                C.Deconnection();
                */

                C.Connection();
                C.Cmd = new SqlCommand("insert into Produit(id_Cat, Nom_Pr, Quantite_Pr, Description_Pr, Img_Pr, Prix_Pr) values (" + id_Cat+", '"+txtNom+"','"+txtQte+"','"+Descpt+ "',@imgdata," + Prix+")", C.Cnx);
                C.Cmd.Parameters.Add("@imgdata", SqlDbType.VarBinary).Value = imgdata;
                C.Cmd.ExecuteNonQuery();

                C.Deconnection();




            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void LoadData()
        {
            try 
            {
                C.Connection();

                DataTable dt = new DataTable("Produit");
                SqlDataAdapter Da = new SqlDataAdapter("select * from Produit", C.Cnx);
                Da.Fill(dt);
                C.Deconnection();
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
            

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

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomProduit.Text) || string.IsNullOrEmpty(txtDescProduit.Text) || string.IsNullOrEmpty(txtQteStock.Text) || string.IsNullOrEmpty(txtPrixPro.Text) || string.IsNullOrEmpty(path))
            {
                MessageBox.Show("insert data ALL first");
            }
            else
            {
                try
                {
                    //Insert(ConverterImageToBytes(imgproduit.Image), txtNomProduit.Text, txtQteStock.Text, Convert.ToInt32(CategorieList.SelectedValue.ToString()), txtDescProduit.Text);
                    Insert(Convert.ToInt32(CategorieList.SelectedValue.ToString()), txtNomProduit.Text, Convert.ToInt32(txtQteStock.Text), txtDescProduit.Text, Convert.ToDecimal(txtPrixPro.Text));
                    MessageBox.Show("Ajoutée avec succes");
                    ClearInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseAPP_Click_1(object sender, EventArgs e)
        {
            //this.Dispose();
            //Application.Exit();
            this.Hide();
            Gestion_Produit MA = new Gestion_Produit();
            MA.Show();

        }

        private void importimg_Click(object sender, EventArgs e)
            
        {
            try 
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files (*.jpg;*.jpeg) |*.jpg;*.jpeg", Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        imgproduit.Image = Image.FromFile(ofd.FileName);
                        path = ofd.FileName;
                        imgdata = File.ReadAllBytes(ofd.FileName);
                        CameraList.Text = ofd.FileName;

                        LoadData();
                    }
                }
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }


        //CLLEAR INPUTS
        public void ClearInput() 
        {
            CategorieList.SelectedIndex = 0;
            txtNomProduit.Clear();
            txtDescProduit.Clear();
            txtQteStock.Clear(); 
            txtPrixPro.Clear();
            imgproduit.Image = null;
        }


    }
}
