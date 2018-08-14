using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AopAlliance.Intercept;

namespace Spring.AOPExample.Advice
{
    //around advice
    public class ConsoleLoggingAroundAdvice : IMethodInterceptor
    {
        #region IMethodInterceptor Members

        public object Invoke(IMethodInvocation invocation)
        {
            Console.WriteLine("Advice executing; calling the advised method..");
            object returnValue = invocation.Proceed();
            Console.WriteLine("advice executed; advised method returned" + returnValue);
            return returnValue;
        }

        #endregion

       
    }
}
