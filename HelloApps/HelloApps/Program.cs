using System;
using System.Collections.Generic;
using System.Text;
using Spring.Context;
using Spring.Context.Support;
using Hello;

namespace HelloApps
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IHello hello = (IHello)ctx.GetObject("MyHello");
            string name = "Mike";
            string result = hello.sayHello(name);
            Console.WriteLine(result);
        }
    }
}
