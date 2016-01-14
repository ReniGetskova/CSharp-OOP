class Battery
{
    private string batteryModel;
    private int hoursIdle;
    private int hoursTalk;
    private BatteryType battryType;

    public Battery(string batteryModel, int hoursIdle, int hoursTalk, BatteryType batteryType)
    {
        this.BatteryModel = batteryModel;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
        this.BatteryType = batteryType;
    }

    public string BatteryModel
    {
        get { return this.batteryModel; }
        set { this.batteryModel = value; }
    }

    public int HoursIdle
    {
        get { return this.hoursIdle; }
        set { this.hoursIdle = value < 0 ? 0 : value; }
    }

    public int HoursTalk
    {
        get { return this.hoursTalk; }
        set { this.hoursTalk = value < 0 ? 0 : value; }
    }

    public BatteryType BatteryType
    {
        get { return this.battryType; }
        set { this.battryType = value; }
    }
}
