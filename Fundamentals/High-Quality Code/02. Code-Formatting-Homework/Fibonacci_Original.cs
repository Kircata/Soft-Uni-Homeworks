using System;

public class Fibonacci
{
    public static void Main()
    {
        for (int j = 0; j < 100; j++)
        {
            Int64 a = 0;
            Int64 b = 1;

            string Value;
            Console.WriteLine(" КОЕ число от Фибоначи те интересува?");
            Value = Console.ReadLine();
            int no;

            int count = 0;
            Int64 c = 0;

            if (int.TryParse(Value, out no))
            {
                for (; count < no; count++)
                {

                    c = a + b;
                    a = b;
                    b = c;





                }

                Console.WriteLine("Числото, което те интересува е: " + c);
                Console.ReadKey();
            }


           
            
            else
            {
            Console.WriteLine("ТРЯбва да въвдеш число, мой човек");


        }





    }



        

        
            Console.ReadKey();


        
        
    }


    
}