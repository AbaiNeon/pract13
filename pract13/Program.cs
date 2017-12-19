using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract13
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() { Name = "Alex", Age = 29 };

            person1.PropertyChanged += new ConsoleSender().PrintMessage;
            person1.Name = "Petr";
            person1.Age = 29;
            
            Console.ReadLine();
        }
    }
}
