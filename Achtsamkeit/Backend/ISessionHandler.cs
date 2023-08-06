using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Achtsamkeit.Backend;

//ISessionHandler.cs
namespace Achtsamkeit.Backend
{
    public interface ISessionHandler
    {
        void SaveSession(Session session);
        List<Session> LoadSessions();
        Dictionary<string, TimeSpan> GetTodayUsageByCategory();
        Dictionary<(string, string), TimeSpan> GetTodayUsageByCategoryAndSubcategory();

        TimeSpan GetTotalDurationForLast7Days();

    }
}