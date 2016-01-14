using System;
using System.Collections.Generic;

class GSM 
{
    private string model;
    private string manufacturer;
    private decimal price;
    private string owner;
    private Battery batteryCharacteristics;
    private Display displayCharacteristics;
    private List<Call> callHistory;

    private static string iPhone4S = "iPhone4S";

    public GSM(string model, string manufacturer)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.callHistory = new List<Call>();
    }

    public GSM(string model, string manufacturer, decimal price, string owner, Battery batteryCharacteristics, Display displayCharacteristics)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.Owner = owner;
        this.BatteryCharacteristics = batteryCharacteristics;
        this.DisplayCharacteristics = displayCharacteristics;
        this.callHistory = new List<Call>();
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set { this.manufacturer = value; }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Price can not has negative value");
            }

            this.price = value;
        }
    }

    public string Owner
    {
        get
        {
            if (this.owner == null)
            {
                throw new ArgumentNullException("Owner can not has a NULL value");
            }

            return this.owner;
        }

        set
        {
            this.owner = value;
        }
    }

    public Battery BatteryCharacteristics
    {
        get
        {
            Battery result = new Battery(this.batteryCharacteristics.BatteryModel, this.batteryCharacteristics.HoursIdle, this.batteryCharacteristics.HoursTalk, this.batteryCharacteristics.BatteryType);
            return result;
        }

        set
        {
            this.batteryCharacteristics = new Battery(value.BatteryModel, value.HoursIdle, value.HoursTalk, value.BatteryType);
        }

    }

    public Display DisplayCharacteristics
    {
        get
        {
            Display result = new Display(this.displayCharacteristics.Size, this.displayCharacteristics.NumberOfColors);
            return result;
        }

        set
        {
            this.displayCharacteristics = new Display(value.Size, value.NumberOfColors);
        }
    }

    public static string IPhone4S
    {
        get { return iPhone4S; }
        set { iPhone4S = value; }
    }

    public List<Call> CallHistory
    {
        get
        {
            if (this.callHistory == null)
            {

                this.callHistory = new List<Call>();
            }

            //return copy -> this we are not allow to change call history from outside the class
            return new List<Call>(this.callHistory);
        }
    }

    public void AddCall(Call call)
    {
        this.callHistory.Add(call);
    }

    public void DeleteCall(Call call)
    {
        if (this.callHistory != null)
        {
            this.callHistory.Remove(call);
        }
        else
        {
            throw new ArgumentNullException("Call history is empty, you can not remove more calls");
        }
    }

    public void ClearHistory()
    {
        this.callHistory.Clear();
    }

    public decimal CallPrice(List<Call> calls, decimal price)
    {
        decimal totalPrice = 0;
        decimal temp = 0;
        foreach (var call in calls)
        {
            
            if (call.Duration % 60 == 0)
            {
                temp = ((call.Duration / 60));
            }
            else
            {
                //+ 1 if the call is less than minute
                temp = ((call.Duration / 60)) + 1;
            }

            totalPrice += temp * price;
        }

        return totalPrice;
    }

    public void PrintCallHistory()
    {
        Console.WriteLine("Call History:");
        foreach (var call in this.CallHistory)
        {
            Console.WriteLine(call.ToString());
        }
    }

    public override string ToString()
    {

        return string.Format("Model: {0}\nManufacturer: {1}\nPrice: {2}\nOwner: {3}\nBattery characteristics:\n\tModel:" + 
                            "{4}\n\tHours Idle: {5}\n\tHours Talk: {6}\n\tType: {7}\nDisplay characteristics:\n\tSize: " +
                            "{8}\n\tColors: {9}",
                            this.Model, this.Manufacturer, this.Price, this.Owner, this.BatteryCharacteristics.BatteryModel,
                            this.BatteryCharacteristics.HoursIdle,
                            this.BatteryCharacteristics.HoursTalk,
                            this.BatteryCharacteristics.BatteryType,
                            this.DisplayCharacteristics.Size,
                            this.DisplayCharacteristics.NumberOfColors
                            );
    }
}
