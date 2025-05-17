
class NumberListProcessor
{
    static void Main()
    {
        Console.WriteLine("Enter a list of numbers, type '0' to finish:");
        List<int> numbers = new List<int>();
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number) && number != 0)
            {
                numbers.Add(number);
            }
            if (number == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number or type '0' to finish.");
            }
          
        }
    }
}