using System;
using System.Collections.Generic;
using TAP2018_19.AlarmClock.Interfaces;
using TAP2018_19.AuctionSite.Interfaces;

namespace AuctionSiteLib
{
    public class SiteFactory: ISiteFactory

    {
        public void Setup(string connectionString)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetSiteNames(string connectionString)
        {
            throw new NotImplementedException();
        }

        public void CreateSiteOnDb(string connectionString, string name, int timezone, int sessionExpirationTimeInSeconds,
            double minimumBidIncrement)
        {
            throw new NotImplementedException();
        }

        public int GetTheTimezoneOf(string connectionString, string name)
        {
            throw new NotImplementedException();
        }

        public ISite LoadSite(string connectionString, string name, IAlarmClock alarmClock)
        {
            throw new NotImplementedException();
        }
    }
}
