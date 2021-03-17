using System;
using System.Text;

namespace RemoveConsecuiveCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using StringBuilder to gain performace advantage as we are going to perform multiple string manipulations.
            StringBuilder text = new StringBuilder("ABCCCCCBBA");
            bool flag = false;
            char s;
            int legt = text.Length;
            int samev = 1;
            int i = 0;
            int st = 0;

            while (i < legt - 1)
            {
                s = text[st]; //First Character of the Current string
                if (s == text[i + 1])
                {
                    samev += 1;
                }
                else
                {
                    if (samev >= 3) //If repeated sequence of characters are >= 3
                    {
                        //Removing the Repeaated part from the StringBuilder
                        text.Remove(st, samev);
                        flag = true;
                    }
                    samev = 1;
                    if (flag)
                    {
                        st = 0; //Resetting the start of the string
                    }
                    else
                    {
                        st += 1;
                    }
                }
                if (flag)
                {
                    i = 0;
                    legt = text.Length; //Recalculating the updated string length
                    flag = false;
                }
                else
                {
                    i += 1;
                }
            }
            Console.WriteLine(text);
        }
    }
}