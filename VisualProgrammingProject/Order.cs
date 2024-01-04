using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public enum Status { inQueue = 0, Preparing = 1, Ready = 2 }
    public class Order
    {
        public string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=starbeks;Integrated Security=True";

        public int orderID { get; set; }
        public string orderName { get; set; }
        public DateTime orderTime { get; set; }
        public Status orderStatus { get; set; }

        public Order() { }
        public Order(int orderID, string orderName, DateTime orderTime, Status orderStatus)
        {
            this.orderID = orderID;
            this.orderName = orderName;
            this.orderTime = orderTime;
            this.orderStatus = orderStatus;
        }

        public void addOrder(Order order)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Order] VALUES (@ID,@Name,@Time,@Status)", conn);
            sqlCommand.Parameters.AddWithValue("@ID", order.orderID);
            sqlCommand.Parameters.AddWithValue("@Name", order.orderName);
            sqlCommand.Parameters.AddWithValue("@Time", order.orderTime);
            sqlCommand.Parameters.AddWithValue("@Status", order.orderStatus.ToString());
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }
        public void updateOrder(Order order)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE [Order] SET Name=@Name,Time=@Time,Status=@Status WHERE ID=@ID", conn);
            sqlCommand.Parameters.AddWithValue("@ID", order.orderID);
            sqlCommand.Parameters.AddWithValue("@Name", order.orderName);
            sqlCommand.Parameters.AddWithValue("@Time", order.orderTime);
            sqlCommand.Parameters.AddWithValue("@Status", order.orderStatus.ToString());
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

        public void removeOrder(Order order)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM [Order] WHERE ID=@ID", conn);
            sqlCommand.Parameters.AddWithValue("@ID", order.orderID);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void removeProduct(OrderProduct product)
        {
            //orderDetails.Remove(product);
        }

        public List<Order> getOrders()
        {
            List<Order> ordersList = new List<Order>();
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Order]", conn);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), (Status)Enum.Parse(typeof(Status), reader.GetString(3)));
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
                order = new Order(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), (Status)Enum.Parse(typeof(Status), reader.GetString(3)));
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
                OrderProduct newOrder = new OrderProduct(reader.GetInt32(0),reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3), reader.GetDouble(4), reader.GetInt32(5));
                orderProducts.Add(newOrder);
            }
            conn.Close();
            return orderProducts;
        }
    }
}
