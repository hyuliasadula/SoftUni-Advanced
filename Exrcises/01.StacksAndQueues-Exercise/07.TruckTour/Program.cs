using System;

namespace _07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPetrolPumps = int.Parse(Console.ReadLine());
            int[] petrolAmounts = new int[numPetrolPumps];
            int[] distances = new int[numPetrolPumps];

            for (int i = 0; i < numPetrolPumps; i++)
            {
                string[] input = Console.ReadLine().Split();
                petrolAmounts[i] = int.Parse(input[0]); // Amount of petrol
                distances[i] = int.Parse(input[1]); // Distance to next petrol pump
            }

            int startPetrolPump = FindStartPetrolPump(numPetrolPumps, petrolAmounts, distances);

            Console.WriteLine(startPetrolPump);
        }

        static int FindStartPetrolPump(int numPetrolPumps, int[] petrolAmounts, int[] distances)
        {
            int totalPetrol = 0;
            int currentPetrol = 0;
            int startPetrolPumpIndex = 0;

            for (int i = 0; i < numPetrolPumps; i++)
            {
                totalPetrol += petrolAmounts[i] - distances[i];

                // If the current petrol is negative, reset starting point and current petrol
                if (currentPetrol < 0)
                {
                    startPetrolPumpIndex = i;
                    currentPetrol = 0;
                }

                currentPetrol += petrolAmounts[i] - distances[i];
            }

            return totalPetrol >= 0 ? startPetrolPumpIndex : -1;
        }
    }
}

