
/*У вас є бізнес - виробництво мобільних телефонів. Але у вас немає розробників програмного забезпечення, тому ви телефонуєте друзям
ваші та попросіть їх допомогти вам створити програмне забезпечення для мобільного телефону. Вони вже домовилися, і ви почали працювати далі
проект. Проект складається з однієї основної моделі – смартфона. Кожен ваш смартфон повинен мати
функції дзвінків на інші телефони та перегляду всесвітньої мережі.
Хоча ці ваші друзі дуже зайняті, тож ви вирішили написати код самостійно. Ось обов'язкове
завдання:
Ви повинні мати модель - Смартфон і дві окремі функції, які має ваш смартфон - дзвонити іншим
телефонів і для перегляду у всесвітній мережі. Ви повинні отримати один клас і два інтерфейси.

 
 0882134215 0882134333 08992134215 0558123 3333 1
http://softuni.bg http://youtube.com http://www.g00gle.com
Calling... 0882134215
C*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            IPhoneNumber phoneNumber = new Phone(str1.Split(' ').ToArray(), str2.Split(' ').ToArray());
            IBrowsing browsing = new Phone(str1.Split(' ').ToArray(), str2.Split(' ').ToArray());
            phoneNumber.CallNumber(phoneNumber.Numbers);
            browsing.Browse(browsing.Link);
            Console.ReadLine();
        }
    }
}