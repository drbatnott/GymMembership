using System;
using GymLibrary;
using System.Collections.Generic;
using System.IO;

namespace UseGymData
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<GymData> memberList = new List<GymData>();
            Console.WriteLine("Hello World!");
            GymData gymData = new GymData(1);
            gymData.HeightCm = 165;
            gymData.MassKg = 60;
            memberList.Add(gymData);
            TextWriter textWriter = new StreamWriter("MemberData.txt", true);
            foreach(GymData g in memberList)
            {
                textWriter.Write(g.BodyMassIndex + "\t" + g.HeightCm + "\t" + g.MassKg);
            }
            textWriter.Close();
            Console.WriteLine("Gym member has BMI " +  gymData.BodyMassIndex);
        }
    }
}
