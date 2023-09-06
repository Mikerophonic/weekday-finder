



(Year Code + Month Code + Century Code + Date Number - Leap Year Code) mod 7 = ... 

0 = Sunday
1 = Monday
2 = Tuesday
3 = Wednesday
4 = Thursday
5 = Friday
6 = Saturday


## Year Code getYearCode ->


1. 
return (YY + (YY/4)) mod 7

YY is the last two digits of the year. For the year 1879, its 79.

First, divide YY by 4 and discard the remainder: 79 div 4 = 19.

Then add 19 back into the YY number, which is 79 in this case, resulting in 98.

The next step is: 98%7 = 0;



## Month Code
January = 0
February = 3
March = 3
April = 6
May = 1
June = 4
July = 6
August = 2
September = 5
October = 0
November = 3
December = 5

Dictionary<string, int> monthcodes = new Dictionary<string, int>(){
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



monthcodes["09"] = 5

## Century Code

You then need to apply an adjustment based on the century. In Great Britain, and what was to become the USA, the calendar system changed from the Julian Calendar to the Gregorian Calendar on 2 September 1752. The Gregorian Calendar began on 14 September 1752, skipping 11 days.

Gregorian Dates
For the Gregorian Calendar, remember the number 4206420:

1700s = 4
1800s = 2
1900s = 0
2000s = 6
2100s = 4
2200s = 2
2300s = 0

if before 2 September 1752? : 

(18 - (YYYY // 100)) % 7

Example 1: if the year is 852 CE, calculate 825 divided by 100, which gives you 8.25. Discard the remainder giving you 8. 18 minus 8 is 10. 10 mod 7 is 3. The Century Code is 3.

Gregorian Calendar
If you can divide a Gregorian year by 4, its a leap year, unless its divisible by 100. 
But it is a leap year if its divisible by 400.

1992 is a leap year because you can divide it by four.
1900 is not a leap year because you can divide it by 100.
2000 is a leap year because you can divide it by 400.
Julian Calendar
If you can divide a Julian year by 4, its a leap year.

(if year % 4 == 0 , then leapYear = true)

Einsteins birthday was in 1879 which was not a leap year (0), so it doesnt affect the outcome.


# 
