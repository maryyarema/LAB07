using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Змоделюйте програму, яка містить клас Ferrari та інтерфейс. Ваше завдання просте, у вас є автомобіль - Ferrari, його
модель "488-Spider" і має драйвер. Ваш Ferrari повинен мати функцію гальмування та натискання газу
педаль. При натисканні на гальма друкується «Гальма!», а при натисканні педалі газу - «Заду6авам».
sA!". Як ви вже здогадалися, ця функція типова для всіх автомобілів, тому вам слід реалізувати інтерфейс для
Опишіть це.
Ваше завдання створити Ferrari і встановити ім'я водія на передане у вхідних даних. Після цього роздрукуйте інформацію.
Подивіться приклади, щоб краще зрозуміти завдання.*/

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string driversname = Console.ReadLine();
            ICar icar = new Ferrari(driversname);
            Console.WriteLine(icar.Model + "/" + icar.Brakes() + "/" + icar.GasPedal() + "/" + icar.DriversName);
            Console.ReadLine();
        }
    }
}