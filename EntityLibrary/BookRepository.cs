using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;




namespace EntityLibrary
{
    public class BookRepository
    {
        public List<Book> GetAll()
        {
            List<Book> book = new List<Book>();
            using (SqlConnection conn = new SqlConnection("Server=DESKTOP-FH5G1I2\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select* From Book";
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    book.Add(new Book()
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Title = reader["Title"].ToString(),
                        AuthorId = int.Parse(reader["AuthorId"].ToString()),
                        Year = int.Parse(reader["Year"].ToString()),
                        Language = reader["Language"].ToString(),
                        Pages = int.Parse(reader["Pages"].ToString()),
                        TypeId = int.Parse(reader["TypeId"].ToString()),
                        Cover = reader["Cover"].ToString()
                    });
                }
                return book;
            }
        }

        public void add(Book book)
        {
            using (SqlConnection conn = new SqlConnection("Server = DESKTOP-FH5G1I2\\SQLEXPRESS; Database = LibraryDB; Trusted_Connection = True; "))
            {
                Console.Write("metoda przyjęta");
                String query = "Insert Into Book(Title,AuthorId,Year,Language,Pages,TypeId) values(@Title, @AuthorId, @Year,@Language,@Pages,@TypeId)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Title", book.Title);
                    command.Parameters.AddWithValue("@AuthorId", book.AuthorId);
                    command.Parameters.AddWithValue("@Year", book.Year);
                    command.Parameters.AddWithValue("@Language", book.Language);
                    command.Parameters.AddWithValue("@Pages", book.Pages);
                    command.Parameters.AddWithValue("@TypeId", book.TypeId);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();



                }
            }
        }
        public Book GetBookById(int Id)
        {
            Book book = new Book();
            using (SqlConnection conn = new SqlConnection("Server=DESKTOP-FH5G1I2\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select Id,Title,AuthorId,Year,Language,Pages,TypeId FROM Book where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                book.Id = int.Parse(reader["Id"].ToString());
                book.Title = reader["Title"].ToString();
                book.AuthorId = int.Parse(reader["AuthorId"].ToString());
                book.Year = int.Parse(reader["Year"].ToString());
                book.Language = reader["Language"].ToString();
                book.Pages = int.Parse(reader["Pages"].ToString());
                book.TypeId = int.Parse(reader["TypeId"].ToString());
                return book;
            }
            

        }
        public Book Edit(Book book,int Id)
        {
            
            using (SqlConnection conn = new SqlConnection("Server=DESKTOP-FH5G1I2\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;"))
            {
                
                
                    String query = "UPDATE Book SET Title=@Title,AuthorId=@AuthorId,Year=@Year,Language=@Language,Pages=@Pages,TypeId=@TypeId WHERE Id=@Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", book.Id);
                    cmd.Parameters.AddWithValue("@Title", book.Title);
                    cmd.Parameters.AddWithValue("@AuthorId", book.AuthorId);
                    cmd.Parameters.AddWithValue("@Year", book.Year);
                    cmd.Parameters.AddWithValue("@Language", book.Language);
                    cmd.Parameters.AddWithValue("@Pages", book.Pages);
                    cmd.Parameters.AddWithValue("@TypeId", book.TypeId);
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                return book;
            }
            
        }
        public void deleteBook(int Id)
        {
            Book bookToDelete = new Book();
            using (SqlConnection conn = new SqlConnection("Server=DESKTOP-FH5G1I2\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Delete FROM Book where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                
                
            }
        }
        public List<Book> GetBooksThatContain(string SearchInput)
        {
            List<Book> book = new List<Book>();
            using (SqlConnection conn = new SqlConnection("Server=DESKTOP-FH5G1I2\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select* From Book WHERE Title LIKE '%tek%'";
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    book.Add(new Book()
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Title = reader["Title"].ToString(),
                        AuthorId = int.Parse(reader["AuthorId"].ToString()),
                        Year = int.Parse(reader["Year"].ToString()),
                        Language = reader["Language"].ToString(),
                        Pages = int.Parse(reader["Pages"].ToString()),
                        TypeId = int.Parse(reader["TypeId"].ToString()),
                        Cover = reader["Cover"].ToString()
                    });
                }
                return book;
            }
        }
    }
}
