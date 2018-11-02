using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Sex { get; set; }
            public int Balance { get; set; }
        }

        static List<Person> people = new List<Person>
        {
            new Person { Name="Иван", Age=31, Sex = "Male", Balance = 400 },
            new Person { Name="Женя", Age=24, Sex = "Male", Balance = 21000 },
            new Person { Name="Даша", Age=22, Sex = "Female", Balance = 570 },
            new Person { Name="Леша", Age=25, Sex = "Male", Balance = 14758 },
            new Person { Name="Соня", Age=27, Sex = "Female", Balance = 4792 }
        };

        static void Main(string[] args)
        {

            //Задание2

            var quantity = people.Where(x => x.Balance > 4000).Count();
            Console.WriteLine("{0} {1}", "Ко-во людей с балансом выше 4000:", quantity);
            int.TryParse(Console.ReadLine(), out var nextTask);

            //Задание3

            var result = people
                .OrderBy(x => x.Age)
                .ThenBy(x => x.Sex)
                .ThenBy(x => x.Balance);
            Console.WriteLine("Сортировка");
            foreach (Person person in result)
                Console.WriteLine("{0} - {1}", person.Name, person.Age);
            int.TryParse(Console.ReadLine(), out var exit);
        }
    }
}
