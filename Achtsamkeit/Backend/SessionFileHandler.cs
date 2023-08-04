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
            List<Session> sessions = LoadSessions();
            sessions.Add(session);
            string jsonData = JsonConvert.SerializeObject(sessions, Formatting.Indented);
            File.WriteAllText(_filePath, jsonData);
            /*List<Session> sessions = new List<Session>();
            string jsonData;

            if (File.Exists(_filePath))
            {
                jsonData = File.ReadAllText(_filePath); 
                sessions = JsonConvert.DeserializeObject<List<Session>>(jsonData);
            }

            sessions.Add(session);
            jsonData = JsonConvert.SerializeObject(sessions, Formatting.Indented); 
            File.WriteAllText(_filePath, jsonData);*/
        }

        public List<Session> LoadSessions()
        {
            List<Session> sessions = new List<Session>();

            if (File.Exists(_filePath))
            {
                string jsonData = File.ReadAllText(_filePath);

                try
                {
                    sessions = JsonConvert.DeserializeObject<List<Session>>(jsonData);
                }
                catch (JsonSerializationException)
                {
                    var singleSession = JsonConvert.DeserializeObject<Session>(jsonData);

                    if (singleSession != null)
                    {
                        sessions.Add(singleSession);
                    }
                }
            }

            return sessions;
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
