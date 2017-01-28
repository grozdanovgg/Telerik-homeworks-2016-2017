namespace _1.Define_class
{
    using System;
    public class Battery
    {
        //Data fields
        private string batteryModel;
        private int batteryHoursIdle;
        private int batteryHoursTalk;
        private BatteryType batteryType;

        //Constructors  
        public Battery(string batteryModel = null, int batteryHoursIdle = 0, int batteryHoursTalk = 0, BatteryType batteryType = BatteryType.LiIon)
        {
            this.batteryModel = batteryModel;
            this.batteryHoursIdle = batteryHoursIdle;
            this.batteryHoursTalk = batteryHoursTalk;
            this.batteryType = batteryType;
        }
        public Battery(string batteryModel = null, BatteryType batteryType = BatteryType.LiIon)
        {
            this.batteryModel = batteryModel;
            this.batteryType = batteryType;
        }
        public Battery(BatteryType batteryType = BatteryType.LiIon)
        {
            this.batteryType = batteryType;
        }

        //Properties
        public string BatteryModel
        {
            get { return this.batteryModel; }
            set
            {
                Methods.ValidateStringInput(value);
                this.batteryModel = value;
            }
        }
        public int BatteryHoursIdle
        {
            get
            {
                return this.batteryHoursIdle;
            }
            set
            {
                Methods.ValidateIntInput(value);
                this.batteryHoursIdle = value;
            }
        }
        public int BatteryHoursTalk
        {
            get
            {
                return this.batteryHoursTalk;
            }
            set
            {
                Methods.ValidateIntInput(value);
                this.batteryHoursTalk = value;

            }
        }
        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set
            {
                Methods.ValidateBatteryTypeInput(value);
                this.batteryType = value;
            }
        }

        //ToString
        public override string ToString()
        {

            return $"\r\nBattery info:\r\nBattery model: {BatteryModel}\r\nIdle Hours: {batteryHoursIdle}\r\nTalk hours: {batteryHoursTalk}";
        }
    }

}