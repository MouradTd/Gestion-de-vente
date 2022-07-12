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

namespace ProjetISTA
{
    public partial class Image_Client : Form
    {
        Connect C = new Connect();
        Byte[] img;
        public Image_Client()
        {
            InitializeComponent();
        }
        public void GetImag()
        {
            try
            {
                C.Connection();
                C.Cmd = new SqlCommand("select Img_Cl from Client  where Id_Cl = " + Gestion_Client.idimg + "", C.Cnx);
                C.Dr = C.Cmd.ExecuteReader();
                while (C.Dr.Read())
                {
                    MemoryStream ms = new MemoryStream(C.Dr.GetSqlBytes(0).Buffer);
                    imguser.Image = Image.FromStream(ms);


                }



                C.Deconnection();

                /*
                var stream = new MemoryStream((Byte[])(Gestion_Produit.Img));
                imgProduit.Image = Image.FromStream(stream);
                */
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_Client GS = new Gestion_Client();
            GS.Show();
            
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void LoadData3()
        {
            //C.Connection();

            //DataTable dt = new DataTable("UserLog");
            //SqlDataAdapter Da = new SqlDataAdapter("select Img_Cl from Client", C.Cnx);
            //Da.Fill(dt);


            //C.Deconnection();
            

        }
        

        private void Image_Client_Load(object sender, EventArgs e)
        {
            //LoadData3();
            GetImag();


        }
    }
}
