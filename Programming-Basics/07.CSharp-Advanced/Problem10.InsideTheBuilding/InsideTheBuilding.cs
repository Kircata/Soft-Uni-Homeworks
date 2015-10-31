using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class InsideTheBuilding
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());

        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());

        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());

        int x4 = int.Parse(Console.ReadLine());
        int y4 = int.Parse(Console.ReadLine());

        int x5 = int.Parse(Console.ReadLine());
        int y5 = int.Parse(Console.ReadLine());

        int[] pointsArr = new int[10] {x1,x2,x3,x4,x5,y1,y2,y3,y4,y5};

        for (int i = 0; i < 5; i++)
        {
          
            if ((pointsArr[i] >= 0) && (pointsArr[i] <= 3 * size) && (pointsArr[i + 5] >= 0) && (pointsArr[i + 5] <= size))
            {
                Console.WriteLine("inside");
            }
            else if ((pointsArr[i] >= size) && (pointsArr[i] <= 2 * size) && (pointsArr[i + 5] >= 0) && (pointsArr[i + 5] <= 4 * size))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }


    }

}
