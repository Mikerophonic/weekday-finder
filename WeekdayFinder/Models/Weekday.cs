using System.Collections.Generic;
using System;
namespace WeekdayFinder.Models
{
  public class Finder
  {

    public string Date {get; set;}

    public Dictionary<string, int> MonthCodes = new Dictionary<string, int>()
      {
        {"01", 0},
        {"02", 3},
        {"03", 3},
        {"04", 6},
        {"05", 1},
        {"06", 4},
        {"07", 6},
        {"08", 2},
        {"09", 5},
        {"10", 0},
        {"11", 3},
        {"12", 5}
      };

    public Finder(string date)
    {
      Date = date;
    }

    //constructor() { this.date = date;}

    public int getLastTwo()
    {
      string twoDigit = Date.Substring(7);
      return Int32.Parse(twoDigit);
    }
    public int CalculateYearCode()
  {
    int lastTwo = this.getLastTwo();
    int divByFour = lastTwo / 4 ;
    int yearCode = (lastTwo + divByFour) % 7;
    return yearCode;
  }

  public string getMonth()
  {
    string month = Date.Substring(0, 2);
    return month;
  }


}
}