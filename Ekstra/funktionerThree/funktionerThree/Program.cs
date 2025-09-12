int i = 1;
while (i != 4)
{
    Console.WriteLine("-------------------------START---------------------------------");
    Console.WriteLine("You want it to be done with multiple variable or an array?");
    Console.WriteLine("Please enter 1 for variables or 2 for array else 4 for exit: ");
    string determine = Console.ReadLine();


    if (determine == "1")
    {
        
        Console.WriteLine("Please enter value one:");
        double one = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nPlease enter value two: ");
        double two = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nPlease enter value three: ");
        double three = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"The input values are {one} and {two} and {three}");

        Console.WriteLine($"The average of the 3 values is: {AverageOfThree(one, two, three)}");
        Console.WriteLine("------------------------DONE-----------------------------------\n\n\n");


    }
    else if (determine == "2")
    {
        double[] values = { 0, 0, 0 };
        Console.WriteLine("Please enter value one:");
        values[0] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nPlease enter value two: ");
        values[1] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nPlease enter value three: ");
        values[2] = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"The input values are {values[0]} and {values[1]} and {values[2]}");

        Console.WriteLine($"The average of the 3 values is: {AverageOfThreeArray(values)}");
        Console.WriteLine("------------------------DONE-----------------------------------\n\n\n");

    }
    else if (determine == "4")
    {
        Console.WriteLine("Goodbye!");
        i = 4;
    }
    else
    {
        Console.WriteLine("wrong way, try again!");
    }

}
double AverageOfThree(double valOne, double valTwo, double valThree)
{
    return (valOne + valTwo + valThree) / 3;
}

double AverageOfThreeArray(double[] toAvg)
{
    return (toAvg[0] + toAvg[1] + toAvg[2]) / 3;
}