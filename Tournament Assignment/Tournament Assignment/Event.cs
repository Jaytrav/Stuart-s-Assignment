using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament_Assignment
{
    class Event
    {
        string eventname;
        List<string> types = new List<string>();
        string type;


        public Event()
        {
            types.Add("acdemic");
            types.Add("sporting");
        }

        public void setType(String s)
        {
            if (types.Contains(s))
            {
                type = s;
            }else
            {
                Console.WriteLine("this is not a valid type");
            }
        }

        
    }
}
