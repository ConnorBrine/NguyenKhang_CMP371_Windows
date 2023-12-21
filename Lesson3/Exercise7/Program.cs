using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Exercise
{
    public class User
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Place { get; set; }
        public DateOnly dob { get; set; }   
        public int salary { get; set; }

        public User(int ID, string FirstName, string LastName, string Place, string dob, int salary)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Place = Place;
            if(dob != "")
            {
                DateTime tmp = Convert.ToDateTime(dob);
                this.dob = DateOnly.FromDateTime(tmp);
            }
            this.salary = salary;
        }
    }
    public class Car
    {
        public string Brand { get; set; }
        public int price { get; set; }
        public Car(string brand, int price)
        {
            Brand = brand;
            this.price = price;
        }
    }
    class Program
    {
        public static void Main()
        {
            User[] users = new User[]
            {
                new (1, "John","", "London", "2001-04-01", 0),
                new (2, "Lenny", "", "New York", "1997-12-11", 0), 
                new (3, "Andrew","", "Boston", "1987-02-22", 0), 
                new (4, "Peter","", "Prague", "1936-03-24", 0), 
                new (5, "Anna","", "Bratislava", "1973-11-18", 0), 
                new (6, "Albert","", "Bratislava", "1940-12-11", 0), 
                new (7, "Adam","", "Trnava", "1983-12-01", 0), 
                new (8, "Robert","", "Bratislava", "1935-05-15", 0), 
                new (9, "Robert","", "Prague", "1998-03-14", 0),
            };
            IEnumerable<User> result = (from emp in users
                                        where emp.Place == "Bratislava"
                                        select emp);
            Console.WriteLine("Users who live in Bratislava\n");
            foreach (User emp in result)
            {
                Console.WriteLine($" {emp.ID} {emp.FirstName} {emp.Place} {emp.dob}");
            }

            var cars = new List<Car> {
                new ("Audi", 52642), 
                new ("Mercedes", 57127), 
                new ("Skoda", 9000), 
                new ("Volvo", 29000), 
                new ("Bentley", 350000), 
                new ("Citroen", 21000), 
                new ("Hummer", 41400), 
                new ("Volkswagen", 21600),
            };

            IEnumerable<Car> result1 = (from emp in cars
                                         where emp.price > 30000 && emp.price < 100000
                                        select emp);
            Console.WriteLine("The cars whose price is between 30000 and 100000\n");
            foreach (Car emp in result1)
            {
                Console.WriteLine($" {emp.Brand} {emp.price}");
            }

            var users2 = new List<User> {
                new (0,"John", "Doe", "","", 1230),
                new (0,"Lucy", "Novak","","", 670), 
                new (0,"Ben", "Walter","","", 2050), 
                new (0,"Robin", "Brown","","", 2300), 
                new (0,"Amy", "Doe","","", 1250), 
                new (0,"Joe", "Draker","","", 1190), 
                new (0,"Janet", "Doe","","", 980), 
                new (0,"Albert", "Novak","","", 1930),
            };
            var orderbyResult = from s in users2
            orderby s.LastName, s.salary
            select s;
            Console.WriteLine("Sort ascending by last name and salary\n");
            foreach (User emp in orderbyResult)
            {
                Console.WriteLine($" {emp.FirstName} {emp.LastName} {emp.salary}");
            }

            IEnumerable<User> result2 = (from emp in users2
                                         where emp.salary > 1500 
                                        select emp).ToList();
            Console.WriteLine("Users who have salary higher than 1500\n");
            foreach (User emp in result2)
            {
                Console.WriteLine($" {emp.FirstName} {emp.LastName} {emp.salary}");
            }
        }


    }
}