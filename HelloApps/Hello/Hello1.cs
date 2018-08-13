using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello
{
    class Hello1: IHello 
    {

        #region IHello Members

        public string sayHello(string name)
        {
            return "안녕하세요 " + name + " 씨!";
        }

        #endregion
    }
}
