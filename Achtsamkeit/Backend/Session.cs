
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Session.cs
namespace Achtsamkeit.Backend
{
    public class Session
    {
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public DateTime Date { get; set; }

        public Session(DateTime startTime, TimeSpan duration, string category, string subCategory)
        {
            StartTime = startTime;
            Duration = duration;
            Category = category;
            Subcategory = Subcategory;
            Date = DateTime.Now;
        }
    }
}

