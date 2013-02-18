using System;

    class CompanyAndManager
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fill the data separated by ENTER: 1.name, 2.address, 3.phone number, 4.fax, 5.web site, 6.manager;");
            string name = Console.ReadLine();
            string address = Console.ReadLine();
            string phone = Console.ReadLine();
            string fax = Console.ReadLine();
            string site = Console.ReadLine();
            string manager = Console.ReadLine();
            Console.WriteLine("Name:{0}\n\rAddress:{1}\n\rPhone:{2}\n\rFax:{3}\n\rWeb site:{4}\n\rManeger:{5}", name, address, phone, fax, site, manager);

            Console.WriteLine("Fill the data separated by ENTER: 1.Manager's First Name, 2.Manager's Last Name:, 3.Manager's Age:, 4.Manager's Phone number:;");
            string mFname = Console.ReadLine();
            string mLname = Console.ReadLine();
            byte mAge = byte.Parse(Console.ReadLine());
            string mPhone = Console.ReadLine();
            Console.WriteLine("Manager's Firs Name:{0}\n\rManager's Last Name:{1}\n\rManager's Age:{2}\n\rManager's Phone:{3}", mFname, mLname, mAge, mPhone);

        }
    }
