using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgrammingProject
{
    public class Product
    {
        public string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=starbeks;Integrated Security=True";
        public int ID { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }


        public Product() { }
        public Product(int ID, string Name, Category Category, int Quantity, double Price)
        {
            this.ID = ID;
            this.Name = Name;
            this.Category = Category;
            this.Quantity = Quantity;
            this.Price = Price;
        }

        public Product getProduct(int ID)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Product] WHERE ID = @ID", conn);
            sqlCommand.Parameters.AddWithValue("@ID", ID);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            Product product = new Product();
            while (reader.Read())
            {
                product.ID = Convert.ToInt32(reader["ID"]);
                product.Name = reader["Name"].ToString();
                product.Quantity = Convert.ToInt32(reader["Quantity"]);
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Category = new Category().getCategory(Convert.ToInt32(reader["CategoryID"]));
            }
            conn.Close();
            return product;
        }


        public void addProduct(Product product)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Product] VALUES (@ID,@Name,@Quantity,@Price,@CategoryID)", conn);
            sqlCommand.Parameters.AddWithValue("@ID", product.ID);
            sqlCommand.Parameters.AddWithValue("@Name", product.Name);
            sqlCommand.Parameters.AddWithValue("@Quantity", product.Quantity);
            sqlCommand.Parameters.AddWithValue("@Price", product.Price);
            sqlCommand.Parameters.AddWithValue("@CategoryID", product.Category.ID);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public List<Product> getProducts()
        {
            List<Product> ProductList = new List<Product>();

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Product]", conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.ID = Convert.ToInt32(reader["ID"]);
                product.Name = reader["Name"].ToString();
                product.Quantity = Convert.ToInt32(reader["Quantity"]);
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Category = new Category().getCategory(Convert.ToInt32(reader["CategoryID"]));
                ProductList.Add(product);
            }
            conn.Close();
            return ProductList;
        }
        public void removeProduct(Product product)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM [Product] WHERE ID=@ID", conn);
            sqlCommand.Parameters.AddWithValue("@ID", product.ID);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }
    }

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
