using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spring.AOPExample.Command
{
    public interface ICommand
    {
        object execute(object context);
    }
}
