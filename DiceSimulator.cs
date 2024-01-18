using System;

// Create class for the dice simulator
class DiceSimulator
{
    // Make method RunSimulation and make sure it's public, accepting the input numberOfRolls
    public static void RunSimulation(int numberOfRolls)
    {
        // Set the input value of the DiceRoller method to the user input
        DiceRoller diceRoller = new DiceRoller();
        int[] results = diceRoller.SimulateDiceRolls(numberOfRolls);

        // Display simulation results and explain the visual
        Console.WriteLine("RESULTS:");
        Console.WriteLine("'*' represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numberOfRolls);

        // Create a for loop to go through and calculate percentages of numbers rolled with total rolls
        for (int i = 2; i <= 12; i++)
        {
            // Calculate the percentage for the current number (i)
            int percentage = results[i] * 100 / numberOfRolls;

            // Display the number and a visual representation of the percentage using *
            Console.WriteLine(i + ": " + new string('*', percentage));
        }
    }
}

class DiceRoller
{
    // Generate random number to assign as "dice roll"
    private Random random = new Random();

    public int[] SimulateDiceRolls(int numberOfRolls)
    {
        // Create an array to store the count of each possible sum (2 to 12)
        int[] results = new int[13];

        // Simulate dice rolls for the specified number of times
        for (int i = 0; i < numberOfRolls; i++)
        {
            // Generate random numbers as if rolling two six-sided dice
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);

            // Calculate the sum of the two dice rolls
            int sum = dice1 + dice2;

            // Increment the count for the corresponding sum in the results array
            results[sum]++;
        }

        // Return the array containing the results of the dice rolls
        return results;
    }
}

