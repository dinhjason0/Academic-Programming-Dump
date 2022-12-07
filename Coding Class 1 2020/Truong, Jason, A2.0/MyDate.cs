using System;

namespace MyDate_StudentWork
{
    class MyDate // You will need to fill this in! :)
    {
        private int currentMonth = 1;
        private int currentDay = 1;

        public MyDate()
        {
        }

        public MyDate(int month, int day)
        {
            setDate(month, day);
        }

        public int getDay()
        {
            return currentDay;
        }

        public int getMonth()
        {
                return currentMonth;
        }

        public void setDate(int month, int day)
        {
            if (month < 13 && month >= 1)
            {
                currentMonth = month;
            }

            if (day < daysInMonth() + 1 && day >= 1)
                currentDay = day;
        }

        public string toString()
        {
            string okaido = (currentMonth + "/" + currentDay);
            return okaido;
        }

        public bool equals(int otherDatesMonth, int otherDatesDay)
        {
            if (currentMonth == otherDatesMonth && currentDay == otherDatesDay)
                return true;
            else
                return false;
        }

        public int daysInMonth()
        {
            int i = 0;
            switch (getMonth())
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    i = 31;
                    break;
                case 2:
                    i = 28;
                    break;
                case 4: case 6: case 9: case 11:
                    i = 30;
                    break;
            }

            if (i != 0)
                return i;

            return i;
        }

        public void nextDay()
        {
            currentDay++;
            if (currentDay > getMonth())
            {
                currentDay = 1;
                currentMonth++;
                if (currentMonth > 12)
                {
                    currentMonth = 1;
                }
            }
        }
    }
}
