using System;

namespace TGDate {
	public class DateFunc {
		public static int getDayForMonth(int month, int year)
		{
			int dayForMonth = 0;
			if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
				dayForMonth = 31;
			else if (month == 4 || month == 6 || month == 9 || month == 11)
				dayForMonth = 30;
			else if (month == 2) {
				if (year%4 == 0) {
					if (year % 100 == 0) {
						if (year % 400 == 0)
							dayForMonth = 29;
						else
							dayForMonth = 28;
					}
					else
						dayForMonth = 29;
				}
				else
					dayForMonth = 28;
			}

			return dayForMonth;
		}
		
		public static long getTimeSince(long _time, int _offset)
		{
			int year = (int)(_time / 10000000000);
			int month = (int)((_time % 10000000000) / 100000000);
			int day = (int)((_time % 100000000) / 1000000);
			int hour = (int)((_time % 1000000) / 10000);
			int min = (int)((_time % 10000) / 100);
			int sec = (int)((_time % 100));
			
			sec += _offset;
			
			min += sec/60;
			sec = sec%60;
			
			hour += min/60;
			min = min%60;
			
			day += hour/24;
			hour = hour%24;
			
			while (true) {
				if (day > getDayForMonth(month, year)) {
					day -= getDayForMonth(month, year);
					month++;
					if (month > 12) {
						month = 1;
						year++;
					}
				}
				else
					break;
			}
			
			_time = year * 10000000000 +
				month * 100000000 +
					day * 1000000 +
					hour * 10000 +
					min * 100 +
					sec;
			
			return _time;
			
		}
		
		public static long getTimeInterval(long time1, long time2) // time2 - time1
		{
			bool minus;
			
			if (time1 > time2) {
				long tmpTime = time1;
				time1 = time2;
				time2 = tmpTime;
				minus = true;
			}
			else
				minus = false;

			int year1 = (int)(time1 / 10000000000);
			int month1 = (int)((time1 % 10000000000) / 100000000);
			int day1 = (int)((time1 % 100000000) / 1000000);
			int hour1 = (int)((time1 % 1000000) / 10000);
			int min1 = (int)((time1 % 10000) / 100);
			int sec1 = (int)((time1 % 100));

			int year2 = (int)(time2 / 10000000000);
			int month2 = (int)((time2 % 10000000000) / 100000000);
			int day2 = (int)((time2 % 100000000) / 1000000);
			int hour2 = (int)((time2 % 1000000) / 10000);
			int min2 = (int)((time2 % 10000) / 100);
			int sec2 = (int)((time2 % 100));
			
			long interval = 0;
			int tmp = sec2 -sec1;
			
			if (tmp < 0) {
				tmp = 60+tmp;
				min2--;
			}
			interval += tmp;
			
			tmp = min2-min1;
			if (tmp < 0) {
				tmp = 60+tmp;
				hour2--;
			}
			interval += tmp*60;
			
			tmp = hour2-hour1;
			if (tmp < 0) {
				tmp = 24+tmp;
				day2--;
			}
			interval += tmp*60*60;
			
			//Year, Month, Day
			for (int i=1; i<=month1; i++) {
				if (month1 < 2) break;
				day1 += getDayForMonth(i-1, year1);
			}
			
			for (int i=1; i<=month2; i++) {
				if (month2 < 2) break;
				day2 += getDayForMonth(i-1, year2);
			}
			
			long tmpDay = 0;
			
			if (year1 == year2) {
				tmpDay = day2-day1;
				interval += tmpDay*24*60*60;
			}
			else {
				
				if (year1%4 == 0) {
					if (year1%100 == 0) {
						if (year1%400 == 0)
							day1 = 366 - day1;
						else
							day1 = 365 - day1;
					}
					else
						day1 = 366 - day1;
				}
				else
					day1 = 365 - day1;
				tmpDay = day1+day2;
				interval += tmpDay*24*60*60;
				
				tmpDay = year2-year1-1;
				interval += tmpDay*365*24*60*60;
				
				//윤달있는 Year 계산
				if (year2-year1 > 1) {
					year1++;
					tmpDay = 24*60*60;
					for (int i=year1; i<year2; i++){
						if (i%4 == 0) {
							if (i%100 != 0)
								interval += tmpDay;
							else {
								if (i%400 == 0)
									interval += tmpDay;
							}
						}
					}
				}
			}
			
			if (minus) interval= -interval;
			return interval;
		}
	}
}