using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Balik
    {
        public ArrayList Items = new ArrayList();

        string trackingnumber;
        public string Trackingnumber
        {
            get { return Trackingnumber; }
            set {trackingnumber = value;
                TrackingnumberAdded?.Invoke(Vratinfo()); // ? sa pyta ci neni tracking number null
            }
        }

        public void Additem(item item)
        {
            Items.Add(item);
        }
        public delegate void OnShipmentMade(string message);
        public event OnShipmentMade TrackingnumberAdded;

        public string Vratinfo()
        {
            string info = "";
            foreach(item i in Items)
            {
                info += i.meno + Environment.NewLine;
                info += i.pocetkusov.ToString() + Environment.NewLine;
                info += i.cenazakus.ToString() + Environment.NewLine;
            }
            return info;
        }
        
        
    }
}
