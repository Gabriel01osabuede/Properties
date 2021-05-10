using System;

namespace properties
{
    class employees
    {
        public string firstName {get; set;}
        public string lastName { get; set; }

        public int totalPay { get; set; }

        public int id { get; set; }

        public void printAllDetail()
        {
            Console.WriteLine($"first Name : {firstName} \nLast Name : {lastName}\nTotal Pay : #{totalPay} Naira\nId : {id}");
        }
        
    }
}