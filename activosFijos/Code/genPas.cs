using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activosFijos.Code
{
    class genPas
    {
        public static string contrasena()
        {
            Random aleatorio = new Random();
            string res = "";
            string[] vals = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", ".", "-" };
            string[] vals3 = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] vals2 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] vals5 = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] vals4 = new string[] { ".", "-" };
            for (int i = 0; i < 8; i++)
            {
                if (i == 0) { res = res + vals5[aleatorio.Next(vals5.GetUpperBound(0) + 1)]; }
                else if (i == 3) { res = res + vals4[aleatorio.Next(vals4.GetUpperBound(0) + 1)]; }
                else if (i == 5) { res = res + vals2[aleatorio.Next(vals2.GetUpperBound(0) + 1)]; }
                else if (i == 6) { res = res + vals3[aleatorio.Next(vals3.GetUpperBound(0) + 1)]; }
                else { res = res + vals[aleatorio.Next(vals.GetUpperBound(0) + 1)]; }
            }
            return res;
        }
    }
}
