using Omryar.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Shared
{
    public static class DrugScheduleCalculator
    {
        public static DateTime Calculate(DateTime lastTakenTime, RepeatType repeatType, int repeatValue)
        {
            switch (repeatType)
            {
                case RepeatType.Hourly:
                    return lastTakenTime.AddHours(repeatValue);
                case RepeatType.Daily:
                    return lastTakenTime.AddDays(repeatValue);
                case RepeatType.Weekly:
                    return lastTakenTime.AddDays(repeatValue * 7);
                default:
                    throw new ArgumentOutOfRangeException("repeatType");
            }
        }
    }
}
