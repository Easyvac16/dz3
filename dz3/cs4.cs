using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    internal class cs4
    {
        public class Web_Site
        {
            private string _name { get; set; }
            private string _link { get; set; }
            private string _Opis { get; set; }
            private string _ip { get; set; }
            public Web_Site(string name, string link, string Opis, string ip)
            {
                _name = name;
                _link = link;
                _Opis = Opis;
                _ip = ip;
            }
            public Web_Site()
            {
                _name = "";
                _link = "";
                _Opis = "";
                _ip = "";
            }
            public string GetName()
            {
                return _name;
            }
            public void SetName(string name)
            {
                _name = name;
            }
            public string GetLink()
            {
                return _link;
            }
            public void SetLink(string link)
            {
                _link = link;
            }
            public string GetOpis() 
            {
                return _Opis;
            }
            public void SetOpis(string Opis)
            {
                _Opis = Opis;
            }
            public string GetIp()
            {
                return _ip;
            }
            public void SeIp(string ip)
            {
                _ip = ip;
            }
            public void DisplaySiteInfo()
            {
                Console.WriteLine($"Site name: {_name}");
                Console.WriteLine($"Site link: {_link}");
                Console.WriteLine($"Description: {_Opis}");
                Console.WriteLine($"Ip: {_ip}");
                

            }
            public void InputWebsiteInfo()
            {
                Console.WriteLine("Write site name:");
                _name = Console.ReadLine();

                Console.WriteLine("Write site link:");
                _link = Console.ReadLine();

                Console.WriteLine("Write site description:");
                _Opis = Console.ReadLine();

                Console.WriteLine("Write site ip:");
                _ip = Console.ReadLine();
                Console.WriteLine(" ");
            }
           
            
        }
        public static void task_4()
        {
            Web_Site mySite = new Web_Site();

            mySite.InputWebsiteInfo();

            mySite.DisplaySiteInfo();
        }

    }
}
