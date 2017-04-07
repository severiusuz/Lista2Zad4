using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4.Model
{
    class PersonalData
    {
        public string address { get; set; }

        public string phoneNumber { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public PersonalData(string address, string phoneNumber, string name, string surname)
        {
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.name = name;
            this.surname = surname;
        }

        public override string ToString()
        {
            return name + " " + surname;
        }
    }
}
