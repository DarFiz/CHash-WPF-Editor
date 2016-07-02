using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CHashWPFEditor
{
    class MyRegex
    {
        public string tekst_;

        public void setString(string tekst)
        {
            tekst_ = tekst;
        }
        public string getString()
        {
            return tekst_;
        }

        public void Zamien(string stare_slowo, string nowe_slowo)
        {
                string find = "(.*?)" + Regex.Escape(stare_slowo) + "(.*)";
                string tekstPoReg = Regex.Replace(tekst_, find,"$1" + nowe_slowo + "$2");
                tekst_ = tekstPoReg;
        }
    }
}
