using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_4
{
    internal class Stacks
    {

        public static Stack<String> stak = new();

        public static void inStack()
        {
            string s = CW.readString();
            stak.Push(s);
        }

        public static void outStack()
        {

            if(stak.Count > 0)
            {
                stak.Pop();

            }
        }

        public static void listStack()
        {
           

            int i = 0;
            foreach(string s in stak)
            {
                i++;

                Console.WriteLine(i + " "+ s);
            }
        }

        public static void reverseString()
        {
            Stack<char> chars= new Stack<char>();
            Queue<char> chars2 = new Queue<char>();

            string s = CW.readString();
            char c;

            for(int i = 0; i<s.Length; i++)
            {
                c = s[i];
                chars.Push(c);
            }

            string newString = "";
            foreach(char g in chars)
            {
                newString += g;
            }

            Console.WriteLine(newString);
            


        }


    }
}
