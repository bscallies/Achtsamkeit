using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Achtsamkeit.Backend;

namespace Achtsamkeit.Backend
{
    public interface ISessionHandler
    {
        void SaveSession(Session session);
        List<Session> LoadSessions();
    }
}