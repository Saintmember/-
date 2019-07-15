namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DbClient : DbContext
    {
        public DbClient()
            : base("name=DbClient")
        {
        }
         public virtual DbSet<User> Users { get; set; }
    }
}