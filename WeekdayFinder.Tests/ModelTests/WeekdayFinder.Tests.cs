using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WeekdayFinder.Models;

namespace WeekdayFinder.Tests
{
  [TestClass]
  public class WeekdayTests
  {
    [TestMethod]
    public void WeekdayFinderConstructor_CreatesInstanceOfWeekdayFinder_Finder()
    {
      Finder newFinder = new Finder("null");
      Assert.AreEqual(typeof(Finder), newFinder.GetType());
    }
    [TestMethod]
    public void WeekdayFinderDate_SetsNonVoidFieldOfType_String()
    {
      string toSet = "09/05/2023";
      Finder newFinder = new Finder(toSet);

      Assert.AreEqual(toSet, newFinder.Date);
    }

    //PATH: yearCode
    [TestMethod]
    public void LastTwoYear_ShouldLastTwoDigitsOfYearFromDate_Int()
    {
      string toSet = "09/05/2023";
      Finder newFinder = new Finder(toSet);
      int lastTwo = 23;
      Assert.AreEqual(lastTwo, newFinder.getLastTwo());
    }
    [TestMethod]
    public void YearCode_ShouldReturnYearCodeFromLastTwo_Int()
    {
     string toSet = "09/05/2023";
     Finder newFinder = new Finder(toSet);
     int lastTwo = 23;
     int expectedYearCode = (lastTwo +(lastTwo /4)) % 7;
     int actualYearCode = newFinder.CalculateYearCode();
     Assert.AreEqual(expectedYearCode, actualYearCode);
    }

    //PATH: Month Code
    [TestMethod]
    public void getMonth_ReturnMonthNumber_String()
    {
      string toSet = "09/05/2023";
      Finder newFinder = new Finder(toSet);
      string month = "09";
      Assert.AreEqual(month, newFinder.getMonth());
    }

    [TestMethod]
    public void calculateMonthCode_ReturnMonthCode_Int()
    {
      string toSet = "09/05/2023";
      Finder newFinder = new Finder(toSet);
      int monthCode = 5;
      Assert.AreEqual(monthCode, newFinder.MonthCodes["09"]);
    }
  }
}