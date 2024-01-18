using System;

class Program
{
    public static void Main()
    {   //When the program starts display a message to the user
        Console.WriteLine("Welcome to the dice rolling simulator");
        //Ask the user how many dice they would like to simulate
        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        DiceSimulator.RunSimulation(numberOfRolls);
        //When the program finishes display a message to the user
        Console.WriteLine("Thank you for using the dice rolling simulator.");
    }
}
