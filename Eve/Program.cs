using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eve
{
    class Program
    {
        static void Main(string[] args)
        {
            CrDelegate uDelegate = new CrDelegate();
            UserInfo ui = new UserInfo("Vasile", "Petrov", 22);
            uDelegate.userEvents += ui.UInfo;
            uDelegate.userEvents += ui.TestFunction;


            for (;;)
            {

                DateTime dt = DateTime.Now;
                if (dt.Second == 50)
                {
                    uDelegate.onHandler();
                    break;
                }
                else
                    Console.Clear();
                    Console.WriteLine(dt.ToString("T"));
                Console.WriteLine("{0 }", dt.Year);
                Console.WriteLine("{0}", dt.Month);
                Console.WriteLine("{0}", dt.Day);

                System.Threading.Thread.Sleep(1000);
                    

            }
            Console.ReadKey();
        }

    }
}
