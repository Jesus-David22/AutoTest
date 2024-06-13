using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace chessGameDurationTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateGameDuration()
        {
            TimeSpan duration1 = CalculateGameDuration("10:05", "13:00");
            TimeSpan duration2 = CalculateGameDuration("08:00", "22:00");

            Assert.AreEqual(duration1, new TimeSpan(2, 55, 0));
            Assert.IsTrue(duration2.TotalHours > 12);
        }

        TimeSpan CalculateGameDuration(string start, string end)
        {
            TimeSpan startTime = TimeSpan.Parse(start);
            TimeSpan endTime = TimeSpan.Parse(end);
            TimeSpan duration = endTime - startTime;

            if (duration < TimeSpan.Zero)
            {
                duration += TimeSpan.FromHours(24);
            }

            return duration;
        }
    }
}
