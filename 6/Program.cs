/**Загальновідомо, що люди святкують дні народження, також відомо, що деякі люди також святкують день народження своїх домашніх тварин
дні народження. Розширте програму з останнього завдання, щоб додати дати народження для громадян і включити клас Pet, pets have a
ім'я та дата народження. Включайте повторювані функції в інтерфейси та впроваджуйте їх у своїх класах.
Ви отримаєте з консолі невідому кількість рядків. До отримання команди «Кінець» кожен рядок буде
містити інформацію в одному з таких форматів: «Громадянин <ім’я> <вік> <ідентифікатор> <дата >» для громадян, «Робот
<model> <id>” для роботів або “Pet <name> <birthdate>” для домашніх тварин. Після команди «End» у наступному рядку ви будете
отримати єдине число, що представляє певний рік, ваше завдання полягає в тому, щоб надрукувати всі дати народження (як громадян, так і домашніх тварин) у
цей рік у форматі день/місяць/рік (порядок друку не має значення)*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var robots = new List<IRobot>();
            var humans = new List<ICitizen>();
            var pets = new List<IPet>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "Pet")
                {
                    IPet ipet = new Pet(input);
                    pets.Add(ipet);
                }
                else if (input[0] == "Citizen")
                {
                    ICitizen ihuman = new Citizen(input);
                    humans.Add(ihuman);
                }
                else if (input[0] == "Robot")
                {
                    IRobot robot = new Robot(input);
                    robots.Add(robot);
                }
                else { break; }
            }
            string lastdigits = Console.ReadLine();
            int result = 0;
            foreach (IPet ppets in pets)
            {
                ppets.CheckBirthday(ppets.Birthday, lastdigits, ref result);
            }
            foreach (ICitizen human in humans)
            {
                human.CheckBirthday(human.Birthday, lastdigits, ref result);
            }
            if (result == 0)
            {
                Console.WriteLine("<empty output>");
            }
            Console.ReadLine();
        }
    }
}
