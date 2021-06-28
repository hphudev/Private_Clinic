using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    static public class Support
    {
        static public string IdAdapter(string prefix, int num, int total)
        {
            return prefix + num.ToString().PadLeft(total, '0');
        }

        static public int IsContain(List<MedicinePhu> things, MedicinePhu s)
        {
            foreach(var thing in things)
            {
                if (thing.name.ToLower().Equals(s.name.ToLower()))
                    return things.IndexOf(thing);
            }
            return -1;
        }

        static public string IntToMoney(int value)
        {
            string res = value.ToString();
            int count = 0;
            for (int i = res.Length - 1; i >= 0; i--)
            {
                count++;
                if (count == 3)
                {
                    if (i > 0)
                        res = res.Insert(i, ",");
                    count = 0;
                }
            }
            return res;
        }
    }
}
