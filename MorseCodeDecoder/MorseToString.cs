using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorseCodeDecoder
{
    static class MorseToString
    {
        public static string getchar(this string morse)
        {
            // Letters
            if (morse == ".-")
            {
                return "a";
            }
            else if (morse == "-...")
            {
                return "b";
            }
            else if (morse == "-...")
            {
                return "b";
            }
            else if (morse == "-.-.")
            {
                return "c";
            }
            else if (morse == "-..")
            {
                return "d";
            }
            else if (morse == ".")
            {
                return "e";
            }
            else if (morse == "..-.")
            {
                return "f";
            }
            else if (morse == "--.")
            {
                return "g";
            }
            else if (morse == "....")
            {
                return "h";
            }
            else if (morse == "..")
            {
                return "i";
            }
            else if (morse == ".---")
            {
                return "j";
            }
            else if (morse == "-.-")
            {
                return "k";
            }
            else if (morse == ".-..")
            {
                return "l";
            }
            else if (morse == "--")
            {
                return "m";
            }
            else if (morse == "-.")
            {
                return "n";
            }
            else if (morse == "---")
            {
                return "o";
            }
            else if (morse == ".--.")
            {
                return "p";
            }
            else if (morse == "--.-")
            {
                return "q";
            }
            else if (morse == ".-.")
            {
                return "r";
            }
            else if (morse == "...")
            {
                return "s";
            }
            else if (morse == "-")
            {
                return "t";
            }
            else if (morse == "..-")
            {
                return "u";
            }
            else if (morse == "...-")
            {
                return "v";
            }
            else if (morse == ".--")
            {
                return "w";
            }
            else if (morse == "-..-")
            {
                return "x";
            }
            else if (morse == "-.--")
            {
                return "y";
            }
            else if (morse == "--..")
            {
                return "z";
            }
            else if (morse == ".--.-")
            {
                return "å";
            }
            else if (morse == ".-.-")
            {
                return "ä";
            }
            else if (morse == "---.")
            {
                return "ö";
            }
            // Numbers
            else if (morse == "-----")
            {
                return "0";
            }
            else if (morse == ".----")
            {
                return "1";
            }
            else if (morse == "..---")
            {
                return "2";
            }
            else if (morse == "...--")
            {
                return "3";
            }
            else if (morse == "....-")
            {
                return "4";
            }
            else if (morse == ".....")
            {
                return "5";
            }
            else if (morse == "-....")
            {
                return "6";
            }
            else if (morse == "--...")
            {
                return "7";
            }
            else if (morse == "---..")
            {
                return "8";
            }
            else if (morse == "----.")
            {
                return "9";
            }
            // Special Characters
            else if (morse == "..--.")
            {
                return "!";
            }
            else if (morse == "..--..")
            {
                return "?";
            }
            else if (morse == "-..-.")
            {
                return "/";
            }
            else if (morse == "-...-")
            {
                return "=";
            }
            else if (morse == "---...")
            {
                return ":";
            }
            else if (morse == "--..--")
            {
                return ",";
            }
            else if (morse == ".-.-.-")
            {
                return ".";
            }
            else if (morse == "-....-")
            {
                return "-";
            }
            else if (morse == "-.--.")
            {
                return "(";
            }
            else if (morse == "-.--.-")
            {
                return ")";
            }
            return "";
        }
    }
}
