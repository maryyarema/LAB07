/*Визначте інтерфейс IPerson із властивостями Ім’я та Вік. Визначте клас Citizen, який реалізує IPerson і
має конструктор, який приймає назву рядка та int age.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            IPerson person = new Citizen(name, age);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.ReadLine();
        }
    }
}
