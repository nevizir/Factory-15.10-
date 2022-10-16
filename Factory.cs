using System.Collections.Generic;

namespace Factory_15._10_
{
    class Factory
    {
        private string name;
        private List<Employee> employees;
        private List<Product> products;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Factory(string name)
        {
            this.name=name;
            
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
       

        public decimal AvrSalary
        {
            get
            {
                decimal avrsalary = 0;
                foreach(Employee e in employees)
                {
                    avrsalary += e.Salary;
                }
                return avrsalary/employees.Count;
            }
        }

        public decimal TotalSalary
        {
            get
            {
                decimal totalsalary = 0;
                foreach (Employee e in employees)
                {
                    totalsalary += e.Salary;
                }
                return totalsalary;
            }
        }

        public decimal GDP
        {
            get
            {
                decimal gdp = 0;
                foreach (Product p in products)
                {
                    gdp += p.Price;
                }
                return gdp / employees.Count;
            }
        }

        public int EmpCount
        {
            get { return employees.Count; }
        }
    }
}
