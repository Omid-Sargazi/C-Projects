using System;
namespace Lambda
{
        public class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Hello");
                List<Person> people = new List<Person>();
                List<PersonCar> cars = new List<PersonCar>()
                {
                    new PersonCar(){PersonId=1,CarName="Pride",CarModel="1988"},
                    new PersonCar(){PersonId=3,CarName="Paykan", CarModel="2010"}
                };


                Person p1 = new Person();
                p1.Name="Reza";
                p1.Family="Alishah";
                p1.PersonId=1;
                p1.Age=20;
                people.Add(p1);


                Person p2 = new Person(){
                    PersonId=2,
                    Name="Hadi",
                    Family="Khatibi",
                    Age=39,
                };

                people.Add(p2);

                people.Add(new Person() {PersonId=3, Name="Abi", Family="daie", Age=21});

                var result1 = people.ToList();

                var result2 = people.OrderByDescending(p=>p.Age).ToList();

                var result3 = people.Where(p=>p.Name.ToLower()=="reza").ToList();

                var result4 = people.Select(p=>p.Name).ToList();

                var result5 = people.Select(p=> new{
                    p.Name, p.Age
                }).ToList();


                foreach(Person p in result3)
                {
                    Console.WriteLine($"{p.Name}:{p.Age} {p.Family} {p.PersonId}");
                }
                foreach(string p in result4)
                {
                    Console.WriteLine($"{p}");
                }

                foreach(var p in result5)
                {
                    Console.WriteLine($"{p.Name},{p.Age}");
                }


                var join = (from p in people
                    join c in cars on p.PersonId equals c.PersonId
                    select new {
                        p.Name, p.Age,p.PersonId,p.Family,c.CarName,c.CarModel
                    } 
                ).ToList();

                foreach(var p in join)
                {
                    Console.WriteLine($"Name: {p.Name}, Family: {p.Family} CarName: {p.CarName} CarModel: {p.CarModel}, PersonalId");
                }
            }
        }
}