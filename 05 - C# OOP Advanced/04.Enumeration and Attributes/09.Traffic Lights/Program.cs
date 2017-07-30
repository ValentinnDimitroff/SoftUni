namespace _09.Traffic_Lights
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<TrafficLight> trafficLights = new List<TrafficLight>();
            string[] inputSignals = Console.ReadLine().Split();
            int stateChangeCount = int.Parse(Console.ReadLine());

            foreach (string inputSignal in inputSignals)
            {
                Light currentLight = (Light)Enum.Parse(typeof(Light), inputSignal);
                trafficLights.Add(new TrafficLight(currentLight));
            }

            for (int i = 0; i < stateChangeCount; i++)
            {
                foreach (TrafficLight trafficLight in trafficLights)
                {
                    trafficLight.SwitchState();
                }
                Console.WriteLine(string.Join(" ", trafficLights));
            }
        }
    }
}
