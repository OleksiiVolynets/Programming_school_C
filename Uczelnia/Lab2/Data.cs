using System;

public class MyDate
{
    private int day;
    private int month;
    private int year;

    
    public MyDate(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    
    public string GetDate()
    {
        return $"{day:00}.{month:00}.{year:0000}";
    }

    
    private DateTime ToDateTime()
    {
        return new DateTime(year, month, day);
    }

    
    private void UpdateFromDateTime(DateTime dt)
    {
        day = dt.Day;
        month = dt.Month;
        year = dt.Year;
    }

     
    public void NextWeek()
    {
        DateTime dt = ToDateTime().AddDays(7);
        UpdateFromDateTime(dt);
    }

    
    public void PreviousWeek()
    {
        DateTime dt = ToDateTime().AddDays(-7);
        UpdateFromDateTime(dt);
    }
}