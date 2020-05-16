namespace FriendOrganizer.DataAccess.Migrations
{
  using FriendOrganizer.Model;
  using System;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;

  internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.DataAccess.FriendOrganizerDbContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = false;
    }

    protected override void Seed(FriendOrganizer.DataAccess.FriendOrganizerDbContext context)
    {
      context.Friends.AddOrUpdate(
        f => f.FirstName,
        new Friend { FirstName = "Thomas", LastName = "Huber" },
        new Friend { FirstName = "Urs", LastName = "Meier" },
        new Friend { FirstName = "Erkan", LastName = "Egin" },
        new Friend { FirstName = "Sara", LastName = "Huber" }
        );
            context.ProgrammingLanguages.AddOrUpdate(p => p.Name,
                new ProgrammingLanguage { Name = "C#" },
                new ProgrammingLanguage { Name = "Type Script" },
                new ProgrammingLanguage { Name = "Java" },
                new ProgrammingLanguage { Name = "React JS" },
                new ProgrammingLanguage { Name = "F#" });

            context.SaveChanges();
            context.FriendPhoneNumbers.AddOrUpdate(pn => pn.Number, new FriendPhoneNumber()
            { Number = "+37499994499", FriendId = context.Friends.FirstOrDefault().Id }); ;
    }
  }
}
