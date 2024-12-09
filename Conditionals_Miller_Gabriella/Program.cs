namespace Conditionals_Miller_Gabriella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asks user to type in a number and assigns it to an integer
            Console.WriteLine("Enter a whole number.");
            int myWholeNum = Convert.ToInt32(Console.ReadLine());

            //checks if number is negative or positive
            if (myWholeNum >= 0)
            {
                Console.WriteLine($"{myWholeNum} is a positive number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is a negative number!");
            }
            //checks if even or odd
            if(myWholeNum % 2 ==0)
            {
                Console.WriteLine($"{myWholeNum} is a positive number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is an odd number!");
            }

            //creates two integer numbers
            int num1 = 6;
            int num2 = 99;

            //gets first max
            int firstMax = Math.Max(myWholeNum, num1);
            //gets second max
            int max = Math.Max(firstMax, num2);

            //prints to console
            Console.WriteLine($"The maximum number of {myWholeNum}, {num1}, and {num2} is {max}!");

            //asks user to input a grade and assigns it to a char variable
            Console.WriteLine("Enter a grade (A, B, C, D, F)!");
            char grade = Console.ReadKey().KeyChar;

            //prints description on grade vakuse
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("\nSuperior");
                    break;
                case 'B':
                    Console.WriteLine("\nVeryGood");
                    break;
                case 'C':
                    Console.WriteLine("\nAverage");
                    break;
                case 'D':
                    Console.WriteLine("\nBelow Average");
                    break;
                case 'F':
                    Console.WriteLine("\nFailed");
                    break;
                default:
                    Console.WriteLine("\nYou did not enter a valid grade.");
                    break;


            }
        }
    }
}