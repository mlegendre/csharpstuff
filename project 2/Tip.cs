using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Tip
    {
        // fields 
        private string guestName;
        private double billAmount;
        private double tipPercent;

    

        // constructors
        public Tip() //no argument constructor
        {
            guestName = "";
            billAmount = 0;
            tipPercent = 0;
        }
        
        // field related properties (gets and sets)
        public string GuestName
        {
            get //returns the value
            {
                return guestName;
            }
            set //assigns the value
            {
                guestName = value;
            }
        }
        
        public double BillAmount
        {
            get //returns the value
            {
                return billAmount;
            }
            set //assigns the value
            {
                billAmount = value;
            }
        }

        public double TipPercent
        {
            get //returns the value
            {
                return tipPercent;
            }
            set //assigns the value
            {
                tipPercent = value;
            }
        }

        // calculated properties this one only has a get, no set
        public double CalculateTip
        {
            get
            {
                return BillAmount * TipPercent;
            }
        }

    }
}
