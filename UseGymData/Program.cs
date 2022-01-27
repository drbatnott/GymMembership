using System;
using GymLibrary;

namespace UseGymData
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GymData gymData = new GymData(1);
            gymData.HeightCm = 165;
            gymData.MassKg = 60;
            Console.WriteLine("Gym member has BMI " +  gymData.BodyMassIndex);
        }
    }
}
