using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class ShowDataDelegate : EventArgs, IShowDataDelegate
    {
        public void GetSomething()
        {
            throw new NotImplementedException();
        }
    }
}
