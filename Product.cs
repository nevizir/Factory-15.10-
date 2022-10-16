using System;

namespace Factory_15._10_
{
    enum CategoryType { Clouthes, Soft, Solid, Tecknica };

    struct Product
    {
        private string name;
        private DateTime manufactureDate;
        private CategoryType category;
        private decimal price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public CategoryType Category
        {
            get { return category; }
            set { category = value; }
        }
        public DateTime ManufactureDate
        {
            get { return manufactureDate; }
        }
        public Decimal Price
            { get { return price; } set { price = value; } }

        public Product(string name, CategoryType category, decimal price)
        {
            this.name = name;
            this.manufactureDate = DateTime.Now;
            this.category = category;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine("Name :: " + name);
            Console.WriteLine("ManufactureDate :: " + manufactureDate);
            Console.WriteLine("Category :: " + category);
            Console.WriteLine("Price :: " + price);
        }
             
    } 
}
