﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace activosFijos.Code
{
    public class libGen
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
        public string annMes(string annMes)
        {
            string mes = "";
            string[] AN = annMes.Split('-');
            switch (AN[1])
            {
                case "01": mes = "Enero";break;
                case "02": mes = "Febrero"; break;
                case "03": mes = "Marzo"; break;
                case "04": mes = "Abril"; break;
                case "05": mes = "Mayo"; break;
                case "06": mes = "Junio"; break;
                case "07": mes = "Julio"; break;
                case "08": mes = "Agosto"; break;
                case "09": mes = "Septiembre"; break;
                case "10": mes = "Octubre"; break;
                case "11": mes = "Noviembre"; break;
                case "12": mes = "Diciembre"; break;
                default: mes = "";break;
            }
            return mes + " del " + AN[0];
        }
    }
}
