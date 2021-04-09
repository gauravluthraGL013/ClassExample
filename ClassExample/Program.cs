 using System;

namespace ClassExample
{
    class Program
    {
        public static Person obj = new Person();
        public static Person obj1 = new Person();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine("Please enter position ");
            string position = Console.ReadLine();
            Console.WriteLine("Please enter salary ");
            string salary = Console.ReadLine();
            Console.WriteLine("Please enter department");
            string department = Console.ReadLine();

            int newSalary = Convert.ToInt32(salary);

            obj.SetMember(position, newSalary, department);

            obj.GetMember(out position, out newSalary, out department);
            Console.WriteLine("Position " + position);
            Console.WriteLine(" Salary " + newSalary);
            Console.WriteLine(" deaprtment " + department);


            Console.WriteLine("Please enter position for Obj1 ");
            position = Console.ReadLine();
            Console.WriteLine("Please enter Salary Obj1");
            salary = Console.ReadLine();
            Console.WriteLine("Please enter department for obj1");
            department = Console.ReadLine();

            newSalary = Convert.ToInt32(salary);

            obj1.SetMember(position, newSalary, department);
            obj1.GetMember(out position, out newSalary, out department);
            Console.WriteLine("Position: " + position);
            Console.WriteLine(" Salary " + newSalary);
            Console.WriteLine(" deaprtment " + department);
        }
    }
}

