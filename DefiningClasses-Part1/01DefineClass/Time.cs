class Time
{
    public Time(int h, int m, int s)
    {
        Hours = h;
        Minutes = m;
        Seconds = s;
    }

    public int Hours { get; set; }

    public int Minutes { get; set; }

    public int Seconds { get; set; }

    public override string ToString()
    {
        return string.Format("{0}:{1}:{2}", this.Hours, this.Minutes, this.Seconds);
    }
}
