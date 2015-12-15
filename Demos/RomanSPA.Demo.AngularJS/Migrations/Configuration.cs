namespace RomanSPA.Demo.AngularJS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    //Add-Migration InitialCreate –IgnoreChanges
    //Update-Database

    internal sealed class Configuration : DbMigrationsConfiguration<RomanSPA.Demo.AngularJS.Models.RomanSPAStarterKitEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RomanSPA.Demo.AngularJS.Models.RomanSPAStarterKitEntities context)
        {
            context
                .BlogPosts
                .AddOrUpdate(
                    p => p.ID,
                    new Models.BlogPost() { Title = "Blog Title", Summary = "Blog Summary", BodyText = "Blog Body", PostDate = DateTime.Now });

            context.SaveChanges();
        }
    }
}
