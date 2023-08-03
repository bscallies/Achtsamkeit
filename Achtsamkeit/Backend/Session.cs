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
        public int Duration { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public DateTime Date { get; set; }
    }
}

