using System;

namespace properties
{
    class Program
    {
        static void Main(string[] args)
        {

            employees EmployeeAndrew = new employees();
            EmployeeAndrew.firstName = "Andrew";
            EmployeeAndrew.lastName = "Gabriel";
            EmployeeAndrew.totalPay = 1500;
            EmployeeAndrew.id = 025;

            EmployeeAndrew.printAllDetail();

            student Andrey = new student();
            properties newProp = new properties();

            newProp.FirstId = -2;
            Console.WriteLine(newProp.FirstId);

            Andrey.setId(03);
            Andrey.setName("Andrey");
            Andrey.setPassMark(100);
            Console.WriteLine($"Students Data = id {Andrey.getId()} \n name = {Andrey.getName()} \n Pass Mark = {Andrey.getPassMark()}");
        }
    }
    
    class student
    {
        private int _id;

        private string _name;
        
        private int _passMark;

        public void setId(int id)
        {
            if(id <= 0)
            {
                throw new Exception("student id can not be less than zero");
            }
            this._id = id;
        }
        public int getId()
        {
            return this._id;
        }

        public void setName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new Exception("Name can not be null");
            }
            this._name = name;
        }

        public string getName()
        {
            return this._name;
        }

         public void setPassMark(int passMark)
        {
            if(passMark > 100)
            {
                throw new Exception("PassMark can not be more than 100");
            }
            this._passMark = passMark;
        }

        public int getPassMark()
        {
            return this._passMark;
        }
    }
}
