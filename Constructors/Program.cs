using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1, FirstName="Aslı", LastName="Özcan", City="Sivas"};

            Customer customer2 = new Customer(2, "Selen", "Derin", "Antalya");
            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        //default constructor
        public Customer()
        {

        }
        public Customer(int id,string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
