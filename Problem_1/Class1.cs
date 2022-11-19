using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Citizen : IPerson
    {
        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }
        private string namee;
        public string Name
        {
            get
            {
                return namee;
            }
            set
            {
                namee= value;
            }
        }
        private int agee;
        public int Age
        {
            get
            {
                return agee;
            }
            set
            {
                agee = value;
            }
        }
    }
}
