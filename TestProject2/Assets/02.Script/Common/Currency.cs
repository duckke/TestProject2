using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Currency : MonoBehaviour {
	public static string currencyL(long value){
		string value_string = "";

		long		value_copy = value;
		long		basis = 1;
		int			loop_cnt;
		int			unit = 0;

		if (value_copy < 0) {
			value_string = "-";
			value_copy = -value_copy;
		}

		if (value_copy >= 1000000000000000000){
			loop_cnt = 4;
			basis = 1000000000;
			unit = 3;
		}
		else if (value_copy >= 1000000000000000) {
			loop_cnt = 3;
			basis = 1000000;
			unit = 3;
		}
		else if (value_copy >= 1000000000000) {
			loop_cnt = 3;
			basis = 1000000;
			unit = 2;
		}
		else if (value_copy >= 1000000000) {
			loop_cnt = 3;
			basis = 1000000;
			unit = 1;
		}
		else if (value_copy >= 1000000) {
			loop_cnt = 3;
			basis = 1000000;
		}
		else if (value_copy >= 1000) {
			loop_cnt = 2;
			basis = 1000;
		}
		else {
			loop_cnt = 1;
			basis = 1;
		}

		if (unit == 1)
			value_copy = value_copy / 1000;
		else if (unit == 2)
			value_copy = value_copy / 1000000;
		else if (unit == 3)
			value_copy = value_copy / 1000000000;

		for (int i=0; i<loop_cnt; i++) {
			long sub_value = value_copy/basis;

			if (i == 0)
				value_string = string.Format("{0}{1}", value_string, sub_value.ToString());
			else
				value_string = string.Format("{0}{1}", value_string, string.Format(",{0:000}", (int)sub_value));
			
			value_copy -= (sub_value) * basis;
			basis = basis / 1000;
		}

		
		if (unit == 0)
			value_string = string.Format("{0}K", value_string);
		else if (unit == 1)
			value_string = string.Format("{0}M", value_string);
		else if (unit == 2)
			value_string = string.Format("{0}B", value_string);
		else if (unit == 3)
			value_string = string.Format("{0}T", value_string);

		return value_string;
	}

	public static string currency(long value){
//		List<string> value_string = new List<string>();
		string value_string = "";
		
		long		value_copy = value;
		long		basis = 1;
		long		loop_cnt;
		
		if (value_copy < 0) {
			value_string = "-";
			value_copy = -value_copy;
		}

		if (value_copy >= 1000000000000) {
			loop_cnt = 5;
			basis = 1000000000000;
		}
		else if (value_copy >= 1000000000) {
			loop_cnt = 4;
			basis = 1000000000;
		}
		else if (value_copy >= 1000000) {
			loop_cnt = 3;
			basis = 1000000;
		}
		else if (value_copy >= 1000) {
			loop_cnt = 2;
			basis = 1000;
		}
		else {
			loop_cnt = 1;
			basis = 1;
		}
		
		for (int i=0; i<loop_cnt; i++) {
			long sub_value = value_copy/basis;
			
			if (i == 0)
				value_string = string.Format("{0}{1}", value_string, sub_value.ToString());
			else
				value_string = string.Format("{0}{1}", value_string, string.Format(",{0:000}", (int)sub_value));
			
			value_copy -= (sub_value) * basis;
			basis = basis / 1000L;
		}
		
		return value_string;
	}

	public static string currency(int value){
		string value_string = "";
		
		int			value_copy = value;
		int			basis = 1;
		int			loop_cnt;
		
		if (value_copy < 0) {
			value_string = "-";
			value_copy = -value_copy;
		}

		if (value_copy >= 1000000000) {
			loop_cnt = 4;
			basis = 1000000000;
		}
		else if (value_copy >= 1000000) {
			loop_cnt = 3;
			basis = 1000000;
		}
		else if (value_copy >= 1000) {
			loop_cnt = 2;
			basis = 1000;
		}
		else {
			loop_cnt = 1;
			basis = 1;
		}

		for (int i=0; i<loop_cnt; i++) {
			int	sub_value = value_copy/basis;
			
			if (i == 0)
				value_string = string.Format("{0}{1}", value_string, sub_value.ToString());
			else
				value_string = string.Format("{0}{1}", value_string, string.Format(",{0:000}", (int)sub_value));

			value_copy -= (sub_value) * basis;
			basis = basis / 1000;
		}

		return value_string;
	}
}
