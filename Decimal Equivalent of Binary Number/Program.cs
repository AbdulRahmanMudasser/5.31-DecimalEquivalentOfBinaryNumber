class DecimalEquivalent
{
    static void Main(string[] args)
    {
        // declaring variables
        string binary;

        // getting input from user
        Console.Write("Enter A Binary Number (Containing Only 0s And 1s):  ");
        binary = Console.ReadLine();

        Console.WriteLine();    // just for spacing

        // check if the entered number is binary or not
        foreach (char c in binary)
        {
            if (c != 0 && c != 1)
            {
                Console.WriteLine("Error - Enter Number Is Not A Binary Number");

                return;
            }
        }
    }
    // end of main method
}
// end of class
