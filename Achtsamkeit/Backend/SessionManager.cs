using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

}
