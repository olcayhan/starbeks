using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgrammingProject
{
    enum Users { Admin, Client, Waiter };
    internal class User
    {
        public string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=starbeks;Integrated Security=True";
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Users Role { get; set; }
        public string Password { get; set; }
        public User() { }
        public User(string Name, string Email, Users Role, string Password)
        {
            this.Name = Name;
            this.Email = Email;
            this.Role = Role;
            this.Password = Password;
        }
        public User Auth(string Email, string Password)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [User] WHERE Email = @Email AND Password = @Password", conn);
            sqlCommand.Parameters.AddWithValue("@Email", Email);
            sqlCommand.Parameters.AddWithValue("@Password", Password);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            User user = new User();
            while (reader.Read())
            {
                user.ID = Convert.ToInt32(reader["ID"]);
                user.Name = reader["Name"].ToString();
                user.Email = reader["Email"].ToString();
                user.Role = (Users)Enum.Parse(typeof(Users), reader["Role"].ToString());
                user.Password = reader["Password"].ToString();
            }
            conn.Close();
            return user;
        }

        public void Signup(int ID, string Name, string Email, Users Role, string Password)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO [User] (ID, Name, Email, Role, Password) VALUES (@ID, @Name, @Email, @Role, @Password)", conn);
            sqlCommand.Parameters.AddWithValue("@ID", ID);
            sqlCommand.Parameters.AddWithValue("@Name", Name);
            sqlCommand.Parameters.AddWithValue("@Email", Email);
            sqlCommand.Parameters.AddWithValue("@Role", Role.ToString());
            sqlCommand.Parameters.AddWithValue("@Password", Password);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

    }
}
