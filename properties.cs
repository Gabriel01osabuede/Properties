using System;

namespace properties
{
    class properties
    {
        private int firstId;
        public int FirstId { 
            get
            {
                return this.firstId;
            }
            set
             {
                 if(value <= 0)
                 {
                     throw new Exception("Id cannot be less than or equal to 0");
                 }
              firstId = value;   
             } 
             }

        public int studentName { get; set; }

        public int studentPassMark { get; set; }

        
    }
}