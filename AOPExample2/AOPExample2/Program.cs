using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Context;
using Spring.Context.Support;
using Spring.Aop.Framework;
using Spring.AOPExample.Advice;
using Spring.AOPExample.Command;

namespace Spring.AOPExample.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            ICommand command = (ICommand) ctx["myServiceCommand"];
            command.execute(null);
            Console.ReadLine();
        }
    }
}
