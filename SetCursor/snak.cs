using System;

namespace Prom
{
    internal class Snak
    {
        public int snak;
        public string str;
        int simb = 0;

        int x = (Console.WindowWidth / 2);
        int y = (Console.WindowHeight / 3);


        public string BOut(int length, char simbol)
        {
            simb = length;
            str = new string(simbol, simb);
            return str;
        }

        public void bocm(ref int x,ref int y)
        {   
            for (int j = 0; j < 6; j++, Console.SetCursorPosition(x, y++))
            {
                Console.WriteLine(BOut(7, '█'));
            }

            Console.SetCursorPosition(x+=2, y-=5);
            Console.Write(BOut(3, ' '));
            Console.SetCursorPosition(x, y+=2);
            Console.WriteLine(BOut(3, ' '));

        }
        public void tri(ref int x, ref int y)
        {
            for (int j = 0; j < 6; j++, Console.SetCursorPosition(x, y++))
            {
                Console.WriteLine(BOut(7, '█'));
            }
        }
    }
}