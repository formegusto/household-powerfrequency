using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroUI.Common;

namespace MetroUI.Utils
{
	class TimeSlotUtils
	{
		public static int TimeSlotToHours(TimeSlot ts)
		{
			int number = 0;
			switch (ts)
			{
				case TimeSlot.timeslot_3h:
					number = 3;
					break;
				case TimeSlot.timeslot_4h:
					number = 4;
					break;
				case TimeSlot.timeslot_6h:
					number = 6;
					break;
				case TimeSlot.timeslot_8h:
					number = 8;
					break;
				case TimeSlot.timeslot_12h:
					number = 12;
					break;
				case TimeSlot.timeslot_24h:
					number = 24;
					break;
			}

			return number;
		}
		public static int TimeSlotToSize(TimeSlot ts)
		{
			int number = 0;
			switch (ts)
			{
				case TimeSlot.timeslot_3h:
					number = 8;
					break;
				case TimeSlot.timeslot_4h:
					number = 6;
					break;
				case TimeSlot.timeslot_6h:
					number = 4;
					break;
				case TimeSlot.timeslot_8h:
					number = 3;
					break;
				case TimeSlot.timeslot_12h:
					number = 2;
					break;
				case TimeSlot.timeslot_24h:
					number = 1;
					break;
			}

			return number;
		}
	}
}
