using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    internal class Program
    {

        /*
         * 
         Create a program that simulates the queue that forms during a traffic jam. During a traffic jam, only N cars can pass the crossroads when the light goes green. Then the program reads the vehicles that arrive one by one and adds them to the queue. When the light goes green N number of cars pass the crossroads and for each, a message "{car} passed!" is displayed. When the "end" command is given, terminate the program and display a message with the total number of cars that passed the crossroads.

        Input

        · On the first line, you will receive N – the number of cars that can pass during a green light.

        · On the next lines, until the "end" command is given, you will receive commands – a single string, either a car or "green".

        Output

        · Every time the "green" command is given, print out a message for every car that passes the crossroads in the format "{car} passed!".

        · When the "end" command is given, print out a message in the format "{number of cars} cars passed the crossroads."
         * 
         * 
         * 
         * 
        Input                       Output

        4                           Hummer H2 passed!
        Hummer H2                   Audi passed
        Audi                        Lada passed!
        Lada                        Tesla passed!
        Tesla                       Renault passed!
        Renault                     Trabant passed!
        Trabant                     Mercedes passed
        Mercedes                    MAN Truck passed!
        MAN Truck                   8 cars passed the crossroads.
        green
        green
        Tesla
        Renault
        Trabant
        end
         */
        static void Main(string[] args)
        {
            int numbersOfVehiclesPassed = int.Parse(Console.ReadLine());
            string vehicle = Console.ReadLine();
            Queue<string> cars = new Queue<string>();

            int count = 0;

            while (vehicle != "end")
            {
                if (vehicle == "green")
                {
                    for (int i = 0; i < numbersOfVehiclesPassed; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine(cars.Dequeue() + " passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(vehicle);
                }
                vehicle = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}