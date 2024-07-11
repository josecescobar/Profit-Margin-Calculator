using System;

namespace ProfitMarginCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Profit Margin Calculator");

            decimal[] costs = new decimal[3];
            bool keepRunning = true;

            while (keepRunning)
            {
                try
                {
                    // Get cost price from user
                    Console.Write("Enter the cost price: ");
                    costs[0] = decimal.Parse(Console.ReadLine());

                    // Get selling price from user
                    Console.Write("Enter the selling price: ");
                    costs[1] = decimal.Parse(Console.ReadLine());

                    // Get overhead cost from user
                    Console.Write("Enter the overhead cost: ");
                    costs[2] = decimal.Parse(Console.ReadLine());

                    // Calculate profit
                    decimal profit = costs[1] - costs[0] - costs[2];

                    // Calculate profit margin
                    decimal profitMargin = (profit / costs[1]) * 100;

                    // Display the result
                    Console.WriteLine($"Cost Price: {costs[0]:C}");
                    Console.WriteLine($"Selling Price: {costs[1]:C}");
                    Console.WriteLine($"Overhead Cost: {costs[2]:C}");
                    Console.WriteLine($"Profit: {profit:C}");
                    Console.WriteLine($"Profit Margin: {profitMargin:F2}%");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numeric values.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

                // Ask user if they want to perform another calculation
                Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                string response = Console.ReadLine().ToLower();
                if (response != "yes")
                {
                    keepRunning = false;
                }
            }

            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
