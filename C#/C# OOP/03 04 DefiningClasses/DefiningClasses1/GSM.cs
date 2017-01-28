namespace _1.Define_class
{
    using System;
    using System.Collections.Generic;
    public class GSM
    {
        //Fields
        private string model;
        private string manufacturer;
        private int price;
        private string owner;
        private Battery batteryInfo;
        private Display displayInfo;
        private List<Call> callHistory = new List<Call>();

        public static GSM iPhone4S = new GSM("iPhone 4S", "Apple", 1400, "Penko", new Battery("Foxcon", 40, 8, BatteryType.LiIon), new Display(4, 20000000));

        //Constructor
        public GSM(string model,string manufacturer,int price,string owner,Battery batteryInfo,Display displayInfo)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.batteryInfo = batteryInfo;
            this.displayInfo = displayInfo;
        }
        public GSM(string model,string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        //Properties
        public string Model
        {
            get { return this.model; }
            set
            {
                Methods.ValidateStringInput(value);
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                Methods.ValidateStringInput(value);
                this.manufacturer = value;
            }
        }
        public int Price
        {
            get { return this.price; }
            set
            {
                Methods.ValidateIntInput(value);
                this.price = value;
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set
            {
                Methods.ValidateStringInput(value);
                this.owner = value;
            }
        }
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        //Override method ToString()
        public override string ToString()
        {

            return "GSM INFO \r\n" +
                "Model: " + model + "\r\n" +
                "Manufacturer: " + manufacturer + "\r\n" +
                "Price: " + price + "\r\n" +
                "Owner: " + owner + "\r\n" + 
                batteryInfo.ToString() + "\r\n";
        }

        //Other Methods
        public void AddCalls(Call input)
        {
            callHistory.Add(input);
        }
        public void DeleteCalls(Call input)
        {
            callHistory.Remove(input);
        }
        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }
        
        public double CalculateTotalPrice(double pricePerMinute)
        {
            double sum = 0;
            foreach (var call in callHistory)
            {
                sum += call.CallDuration;
            }

            return sum;
        }
    }
}