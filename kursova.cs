using system;
using system.Colections.Generic;
using system.Text;

namespace ConsoleApp6
{
    class Moon: Galaxy
    {
        private string name;

       public Moon (string name)
       {
           this.name=name
       }

       public void PrintMoon()
       {
           Console.WriteLine($"Lunata {name} ");
       }

    }
}