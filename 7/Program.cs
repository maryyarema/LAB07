/*Проблема 7. Дефіцит їжі
У вашому тоталітарному антиутопічному суспільстві не вистачає їжі, тому з’являється багато повстанців. Розширте код із вашого
попереднє завдання з новою функціональністю для вирішення цього завдання.
Визначте клас Rebel, який має назву, вік і групу (рядок), імена унікальні - ніколи не буде 2
Повстанці/Громадяни або Повстанці та Громадяни з однаковою назвою. Визначте інтерфейс IBuyer, який визначає метод
BuyFood() і цілочисельна властивість Food. Реалізуйте інтерфейс IBuyer у класі Citizen і Rebel, обидва Rebels
Громадяни починають з 0 їжі, коли повстанець купує їжу, його їжа збільшується на 5, коли громадянин купує їжу, його їжа
збільшується на 10.
У першому рядку вхідних даних ви отримаєте ціле число N - кількість людей, у кожному з наступних N рядків ви
отримає інформацію в одному з таких форматів “<ім’я> <вік> <ідентифікатор> <дата народження>” для громадянина або “<ім’я>
<age><group>” для Rebel. Після N рядків до отримання команди «Кінець» ви будете отримувати імена людей
які купили їжу, кожен по новій лінії. Зауважте, що не всі імена можуть бути дійсними, у разі неправильної назви – нічого
повинно статися.
Вихід
Вихідні дані складаються лише з одного рядка, у якому слід вивести загальну кількість закуплених продуктів.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rebels = new List<Rebel>();
            var citizens = new List<Citizen>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input.Length == 4)
                {
                    Citizen citizen = new Citizen(input);
                    citizens.Add(citizen);
                }
                else
                {
                    Rebel rebel = new Rebel(input);
                    rebels.Add(rebel);
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                int a = 0;
                for (int i = 0; i < rebels.Count; i++)
                {
                    if (rebels[i].Name == input)
                    {
                        rebels[i].BuyFood();
                        a = 1;
                        break;
                    }
                }
                if (a == 0)
                {
                    for (int i = 0; i < citizens.Count; i++)
                    {
                        if (citizens[i].Name == input)
                        {
                            citizens[i].BuyFood();
                            break;
                        }
                    }
                }
            }
            int result = 0;
            for (int i = 0; i < rebels.Count; i++)
            {
                result += rebels[i].Food;
            }
            for (int i = 0; i < citizens.Count; i++)
            {
                result += citizens[i].Food;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}