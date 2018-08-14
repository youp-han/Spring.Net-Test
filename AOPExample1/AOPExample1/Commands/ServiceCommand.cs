using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spring.AOPExample.Command
{
    // adviced object

    public class ServiceCommand : ICommand
    {
        #region ICommand Members

        public object execute(object context)
        {
            Console.WriteLine("\tService Implementation : [{0}]", context);
            return " with this returned Value";
        }

        #endregion
    }
}
