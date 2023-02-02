using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static EnumStatic.RegisMonth;


namespace EnumStatic
{



    internal class User
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public RegistrationMonth RegistrationMonth { get; set; }

        private string pin;
        public string Pin
        {
            get
            {
                return pin;
            }
            set
            {
                if (value.CheckPin())
                {
                    pin = value;
                }               
            }
        }
        public User(string Name, string Surname, RegistrationMonth RegistrationMonth, string Pin)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Pin = Pin;
            this.RegistrationMonth = RegistrationMonth;
            
        }

        public string GetDetails()
        {
            string details = $"{Name}\n{Surname}\n{RegistrationMonth}\n{Pin}\n";
            Console.WriteLine(details);
            return details ;
        }



    }
}