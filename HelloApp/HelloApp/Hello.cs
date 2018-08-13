using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloApp
{
    class Hello : IHello
    {

        #region IHello Members

        string IHello.sayHello(string name)
        {
            return "안녕하세요 " + name + " 씨!";
        }

        #endregion
    }
}
