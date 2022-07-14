using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam

{
    abstract class Product
    {
        private int id;
        private string name;
        private double price;
        private static int counter = 1;

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            this.Id = counter++;
            this.Name = name;
            this.Price = price;
        }

        public String ToString()
        {
            return this.Id + ". " + this.Name + " - $" + this.Price;
        }

        public abstract double computeTax();
    }

    class Book : Product
    {
        public Book(string name, double price) : base(name, price)
        {

        }
        public override double computeTax()
        {
            return Price * 5 / 100;
        }
    }

    class Phone : Product
    {
        public Phone(string name, double price) : base(name, price)
        {

        }
        public override double computeTax()
        {
            return Price * 10 / 100;
        }
    }


    class Test
    {
        static void Main(string[] args)
        {
            List<Product> objProduct = new List<Product>();
            objProduct.Add(new Book("Book 1", 100));
            objProduct.Add(new Book("Book 2", 80));
            objProduct.Add(new Book("Book 3", 150));
            objProduct.Add(new Phone("Phone 1", 1000));
            objProduct.Add(new Phone("Phone 2", 1500));

            double total = 0;

            foreach (Product product in objProduct)
            {
                Console.WriteLine(product.ToString());
                total += product.computeTax();
            }

            Console.WriteLine("Total tax of Book and Phone: $" + total);
        }
    }
}