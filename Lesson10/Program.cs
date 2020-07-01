using System;

namespace Lesson10
{
    class Program
    {
        public const bool isMan = true;
        public const bool isWoman = false;

        static void Main(string[] args)
        {
            //клиент вводит пол и имя
            //Step1(false, "Иванова Ольга");
            //Step2(true, "Петров Иван");
            StepWeek1(255);
        }

        static void Step1(bool gender, string name)
        {
            if (gender == true)//муж - true, жун - false
            {
                Console.WriteLine($"Еважаемый, {name}!");
            }
            else
            {
                Console.WriteLine($"Уважаемая, {name}!");
            }

            Console.WriteLine("Приветствуем Вас на нашем сайте!");

            Console.ReadLine();
        }

        static void Step2(bool gender, string name)
        {
            if (gender == isMan)//муж - true, жун - false
            {
                Console.WriteLine($"Уважаемый, {name}!");
            }
            else
            {
                Console.WriteLine($"Уважаемая, {name}!");
            }

            Console.WriteLine("Приветствуем Вас на нашем сайте!");

            Console.ReadLine();
        }

        static void StepWeek1(byte dayOfWeek)
        {
            if (dayOfWeek == 6 || dayOfWeek == 7) //1...7 дни недели начиная с понедельника
            {
                Console.WriteLine("Выходной день");
            }
            else
            {
                Console.WriteLine("Рабочий день");
            }
        }
    }
}
