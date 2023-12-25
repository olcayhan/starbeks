using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgrammingProject
{
    public enum Status { inQueue, Preparing, Ready }
    public class Order
    {
        public static List<Order> ordersList = new List<Order>();
        public List<OrderProduct> orderDetails = new List<OrderProduct>();

        public int orderID { get; set; }
        public string orderName { get; set; }
        public DateTime orderTime { get; set; }
        public Status orderStatus { get; set; }

        public Order() {}
        public Order(int orderID, string orderName, DateTime orderTime)
        {
            this.orderID = orderID;
            this.orderName = orderName;
            this.orderTime = orderTime;
        }

        public void addOrder(Order order)
        {
            ordersList.Add(order); 
        }

        public void addProduct(OrderProduct product)
        {
            orderDetails.Add(product);
        }

        public void removeOrder(Order order)
        {
            ordersList.Remove(order);
        }

        public void removeProduct(OrderProduct product)
        {
            orderDetails.Remove(product);
        }

        public List<Order> getOrders()
        {
            return ordersList;
        }

        public Order getOrder(int id)
        {
            return ordersList.Find(item => item.orderID == id);
        }
    }


    public class OrderProduct
    {
        public string productName { get; set; }
        public double productPrice { get; set; }
        public int productPiece { get; set; }

        public OrderProduct(string productName, double productPrice,int productPiece)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.productPiece = productPiece;
        }
    }
}
