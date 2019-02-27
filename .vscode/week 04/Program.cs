using System;

namespace week_04
{
    class Program
    {
        static void Main(string[] args)
        {
        //    bool snowing = true;
        //    bool isCarrot = true;
        //    int temp = 40;
        //    string clothes = "outfit";
        //    string name;
        //    name = Console.ReadLine();

        //    if ((snowing && temp <= 40) && (name != "Bob" || isCarrot)){
        //    Console.WriteLine("I'm a snowman!");
        //    }

        Console.WriteLine("Write millitary hour.");
        
        int number = Convert.ToInt32( Console.ReadLine());

        Console.WriteLine("Enter abbreviated day");
        string day = Console.ReadLine();
        
         if((number >= 18 && number <= 22) && (day == "mon" || day == "tues" || day == "wed" || day == "thur"))
         {
              Console.WriteLine("2 hour parking.");
         }
         
      
        }
    }
}
