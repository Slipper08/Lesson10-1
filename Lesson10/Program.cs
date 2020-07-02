using System;

namespace Lesson10
{
    class Program
    {

        static void Main(string[] args)
        {
            //клиент вводит пол и имя
            //Step1((GenderEnum)0, "Иванова Ольга");
            //Step2(true, "Петров Иван");
            //StepWeek1((DayOfWeekEnum)7);
            PrintAllDays();
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
                Console.WriteLine($"{DayToRussian(dayOfWeek)} - выходной день");
            }
            else
            {
                Console.WriteLine($"{DayToRussian(dayOfWeek)} - рабочий день");
            }
        }

        static string DayToRussian(DayOfWeekEnum dayOfWeek)
        {
            string output = "";
            switch (dayOfWeek)
            {
                case DayOfWeekEnum.Monday:
                    output = "понедельник";
                    break;
                case DayOfWeekEnum.Tuesday:
                    output = "вторник";
                    break;
                case DayOfWeekEnum.Wensday:
                    output = "среда";
                    break;
                case DayOfWeekEnum.Thursday:
                    output = "четверг";
                    break;
                case DayOfWeekEnum.Friday:
                    output = "пятница";
                    break;
                case DayOfWeekEnum.Saturday:
                    output = "суббота";
                    break;
                case DayOfWeekEnum.Sunday:
                    output = "воскресенье";
                    break;
                default:
                    break;
            }
            return output;
        }

        static void PrintAllDays()
        {
            foreach (var item in Enum.GetValues(typeof(DayOfWeekEnum)))
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
