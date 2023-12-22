using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgrammingProject
{
    public class Product
    {
        public int Name { get; set; }
        public Category Category { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public static List<Product> ProductList = new List<Product>();

        public Product() { }
        public Product(int Name, Category Category, int Amount, double Price)
        {
            this.Name = Name;
            this.Category = Category;
            this.Amount = Amount;
            this.Price = Price;
        }


        public void addProduct(Product product)
        {
            ProductList.Add(product);
        }

        public List<Product> getProducts()
        {
            return ProductList;
        }
    }

    public class Category
    {
        public static List<Category> CategoryList = new List<Category>();
        public string Name { get; set; }


        public Category() { }
        public Category(string Name)
        {
            this.Name = Name;
        }

        public void AddCategory(Category category)
        {
            CategoryList.Add(category);
        }

        public List<Category> GetCategories()
        {
            return CategoryList;
        }

    }
}
