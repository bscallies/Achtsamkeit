using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//SessionManager.cs
namespace Achtsamkeit.Backend
{
    public class SessionManager
    {
        private ISessionHandler sessionHandler;
        private Session currentSession;

        public SessionManager(ISessionHandler handler)
        {
            sessionHandler = handler;
        }

        public void BeginSession(string category, string subCategory)
        {
            currentSession = new Session(DateTime.Now, new TimeSpan(0), category, subCategory);
            sessionHandler.SaveSession(currentSession);
        }

        public void UpdateSession()
        {
            if (currentSession != null)
            {
                TimeSpan elapsed = DateTime.Now - currentSession.StartTime;
                currentSession.Duration = currentSession.Duration.Add(elapsed);

                sessionHandler.SaveSession(currentSession);
            }
        }

        public void EndSession()
        {
            currentSession = null;
        }
        public Dictionary<string, TimeSpan> GetTodayUsageByCategory()
        {
            var sessions = sessionHandler.LoadSessions();
            var todaySessions = sessions.Where(s => s.StartTime.Date == DateTime.Now.Date);
            var categoryUsage = new Dictionary<string, TimeSpan>();

            foreach (var session in todaySessions)
            {
                if (categoryUsage.ContainsKey(session.Category))
                {
                    categoryUsage[session.Category] += session.Duration;
                }
                else
                {
                    categoryUsage[session.Category] = session.Duration;
                }
            }

            return categoryUsage;
        }
    }
}
