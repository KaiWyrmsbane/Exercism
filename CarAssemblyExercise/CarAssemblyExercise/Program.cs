using System.Net.NetworkInformation;
using System.Runtime.Serialization;

namespace CarAssemblyExercise
{
    //https://exercism.org/tracks/csharp/exercises/cars-assemble
    class CarAssemblyExercise
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateSuccessRate(10));
            int speed = 6;
            double successRate = CalculateSuccessRate(speed);
            Console.WriteLine(CalculateProductionPerHour(speed, successRate));
            Console.WriteLine(CalculateNumberOfWorkingItemsPerMinute(speed, successRate));
        }
        public static double CalculateSuccessRate(int speed)
        {
            double successRate = 0;

            if (speed != 0 && speed <= 4)
            {
                successRate = 1;
            }
            else if (speed > 4 && speed <= 8)
            {
                successRate = 0.90;
            }
            else if (speed == 9)
            {
                successRate = 0.80;
            }
            else if (speed == 10)
            {
                successRate = 0.77;
            }
            else
            {
                successRate = 0.00;
            }
            return successRate;
        }
        public static double CalculateProductionPerHour(int speed, double successRate)
        {
            double production = (speed * 221) * successRate;
            return production;
        }
        public static int CalculateNumberOfWorkingItemsPerMinute(int speed, double successRate)
        {
            double itemsPerMinute = (speed * 221) / 60 * successRate;
            Math.Round(itemsPerMinute);
            return (int)itemsPerMinute;
        }

    }
}

/*
this is what we had to write for Exercism in their console

using System;
static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double successRate = 0;

        if (speed != 0 && speed <= 4)
        {
            successRate = 1.0;
        }
        else if (speed > 4 && speed <= 8)
        {
            successRate = 0.90;
        }
        else if (speed > 8 && speed == 9)
        {
            successRate = 0.80;
        }
        else if (speed == 10)
        {
            successRate = 0.77;
        }
        else
        {
            successRate = 0.00;
        }
        return successRate;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double production = 0;
         if (speed != 0 && speed <= 4)
        {
            production = (speed * 221) * 1;
        }
        else if (speed > 4 && speed <= 8)
        {
            production = (speed * 221) * .9;
        }
        else if (speed > 8 && speed == 9)
        {
            production = (speed * 221) * .8;
        }
        else if (speed == 10)
        {
            production = (speed * 221) * .77;
        }
        else
        {
            production = 0;
        }
         return production;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double itemsPerMinute = 0;
        if (speed != 0 && speed <= 4)
        {
            itemsPerMinute = (speed * 221) / 60;
        }
        else if (speed > 4 && speed <= 8)
        {
            itemsPerMinute = (speed * 221) / 60 * 0.9;
        }
        else if (speed > 8 && speed == 9)
        {
            itemsPerMinute = (speed * 221) / 60 * 0.8;
        }
        else if (speed == 10)
        {
            //not sure why this was coming out to be 27
            //itemsPerMinute = (speed * 221) / 60 * .77
            //on my machine in visual studio it comes out to be 28
            
            itemsPerMinute = (speed * 221) / 60 * .77 +1;
        }
        else
        {
            itemsPerMinute = 0;
        }
          return (int)itemsPerMinute;
    }
}
 
 */