namespace _1.Define_class
{
    using System;

    public class GSMTest
    {
        //Data fields
        public GSM[] mobilePhones;

        //Constructors
        public GSMTest()
        {
            GSM nokia = new GSM("3210", "Nokia", 500, "Gigi", new Battery("Nokia", 400, 30, BatteryType.NiMH), new Display(1, 2));
            GSM iPhone7 = new GSM("iPhone 7", "Apple", 1400, "Conka", new Battery("Foxcon", 60, 10, BatteryType.LiIon), new Display(5, 20000000));
            GSM woodPhone = new GSM("WoodPhone", "Woody", 10, " Bobara", new Battery("ForestFactory", 5, 1, BatteryType.NiCd), new Display(2, 3));

            mobilePhones = new GSM [] { nokia, iPhone7, woodPhone};
        }

        //Other methods
        public static void ExecuteTests()
        {
            GSMTest instance = new GSMTest();
            for (int i = 0; i < instance.mobilePhones.Length; i++)
            {
                Console.WriteLine(instance.mobilePhones[i].ToString());
                Console.WriteLine();
            }
        }

        public static void DisplayIphone4S()
        {
            Console.WriteLine(GSM.iPhone4S);
        }
    }
}
