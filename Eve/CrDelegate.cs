using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eve
{
    public delegate void userHandle();
    class CrDelegate
    {
        public event userHandle userEvents;

        public void onHandler()
        {
            if (userEvents != null)
                userEvents();
         }
    }
}
