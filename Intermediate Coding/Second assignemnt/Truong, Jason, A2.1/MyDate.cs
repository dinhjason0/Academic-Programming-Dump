//JASON TRUONG
//BIT 142
//A2.1
using System;

namespace MyDate_StudentWork
{
    class MyDate // You will need to fill this in! :)
    {
        private int theDay;
        private int theMonth;

        public MyDate()
        {
            setDate(1, 1);
        }

        public MyDate(int month, int day)
        {
            setDate(month, day);
        }

        public int getDay()
        {
            return theDay;
        }

        public int getMonth()
        {
            return theMonth;
        }

        public void setDate(int month, int day)
        {
            if (month >= 1 && month <= 12)
                theMonth = month;
            else theMonth = 1;
            if (day > 0 && day <= daysInMonth())
                theDay = day;
            else theDay = 1;
        }

        public string toString()
        {
            return getMonth() + "/" + getDay();
        }

        public bool equals(int otherDatesMonth, int otherDatesDay)
        {
            if (theDay == otherDatesDay && theMonth == otherDatesMonth)
                return true;
            else return false;
        }

        public int daysInMonth()
        {
            switch (getMonth())
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return 28;
            }
            return 0;
        }

        public void nextDay()
        {
            if (getDay() + 1 > daysInMonth())
            {
                switch (getMonth())
                {
                    case 12:
                        if (getDay() != 31)
                            setDate(getMonth() + 1, 1);
                        else setDate(1, 1);
                        break;
                    default:
                        setDate(getMonth() + 1, 1);
                        break;
                }
            }
            else setDate(getMonth(), getDay() + 1);
        }
    }
}
