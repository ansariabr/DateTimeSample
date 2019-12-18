using System;

namespace DateTimeSample
{
    public struct DateTimeOffsetWrapper
    {
        private static DateTimeOffset? _dateTimeOffset;
        public static DateTimeOffset Now => _dateTimeOffset ?? DateTimeOffset.Now;
        
        /// <summary>
        /// This method can be used to initialize our internal DateTimeOffset object to the desired date and time
        /// </summary>
        /// <param name="dateTimeOffset">Desired date and time</param>
        public static void SetDateTimeOffset(DateTimeOffset dateTimeOffset)
        {
            _dateTimeOffset = dateTimeOffset;
        }
    }
}
