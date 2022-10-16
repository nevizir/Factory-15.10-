using System;

namespace Factory_15._10_
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("david", "sda", DateTime.Now, 200);
            Product product = new Product("ris",CategoryType.Tecknica,200);
            Factory factory = new Factory("Roshen");
            factory.AddProduct(product);
            factory.AddEmployee(employee);
            decimal avrsalary = factory.AvrSalary;
            Console.WriteLine(avrsalary);
           
        }
    }
}
