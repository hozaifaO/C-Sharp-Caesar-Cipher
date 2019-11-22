using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

namespace Learning_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 0; // i am using p as a check varibale makes things easier for me.
            while(p==0)
            {
                Console.Write("Enter a Word or Name - ");
                string word = Console.ReadLine();
                Console.Write("Enter a Shift Key - ");
                string key_shift = Console.ReadLine();
                int key;

                if (int.TryParse(key_shift, out key) && Regex.IsMatch(word, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine(encrypt(key, word));
                    p = 1;
                }

                else { Console.WriteLine("Please Enter Only letters for word and numbers in shift key");}
            }
        }

        public static string encrypt(int key, string word) {
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y','Z'};
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            word = textInfo.ToUpper(word);
            string newWord = "";
            foreach (char c in word)
            {
                int i = Array.IndexOf(alphabet, c);

                if (i == 25)
                {

                    newWord += alphabet[(i-25)+ (key-1)];
                }
                else { newWord += alphabet[i + key]; }
                

            }

            return newWord;
        }
    }
}
