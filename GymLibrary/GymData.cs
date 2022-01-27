using System;

namespace GymLibrary
{
    public class GymData
    {
        /*Good programming practice would make fields private or protected
         * On the same basis we would have a company standard for variable names.
         * we will use lower case start Camel case for fields (private things)
         * and upper case start for parameters and functions
         * */
        int idNumber;
        float massKg;
        int heightCm;
        float bodyMassIndex;
        /// <summary>
        /// This constructs a new GymData object when sent an id number
        /// </summary>
        /// <param name="id">The new ID</param>
        public GymData(int id)
        {
            idNumber = id;
            massKg = -1;
            heightCm = -1;
            bodyMassIndex = -1;
        }

        public void SetPhysicalData(int hCm, float mKg)
        {
            heightCm = hCm;
            massKg = mKg;
            float heightM = heightCm / 100f;//this uses f to tell the compiler to do a floating point calculation
            bodyMassIndex = CalculateBMI(heightM);
        }

        private float CalculateBMI(float hM)
        {
            float bmi = massKg / (hM * hM);
            return bmi;
        }
        /// <summary>
        /// Parameter to return the BMI field
        /// </summary>
        public float BodyMassIndex
        {
            get { return bodyMassIndex; }
        }
        /// <summary>
        /// parameter to return the HeightCM field 
        /// sets a value for heightCM if used 
        /// also will calculate bmi if Mass available
        /// </summary>
        public int HeightCm
        {
            set
            {
                heightCm = value;
                if (massKg != -1)
                {
                    float heightM = heightCm / 100f;
                    CalculateBMI(heightM);
                }
            }
            get { return heightCm; }
        }

        public float MassKg
        {
            set
            {
                massKg = value;
                if(heightCm != -1)
                {
                    float heightM = heightCm / 100f;
                    CalculateBMI(heightM);
                }
            }
            get { return massKg; }
        }
    }
}
