using System;

namespace Exampe
{
    class Employee
    {
        public int id;
        public string name;
        public float salary;

        public Employee(int i, string n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }

        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary );
        }

        static void Main(string[] arg)
        {
            Employee e1 = new Employee(1, "lugenge", 1200000f);
            
            e1.display();
        }
    }
}