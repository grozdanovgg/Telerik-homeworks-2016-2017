namespace _1.Define_class
{
    using System;
    public class Display
    {
        //Data fields
        private int displaySize;
        private int displayNumberOfColors;

        //Construcors
        public Display(int displaySize,int displayNumberOfColors)
        {
            this.displaySize = displaySize;
            this.displayNumberOfColors = displayNumberOfColors;
        }
        public Display(int displaySize)
        {
            this.displaySize = 0;
        }

        //Properties
        public int DisplaySize
        {
            get { return this.displaySize; }
            set
            {
                Methods.ValidateIntInput(value);
                this.displaySize = value;
            }
        }
        public int DisplayNumberOfColors
        {
            get { return this.displayNumberOfColors; }
            set
            {
                Methods.ValidateIntInput(value);
                this.displayNumberOfColors = value;
            }
        }
    }
}
