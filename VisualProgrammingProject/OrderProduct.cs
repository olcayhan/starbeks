using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgrammingProject
{
    public class OrderProduct
    {
        public int ID { get; set; }
        public int productID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Piece { get; set; }
        public int orderID { get; set; }

        public OrderProduct(int ID,int productID, string Name, int Piece, double Price, int orderID)
        {
            this.ID = ID;
            this.productID = productID;
            this.Name = Name;
            this.Price = Price;
            this.Piece = Piece;
            this.orderID = orderID;
        }
    }

}
