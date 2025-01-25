namespace day1;

public class Loops
{
    // public static void ForLoopExample()
    // {
    //     Console.WriteLine("For Loop exapmle");

    //     int i;
    //     for (i=0; i <= 5; i++ )
    //     {
    //         Console.WriteLine(i);
    //     }
    // }

    public static void WhileLoop()
    {
        Console.WriteLine("While loop");
        int j=0;
        
        while(j <= 5)
        {
            Console.WriteLine($"Count is {j}");
            j++;
        }

    }
    
    public static void DoWhileLoop()
    {
        Console.WriteLine("Do - While loop");

        int j=0;
        do{
            Console.WriteLine(j);
            j++;
        }
        while(j >= 5);
    }
}
