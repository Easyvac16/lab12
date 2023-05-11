using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    public class Alphabet
    {
        private readonly char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        public IEnumerator<char> GetEnumerator()
        {
            for (int i = 0; i < letters.Length; i++)
            {
                yield return letters[i];
            }
        }
    }   
    

    internal class cs1
    {
        public static void task_1()
        {
            Alphabet alphabet = new Alphabet();

            foreach (char letter in alphabet)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine();
        }
    }
}
