using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EnumStatic
{
    internal static class Extension
    {
        public static bool CheckPin(this string Pin)
        {
            if (Pin.Length == 7 && Pin == Pin.ToUpper())
            {
                return true;
            }
            else 
            {
                throw new Exception("Invalid Pin");
            }
        }
    }
}