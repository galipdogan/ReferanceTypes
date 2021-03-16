using System;

namespace Constructors
{
    class Program
    {
        //class yapulandırıldığında çalışan uygulamadır.
        static void Main(string[] args)
        {
            Customer customer1 = new Customer{Id =1,FirstName ="Galip", LastName = "Doğan",City = "İzmir"};

            Customer customer2 = new Customer(2, "Galip", "Doğan", "İzmir");

            
        }

       static void Method(int Id,string FirstName,string LastName,string City)
        {

        }
    }

    class Customer
    {
        public Customer(int id, string firstName, string lastName, string city)  // İstersek bu şekilde de override ederek yazabiliriz.
        {
            // Bu kısımda constructor çalışacağından parametreleri eşitlememiz gerekiyor.
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public Customer() //Default Constroctor. Bunu yazmasak bile bu blok oluşur.Class ile aynı isimle olandır. 
        {
            
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
