using System;
using System.Data.Entity;
using NLayerApp.DAL.Entities;
using NLayerApp.DAL.Migrations;

namespace NLayerApp.DAL.EF
{
    public class DbInitializer : MigrateDatabaseToLatestVersion<MobileContext, Configuration>
    {
        
    }
}