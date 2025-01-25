//used to perform different actions for different decision

using System.Diagnostics;
using System.Transactions;

namespace day1;

public class ConditionalStatements
{
    // public static void IfElseEx()
    // {   
    //     Console.WriteLine("If-Else Statement");

    //     int age;
    //     Console.WriteLine("Please Enter your age :");
    //     age = Convert.ToInt32(Console.ReadLine());

    //     if (age >= 18)
    //     {
    //         Console.WriteLine("Yes, You are eligible to vote.");
    //     }
    //     else
    //     {
    //         Console.WriteLine("No, You are not eligible to vote");
    //     }
        
    // }
    // public static void IfElifEx()
    // {
    //     Console.WriteLine("If - elif Statement");
    //     int temparature;

    //     Console.WriteLine("Enter the temperature: ");
    //     temparature = Convert.ToInt32(Console.ReadLine());

    //     if (temparature < 20)
    //     {
    //         Console.WriteLine("It's too cold here.");
    //     }
    //     else if (temparature >=  20 && temparature < 30) 
    //     {
    //         Console.WriteLine("It's moderate.");
    //     }
    //     else
    //     {
    //         Console.WriteLine("It's too hot here.");
    //     }    
    //}

                                    //   switch(expression) 
                                    // {
                                    //   case x:
                                    //     // code block
                                    //     break;
                                    //   case y:
                                    //     // code block
                                    //     break;
                                    //   default:
                                    //     // code block
                                    //     break;
                                    // }
    public static void SwitchEx()
    {
        Console.WriteLine("Switch case");

        int day;
        Console.WriteLine("Enter a number between 1 to 7 :");
        day = Convert.ToInt32(Console.ReadLine());

        switch(day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                break;
        }
    }
}
