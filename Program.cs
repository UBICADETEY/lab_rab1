using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("разработка консольного приложения ");
            Console.WriteLine("Чемурзиев Микаил Исламович");
            Console.WriteLine("ИНС-Бо-19-2 ");
            Console.WriteLine("21.08.2001 ");
            Console.WriteLine("г.Ставрополь ул.Узорная");
            Console.WriteLine("информатика ");
            Console.WriteLine("программирование на разных языках \n \n \n \n \n ");

            Console.WriteLine(" Индивидуальное задание №4 ");

            int g = 5;
            int h = 10;
            int b = 3;
            int q = 2;
            int x = 1;
            int y = 8;
            int w = 4;

            int c = (g * h) + (b * q * 3) - x + (y / w);
            Console.WriteLine(" решим пример с=gh+b*q3-x+y/w ,\n" +
            " переменная g = 5 \n" +
            " переменная h = 10 \n" +
            " переменная b = 3 \n " +
            "переменная q = 2 \n" +
            " переменная x = 1 \n" +
            " переменная y = 8 \n " +
            "переменная w = 4 \n " +
            "Ответ: c ={0} ", c);


            Console.ReadKey();

        }
    }
}
