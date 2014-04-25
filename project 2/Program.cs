using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        public static void Main()
        {
            const double TEN = .10;
            const double FIFTEEN = .15;
            const double TWENTY = .20;
            int percentChoice;


            Tip[] tipArray = new Tip[4];
            for (int i = 0; i < tipArray.Length; i++)
            {

                tipArray[i] = new Tip();

                //bool valid entry here


                Console.Write("Please enter guest's name: ");
                tipArray[i].GuestName = Console.ReadLine(); //assigning array object

                Console.Write("What was {0} total bill? ", tipArray[i].GuestName);
                tipArray[i].BillAmount = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("How much would {0} like to tip?\n 1.) 15% \n 2.) 20% \n Any other value entered will count as 10% ", tipArray[i].GuestName);
                percentChoice = Convert.ToInt32(Console.Read());
                switch(percentChoice)
                {
                    case '1':
                        tipArray[i].TipPercent = FIFTEEN;
                        break;
                    
                    case '2':
                        tipArray[i].TipPercent = TWENTY;
                        break;

                    default:
                        tipArray[i].TipPercent = TEN;
                        break;
                }



                
                
                Console.WriteLine("{0} tips: {1:C}\n", tipArray[i].GuestName, tipArray[i].CalculateTip);
                Console.ReadLine();

                


            }
        }
    }
}
