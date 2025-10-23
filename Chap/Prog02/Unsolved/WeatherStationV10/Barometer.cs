/// <summary>
///  Simple barometer, measuring pressure in hPa (hectopascal)
/// </summary>
public class Barometer
{
    #region Properties
    public double Pressure { get; set; }

    public string WeatherDescription{ get; private set; }
    #endregion

    #region Constructor
    public Barometer()
    {
        Pressure = 1000.0;
        WeatherDescription = "";
    }
    #endregion

    #region Methods

    public void HandlePressure()
    {
        //if (Pressure < 980 ) { WeatherDescription = "Stormy"; }
        //else if (Pressure >= 980 && Pressure < 1000) { WeatherDescription = "Rainy"; }
        //else if (Pressure >= 1000 && Pressure < 1020) { WeatherDescription = "Changing"; }
        //else if (Pressure >= 1020 && Pressure < 1040) { WeatherDescription = "Fair"; }
        //else if (Pressure >= 1040) { WeatherDescription = "Very dry"; }

        WeatherDescription = Pressure switch // switch expression with pattern matching C# 8 or newer
        {
            < 980 => "Stormy",
            >= 980 and < 1000 => "Rainy",
            >= 1000 and < 1020 => "Changing",
            >= 1020 and < 1040 => "Fair",
            >= 1040 => "Very dry",
            _ => "Unknown"
        };
    }

    #endregion
}
