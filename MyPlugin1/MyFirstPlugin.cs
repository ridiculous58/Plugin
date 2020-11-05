using Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlugin1
{
    public class MyFirstPlugin : IPlugin
    {
        public string Description()
        {
            return "MyPlugin1 Description() Method";
        }

        public string Name()
        {
            return "MyPlugin1 Name() Method";
            
        }

        public void Run()
        {
            Console.WriteLine("MyPlugin1 Run() Method");
        }
    }
}
