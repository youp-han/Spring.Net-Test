using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class Hello2 : IHello
    {
        #region IHello Members

        public string sayHello(string name)
        {
            return "안녕하십니까? " + name + " 님";
        }

        #endregion
    }
}
