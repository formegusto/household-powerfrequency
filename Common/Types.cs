using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhpf.Common
{
	public enum Day
	{
		SUN,
		MON,
		TUE,
		WED,
		THU,
		FRI,
		SAT
	}

	public enum TimeSlot
	{
		timeslot_3h = 3,
		timeslot_4h = 4,
		timeslot_6h = 6,
		timeslot_8h = 8,
		timeslot_12h = 12,
		timeslot_24h = 24
	}

	public enum Season
	{
		ALL,
		SPRING,
		SUMMER,
		AUTUMN,
		WINTER
	}
}
