using System;
using System.IO;
using System.Linq;
using chatter.models;

namespace chatter
{
    class Program
    {
        static void Main(string[] args)
        {
            var moduleLoader = new ModuleLoader();
            var directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var modules = moduleLoader.Load(directory);
            if (modules.Any())
            {
                Console.WriteLine("There are modules!");
            }
            else {
                Console.WriteLine("Nothing to see here!");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
