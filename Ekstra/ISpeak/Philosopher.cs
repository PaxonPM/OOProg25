using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpeak
{
    public class Philosopher: ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Hello World");
        }

        public void Think()
        {
            Console.WriteLine("I Think therefor I am");
        }
    }
}
