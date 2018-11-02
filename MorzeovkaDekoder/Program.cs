using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorzeovkaDekoder
{

    /*
     *	       __          __                __            
     *	  ____/ /__ _   __/ /_  ____  ____  / /__ _________
     *	 / __  / _ \ | / / __ \/ __ \/ __ \/ //_// ___/_  /
     *	/ /_/ /  __/ |/ / /_/ / /_/ / /_/ / ,< _/ /__  / /_
     *	\__,_/\___/|___/_.___/\____/\____/_/|_(_)___/ /___/
     *                                                   
     *                                                           
     *      TUTORIÁLY  <>  DISKUZE  <>  KOMUNITA  <>  SOFTWARE
     * 
     *	Tento zdrojový kód je součástí tutoriálů na programátorské 
     *	sociální síti DEVBOOK.CZ	
     *	
     *	Kód můžete upravovat pod licencí MIT, 
     *	tedy jak chcete, jen zmiňte odkaz na www.devbook.cz :-) 
     */

    class Program
    {
        static void Main(string[] args)
        {
            // řetězec, který chceme dekódovat
            string s = ".. ... .-.. .- -. -.. ... --- ..-. -";
            Console.WriteLine("Původní zpráva: {0}", s);
            // řetězec s dekódovanou zprávou
            string zprava = "";

            // vzorová pole
            string abecedniZnaky = "abcdefghijklmnopqrstuvwxyz";
            string[] morseovyZnaky = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", 
            "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", 
            "...-", ".--", "-..-", "-.--", "--.."};

            // rozbití řetězce na znaky morzeovky
            string[] znaky = s.Split(' ');

            // iterace znaků morzeovky
            foreach (string morseuvZnak in znaky)
            {
                char abecedniZnak = '?';
                int index = Array.IndexOf(morseovyZnaky, morseuvZnak);
                if (index >= 0) // znak nalezen
                    abecedniZnak = abecedniZnaky[index];
                zprava += abecedniZnak;
            }

            // výpis
            Console.WriteLine("Dekódovaná zpráva: {0}", zprava);
            Console.ReadKey();
        }
    }
}
