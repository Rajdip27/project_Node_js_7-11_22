using System;

namespace MyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            person per = new person();
            per.firstName = "Rajdip";
            per.MiddleNamw = "Raj";
            per.LastName = "Santanu";
            string fullName = per.GetFullName();
            Console.WriteLine(fullName);


            person per2 = new person();
            per2.firstName = "Eava";
            per2.MiddleNamw = "Kabila";
            per2.LastName = "Rokeya";
            fullName = per2.GetFullName();
            Console.WriteLine(fullName);
            person per3;
            per3 = new person();
            per3 = per;
            per3.MiddleNamw = "Santanu";
            fullName = per3.GetFullName();
            Console.WriteLine(fullName);




            Console.ReadKey();

        }
    }
}
