using System;

class Call 
{
    private DateTime date;
    private Time time;
    private string dialledPhoneNumber;
    private int duration;

    public Call (DateTime date, Time time, string dialledPhoneNumber, int duration)
    {
        this.Date = date;
        this.Time = time;
        this.DialledPhoneNumber = dialledPhoneNumber;
        this.Duration = duration;
    }

    public Call()
    {
        this.Date = new DateTime(2000, 01, 01);
        this.Time = new Time(0, 0, 0);
        this.DialledPhoneNumber = "123";
        this.Duration = 0;
    }

    public DateTime Date
    {
        get
        {
            DateTime result = new DateTime(this.date.Year, this.date.Month, this.date.Day);
            return result;
        }

        set
        {
            this.date = new DateTime(value.Year, value.Month, value.Day);
        }
    }

    public Time Time
    {
        get
        {
            Time result = new Time(this.time.Hours, this.time.Minutes, this.time.Seconds);
            return result;
        }
        set
        {
            this.time = new Time(value.Hours, value.Minutes, value.Seconds);
        }
    }

    public string DialledPhoneNumber
    {
        get { return this.dialledPhoneNumber; }
        set { this.dialledPhoneNumber = value; }
    }

    public int Duration
    {
        get
        {
            return this.duration;
        }

        set
        {
            if (value < 0 || value > 3600)
            {
                throw new ArgumentOutOfRangeException("Duration must be at least 0 seconds and maximun 3600 seconds");
            }

            this.duration = value;
        }
    }

    public override string ToString()
    {
        return string.Format("\tDate: {0:yyyy.MM.dd} | Time: {1}\n\tDialled phone number: {2} | Duration: {3}", 
                            this.Date, this.Time, this.DialledPhoneNumber, this.Duration);
    }
}
