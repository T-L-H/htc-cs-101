using System;

namespace week03
{
    class Program
    {
        static void Main(string[] args)
        {
//             Console.WriteLine("Hello World!");

//              Console.WriteLine("What is the temperature outside?");
//              int OutsideTemperature = Convert.ToInt32(Console.ReadLine());

//              if (OutsideTemperature <= 25){
// Console.WriteLine("Put on a coat!");

//              }

//             else if(OutsideTemperature >= 26) 
//              {
//                 Console.WriteLine("Wear sunglasses!"); 
//              }

//              else {Console.WriteLine("Try not to die!");
//              }

                Console.WriteLine("Guess a number between 1 and 10");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 4){
                Console.WriteLine("Too High!");}

               else if (number < 4){
                Console.WriteLine("Too Low!");}

                
                else{
                Console.WriteLine("Just Right!");}


        }
    }
}
