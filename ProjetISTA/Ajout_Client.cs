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
    public partial class Ajout_Client : Form
    {
        Connect C = new Connect();
        public Ajout_Client()
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

        private void Ajout_Client_Load(object sender, EventArgs e)
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

        private void Insert( byte[] image , string txtNom , string txtPren ,string Cin, string txtNum, string txtmail, int Ville)
        {
            try {
                C.Connection();
                C.Cmd = C.Cnx.CreateCommand();
                C.Cmd.CommandText = "INSERT INTO Client(City_Id, Nom_Cl, Prenom_Cl,Cin_Cl, Tel_Cl, Email_Cl, Img_Cl) VALUES(@combosVilleCli , @txtNomCli ,@txtPrenCli, @Cin, @txtNumCli , @txtMail ,@image)";
                C.Cmd.Parameters.AddWithValue("@combosVilleCli", Ville);
                C.Cmd.Parameters.AddWithValue("@txtNomCli", txtNom);
                C.Cmd.Parameters.AddWithValue("@txtPrenCli", txtPren);
                C.Cmd.Parameters.AddWithValue("@Cin", Cin);
                C.Cmd.Parameters.AddWithValue("@txtNumCli", txtNum);
                C.Cmd.Parameters.AddWithValue("@txtMail", txtmail);
                C.Cmd.Parameters.AddWithValue("@image", image);
                C.Cmd.ExecuteNonQuery();
                C.Deconnection();

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
           
        }
        private void LoadData()
        {
            C.Connection();
            
            DataTable dt = new DataTable("Client");
            SqlDataAdapter Da = new SqlDataAdapter("select * from Client",C.Cnx);
            Da.Fill(dt);
            C.Deconnection();

        }
        byte[] ConverterImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream()) {

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

        

        private void BackMenu_Click(object sender, EventArgs e)
        {

            Gestion_Client GC = new Gestion_Client();
            this.Hide();
            GC.Show();
           
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            try
            {
                Insert(ConverterImageToBytes(imguser.Image), txtNomCli.Text, txtPrenCli.Text, CinCL.Text,txtNumCli.Text, txtMail.Text,Convert.ToInt32(combosVilleCli.SelectedValue.ToString()) );
                MessageBox.Show("Ajoutée avec succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            //Application.Exit();
            Gestion_Client GC = new Gestion_Client();
            this.Hide();
            GC.Show();
        }

        private void importimg_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter="Image files (*.jpg;*.jpeg) |*.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imguser.Image = Image.FromFile(ofd.FileName);
                    CameraList.Text = ofd.FileName;
                   
                    LoadData();
                }
            }
        }
    }
}
