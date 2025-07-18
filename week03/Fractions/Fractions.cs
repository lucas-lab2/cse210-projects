public class Fraction
{
    // Attributes are private to enforce encapsulation.
    // No other class can change these directly.
    private int _top;
    private int _bottom;


    // Constructor 1: No parameters, initializes to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: One parameter for the top, denominator is 1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor 3: Two parameters for top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for the top number
    public int GetTop()
    {
        return _top;
    }

    // Setter for the top number
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for the bottom number
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for the bottom number
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }


// Returns a string representation like "3/4"
public string GetFractionString()
{
    return $"{_top}/{_bottom}";
}

// Returns the decimal value of the fraction
public double GetDecimalValue()
{
    // We cast _top to a double to ensure floating-point division
    return (double)_top / _bottom;
}
}

