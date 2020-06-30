using System;

namespace lesson10_1
{
    class Program
    {
        public static bool isMan = true;
        public static bool isWoman = false;

        static void Main(string[] args)
        {
            //клиент вводит пол и имя
            //Step2(false, "Иванова Ольга");
            Step2(true, "Петров Иван");
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
    }
}
