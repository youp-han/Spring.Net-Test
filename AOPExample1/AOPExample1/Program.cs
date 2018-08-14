using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Spring.Aop.Framework;
using Spring.AOPExample.Command;
using Spring.AOPExample.Advice;

namespace Spring.AOPExample.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyFactory factory = new ProxyFactory(new ServiceCommand());
            factory.AddAdvice(new ConsoleLoggingAroundAdvice());
            ICommand command = (ICommand)factory.GetProxy();
            command.execute("this is the argument");
            Console.ReadLine();

        }
    }
}
