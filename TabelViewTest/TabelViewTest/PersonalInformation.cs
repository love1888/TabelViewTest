using System;
using System.Collections.Generic;
using System.Text;
using TabelViewTest.ViewModel;

namespace TabelViewTest
{
    class PersonalInformation : ViewModelBase
    {
        string name, emailAddress, phoneNmber;
        int age;
        bool isProgrammer;

        public string Name { get => name; set => name = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string PhoneNmber { get => phoneNmber; set => phoneNmber = value; }
        public int Age { get => age; set => age = value; }
        public bool IsProgrammer { get => isProgrammer; set => isProgrammer = value; }
    }
}
