using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        int n = int.Parse(Console.ReadLine());
        List<TrafficLight> allTrafficLights = new List<TrafficLight>();

        foreach (var signal in input)
        {
            Signal signalNow = (Signal)Enum.Parse(typeof(Signal), signal);

            TrafficLight trafficLight = new TrafficLight(signalNow);
            allTrafficLights.Add(trafficLight);

        }

        for (int i = 0; i < n; i++)
        {
            foreach (var trafficLight in allTrafficLights)
            {
                trafficLight.ChangeState();

            }
            Console.WriteLine(string.Join(" ", allTrafficLights));
        }
    }
}

