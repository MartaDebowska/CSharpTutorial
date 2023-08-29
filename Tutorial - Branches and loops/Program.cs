namespace Tutorial___Branches_and_loops
{
    internal class Program
    {
            static void Main(string[] args)
            
        {
            //Testing if statement from examples

            int a = 3;
            int b = 2;
            if (a + b > 10)
                  Console.WriteLine("The answer is greater than 10.");
            else
                  Console.WriteLine("The answer is not greater than 10");

            

            int c = 7;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }

            //Testing loops to repeat operations

            int counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);
        }
    }
} 