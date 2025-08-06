namespace Assignment_5._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1234;
            Console.WriteLine(number);
            DisplayNumbers(number);

        }
        static void DisplayNumbers(int number)
        {
            if (number > 0)
            {
                int result = number % 10;
                DisplayNumbers(number/=10);
                
                Console.WriteLine(result);
                
            }
            

        }
    }
}
