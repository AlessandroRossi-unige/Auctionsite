using AuctionSiteLib;
using Ninject.Modules;
using TAP2018_19.AuctionSite.Interfaces;


public class Bindings : NinjectModule
{
    public override void Load()
    { 
        Bind<ISiteFactory>().To<AuctionSiteLib.SiteFactory>();
    }
}

