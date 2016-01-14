using System;

class Display
{
    private double size;
    private int numberOfColors;

    public Display(double size, int numberOfColors)
    {
        this.Size = size;
        this.NumberOfColors = numberOfColors;
    }

    public double Size
    {
        get { return this.size; }
        set { this.size = value; }
    }

    public int NumberOfColors
    {
        get
        {
            return this.numberOfColors;
        }

        set
        {
            if (value < 0 || value > 65536)
            {
                throw new ArgumentOutOfRangeException("Number of colors must be between 0 and 65 536");
            }

            this.numberOfColors = value;
        }
    }
}
