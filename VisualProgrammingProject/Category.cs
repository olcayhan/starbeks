using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgrammingProject
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=starbeks;Integrated Security=True";


        public Category() { }
        public Category(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        public void AddCategory(Category category)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Category] VALUES (@ID,@Name)", conn);
            sqlCommand.Parameters.AddWithValue("@ID", category.ID);
            sqlCommand.Parameters.AddWithValue("@Name", category.Name);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public List<Category> GetCategories()
        {
            List<Category> CategoryList = new List<Category>();

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Category]", conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Category category = new Category();
                category.ID = Convert.ToInt32(reader["ID"]);
                category.Name = reader["Name"].ToString();
                CategoryList.Add(category);
            }
            conn.Close();
            return CategoryList;
        }

        public Category getCategory(string Name)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Category] WHERE Name = @Name", conn);
            sqlCommand.Parameters.AddWithValue("@Name", Name);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            Category category = new Category();
            while (reader.Read())
            {
                category.ID = Convert.ToInt32(reader["ID"]);
                category.Name = reader["Name"].ToString();
            }
            conn.Close();
            return category;
        }
        public Category getCategory(int id)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Category] WHERE ID = @ID", conn);
            sqlCommand.Parameters.AddWithValue("@ID", id);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            Category category = new Category();
            while (reader.Read())
            {
                category.ID = Convert.ToInt32(reader["ID"]);
                category.Name = reader["Name"].ToString();
            }
            conn.Close();
            return category;
        }
        public void removeCategory(Category category)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM [Product] WHERE CategoryID=@CategoryID", conn);
            sqlCommand.Parameters.AddWithValue("@CategoryID", category.ID);
            sqlCommand.ExecuteNonQuery();

            SqlCommand sqlCommand2 = new SqlCommand("DELETE FROM [Category] WHERE ID=@ID", conn);
            sqlCommand2.Parameters.AddWithValue("@ID", category.ID);
            sqlCommand2.ExecuteNonQuery();
            conn.Close();
        }

    }
}

