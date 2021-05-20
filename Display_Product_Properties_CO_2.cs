using System;

public class Product{
        private int productId;
        private string productName;
        private double price;

        public int ProductId{
            get{ return productId; }
            set{ productId = value; }
        }
        public String ProductName{
            get { return productName;}
            set{ productName = value;}
        }
        public double Price{
            get { return price; }
            set{ 
                if (value < 0){
                    price = 0;
                }
                else {
                    price = value; 
                }
            }
            
        }
        public void Display(){
            Console.WriteLine("Product ID: {0}", productId);
            Console.WriteLine("Product Name: {0}", productName);
            Console.WriteLine("Product Price: {0}", price);
        }
    }
    public class Program{
        public static void Main(){
            Console.WriteLine("Enter product id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product price");
            double price = Convert.ToDouble(Console.ReadLine());
            Product product = new Product();
            product.ProductId = id;
            product.ProductName = name;
            product.Price = price;
            product.Display();
        }
    }