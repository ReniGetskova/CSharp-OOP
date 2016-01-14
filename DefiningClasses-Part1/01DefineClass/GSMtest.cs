using System;
using System.Collections.Generic;

class GSMtest
{
    static void Main()
    {
        GSM[] gsmArray = { 
                             new GSM("S3", "Galaxy", 710M, "Reni", new Battery("A12", 20, 5, BatteryType.LiIon), new Display(4.8, 50000)),
                             new GSM("5", "Nexus", 610M, "Stasko", new Battery("A13", 19, 6, BatteryType.NiCd), new Display(5, 40000)),
                         };

        foreach (var gsm in gsmArray)
        {
            Console.WriteLine(gsm.ToString());
            Console.WriteLine(new string('-', 50));
        }

        Console.WriteLine("Static property: {0}", GSM.IPhone4S);

        GSM myGSM = new GSM("Xperia", "Sony", 510M, "Didi", new Battery("A14", 15, 7, BatteryType.NiMH), new Display(4.9, 45000));


        List<Call> callHistory = new List<Call>
                            {
                               new Call(new DateTime(2015, 03, 18), new Time(23, 22, 56), "0888123456", 360),
                               new Call(new DateTime(2015, 02, 19), new Time(13, 19, 25), "0888124556", 520),
                               new Call(new DateTime(2015, 01, 15), new Time(11, 10, 20), "0888124106", 800)
                            };

        //add calls to call history list
        foreach (var call in callHistory)
        {
            myGSM.AddCall(call);
        }

        Console.WriteLine(myGSM.ToString());
        myGSM.CallHistory.Add(new Call(new DateTime(2015, 01, 15), new Time(11, 10, 20), "0888124106", 800));
        //print call history
        myGSM.PrintCallHistory();

        //calculate total price and print it
        decimal totalPrice = myGSM.CallPrice(myGSM.CallHistory, 0.37M);
        Console.WriteLine("Total call's price: {0}", totalPrice);

        //remove the longest call from the history 
        Call longestCall = new Call();
        foreach (var call in callHistory)
        {
            if (longestCall.Duration <= call.Duration)
            {
                longestCall = call;
            }
        }

        //delete longest call
        myGSM.DeleteCall(longestCall);
        myGSM.PrintCallHistory();

        //calculate the total price again
        totalPrice = myGSM.CallPrice(myGSM.CallHistory, 0.37M);
        Console.WriteLine("Total call's price: {0}", totalPrice);

        //clear the call history and print it.
        myGSM.ClearHistory();
        myGSM.PrintCallHistory();
    }
}
