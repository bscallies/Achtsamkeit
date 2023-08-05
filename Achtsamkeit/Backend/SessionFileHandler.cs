﻿
using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Achtsamkeit.Backend;

//SessionFileHandler.cs
namespace Achtsamkeit.Backend
{
    public class SessionFileHandler : ISessionHandler
    {
        private string _filePath;

        public SessionFileHandler(string filePath)
        {
            _filePath = filePath;
        }

        public void AddTimeToCategory(string category, TimeSpan duration)
        {
            var sessions = LoadSessions();
            var session = sessions
                .FirstOrDefault(s => s.StartTime.Date == DateTime.Today && s.Category == category);
            if (session == null)
            {
                session = new Session(DateTime.Today, duration, category, "General");
                sessions.Add(session);
            }
            else
            {
                session.Duration += duration;
            }
            SaveSessions(sessions);
        }
        public void SaveSession(Session session)
        {
            var sessions = LoadSessions();
            sessions.Add(session);
            SaveSessions(sessions);
        }

        public void SaveSessions(List<Session> sessions)
        {
            string jsonData = JsonConvert.SerializeObject(sessions, Formatting.Indented);
            File.WriteAllText(_filePath, jsonData);
        }
        /*public void SaveSessions(Session session)
        {
            List<Session> sessions = LoadSessions();
            sessions.Add(session);
            string jsonData = JsonConvert.SerializeObject(sessions, Formatting.Indented);
            File.WriteAllText(_filePath, jsonData);
        }*/

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
