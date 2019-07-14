using System;
using System.Collections.Generic;
using System.Text;
using TabelViewTest.ViewModel;

namespace TabelViewTest
{
    class ProgrammerInformation : ViewModelBase
    {
        string name, emailAddress, phoneNumber, ageRange;
        bool isProgrammer;
        string language, platform;

        public string Name { get => name; set => name = value; }
        public string EmaiAddress { get => emailAddress; set => emailAddress = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string AgeRange { get => ageRange; set => ageRange = value; }
        public bool IsProgrammer
        {
            set { SetProperty(ref isProgrammer, value); }
            get { return isProgrammer; }
        }
        public string Language { get => language; set => language = value; }
        public string Platform { get => platform; set => platform = value; }
    }
}
