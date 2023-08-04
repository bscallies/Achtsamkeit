//SessionFileHandler.cs
using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Achtsamkeit.Backend;

namespace Achtsamkeit.Backend
{
    public class SessionFileHandler : ISessionHandler
    {
        private string _filePath;

        public SessionFileHandler(string filePath)
        {
            _filePath = filePath;
        }

        public void SaveSession(Session session)
        {
            List<Session> sessions = new List<Session>();
            string jsonData; // Declare jsonData here

            if (File.Exists(_filePath))
            {
                jsonData = File.ReadAllText(_filePath); // Assign to jsonData here, don't declare it again
                sessions = JsonConvert.DeserializeObject<List<Session>>(jsonData);
            }

            sessions.Add(session);
            jsonData = JsonConvert.SerializeObject(sessions, Formatting.Indented); // Assign to jsonData here, don't declare it again
            File.WriteAllText(_filePath, jsonData);
        }

        public List<Session> LoadSessions()
        {
            if (!File.Exists(_filePath))
                return new List<Session>(); // return an empty list if the file doesn't exist

            string jsonData = File.ReadAllText(_filePath);
            List<Session> sessions = JsonConvert.DeserializeObject<List<Session>>(jsonData);
            return sessions ?? new List<Session>(); // return the deserialized sessions or an empty list if deserialization results in null
        }
        public Dictionary<string, TimeSpan> GetTodayUsageByCategory()
        {
            var sessionsToday = LoadSessions()
                .Where(session => session.StartTime.Date == DateTime.Today)
                .GroupBy(session => session.Category)
                .ToDictionary(
                    group => group.Key,
                    group => new TimeSpan(group.Sum(session => session.Duration.Ticks)));

            return sessionsToday;
        }
    }
}
