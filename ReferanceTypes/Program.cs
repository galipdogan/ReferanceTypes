using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum,boolean  values types
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;
            //sayi2 = 100;

            //Console.WriteLine("Sayı1 : " +sayi1);

            //// arrays,claas,inteface  referance types
            //int[] sayilar1 = new int[] {1, 2, 3};
            //int[] sayilar2 = new int[] {10, 20, 30};

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayılar1[0] : " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Galip"; 
            person2 = person1;// buarada artık referance type olduğundan person2 person1 referansını alır(Yani bellekteki adresini gösterir)
            person1.FirstName = "Derin"; // person1 ve person2 bellekteki adresleri aynı olduğundan person2 nin de adı değişmiş oldu

            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditNumber = "123456667";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;// bu şekilde yapilmemizin nedeni Customer Person(inheritance) barındırdığından
            person3.FirstName = "Ahmet";
            
            
           //Console.WriteLine(((Customer)person3).CreditNumber);


           //Base class dan türetilmiş olanları tekrardan add içinde kullanabiliriz.
           //Referans aldığından her işlemi ayrı ayrı gerçekleştirip farklı proje ve veritabanlarında kullanabilmemize olanak sağlar.
           PersonManager personManager = new PersonManager();
           personManager.Add(person1);
           personManager.Add(employee);
           personManager.Add(customer);
        }

    }

    class Person      //Base class
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer:Person // Person dan türetiyoruz ve persondan gelenlere customer eklenmiş olur.
    {
        public string CreditNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
          
        }
    }
}
