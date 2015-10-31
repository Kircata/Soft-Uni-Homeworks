using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.PrintCompanyName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Enter company adress: ");
            string companyAdress = Console.ReadLine();
            Console.Write("Enter company phone number: ");
            string stringPhoneNmber = Console.ReadLine();
            long phoneNumber = long.Parse(stringPhoneNmber);
            Console.Write("Enter fax number: ");
            string strFaxNumber = Console.ReadLine();
            if (strFaxNumber == string.Empty)
            {
                strFaxNumber = "(no fax)";
            }
            Console.Write("Enter website: ");
            string webSite = Console.ReadLine();
            Console.Write("Enter manager first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter manager last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter manager's age: ");
            string strManagerAge = Console.ReadLine();
            byte managerAge = byte.Parse(strManagerAge);
            Console.Write("Enter manager phone number: ");
            string strManNumber = Console.ReadLine();
            long manPhoneNumber = long.Parse(strManNumber);



            Console.WriteLine("{0}\nAdress: {1}\nTel: +{2}\nFax: {3}\nWebsite: {4}",companyName, companyAdress, phoneNumber, strFaxNumber, webSite);
            Console.WriteLine("Manager: {0} {1}(age: {2}, tel: +{3})", firstName, lastName, managerAge, manPhoneNumber );
        }
    }
}
