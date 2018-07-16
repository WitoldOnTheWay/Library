using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EntityLibrary
{
    public class LibraryRepository
    {
        public List<Library> GetAll()
        {
            List<Library> library = new List<Library>();
            using (SqlConnection conn = new SqlConnection("Server=DESKTOP-FH5G1I2\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select* From Library";
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    library.Add(new Library()
                    {


                        Id = int.Parse(reader["Id"].ToString()),
                        Name = reader["Name"].ToString(),
                        Address = reader["Address"].ToString(),
                        //NeedLogin=bool.Parse["NeedLogin"].ToString(),

                    });
                }
                return library;
            }
        }
    }
}
