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
            GymData gymData = new GymData(3);
            gymData.HeightCm = 150;
            gymData.MassKg = 30;
            memberList.Add(gymData);
            TextWriter textWriter = new StreamWriter("MemberData.txt",true);//Data written now will be appended
           // textWriter.WriteLine("Member ID\tBMI\tHeight cm\tWeight kg"); Only needed when initialising the file
            foreach(GymData g in memberList)
            {
                textWriter.WriteLine(g.IDNumber + "\t" + g.BodyMassIndex + "\t" + g.HeightCm + "\t" + g.MassKg);
            }
            textWriter.Close();
            Console.WriteLine("Gym member has BMI " +  gymData.BodyMassIndex);
        }
    }
}
