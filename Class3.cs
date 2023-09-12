using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3project
{
    internal class Class3
    {
        protected String Name;
        protected int Sellery;

        protected Class3(String Name, int Sellery)
        {
            this.Sellery = Sellery;
            this.Name = Name;

        }

        protected void Print()
        {
            Console.WriteLine($"The employee name is {Name} and sellery of the emp is {Sellery}");
        }
    }
    internal class Child : Class3
    {
        public String City;

        protected Child(string City) : base("mohit", 250000)
        {

            this.City = City;
        }

        public static void Main(String[] args)
        {
            Child c1 = new Child("Agra");
            Console.WriteLine(c1.City);

            c1.Print();
            Console.ReadLine();
        }
    }
}
