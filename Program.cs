using System;
using System.Globalization;

namespace PaivaMuotoiluKonsoli
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cultureInfo = new CultureInfo("fi-FI");
            CultureInfo cloneCultureInfo = (CultureInfo)cultureInfo.Clone();
            DateTimeFormatInfo dtfi = CultureInfo.GetCultureInfo("fi-FI").DateTimeFormat;
            string shortDateFormatString = cultureInfo.DateTimeFormat.ShortDatePattern;

            Console.WriteLine("Päivämääräerotin on: " + dtfi.DateSeparator + " <--");
            string pvmMuotoilija = String.Format("dd{0}mm{0}yy", dtfi.DateSeparator);
            Console.WriteLine("pvmMuotoilija on: " + pvmMuotoilija);

            DateTime today = DateTime.Today.Date;
            DateTime justNow = DateTime.Now;
            

            Console.WriteLine("Tänään on: " + today.ToString(cultureInfo) + " formatoitu cultureinfolla");
            Console.WriteLine("Tänään on: " + today.ToString(pvmMuotoilija) + " formatoitu dd.MM.yy");
            Console.WriteLine("Tänään on: " + today.ToString(pvmMuotoilija) + " formatoitu cultureinfolla");
            Console.WriteLine("Tänään on: " + today.ToString(shortDateFormatString) + " shortDateFormatStringillä");

            Console.WriteLine("Juuri nyt on: " + justNow.ToString(cultureInfo) + " formatoitu cultureinfolla");
            Console.WriteLine("Juuri nyt pelkkä Date on: " + justNow.Date.ToString(cultureInfo) + " formatoitu cultureinfolla");

            Console.WriteLine("<===== Formatoidaanpa numeroita 0====>");
            double d = 10230.42;
            double d2 = 0.2;
            Console.WriteLine("Cultureinfolla: " + d.ToString(cultureInfo));
            Console.WriteLine("Cultureinfolla ja formatoinnilla 0.00: " + d2.ToString("0.00", cultureInfo));
            double d3 = 1234567890.123456;
            Console.WriteLine(d3.ToString("0,0.00000", cultureInfo));






        }
    }
}
