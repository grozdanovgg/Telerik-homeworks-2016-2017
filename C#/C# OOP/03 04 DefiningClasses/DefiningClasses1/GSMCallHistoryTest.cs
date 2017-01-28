namespace _1.Define_class
{
    using System;

    class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            GSM testUnit = new GSM("Secret Prototype", "NASA", 180000, "Goverment", new Battery("Tesla", 2900, 350, BatteryType.LiIon), new Display(5, 1000000));

            var call1 = new Call(DateTime.Now, "0888 123 456", 41);
            var call2 = new Call(DateTime.Today.AddDays(-1.5), "0888 582 093", 230);
            var call3 = new Call(DateTime.Today.AddDays(-2.3), "0888 341 333", 110);

            testUnit.AddCalls(call1);
            testUnit.AddCalls(call2);
            testUnit.AddCalls(call3);

            double totalDuration = 0;
            double longestCall = 0;
            foreach (var phonecall in testUnit.CallHistory)
            {
                Console.WriteLine(phonecall.ToString());
                Console.WriteLine();
                totalDuration += phonecall.CallDuration;
                if (phonecall.CallDuration > longestCall)
                {
                    longestCall = phonecall.CallDuration;
                }

            }
            double price = 0.37;
            double totalTimeInMinutes = totalDuration / 60;
            double totalPrice = totalTimeInMinutes * price;
            Console.WriteLine($"The total price of the calls is: {totalPrice:C}");
            Console.WriteLine();

            //remove the longest call
            double totalDurationMinusLongestCall = totalDuration - longestCall;
            totalTimeInMinutes = totalDurationMinusLongestCall / 60;
            totalPrice = totalTimeInMinutes * price;
            Console.WriteLine($"The total price of all calls, except the longest call, is: {totalPrice:C}");
            Console.WriteLine();

            //Clear the Call history and print it
            Console.WriteLine("Clearing the Call history...");
            testUnit.ClearCallHistory();
            Console.WriteLine();

            Console.WriteLine("Printing the Call history again:");
            foreach (var phonecall in testUnit.CallHistory)
            {
                Console.WriteLine(phonecall.ToString());
                Console.WriteLine();
                totalDuration += phonecall.CallDuration;
                if (phonecall.CallDuration > longestCall)
                {
                    longestCall = phonecall.CallDuration;
                }

            }
            Console.WriteLine();
        }

    }
}
