using system;
using system.Colections.Generic;
using system.Text;

namespace ConsoleApp6
{
    class Galaxy
    {
       
        internal string name;
        internal string type;
        internal double age;

       

        

        public void PrintMPS()
        {
            Console.WriteLine($"{name} {type} e na {age} godini");
        }
    }
}