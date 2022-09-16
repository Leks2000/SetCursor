using System;
using System.Security.Cryptography.X509Certificates;

namespace Prom
{
    class Program
    {
        static void Main()
        {   
            Console.Write("Введите числа от 0 до 9 включая разделители Пробел или точку: ");
            var InPut = Console.ReadLine();
            var rar = InPut.Length;
            var X = 0;
            Snak sn = new Snak();
            char[] array = InPut.ToCharArray();

            foreach (char s in array)
            {
                switch (s)
                {
                    case '.': X+= 4; break;
                    case ' ': X+= 2; break;
                    default:  X+= 9 ; break;
                }
            }
            var x = (Console.WindowWidth - X) /2;
            var y = (Console.WindowHeight / 3);
            foreach (char count in InPut)
            {
                Console.SetCursorPosition(x, y);
                switch (count)
                {
                    case (' '):
                        for (int j = 0; j < 6; j++, Console.SetCursorPosition(x, y++))
                        {
                            Console.WriteLine(sn.BOut(1, ' '));
                        }
                        Console.SetCursorPosition(x, y );
                        x+= 3;
                        y = (Console.WindowHeight) / 3;
                        break;
                    case ('.'):
                        for (int j = 0; j < 6; j++, Console.SetCursorPosition(x, y++))
                        {
                            Console.WriteLine(sn.BOut(4, ' '));
                        }
                        Console.SetCursorPosition(x, y);
                        Console.SetCursorPosition(x, y -= 2);
                        Console.WriteLine(sn.BOut(2, '█'));
                        x += 4;
                        y = (Console.WindowHeight) / 3 ;

                        break;

                    case ('0'):
                        sn.tri(ref x, ref y);
                        Console.SetCursorPosition(x += 2, y -= 5);
                        for (int j = 0; j < 5; j++, Console.SetCursorPosition(x, y++))
                        {
                            Console.WriteLine(sn.BOut(3, ' '));
                        }
                        Console.SetCursorPosition(x, y -= 2);
                        Console.WriteLine(sn.BOut(3, '█'));
                        x += 7;
                        y = (Console.WindowHeight) / 3;
                        break;

                    case ('1'):
                        sn.tri(ref x, ref y);
                        Console.SetCursorPosition(x += 5, y -= 6);
                        for (int j = 0; j < 5; j++, Console.SetCursorPosition(x, y++))
                        {
                            Console.WriteLine(sn.BOut(2, ' '));
                        }
                        Console.SetCursorPosition(x -= 5, y -= 4);
                        for (int j = 0; j < 4; j++, Console.SetCursorPosition(x, y++))
                        {
                            Console.WriteLine(sn.BOut(2, ' '));
                        }
                        Console.SetCursorPosition(x, y);
                        x +=9;
                        y = (Console.WindowHeight) / 3;
                        break;

                    case ('2'):
                        sn.bocm(ref x, ref y);
                        Console.SetCursorPosition(x -= 2, y -= 2);
                        Console.WriteLine(sn.BOut(2, '▀'));
                        Console.SetCursorPosition(x += 5, y += 2);
                        Console.WriteLine(sn.BOut(2, '▄'));
                        x += 4;
                        y = (Console.WindowHeight) / 3;
                        break;
                    case ('3'):
                        sn.bocm(ref x, ref y);
                        Console.SetCursorPosition(x -= 2, y -= 2);
                        Console.WriteLine(sn.BOut(2, '▀'));
                        Console.SetCursorPosition(x, y += 2);
                        Console.WriteLine(sn.BOut(2, ' '));
                        x += 9;
                        y = (Console.WindowHeight) / 3;
                        break;
                    
                    case ('4'):
                        sn.tri(ref x, ref y);
                        Console.SetCursorPosition(x += 2, y -= 6);
                        for (int j = 0; j < 4; j++, Console.SetCursorPosition(x, y++))
                        {
                            Console.WriteLine(sn.BOut(3, ' '));
                        }
                        Console.SetCursorPosition(x += 2, y -=4);
                        for (int j = 0; j < 3; j++, Console.SetCursorPosition(x, y++))
                        {
                            Console.WriteLine(sn.BOut(3, ' '));
                        }
                        Console.SetCursorPosition(x -= 2, y+=1);
                        for (int j = 0; j < 4; j++, Console.SetCursorPosition(x--, y))
                        {
                            Console.WriteLine(sn.BOut(3, ' '));
                        }
                        x += 11;
                        y = (Console.WindowHeight) / 3;
                        break;

                    case ('5'):
                        sn.bocm(ref x, ref y);
                        Console.SetCursorPosition(x += 3, y -= 2);
                        Console.WriteLine(sn.BOut(2, ' '));
                        Console.SetCursorPosition(x -= 5, y += 2);
                        Console.WriteLine(sn.BOut(2, '▄'));
                        x += 9;
                        y = (Console.WindowHeight) / 3;
                        break;
                    case ('6'):
                        sn.bocm(ref x, ref y);
                        Console.SetCursorPosition(x += 3, y -= 2);
                        Console.WriteLine(sn.BOut(2, ' '));
                        Console.SetCursorPosition(x -= 5, y += 3);
                        x += 9;
                        y = (Console.WindowHeight) / 3;
                        break;
                    case ('7'):
                        sn.tri(ref x, ref y);
                        Console.SetCursorPosition(x, y -= 5);
                        for (int j = 0; j < 5; j++, Console.SetCursorPosition(x, y++))
                        {
                            Console.WriteLine(sn.BOut(5, ' '));
                        }
                        Console.SetCursorPosition(x, y-=5);
                        Console.WriteLine(sn.BOut(2, '▀'));
                        Console.SetCursorPosition(x, y+=3);
                        x += 9;
                        y = (Console.WindowHeight) / 3;
                        break;
                    case ('8'):
                        sn.bocm(ref x, ref y);
                        x += 7;
                        y = (Console.WindowHeight) / 3;
                        break;
                    case ('9'):
                        sn.bocm(ref x, ref y);
                        Console.SetCursorPosition(x -= 2, y);
                        Console.WriteLine(sn.BOut(2, ' '));
                        Console.SetCursorPosition(x, y += 1);
                        Console.WriteLine(sn.BOut(2, ' '));
                        x += 9;
                        y = (Console.WindowHeight) / 3;
                        break;
                }
            }         
        }
     }   
}