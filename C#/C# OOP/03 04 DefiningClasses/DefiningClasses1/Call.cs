using System;

namespace _1.Define_class
{
    public class Call
    {
        // date, time, dialled phone number and duration (in seconds).
        private DateTime callDate;
        private TimeSpan callTime;
        private ulong callDuration;
        private string dailedNumber;

        //Constructor
        public Call(DateTime callDate, string dailedNumber, ulong callDuration)
        {
            this.callDate = callDate.Date;
            this.callTime = callDate.TimeOfDay;
            this.dailedNumber = dailedNumber;
            this.callDuration = callDuration;
        }

        //Parameters
        public ulong CallDuration
        {
            get
            {
                return this.callDuration;
            }
            set
            {
                this.callDuration = value;
            }
        }

        //ToString
        public override string ToString()
        {
            return $"Date of call: {callDate}\r\nTime of call: {callTime}\r\nDailed number: {dailedNumber}\r\nDuration: {callDuration} seconds";
        }
    }
}
