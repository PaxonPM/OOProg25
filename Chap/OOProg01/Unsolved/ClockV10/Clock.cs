

using System.Data;

public class Clock
{
    #region Properties
    private int Hour { get; set; }
    private int Min { get; set; }
    #endregion

    #region Constructor
    public Clock(int hour, int min)
    {
        SetTime(hour, min);
    }
    #endregion

    #region methods
    public void SetTime(int hour, int min)
    {
        Hour = hour;
        Min = min;
    }
    public string DisplayTime()
    {
        return $"{Hour:00}:{Min:00}";
    }
    public void AddTime()
    {

        if (Hour == 23 && Min == 59)
        {
            Hour = 0;
            Min = 0;
        }
        else if (Min == 59)
        {
            Min = 0;
            Hour += 1;
        }  
        else
        {
            Min += 1;
        }
     
    }
    #endregion




}

