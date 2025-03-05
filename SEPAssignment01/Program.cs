// See https://aka.ms/new-console-template for more information


// // Create a console application that asks the user a few questions and then generates some custom output for them. 
// Console.WriteLine("Welcome. Let's generate your hacker name! ");
// Console.WriteLine("What is your favorite color? ");
// string? color = Console.ReadLine();
// Console.WriteLine("What is your astrology sign? ");
// string? sign = Console.ReadLine();
// Console.WriteLine("What is your street address number? ");
// string? street = Console.ReadLine();
// string hackerName = color + sign + street;
// Console.WriteLine($"Your hacker name is \"{hackerName}\". ");


// // Output the number of bytes in memory that each of the following number types uses, and the minimum and maximum values they can have. 
// string[] types = { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal" };
// int[] numOfBytes = { sizeof(sbyte), sizeof(byte), sizeof(short), sizeof(ushort), sizeof(int), sizeof(uint), sizeof(long), sizeof(ulong), sizeof(float), sizeof(double), sizeof(decimal) };
// string[] minimumValues = { sbyte.MinValue.ToString(), byte.MinValue.ToString(), short.MinValue.ToString(), ushort.MinValue.ToString(), int.MinValue.ToString(), uint.MinValue.ToString(), long.MinValue.ToString(), ulong.MinValue.ToString(), float.MinValue.ToString(), double.MinValue.ToString() };
// string[] maximumValues = { sbyte.MaxValue.ToString(), byte.MaxValue.ToString(), short.MaxValue.ToString(), ushort.MaxValue.ToString(), int.MaxValue.ToString(), uint.MaxValue.ToString(), long.MaxValue.ToString(), ulong.MaxValue.ToString(), float.MaxValue.ToString(), double.MaxValue.ToString() };
//
// Console.WriteLine("{0,-25} {1,-25} {2, -25} {3, -25}", "Type", "NumOfBytes", "MinValue", "MaxValue");
// for (int i = 0; i < types.Length; i++)
// {
//     Console.WriteLine("{0,-25} {1,-25} {2, -25} {3, -25}", types[i], numOfBytes[i], minimumValues[i], maximumValues[i]);
// }


// // Enter an integer number of centuries and convert it to years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds
// using System.Text;
//
// string? input = Console.ReadLine();
// double num = int.Parse(input);
// StringBuilder output = new StringBuilder();
// output.Append(input);
// output.Append(" centuries = ");
// output.Append(num *= 100);
// output.Append(" years = ");
// output.Append(num = double.Round(num * 365.2425));
// output.Append(" days = ");
// output.Append((num *= 24));
// output.Append(" hours = ");
// output.Append((num *= 60));
// output.Append(" minutes = ");
// output.Append((num *= 60));
// output.Append(" seconds = ");
// output.Append((num *= 1000));
// output.Append(" milliseconds = ");
// output.Append((num *= 1000));
// output.Append(" microseconds = ");
// output.Append(((decimal)num * 1000));
// output.Append(" nanoseconds");
// Console.WriteLine(output.ToString());


// // Output a simulated FizzBuzz game counting up to 100. 
// using System.Text;
//
// for (int i = 1; i <= 100; i++)
// {
//     StringBuilder result = new StringBuilder();
//     if (i % 3 == 0)
//     {
//         result.Append("fizz");
//     }
//     if (i % 5 == 0)
//     {
//         result.Append("buzz");
//     }
//
//     if (result.Length > 0)
//     {
//         Console.Write(result.ToString());
//     }
//     else
//     {
//         Console.Write(i);
//     }
//     
//     if (i < 100)
//     {
//         Console.Write(", ");
//     }
// }


// // Run the code and view the output. What happens?
// int max = 500;
// for (byte i = 0; i < max; i++) // The condition is always true, resulting in an infinite loop
// {
//     Console.WriteLine(i);
// }
// // What code could you add (don’t change any of the code) to warn us about the problem?
// if (max > byte.MaxValue)
// {
//     Console.WriteLine("Warning: 'max' exceeds the range of the 'byte' type.");
// }


// // Print-a-Pyramid. 
// for (int i = 1; i <= 5; i++)
// {
//     for (int j = 0; j < 5 - i; j++)
//     {
//         Console.Write(" ");
//     }
//
//     for (int j = 0; j < 1 + 2 * (i - 1); j++)
//     {
//         Console.Write("*");
//     }
//     
//     Console.WriteLine();
// }


// // Generates a random number between 1 and 3 and asks the user to guess what the number is. 
// int correctNumber = new Random().Next(3) + 1;
// while (true)
// {
//     int guessedNumber = int.Parse(Console.ReadLine());
//     if (guessedNumber == correctNumber)
//     {
//         Console.Write($"Correct answer");
//         break;
//     } else if (guessedNumber > correctNumber)
//     {
//         Console.Write($"Too high");
//     }
//     else
//     {
//         Console.Write($"Too low");
//     }
//
//     if (guessedNumber > 3 || guessedNumber < 1)
//     {
//         Console.Write($", out of range");
//     }
//     Console.WriteLine();
// }


// // Write a simple program that defines a variable representing a birth date and calculates how many days old the person with that birth date is currently.
// DateTime birthDate = new DateTime(1998, 12, 26);
// DateTime today = DateTime.Now;
// TimeSpan age = today - birthDate;
// Console.WriteLine($"The person is {age.Days} days old. ");
// int daysToNextAnniversary = 10000 - (age.Days % 10000); 
// DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);
// Console.WriteLine($"The person's next anniversary is on {nextAnniversary.ToString("yyyy/MM/dd")}. ");


// // Write a program that greets the user using the appropriate greeting for the time of day.
// DateTime now = DateTime.Now;
// if (now.Hour < 12)
// {
//     Console.WriteLine("Good Morning");
// } else if (now.Hour < 18)
// {
//     Console.WriteLine("Good Afternoon");
// } else if (now.Hour < 20)
// {
//     Console.WriteLine("Good Evening");
// }
// else
// {
//     Console.WriteLine("Good Night");
// }


// Write a program that prints the result of counting up to 24 using four different increments.
for (int increment = 1; increment <= 4; increment++)
{
    for (int i = 0; i <= 24; i+=increment)
    {
        Console.Write(i);
        if (i < 24)
        {
            Console.Write(',');
        }
    }
    Console.WriteLine();
}