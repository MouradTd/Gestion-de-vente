using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetISTA
{
    public partial class Image_Produit : Form
    {
        Connect C = new Connect();
        Gestion_Produit GP = new Gestion_Produit();
        Byte[] img;
        public Image_Produit()
        {
            InitializeComponent();
        }
        public void GetImag()
        {
            try 
            {
                C.Connection();
                C.Cmd = new SqlCommand("select Img_Pr from Produit  where id_Pr = " + Gestion_Produit.IdPro + "", C.Cnx);
                C.Dr = C.Cmd.ExecuteReader();
                while (C.Dr.Read())
                {
                    MemoryStream ms = new MemoryStream(C.Dr.GetSqlBytes(0).Buffer);
                     imgProduit.Image = Image.FromStream(ms);
                    

                }
                


                C.Deconnection();
                
                /*
                var stream = new MemoryStream((Byte[])(Gestion_Produit.Img));
                imgProduit.Image = Image.FromStream(stream);
                */
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
           


        }

        


        private void guna2Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_Produit GP = new Gestion_Produit();
            GP.Show();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Image_Produit_Load(object sender, EventArgs e)
        {
            GetImag();
        }
    }
}
