using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4.Model
{
    [Serializable]
    class PersonalData
    {
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public PersonalData(string address, string phoneNumber, string name, string surname)
        {
            Address = address;
            PhoneNumber = phoneNumber;
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
