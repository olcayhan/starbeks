using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public enum Status { inQueue = 0, Preparing, Ready, Paid }
    public class Order
    {
        public string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=starbeks;Integrated Security=True";

        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public Status Status { get; set; }
        public int UserID { get; set; }

        public Order() { }
        public Order(int ID, string Name, DateTime Time, Status Status, int UserID)
        {
            this.ID = ID;
            this.Name = Name;
            this.Time = Time;
            this.Status = Status;
            this.UserID = UserID;
        }

        public void addOrder(Order order)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Order] VALUES (@ID,@Name,@Time,@Status,@UserID)", conn);
            sqlCommand.Parameters.AddWithValue("@ID", order.ID);
            sqlCommand.Parameters.AddWithValue("@Name", order.Name);
            sqlCommand.Parameters.AddWithValue("@Time", order.Time);
            sqlCommand.Parameters.AddWithValue("@Status", order.Status.ToString());
            sqlCommand.Parameters.AddWithValue("@UserID", order.UserID);

            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }
        public void updateOrder(Order order)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE [Order] SET Name=@Name,Time=@Time,Status=@Status WHERE ID=@ID", conn);
            sqlCommand.Parameters.AddWithValue("@ID", order.ID);
            sqlCommand.Parameters.AddWithValue("@Name", order.Name);
            sqlCommand.Parameters.AddWithValue("@Time", order.Time);
            sqlCommand.Parameters.AddWithValue("@Status", order.Status.ToString());
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void addProduct(OrderProduct product)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO [OrderProduct] (ID,ProductID,Name,Price,Piece,orderID) VALUES (@ID,@ProductID,@Name,@Price,@Piece,@orderID)", conn);
            sqlCommand.Parameters.AddWithValue("@ID", product.ID);
            sqlCommand.Parameters.AddWithValue("@ProductID", product.productID);
            sqlCommand.Parameters.AddWithValue("@Name", product.Name);
            sqlCommand.Parameters.AddWithValue("@Price", product.Price);
            sqlCommand.Parameters.AddWithValue("@Piece", product.Piece);
            sqlCommand.Parameters.AddWithValue("@orderID", product.orderID);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void PayOrder(Order order)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE [Order] SET Status=@Status WHERE ID=@ID", conn);
            sqlCommand.Parameters.AddWithValue("@ID", order.ID);
            sqlCommand.Parameters.AddWithValue("@Status", Status.Paid.ToString());
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public List<Order> getOrders()
        {
            List<Order> ordersList = new List<Order>();
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Order] WHERE Status!=@Status", conn);
            sqlCommand.Parameters.AddWithValue("@Status", Status.Paid.ToString());
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), (Status)Enum.Parse(typeof(Status), reader.GetString(3)), reader.GetInt32(4));
                ordersList.Add(order);
            }
            conn.Close();
            return ordersList;
        }
        public List<Order> getActiveOrders(int userID) {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Order] WHERE Status!=@Status AND UserID=@UserID", conn);
            sqlCommand.Parameters.AddWithValue("@Status", Status.Paid.ToString());
            sqlCommand.Parameters.AddWithValue("@UserID", userID);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<Order> ordersList = new List<Order>();
            while (reader.Read())
            {
                Order order = new Order(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), (Status)Enum.Parse(typeof(Status), reader.GetString(3)), reader.GetInt32(4));
                ordersList.Add(order);
            }
            conn.Close();
            return ordersList;
        }
        public List<Order> getCompletedOrders(int userID)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Order] WHERE Status=@Status AND UserID=@UserID", conn);
            sqlCommand.Parameters.AddWithValue("@Status", Status.Paid.ToString());
            sqlCommand.Parameters.AddWithValue("@UserID", userID);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<Order> ordersList = new List<Order>();
            while (reader.Read())
            {
                Order order = new Order(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), (Status)Enum.Parse(typeof(Status), reader.GetString(3)), reader.GetInt32(4));
                ordersList.Add(order);
            }
            conn.Close();
            return ordersList;
        }
        public Order getOrder(int id)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Order] WHERE ID=@ID", conn);
            sqlCommand.Parameters.AddWithValue("@ID", id);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            Order order = new Order();
            while (reader.Read())
            {
                order = new Order(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), (Status)Enum.Parse(typeof(Status), reader.GetString(3)), reader.GetInt32(4));
            }
            conn.Close();
            return order;
        }
        public List<OrderProduct> getProducts(int id)
        {
            List<OrderProduct> orderProducts = new List<OrderProduct>();
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [OrderProduct] WHERE OrderID=@OrderID", conn);
            sqlCommand.Parameters.AddWithValue("@OrderID", id);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                OrderProduct newOrder = new OrderProduct(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3), reader.GetDouble(4), reader.GetInt32(5));
                orderProducts.Add(newOrder);
            }
            conn.Close();
            return orderProducts;
        }

        public List<Order> getReadyOrders()
        {
            List<Order> ordersList = new List<Order>();
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Order] WHERE Status=@Status", conn);
            sqlCommand.Parameters.AddWithValue("@Status", Status.Ready.ToString());
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), (Status)Enum.Parse(typeof(Status), reader.GetString(3)), reader.GetInt32(4));
                ordersList.Add(order);
            }

            conn.Close();
            return ordersList;
        }
    }
}
