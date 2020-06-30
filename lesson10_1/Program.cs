using System;

namespace lesson10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //клиент вводит пол и имя
            
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
    }
}
