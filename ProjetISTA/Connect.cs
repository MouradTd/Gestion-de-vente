using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ProjetISTA
{
    class Connect
    {
        public SqlConnection Cnx = new SqlConnection();
        public SqlCommand Cmd;
        public SqlDataReader Dr;
        public void Connection()
        {
            if (Cnx.State != ConnectionState.Open)
            {
                Cnx.ConnectionString = ConfigurationManager.ConnectionStrings["GvCS"].ToString();
                //Cnx = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=ProjetISTA_1;Integrated Security=True");
                Cnx.Open();
            }
        }
        public void Deconnection()
        {
            Cnx.Close();
        }
    }
}
