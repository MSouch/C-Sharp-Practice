using System;
using System.IO;

class Program
{
    static void Main()
    {
        int lowNumber;
        int highNumber;

        Console.WriteLine("Enter a low number: ");
        lowNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a high number: ");
        highNumber = Convert.ToInt32(Console.ReadLine());

        int difference = lowNumber - highNumber;
        Console.WriteLine($"The difference between {highNumber} and {lowNumber} is {difference}");
          
    do
        {
            Console.WriteLine("Enter a positive low number: ");
            while (!int.TryParse(Console.ReadLine(), out lowNumber) || lowNumber <=0)
            {
                Console.WriteLine("Invalid input. Please enter a positive int.");
            }
        } while (lowNumber <= 0);

    do
        {
            Console.WriteLine("Enter a high number greater than the low number: ");
            while (!int.TryParse(Console.ReadLine(),out highNumber) || highNumber <= lowNumber)
            {
                Console.WriteLine("Invalid input. Enter a number greater than the low number");
            }
        } while (highNumber <= lowNumber);

        difference = highNumber - lowNumber;
        Console.WriteLine($"The difference between {highNumber} and {lowNumber} is {difference}");
    
        int[] numbersArray = new int[difference + 1];
        for (int i = 0; i < difference; i++)
        {
            numbersArray[i] = lowNumber + i;
        }

        string filePath = "numbers.txt";

        using (StreamWriter writer = new StreamWriter(filePath)) 
        {
            for (int i = numbersArray.Length - 1; i >= 0; i--)
            {
                writer.WriteLine(numbersArray[i]);
            }
        }
        Console.WriteLine($"Numbers have been written to file in location {filePath}");
    }
    }
    
