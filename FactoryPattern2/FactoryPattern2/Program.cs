using FactoryPattern2.Matters;
using System;
using System.Collections.Generic;

namespace FactoryPattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MatterBase> matterCollection = new List<MatterBase>();

            matterCollection.AddRange(new MatterBase[] 
            { 
                new SaleMatter(),
                new RentalMatter() 
            });

            foreach(var m in matterCollection)
            {
                Console.WriteLine($"{m.Name} - typeof {m.GetType().Name}");

                foreach(var a in m.MatterAreaCollection)
                {
                    Console.WriteLine($"{a.Name} - typeof {a.GetType().Name}");
                }

                Console.WriteLine("------------------");
            }
        }
    }
}
