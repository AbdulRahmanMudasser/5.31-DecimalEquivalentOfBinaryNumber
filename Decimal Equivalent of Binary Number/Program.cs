class DecimalEquivalent
{
    static void Main(string[] args)
    {
        // declaring variables
        string? binary;
        int decimalValue = 0;
        int exponent = 0;

        // getting input from user
        Console.Write("Enter A Binary Number (Containing Only 0s And 1s):  ");
        binary = Console.ReadLine();

        Console.WriteLine();    // just for spacing

        // check if the entered number is binary or not
        foreach (char c in binary!)
        {
            if (c != '0' && c != '1')
            {
                Console.WriteLine("Error - Enter Number Is Not A Binary Number");

                return;
            }
        }

        for (int i = binary.Length - 1; i >= 0; i--) 
        {
            if (binary[i] == '1')
            {
                decimalValue = decimalValue + (int)Math.Pow(2, exponent);
            }

            exponent++;
        }

        Console.WriteLine("Decimal equivalent: " + decimalValue);
    }
    // end of main method
}
// end of class
