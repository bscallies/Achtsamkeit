using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Achtsamkeit.Backend;

namespace Achtsamkeit
{
    class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Session> Sessions { get; set; }
    }
}
