using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Використовуючи код із попереднього завдання, визначте інтерфейс II, який можна ідентифікувати за допомогою ідентифікатора властивості рядка та інтерфейсу
IBirthable з рядковою властивістю Birthdate і реалізуйте їх у класі Citizen. Перепишіть конструктор Citizen
щоб прийняти нові параметри*/

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            IBirthable birthable = new Citizen(name, age, id, birthdate);
            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthable.Birthdate);
            Console.ReadLine();
        }
    }
}