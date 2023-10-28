using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfacesAndAbstractClasses2
{
    public class Dog : Animals
    {
        // Implement the abstract Eat method
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
    }
}
