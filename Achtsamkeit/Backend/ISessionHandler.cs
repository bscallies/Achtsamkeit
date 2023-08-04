﻿using System;
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
    }
}