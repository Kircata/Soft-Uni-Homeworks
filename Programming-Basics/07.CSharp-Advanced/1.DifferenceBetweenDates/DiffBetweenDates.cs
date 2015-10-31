using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DiffBetweenDates
{
    static void Main()
    {

        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        TimeSpan diff = secondDate - firstDate;
        if (secondDate > firstDate)
        {
            Console.WriteLine("{0:dd}", diff);
        }
        else if (firstDate > secondDate)
        {
            Console.WriteLine("-{0:dd}", diff);
        }
        else
        {
            Console.WriteLine(0);
        }

    }
}

