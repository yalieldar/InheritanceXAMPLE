using System;

namespace InheritanceXAMPLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Mammels m=new Mammels(200, "Mammel",150,"Kuku");
            Mammels m1 = new Mammels(400);
           Otter o = new Otter(50, 100, "Otter",25, "Charlie");
            
           Console.WriteLine(o);

        }
    }
}
