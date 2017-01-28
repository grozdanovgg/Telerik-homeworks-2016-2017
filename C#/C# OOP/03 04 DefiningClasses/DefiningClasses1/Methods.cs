namespace _1.Define_class
{
    using System;
    using System.ComponentModel;
    class Methods
    {
        //Validation methods
        public static void ValidateStringInput(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                throw new ArgumentException("The input is empty. Please provide correct data.");
            }
        }
        public static void ValidateIntInput(int input)
        {
            if (input <= 0)
            {
                throw new ArgumentException("The number must be greater than 0. Please provide correct data.");
            }
        }

        //Enum validation
        public const BatteryType minimum = BatteryType.LiIon;
        public const BatteryType maximum = BatteryType.NiCd;

        public static void ValidateBatteryTypeInput(BatteryType input)
        {
            if (input < minimum | input > maximum)
            {
                throw new InvalidEnumArgumentException(
                    "Invalid battery type. Chose one of these three options: LiIon, NiMH or NiCd");
            }
        }


    }
}
