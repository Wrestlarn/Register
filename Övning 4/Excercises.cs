using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Övning_4
{
    internal class Excercises
    {
        public static void checkParantheses()
        {
            List<char> cleaner = new();
            string ask = CW.readString();
            Stack<char> checker = new();

            foreach (char c in ask)
            {
                if (c == '(' || c == ')' || c == '{' || c == '}' || c == '[' || c == ']')
                {
                    cleaner.Add(c);
                }
            }
            int unmatchedPair = 0;
            int index = -1;
            char temp = ' ';
            for (int i = 0; i < cleaner.Count(); i++)
            {
                if (cleaner[i] == '(' || cleaner[i] == '{' || cleaner[i] == '[')
                {
                    checker.Push(cleaner[i]);
                    temp = cleaner[i];
                    index++;
                } else if(cleaner[i] == ')' || cleaner[i] == '}' || cleaner[i] == ']')
                {
                    if(checker.Count() == 0)
                    {
                        unmatchedPair++;
                        break;
                    }

                    if (checker.ElementAt(0) == '(' && cleaner[i] == ')' && checker.Count() > 0)
                    {
                        checker.Pop();
                        index--;
                        continue;
                    }

                    if (checker.ElementAt(0) == '{' && cleaner[i] == '}' && checker.Count() > 0)
                    {
                        checker.Pop();
                        index--;
                        continue;                        
                    }

                    if (checker.ElementAt(0) == '[' && cleaner[i] == ']' && checker.Count() > 0)
                    {
                        index--;
                        checker.Pop();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("no matching pair found");
                        unmatchedPair++;

                    }



                }
            
            }
            if (checker.Count == 0 && unmatchedPair == 0)
            {
                Console.WriteLine($"{ask} är balanserad");
            }
            else
            {
                Console.WriteLine($"{ask} är inte balanserad");
            }
        }
    }
}
