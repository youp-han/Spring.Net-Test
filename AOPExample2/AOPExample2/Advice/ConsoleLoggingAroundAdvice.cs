using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AopAlliance.Intercept;

namespace Spring.AOPExample.Advice
{
    class ConsoleLoggingAroundAdvice: IMethodInterceptor
    {

        #region IMethodInterceptor Members

        public object Invoke(IMethodInvocation invocation)
        {
            Console.WriteLine("Advice Executing; Calling the advised method ... ");
            object returnValue = invocation.Proceed();
            Console.WriteLine("Advice Executed; Advised method returned " + returnValue);
            return returnValue;
        }

        #endregion
    }
}
