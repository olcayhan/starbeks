using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgrammingProject
{
    public class OrderProduct
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }
        public int productPiece { get; set; }
        public int orderID { get; set; }

        public OrderProduct(int productID, string productName, int productPiece, double productPrice, int orderID)
        {
            this.productID = productID;
            this.productName = productName;
            this.productPrice = productPrice;
            this.productPiece = productPiece;
            this.orderID = orderID;
        }
    }

}
