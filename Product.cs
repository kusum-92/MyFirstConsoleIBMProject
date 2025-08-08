using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMProject
{
    internal class Product //only two type of classes - internal and public
    {
        //data members of Product class
        private string productName;
        private double productPrice;
        private int productQuantity;//instance variable

        public Product()  //create instance of Product class - default constructor 
        {

        }
        public Product(string name,double price, int quantity) //parameterized constructor
        {
            productName = name;
            productPrice = price;
            productQuantity = quantity;
        }
        // public properties only for private data members
        public string ProductName //should start from upper case letter
        {
            get { return productName; }
            set { productName = value; }
        }
        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        public int ProductQuantity
        {
            get { return productQuantity; }
            set { productQuantity = value; }
        }
        //method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {productName}");
            Console.WriteLine($"Product Price: {productPrice}");
            Console.WriteLine($"Product Quantity: {productQuantity}");
        }
        //method to calculate total price of the product
        public double CalculateTotalPrice()
        {
            return productPrice * productQuantity;
        }
        //method to apply discount on the product

        public double ApplyDiscount(double discountPercentage)
        {
            double discountAmount = (productPrice * discountPercentage) / 100;
            return productPrice - discountAmount;
        }
        //method to check if the product is in stock
        public bool IsInStock()
        {
            return productQuantity > 0;
        }
        //method to restock the product
        public void Restock(int additionalquantity)
        {
            if (additionalquantity > 0)
            {
                productQuantity += additionalquantity;
                Console.WriteLine($"{additionalquantity} units added to stock. New quantity: {productQuantity}");
            }
            else
            {
                Console.WriteLine("Invalid quantity to restock.");
            }
        }
        //method to update product price    
        public void UpdatePrice(double newPrice)
        {
            if (newPrice > 0)
            {
                productPrice = newPrice;
                Console.WriteLine($"Product price updated to: {productPrice}");
            }
            else
            {
                Console.WriteLine("Invalid price. Price must be greater than zero.");
            }
        }
            //method to sell the product
        public void SellProduct(int sellquantity)
        {
            if (sellquantity>0  && sellquantity <= productQuantity)
            {
                productQuantity-=sellquantity;
                Console.WriteLine($"{sellquantity} units sold. Remaining stock: {productQuantity}");
            }
            else
            {
                Console.WriteLine("Insufficient Stock");
            }
        }
        
    }
}
