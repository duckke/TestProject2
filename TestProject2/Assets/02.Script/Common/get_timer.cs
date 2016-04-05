using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class get_timer : MonoBehaviour {
	
	public	const	int	DAY = 0;
	public	const	int	HOUR = 1;
	public	const	int	MINUTE = 2;
	public	const	int	SECOND = 3;
	
	public	static	List<string> time_list = new List<string>();
	public	static	long[]	time_arr = new long[4];
	public	static	string	result;
	public	static	long	day;
	public	static	long	hour;
	public	static	long	minute;
	public	static	long	second;

//	public static string getRemainTimer(long time){
//		string ggg = get_timer.makeTimer(time, ":", ":");
//
//		return ggg;
//	}
//
//	private static string makeTimer(long time, string delemeter1, string delemeter2){
//		string result = "";
//
//		long hour = time/3600L;
//		long minute = time%3600L/60L;
//		long second = time%3600L%60L;
//		
//		if (hour > 0)
//			result = string.Format("{0}{1}{2}", result, string.Format("{0:00}",hour), delemeter1);
//
//		result = string.Format("{0}{1}{2}", result, string.Format("{0:0}",minute), delemeter2); // RemainTimer 갱신할때 분에 한자리수로 표시하기위해 수정. 다른문제있을시 수정해야함
//		result = string.Format("{0}{1}", result, string.Format("{0:00}", second));
//		
//		return result;
//	}
//
//	public static string getHourTimer(long time){
//		return getHourTimer(time, true);
//	}
//	public static string getHourTimer(long time, bool cut_time){
//		time_list.Clear();
//		for (int i=0; i<time_arr.Length; i++) //init time_arr
//			time_arr[i] = 0;
//
//		result = "";
//		day		= time/86400L;
//		hour	= time%86400L/3600L;
//		minute	= time%3600L/60L;
//		second	= time%3600L%60L;
//
//		for (int i=0; i<time_arr.Length; i++) {
//			switch(i) {
//			case DAY:
//				if (day > 0)
//					time_list.Add(string.Format("{0}{1}", day, g.sub_lang.getString("d")));
//				break;
//			case HOUR:
//				if (hour > 0 || (day > 0 && hour == 0 && minute > 0))
//					time_list.Add(string.Format("{0}{1}", hour, g.sub_lang.getString("h")));
//				break;
//			case MINUTE:
//				if (minute > 0 || (hour > 0 && minute == 0 && second > 0))
//					time_list.Add(string.Format("{0}{1}", minute, g.sub_lang.getString("m")));
//				break;
//			case SECOND:
//				if ((day == 0 && hour == 0 && minute >= 0 && second > 0) || (day == 0 && hour == 0&& minute == 0 && second >= 0))
//					time_list.Add(string.Format("{0}{1}", second, g.sub_lang.getString("s")));
//				break;
//			}
//		}
//
//		int print_count = time_list.Count;
//		if (cut_time && print_count > 2)
//			print_count = 2;
//
//		for (int i=0; i<print_count; i++) {
//			if (i == 0)
//				result = string.Format("{0}", time_list[i]);
//			else if (i+1 <= print_count)
//				result = string.Format("{0} {1}", result, time_list[i]);
//		}
//
//
//		return result;
//	}
//
//	
//	public static string getMessageTimer(long time, bool cut_time){
//		string result = "";
//		string delemeter1 = g.sub_lang.getString("d");
//		string delemeter2 = g.sub_lang.getString("h");
//		string delemeter3 = g.sub_lang.getString("m");
//		
//		long day = time/86400L;
//		long hour = time/3600L;
//		long minute = time%3600L/60L;
//		long second = time%3600L%60L;
//
//		if (day > 1)
//			delemeter1 = g.sub_lang.getString("d");
//		if (hour > 1)
//			delemeter2 = g.sub_lang.getString("h");
//		
//		if (day > 0){
//			result = string.Format("{0} {1} {2}", result, string.Format("{0:#0}", day), delemeter1);
//			if (cut_time){
//				result = string.Format("{0} {1}", result, g.sub_lang.getString("ago"));
//				return result;
//			}
//		}
//		else{
//			if (hour > 0){
//				result = string.Format("{0} {1} {2}", result, string.Format("{0:#0}", hour), delemeter2);
//				if (cut_time){
//					result = string.Format("{0} {1}", result, g.sub_lang.getString("ago"));
//					return result;
//				}
//			}
//			if (minute > 0 || (hour > 0 && minute == 0 && second > 0)){
//				result = string.Format("{0} {1} {2}", result, string.Format("{0:#0}", minute), delemeter3);
//				if (cut_time){
//					result = string.Format("{0} {1}", result, g.sub_lang.getString("ago"));
//					return result;
//				}
//			}
//			if (second > 0 || (hour == 0 && minute == 0 && second == 0)){
//				result = string.Format("{0} {1}", result, string.Format("{0:#0}", second));
//				if (cut_time){
//					result = string.Format("{0}", g.sub_lang.getString("now"));
//					return result;
//				}
//			}
//		}
//		
//		return result;
//	}


	public static string getBattleTimer(long time){
		string result = "";
		
		long minute = time%3600L/60L;
		long second = time%3600L%60L;

		result = string.Format("{0}{1}:", result, string.Format("{0:00}",minute));
		result = string.Format("{0}{1}", result, string.Format("{0:00}",second));
		
		return result;
	}
}
