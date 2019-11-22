using System;
using System.Globalization;
using System.Threading;

namespace Learning_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Word or Name - ");
            string word = Console.ReadLine();
            Console.Write("Enter a Shift Key - ");
            string key_shift = Console.ReadLine();
            int key = Int32.Parse(key_shift);

            Console.WriteLine(encrypt(key,word));

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
