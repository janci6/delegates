using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                Balik S = new Balik();
                item item = new item();
                item.pocetkusov = 8887;
                item.meno = "zasielka A";
                item.cenazakus = 13;

                S.Additem(item);

                item = new item();
                item.cenazakus = 99;
                item.meno = "zasielka B";

            S.Additem(item);

            Notification n = new Notification();
            S.TrackingnumberAdded += n.notify;

            S.Trackingnumber = "1232nn";

            Console.ReadLine();

                

        }
    }
}
