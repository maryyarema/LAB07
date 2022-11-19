/*Визначте інтерфейс IPerson із властивостями Ім’я та Вік. Визначте клас Citizen, який реалізує IPerson і
має конструктор, який приймає назву рядка та int age.*/

using System;
using System.Reflection;

public class Startup
{
    public static void Main()
    {
        Type identifiableInterface = typeof(Citizen).GetInterface("IIdentifiable");
        Type birthableInterface = typeof(Citizen).GetInterface("IBirthable");
        PropertyInfo[] properties = identifiableInterface.GetProperties();
        Console.WriteLine(properties.Length);
        Console.WriteLine(properties[0].PropertyType.Name);
        properties = birthableInterface.GetProperties();
        Console.WriteLine(properties.Length);
        Console.WriteLine(properties[0].PropertyType.Name);
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string id = Console.ReadLine();
        string birthdate = Console.ReadLine();
        IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
        IBirthable birthable = new Citizen(name, age, id, birthdate);
    }

    public interface IBirthable
    {
        string Birthdate { get; }
    }
    public interface IIdentifiable
    {
        string Id { get; }
    }


    public interface IPerson
    {
        string Name { get; }
        int Age { get; }
    }


    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name { get; }
        public int Age { get; }
        public string Id { get; }
        public string Birthdate { get; }


    }
}
