using System;

namespace ABH.Utility
{
    public static class TimeHelper
    {
        /// <summary>
        /// A string representation of the current time formatted as '@HR_MN_MS'
        /// </summary>
        public static string ExactTimeString
        {
            get {
                string _time = "@" + DateTime.Now.Hour.ToString() + "_";

                if (DateTime.Now.Minute <= 9)
                    _time += "0" + DateTime.Now.Minute.ToString() + "_";
                else
                    _time += DateTime.Now.Minute.ToString() + "_";

                if (DateTime.Now.Millisecond <= 9)
                    _time += "0" + DateTime.Now.Millisecond.ToString();
                else
                    _time += DateTime.Now.Millisecond.ToString();

                return _time;
            }
        }
    }
}
