using System;
using System.Colections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Planet: Galaxy
    {
      public string obitaemost;

      public Planet () { }

          public Planet (): base{name, type, age, }

      public Planet(string name, string type, double age, string obitaemost): base(name, type, age)
      {
          this.obitaemost=obitaemost
      }

      public void PrintStudent() { 
          Console.WriteLine($"Planetata{name} e na {age} i e{obitaemost}")
      }
    }

}