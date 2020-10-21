using System;

namespace WeekOfDay
{
    class Judge
    {

        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Judge()
        {
            
        }
        
        public string EndofWeekChecker(string inputYear,string inputMonth,string inputDay)
        {
            int year = Convert.ToInt32(inputYear);
            int month = Convert.ToInt32(inputMonth);
            int day = Convert.ToInt32(inputDay);


            var inputStrings = new DateTime(year,month,day);
            string endOfWeek=inputStrings.ToString("dddd");   


            return endOfWeek;
        }
    }
}
