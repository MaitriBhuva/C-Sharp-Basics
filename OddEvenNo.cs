using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace day1;

public class OddEvenNo
{
    public static void OddEvenExample()
    {
    int number;

    Console.WriteLine("Enter a number");
    number = Convert.ToInt32(Console.ReadLine());

    if (number != 0)
    {
        Console.WriteLine($"{number} is odd.");
    }
    else
    {
        Console.WriteLine($"{number} is even.");
    }

    }
}
