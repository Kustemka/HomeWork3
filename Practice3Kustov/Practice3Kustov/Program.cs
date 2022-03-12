using System;

namespace Practice3Kustov
{
    class Program
    {

        static void Main(string[] args)
        {
    
            // Проверка числа на четность/нечетность
            Console.WriteLine("Введите целое число для проверки на четность: ");
            int number = int.Parse(Console.ReadLine());
          
            if (number % 2 == 1)
            {
                Console.WriteLine("Число нечетное");
            }
            else
            {
                Console.WriteLine("Число четное");
            }
            //Console.WriteLine(number % 2 == 1 ? "Число нечетное" : "Число четное"); //тернарный способ

           
            
            //Игра в "21"
            Console.WriteLine("\nЗдравствуйте, сколько карт у вас на руках: ");
            int i = int.Parse(Console.ReadLine());
            int a = i;
            int sum = 0;
           
            Console.WriteLine("\nНапишите цифру своей карты или если валет - J, королева - Q, король - K, туз - T");
            for (int count = 0; count < a; count++)  
            {
                //int card = int.Parse(Console.ReadLine());
                string card = Console.ReadLine();
                switch (card)
                {
                    case "1":
                        sum = sum + 1;
                        Console.WriteLine("Введите следующую карту ");
                        break;
                    case "2":
                        sum = sum + 2;
                        Console.WriteLine("Введите следующую карту ");
                        break;
                    case "3":
                        sum = sum + 3;
                        Console.WriteLine("Введите следующую карту ");
                        break;
                    case "4":
                        sum = sum + 4;
                        Console.WriteLine("Введите следующую карту ");
                        break;
                    case "5":
                        sum = sum + 5;
                        Console.WriteLine("Введите следующую карту ");
                        break;
                    case "6":
                        sum = sum + 6;
                        Console.WriteLine("Введите следующую карту ");
                        break;
                    case "7":
                        sum = sum + 7;
                        Console.WriteLine("Введите следующую карту ");
                        break;
                    case "8":
                        sum = sum + 8;
                        Console.WriteLine("Введите следующую карту ");
                        break;
                    case "9":
                        sum = sum + 9;
                        Console.WriteLine("Введите следующую карту ");
                        break;
                    case "10":
                        sum = sum + 10;
                        Console.WriteLine("Введите следующую карту ");
                        break;
                    case "J":
                        sum = sum + 10;
                        Console.WriteLine("Введите следующую карту ");
                        break;
                    case "Q":
                        sum = sum + 10;
                        Console.WriteLine("Введите следующую карту ");
                        break;
                    case "K":
                        sum = sum + 10;
                        Console.WriteLine("Введите следующую карту ");
                        break;
                    case "T":
                        sum = sum + 10;
                        Console.WriteLine("Введите следующую карту ");
                        break;
                }
            }

            Console.WriteLine($"\nСумма карт: {sum}");


            //Проверка простого числа
            Console.WriteLine("\nВведите число больше 1, которое будем проверять на простоту: ");
            int checkNumber = int.Parse(Console.ReadLine());
            int N = checkNumber;
            int prNumber = 1;
            bool flag = true;
            int result = 0;
            int county = 0;
            
            while (prNumber <= N - 1)
            {
                result = N % prNumber;
                prNumber++;
                if (result == 0)
                {
                    county++;
                }
                if (county > 1)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Простое");
            }
            else
            { 
                Console.WriteLine("Не простое");
            }
        }
    }
}
