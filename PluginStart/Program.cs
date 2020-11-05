using Plugin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PluginStart
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Directory.GetFiles("plugins","*.dll"))
            {
                Assembly assembly = Assembly.LoadFrom(item);

                foreach (var type in assembly.GetTypes())
                {
                    if(type.GetInterface("IPlugin") != null)
                    {
                        IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                        Console.WriteLine(plugin.Name()); 
                        Console.WriteLine(plugin.Description());
                        plugin.Run();
                    }
                    
                }
            }
            Console.ReadLine();
        }
        
    }
}
