using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleJeszczeWPracy
{
    class Program
    {
        static void Main(string[] args)
        {
            int minuty_w_int = DateTime.Now.Minute;
            string minuta = Convert.ToString(minuty_w_int);
            int ile_zostalo_minut = 60 - minuty_w_int;
            DateTime teraz = DateTime.Now;
            DateTime za8h = teraz;
            za8h = za8h.AddHours(8);
            int godzina_w_int = DateTime.Now.Hour;
            int ile_zostalo_godzin = 16 - godzina_w_int;//tu wpisujemy godzine o której kończymy -(minus) 1 czyli jak wychodzimy o 17 to wpisujemy = 16, jak kończymy o 16 to wpisujemy = 15.Modyfikujemy to też linijkę niżej w miejscu x w stringu:" Do godziny xx:00 zostało "  

            File.AppendAllText(@"C:\Dane\ileJeszcze.txt", teraz.ToString() + " Do godziny 17:00 zostalo " + ile_zostalo_godzin + " Godzin i " + ile_zostalo_minut +
                 " minut. " + Environment.NewLine);
        }
    }
}
