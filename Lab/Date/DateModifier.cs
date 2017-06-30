using System;
using System.Linq;

public class DateModifier
{
    private DateTime start;
    private DateTime end;

    public DateModifier(string date1, string date2)
    {
        int[] date = date1
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        this.start = new DateTime(date[0], date[1], date[2]);

        date = date2
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        this.end = new DateTime(date[0], date[1], date[2]);

        if (DateTime.Compare(this.start,this.end) > 0)
        {
            DateTime tmp = this.end;
            this.end = this.start;
            this.start = tmp;
        }
    }

    public double GetDifference()
    {
        TimeSpan diffTimeSpan = this.end-this.start;

        return diffTimeSpan.TotalDays;
    }
}
