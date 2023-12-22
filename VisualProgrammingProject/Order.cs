using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgrammingProject
{
    public enum Situation { inQueue, Preparing, Ready }
    public class Order
    {
        public Order() {}


        public static List<Order> ordersList = new List<Order>();
        public int orderID { get; set; }
        public string orderName { get; set; }
        public DateTime orderTime { get; set; }
        public Situation orderSituation { get; set; }
        public OrderProduct[] orderDetails { get; set; }



        public void addOrder(Order order)
        {
            ordersList.Add(order); 
        }

        public void removeOrder(Order order)
        {
            ordersList.Remove(order);
        }

        public List<Order> getOrders()
        {
            return ordersList;
        }


    }


    public class OrderProduct
    {
        public string productName { get; set; }
        public double productPrice { get; set; }
        public int productQuantity { get; set; }
    }
}
