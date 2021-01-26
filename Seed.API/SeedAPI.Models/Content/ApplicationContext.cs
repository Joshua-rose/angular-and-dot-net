using System;
using System.Collections.Generic;
using System.Text;

namespace SeedAPI.Models.Content
{
    class ApplicationContext : IdentityDbContext<User>, IApplicationContext
    {
        private IDbContextTransaction dbContextTransaction;
        public ApplicationContext(DBContextOptions options) : base(options)
        {
            public DbSet<User> UsersDB { get; set; }

            public new void SaveChanges()
            {
            base.saveChanges();
            }
        public new DbSet<T> Set<T>() where T: class
        {
            return base.Set<T>();
        }
        public void CommitTransaction()
        {
            if(dbContextTransaction != null)
            {
                dbContextTransaction.Commit();
            }
        }
        public void RollbackTransaction()
        {
            if (dbContextTransaction != null)
            {
                dbContextTransaction.Rollback();
            }
        }
        public void DisploseTransaction()
        {
            if(dbContextTransaction != null)
            {
                dbContextTransaction.Dispose();
            }
        }
        }
    }
}
