namespace Homework7;

public class Date
{
    private int day = 25;
    private int month = 12;
    private int year = 2020;
    
    public int Day {get; set; }
    public int Month {get; set; }
    public int Year {get; set; }

    public Date() { }

    public Date(int day)
    {
        this.day = day;
    }

    public Date(int day, int month)
    {
        this.day = day;
        this.month = month;
    }
    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public void SetDate(int day, int month, int year)
    {
        this.Day = day;
        this.Month = month;
        this.Year = year;
    }

    public int GetDay() => this.Day;
    public int GetMonth()=> this.Month;
    public int GetYear() => this.Year;

    public string toString()
    {
        return $"{this.day}/{this.month}/{this.year}";
    }
    public string ToString()
    {
        return $"{this.Day}/{this.Month}/{this.Year}";
    }
}