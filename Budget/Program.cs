internal class Program
{
    private static void Main(string[] args)
    {
        // used to store both
        Dictionary<string, decimal> inputs = new Dictionary<string, decimal>();



        Console.WriteLine("Hello! The following application allows you to see your monthly balance");


        // take in user input into the cashInput  
        while (true)
        {
            Console.WriteLine("Input the name of your income/expense (ie rent, work pay, insurance, tax credit");

            string name = Console.ReadLine();

            Console.WriteLine("Now please enter the value of your income/expense (ie -600, 423.12");

            decimal value = decimal.Parse(Console.ReadLine());

            inputs.Add(name, value);

            Console.WriteLine("If you would like to continue adding, enter y");
            if (!(string.Equals(Console.ReadLine(), "y")))
            {
                break;
            }
        }

        // rudimentary printout of dictionary
        foreach (KeyValuePair<string, decimal> kvp in inputs)
        {
            Console.WriteLine($"Name: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}