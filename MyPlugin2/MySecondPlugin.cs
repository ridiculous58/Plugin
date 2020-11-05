using Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlugin2
{
    public class MySecondPlugin : IPlugin
    {
        public string Description()
        {
            return "MyPlugin2 MySecondPlugin Description() Method";
        }

        public string Name()
        {
            return "MyPlugin2 MySecondPlugin Name() Method";
        }

        public void Run()
        {
            Console.WriteLine("MyPlugin2 MySecondPlugin Run() Method");
        }
    }
}
