using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace activosFijos.Code
{
    class libGen
    {
        public bool IsValidEmail(string email)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(email, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }
        public bool IsValidPass(string pass)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(pass, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[.,!#$@%&*~+=_-])[A-Za-z\d.,!#$@%&*~+=_-]{8,30}$");
        }

        public string genUsu(string Usu)
        {
            string codUsu = "";
            string[] usuario = Usu.Split(' ');
            foreach (string srr in usuario)
                codUsu = codUsu + srr.Substring(0, 1);
            // Return true if strIn is in valid e-mail format.
            return codUsu;
        }
    }
}
