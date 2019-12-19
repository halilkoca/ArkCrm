﻿using System;

namespace ARK.CORE.Common
{
    public static class TimeStamp
    {
        /// <summary>
		///    Converts a given DateTime into a Unix timestamp
		/// </summary>
		/// <param name="value">Any DateTime</param>
		/// <returns>The given DateTime in Unix timestamp format</returns>
		public static int ToUnixTimestamp(this DateTime value)
        {
            return (int)Math.Truncate(value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
        }

        /// <summary>
        ///    Gets a Unix timestamp representing the current moment
        /// </summary>
        /// <returns>Now expressed as a Unix timestamp</returns>
        public static int UnixTimestamp()
        {
            return (int)Math.Truncate(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
        }

        public static DateTime UnixTimeStampToDateTime(int unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            var dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static DateTime JavaTimeStampToDateTime(double javaTimeStamp)
        {
            // Java timestamp is milliseconds past epoch
            var dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddMilliseconds(javaTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}
