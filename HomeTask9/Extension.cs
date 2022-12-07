using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9
{
    public static class Extension
    {
         public static bool CustomContains(this string str,string searchtext)
        {
            List<char> chars = new List<char>();
            foreach (var item in searchtext)
            {
                foreach (var item1 in str)
                {
                    if (item.ToString().ToLower() == item1.ToString().ToLower())
                    {
                        chars.Add('t');
                    }
                }

            }
            if (chars.Count==str.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
