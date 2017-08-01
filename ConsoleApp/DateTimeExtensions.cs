using System;

namespace WeeklyTips.ConsoleApp
{
	internal static class DateTimeExtensions
	{


		public static DateTime AddWeekdays(this DateTime date, int days)
		{
			var sign = days < 0 ? -1 : 1;
			var unsignedDays = Math.Abs(days);
			var weekdaysAdded = 0;
			while (weekdaysAdded < unsignedDays)
			{
				date = date.AddDays(sign);
				if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
					weekdaysAdded++;
			}
			return date;
		}

		

	

		public static System.DateTime Round(this DateTime candidate, RoundUnit roundUnit)
		{
			var proposed = new System.DateTime();

			switch (roundUnit)
			{
				case RoundUnit.Second:
					proposed = new System.DateTime(candidate.Year,
																				 candidate.Month,
																				 candidate.Day,
																				 candidate.Hour,
																				 candidate.Minute,
																				 candidate.Second);

					if (candidate.Millisecond >= 500)
					{
						proposed = proposed.AddSeconds(1);
					}
					break;

				case RoundUnit.Minute:
					proposed = new System.DateTime(candidate.Year,
																				 candidate.Month,
																				 candidate.Day,
																				 candidate.Hour,
																				 candidate.Minute, 0);
					if (candidate.Second >= 30)
					{
						proposed = proposed.AddMinutes(1);
					}
					break;

				case RoundUnit.Hour:
					proposed = new System.DateTime(candidate.Year,
																				 candidate.Month,
																				 candidate.Day,
																				 candidate.Hour, 0, 0);
					if (candidate.Minute >= 30)
					{
						proposed = proposed.AddHours(1);
					}
					break;

				case RoundUnit.Day:
					proposed = new System.DateTime(candidate.Year,
																				 candidate.Month,
																				 candidate.Day, 0, 0, 0);
					if (candidate.Hour >= 12)
					{
						proposed = proposed.AddDays(1);
					}
					break;
			}

			return proposed;
		}

		public enum RoundUnit
		{
			Second,
			Minute,
			Hour,
			Day
		}
	}
}