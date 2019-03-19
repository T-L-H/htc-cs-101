using System;

namespace Week_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the first number?");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What is the second number?");
            int secondNum = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("What operation do you want?");
           string operation = Console.ReadLine();

           if(operation == "+")
           {
               Console.WriteLine(AddNumbers(firstNum, secondNum));

           }
            
        else if(operation == "-"){

            int difference = SubtractNumbers(firstNum, secondNum);
            Console.WriteLine(difference);
        }

        else if(operation == "x"){

            int difference = MultiplyNumbers(firstNum, secondNum);
            Console.WriteLine(difference);
        }

         else if(operation == "/"){

            int difference = DivideNumbers(firstNum, secondNum);
            Console.WriteLine(difference);
        }

        else{

     Console.WriteLine("Invalid Number");
        }
        }

        public static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int SubtractNumbers(int num1, int num2){
            return num1 - num2;
        }

         public static int MultiplyNumbers(int num1, int num2){
            return num1 * num2;
        }

        public static int DivideNumbers(int num1, int num2){
            return num1 / num2;
        }
    }
}
