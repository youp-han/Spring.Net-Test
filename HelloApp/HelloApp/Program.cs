using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Context;
using Spring.Context.Support;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IHello hello = (IHello)ctx.GetObject("MyHello");
            Console.WriteLine(hello.sayHello("Mike"));
        }
    }
}
