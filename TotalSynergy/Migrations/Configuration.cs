using System.Data.Entity.Migrations;

namespace TotalSynergy.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<TotalSynergy.Data.DataModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TotalSynergy.Data.DataModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
