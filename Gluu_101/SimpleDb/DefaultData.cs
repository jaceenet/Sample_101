namespace Gluu_101.SimpleDb
{
    using System.Data.Entity;

    public class DefaultData : CreateDatabaseIfNotExists<GluuSimpleDb>
    {
        protected override void Seed(GluuSimpleDb context)
        {
            base.Seed(context);
            context.Users.Add(new User() { Email = "some@email.com", Username = "demo" });
            context.SaveChanges();
        }
    }
}