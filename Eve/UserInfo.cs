using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eve
{
    class UserInfo
    {
        private string name, sname;
        private int u_age;
        public UserInfo(string name, string sname, int u_age)
        {
            this.name = name;
            this.sname = sname;
            this.u_age = u_age;
        }

        public void UInfo() 
        {
            Console.WriteLine("Event is call");
            Console.WriteLine(name + " "  + sname + " " + u_age);
        }
        public void TestFunction() //Метод для тестирования
        {
            Console.WriteLine("Test message");
        }
    }
}
