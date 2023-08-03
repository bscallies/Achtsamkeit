using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achtsamkeit.Backend
{
    public class SessionFileHandler : ISessionHandler
    {
        private string filePath;

        public SessionFileHandler(string filePath)
        {
            this.filePath = filePath;
        }

        public void SaveSession(Session session)
        {
            string line = $"{session.StartTime},{session.Duration},{session.Category},{session.SubCategory},{session.Date}";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(line);
            }
        }

        public List<Session> LoadSessions()
        {
            // To be implemented
            return new List<Session>();
        }
    }
}
