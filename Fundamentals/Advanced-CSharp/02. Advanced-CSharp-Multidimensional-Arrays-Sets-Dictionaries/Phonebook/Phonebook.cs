using System;
using System.Collections.Generic;
using System.Linq;
class Phonebook
{
    static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string> { };
        string[] info = Console.ReadLine().Split('-').ToArray();
        while (info[0] != "search")
        {
            string name = info[0];
            string number = info[1];
            phonebook.Add(name, number);
            info = Console.ReadLine().Split('-').ToArray();
        }
        var listOfContacts = new List<string>{};
        string contact = Console.ReadLine();
        while (contact != "")
        {
            listOfContacts.Add(contact);
            contact = Console.ReadLine();
        }

        foreach (var name in listOfContacts)
        {
            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine("{0} -> {1}", name, phonebook[name]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist", name);
            }
        }
    }
}

