//Session.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achtsamkeit.Backend
{
    public class Session
    {
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public DateTime Date { get; set; }

        public Session(DateTime startTime, TimeSpan duration, string category, string subCategory)
        {
            StartTime = startTime;
            Duration = duration;
            Category = category;
            SubCategory = subCategory;
            Date = DateTime.Now;
        }
    }
}

