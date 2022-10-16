using System;

namespace Factory_15._10_
{
    class Employee
    {
        private string name;
        private string surname;
        private DateTime birthdate;
        private decimal salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public DateTime Birthdate
        {
            get { return birthdate; }
            set
            {
                birthdate = value;
            }
        }
        public decimal Salary
        {
            get { return salary; }
            set
            {
                salary = value;
            }
        }

        public Employee(string name, string surname, DateTime birthdate, decimal salary)
        {
            this.name = name;
            this.surname = surname;
            this.birthdate = birthdate;
            this.salary = salary;
        }

        public void Show()
        {
            Console.WriteLine("Name :: " + name);
            Console.WriteLine("Surname :: " + surname);
            Console.WriteLine("Birthday :: " + birthdate);
            Console.WriteLine("Salary ::" + salary);
        }
       
    }
}
