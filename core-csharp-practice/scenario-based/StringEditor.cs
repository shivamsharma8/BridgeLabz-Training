using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Scenario_Based
{
    internal class StringEditor
    {
        //Method to add Space after Punctuations in the given String
        public static string SpaceAdder(string str) {

            string output = "";

            for (int i = 0; i < str.Length; i++) { 
                char c = str[i];
                output += c;

                if (c == '.' || c == ',' || c == '!' || c == ';' || c == ':' || c == '?') {
                    if(i+1 < str.Length &&  str[i+1] == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        output += ' ';
                    }
                }

            }

            return output;
        }
        //Method to Capitalize the first leeter of word comming after "?",".","!"
        public static string Capitalizer(string str)
        {
            string output = "";

            for (int i = 0; i < str.Length;i++)
            {
                char c = str[i];
                output += c;
                if(c == '.' || c == '!' || c == '?') {
                    if (str[i + 1] >= 97 && str[i + 1] <= 122)
                    {
                        i += 1;
                        c = ( char)(str[i]-32);
                        output += c;
                        //str[i + 1] = (char)(str[i + 1] - 32);

                    }
                    else if (str[i + 1] == ' ' && (str[i + 2] >= 97 && str[i + 2] <= 122))
                    {
                        i += 2;
                        c = (char)(str[i] - 32);
                        output += c;
                        //str[i + 2] = (char)(str[i + 2] - 32);
                    }
                }
            }

            return output;
        }//Method to remove extra spaces (Just like .Trim() function)
        public static string SpaceTrimmer(string str)
        {
            string output = "";

            for(int i = 0;i < str.Length; i++)
            {
                char c = str[i];

                if (c == ' ' && (i + 1 < str.Length) && str[i + 1] == ' ') {
                    continue;
                }
                else
                {
                    output += c;
                }
                   
            }

            return output;
        }

        static void Main(string[] args) {

            Console.WriteLine("Enter the String");
            string str = Console.ReadLine();

            str = SpaceAdder(str);
            Console.WriteLine("After SpaceAdder: "+str);
            str = Capitalizer(str);
            Console.WriteLine("After Capitalizer: " + str);
            str = SpaceTrimmer(str);
            Console.WriteLine("After SpaceTrimmer: "+ str);
            
            
        }
    }
}
