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
    public partial class Modifié_Client : Form
    {
        Connect C = new Connect();
        public Byte[] imgdata;
        public Modifié_Client()
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

        private void FillCombo()
        {
            C.Connection();
            C.Cmd = C.Cnx.CreateCommand();
            C.Cmd.CommandText = "SELECT * FROM Region";
            C.Dr = C.Cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(C.Dr);
            combosVilleCli.ValueMember = "reg_id";
            combosVilleCli.DisplayMember = "reg_region";
            combosVilleCli.DataSource = dt;
            C.Deconnection();


        }

        private void Modifié_Client_Load(object sender, EventArgs e)
        {
            FillCombo();

            try
            {
                if (Gestion_Client.idcl != null)
                {
                    C.Connection();
                    C.Cmd = C.Cnx.CreateCommand();
                    C.Cmd.CommandText = "select * from Client where Nom_Cl ='" + Gestion_Client.idcl + "'";
                    C.Dr = C.Cmd.ExecuteReader();
                    while (C.Dr.Read())
                    {
                        //combosVilleCli.Text = C.Dr[1].ToString();
                        txtNomCli.Text = C.Dr[2].ToString();
                        txtPrenCli.Text = C.Dr[3].ToString();
                        txtNumCli.Text = C.Dr[4].ToString();
                        txtMail.Text = C.Dr[5].ToString();
                       
                    }

                    C.Deconnection();

                }
                else
                {
                    MessageBox.Show("Erreur");

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
        private void importimg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files (*.jpg;*.jpeg) |*.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imguser.Image = Image.FromFile(ofd.FileName);
                    imgdata = File.ReadAllBytes(ofd.FileName);
                    CameraList.Text = ofd.FileName;

                    
                }
            }
        }
        private void Update( string txtNom  ,string txtPren, int txtNum, string txtmail, int Ville)
        {
            try
            {
                C.Connection();
                C.Cmd = C.Cnx.CreateCommand();
                C.Cmd.CommandText = "update Client set City_Id = '"+Ville +"' , Prenom_Cl = '"+txtPren +"' , Tel_Cl = '"+txtNum+"' , Email_Cl = '"+ txtmail+"' , Img_Cl = @imgdata where Nom_Cl = '"+ txtNomCli+"'";
                //C.Cmd.Parameters.AddWithValue("@combosVilleCli", Ville);
                //C.Cmd.Parameters.AddWithValue("@txtNomCli", txtNom);
                //C.Cmd.Parameters.AddWithValue("@txtPrenCli", txtPren);
                //C.Cmd.Parameters.AddWithValue("@txtNumCli", txtNum);
                //C.Cmd.Parameters.AddWithValue("@txtMail", txtmail); 
                C.Cmd.Parameters.Add("@imgdata", SqlDbType.VarBinary).Value = imgdata;

                C.Cmd.ExecuteNonQuery();
                C.Deconnection();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            try
            {
                Update(txtNomCli.Text ,txtPrenCli.Text, Convert.ToInt32(txtNumCli.Text), txtMail.Text, Convert.ToInt32(combosVilleCli.SelectedValue.ToString()));
                MessageBox.Show("Modifier avec succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_Client GC = new Gestion_Client();
            GC.Show();
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
