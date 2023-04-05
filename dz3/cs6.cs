using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    internal class cs6
    {
        class Shop
        {
            private string _name { get;set; }
            private string _address { get; set; }
            private string _profile { get; set; }
            private string _phone { get; set; }
            private string _email { get; set; }

            public void SetName(string name)
            {
                this._name = name;
            }
            public void SetAddress(string address) 
            {
                this._address = address;
            }
            public void SetProfile(string profile) 
            {
                this._profile = profile;
            }
            public void SetPhone(string phone) 
            {
                this._phone = phone;
            }
            public void SetEmail(string email) 
            {
                this._email = email;
            }
            public string GetName()
            {
                return this._name;
            }
            public string GetAddress() 
            {
                return this._address;
            }
            public string GetProfile() 
            {
                return this._profile;
            }
            public string GetPhone()
            {
                return this._phone;
            }
            public string GetEmail()
            {
                return this._email;
            }

            public void InputData()
            {
                Console.Write("Enter shop name: ");
                _name = Console.ReadLine();
                Console.Write("Enter shop address: ");
                _address = Console.ReadLine();
                Console.Write("Enter shop profile: ");
                _profile = Console.ReadLine();
                Console.Write("Enter shop phone: ");
                _phone = Console.ReadLine();
                Console.Write("Enter shop email: ");
                _email = Console.ReadLine();
                Console.WriteLine(" ");
            }

            public void OutputData()
            {
                Console.WriteLine($"Shop name: {_name}");
                Console.WriteLine($"Shop address: {_address}" );
                Console.WriteLine($"Shop profile: {_profile}");
                Console.WriteLine($"Shop phone: {_phone}");
                Console.WriteLine($"Shop email: {_email}");
            }

            
        }
        public static void task_6()
        {
            Shop shop = new Shop();
            shop.InputData();
            shop.OutputData();
        }
    }
}
