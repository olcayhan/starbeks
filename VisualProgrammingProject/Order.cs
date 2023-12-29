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
        public List<OrderProduct> orderDetails = new List<OrderProduct>();
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

        public void addProduct(OrderProduct product)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO [OrderProduct] (ID,Name,Price,Piece,orderID) VALUES (@ID,@Name,@Price,@Piece,@orderID)", conn);
            sqlCommand.Parameters.AddWithValue("@ID", product.productID);
            sqlCommand.Parameters.AddWithValue("@Name", product.productName);
            sqlCommand.Parameters.AddWithValue("@Price", product.productPrice);
            sqlCommand.Parameters.AddWithValue("@Piece", product.productPiece);
            sqlCommand.Parameters.AddWithValue("@orderID", product.orderID);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void removeOrder(Order order)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM [Order] WHERE orderID=@ID", conn);
            sqlCommand.Parameters.AddWithValue("@ID", order.orderID);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void removeProduct(OrderProduct product)
        {
            orderDetails.Remove(product);
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
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Order] WHERE orderID=@ID", conn);
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
                OrderProduct newOrder = new OrderProduct(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3), reader.GetInt32(4));
                orderProducts.Add(newOrder);
            }
            conn.Close();
            return orderProducts;
        }
    }


    public class OrderProduct
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }
        public int productPiece { get; set; }
        public int orderID { get; set; }

        public OrderProduct(int productID, string productName, double productPrice, int productPiece, int orderID)
        {
            this.productID = productID;
            this.productName = productName;
            this.productPrice = productPrice;
            this.productPiece = productPiece;
            this.orderID = orderID;
        }
    }
}
