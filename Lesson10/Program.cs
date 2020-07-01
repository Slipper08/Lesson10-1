using System;

namespace Lesson10
{
    class Program
    {

        static void Main(string[] args)
        {
            //клиент вводит пол и имя
            Step1((GenderEnum)0, "Иванова Ольга");
            //Step2(true, "Петров Иван");
            StepWeek1((DayOfWeekEnum)5);
        }

        static void Step1(GenderEnum gender, string name)
        {
            if (gender == GenderEnum.Man)
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
            if (gender == Gender.isMan)//муж - true, жун - false
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

        static void StepWeek1(DayOfWeekEnum dayOfWeek)
        {
            if (dayOfWeek == DayOfWeekEnum.Saturday || dayOfWeek == DayOfWeekEnum.Sunday) 
            {
                Console.WriteLine($"{dayOfWeek} - выходной день");
            }
            else
            {
                Console.WriteLine($"{dayOfWeek} - рабочий день");
            }
        }

        static string DayOfWeekEnumToRussianString(DayOfWeekEnum dayOfWeek)
        {
            string output = "";
            switch (dayOfWeek)
            {
                case DayOfWeekEnum.Monday:
                    output = "";
                    break;
                case DayOfWeekEnum.Tuesday:
                    output = "";
                    break;
                case DayOfWeekEnum.Wensday:
                    output = "";
                    break;
                case DayOfWeekEnum.Thursday:
                    output = "";
                    break;
                case DayOfWeekEnum.Friday:
                    output = "";
                    break;
                case DayOfWeekEnum.Saturday:
                    output = "";
                    break;
                case DayOfWeekEnum.Sunday:
                    output = "";
                    break;
                default:
                    break;
            }
        }
    }
}
