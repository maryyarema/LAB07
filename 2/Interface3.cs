using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
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
               namee = value;
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
        private string idd;
        public string Id
        {
            get
            {
                return idd;
            }
            set
            {
                idd = value;
            }
        }
        private string birthdatee;
        public string Birthdate
        {
            get
            {
                return birthdatee;
            }
            set
            {
                birthdatee = value;
            }
        }
    }
}