using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class StudentCables
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfCable = 0;
            int joins = -1;
            for (int i = 0; i < n; i++)
            {
                int cableLenght = int.Parse(Console.ReadLine());
                string cablesMeasure = Console.ReadLine();
                if ((cablesMeasure == "meters")  && (cableLenght >= 0.2))
                {
                    sumOfCable += cableLenght * 100;
                    joins++;
                }
                else if ((cablesMeasure == "centimeters") && cableLenght >= 20)
                {
                    sumOfCable += cableLenght;
                    joins++;
                }
            }
            sumOfCable -= 3 * joins;
            int studentCablesCount = sumOfCable / 504;
            Console.WriteLine(studentCablesCount);
            Console.WriteLine(sumOfCable - (studentCablesCount * 504));
        }
    }

