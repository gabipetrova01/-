using system;
using system.Colections.Generic;
using system.Text;

namespace ConsoleApp6
{
    class Star :Galaxy
    {
        private string class;
        private double masa;
        private int razmer;
        private int temperatyra;
        private int svetimost;

        public Star(string name, string type, double age,string class, double masa, int razmer, int temperatyra, int svetimost) 
        {
           this.name= name;
           this.type= type;
           this.age= age;
           this.class= class;
           this.masa= masa;
           this.razmer= razmer;
           this.temperatyra=temperatyra;
           this.svetimost=svetimost;
        
        }

        public void PrintStar()
        {
            Console.WriteLine($"Zvezdata {Name} e class {class} ima masa {masa}, razmer {razmer}, temperatyra {temperatyra} i svetimost {svetimost}");
            
        }
    }
}