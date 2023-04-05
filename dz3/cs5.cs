using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    internal class cs5
    {
        class Journal
        {
            private string _name { get; set; }
            private int _yearFounded { get; set; }
            private string _description{ get; set; }
            private string _contactPhone { get; set; }
            private string _email { get; set; }

            public void SetName(string name)
            {
                this._name = name;
            }

            public void SetYearFounded(int yearFounded)
            {
                this._yearFounded = yearFounded;
            }

            public void SetDescription(string description)
            {
                this._description = description;
            }

            public void SetContactPhone(string contactPhone)
            {
                this._contactPhone = contactPhone;
            }

            public void SetEmail(string email)
            {
                this._email = email;
            }

            public string GetName()
            {
                return _name;
            }

            public int GetYearFounded()
            {
                return _yearFounded;
            }

            public string GetDescription()
            {
                return _description;
            }

            public string GetContactPhone()
            {
                return _contactPhone;
            }

            public string GetEmail()
            {
                return _email;
            }

            public void DisplayDetails()
            {
                Console.WriteLine($"Name: {_name}");
                Console.WriteLine($"Year founded: {_yearFounded}");
                Console.WriteLine($"Description: {_description}");
                Console.WriteLine($"Contact phone: {_contactPhone}");
                Console.WriteLine($"Email: {_email}");
            }

            public void EnterDetails()
            {
                Console.Write("Enter name: ");
                _name = Console.ReadLine();

                Console.Write("Enter year founded: ");
                _yearFounded = int.Parse(Console.ReadLine());

                Console.Write("Enter description: ");
                _description = Console.ReadLine();

                Console.Write("Enter contact phone: ");
                _contactPhone = Console.ReadLine();

                Console.Write("Enter email: ");
                _email = Console.ReadLine();
                Console.WriteLine(" ");
            }
            
        }
        public static void task_5()
        {
            Journal myJournal = new Journal();
            myJournal.EnterDetails(); 
            myJournal.DisplayDetails();
        }
    }
}
