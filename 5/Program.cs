/*Прикордонний контроль
Це майбутнє, ви правитель тоталітарного антиутопічного суспільства, населеного громадянами та роботами, оскільки ви
боячись повстань, ви вирішуєте ввести суворий контроль за тим, хто в'їжджає у ваше місто. Ваші солдати перевіряють ідентифікатори
кожен, хто входить і виходить.
Ви отримуватимете невідому кількість рядків із консолі, доки не буде отримано команду «Кінець» у кожному рядку
там буде частина інформації для громадянина або робота, який намагається ввести ваше місто у форматі “<ім’я>
<age> <id>” для громадян і “<model> <id>” для роботів. Після команди end у наступному рядку ви отримаєте a
одне число, що представляє останні цифри підроблених ідентифікаторів, усіх громадян або роботів, чий ідентифікатор закінчується вказаними цифрами
повинні бути затримані.
Вихід вашої програми має складатися з усіх затриманих ідентифікаторів, кожен в окремому рядку (порядок друку не
матерія)*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var robots = new List<IRobot>();
            var humans = new List<IHuman>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input.Length == 2)
                {
                    IRobot irobot = new Citizen(input);
                    robots.Add(irobot);
                }
                else if (input.Length == 3)
                {
                    IHuman ihuman = new Citizen(input);
                    humans.Add(ihuman);
                }
                else { break; }
            }
            string lastdigits = Console.ReadLine();
            foreach (IRobot irobot in robots)
            {
                irobot.CheckID(irobot.RobotId, lastdigits);
            }
            foreach (IHuman human in humans)
            {
                human.CheckID(human.HumanId, lastdigits);
            }
            Console.ReadLine();
        }
    }
}