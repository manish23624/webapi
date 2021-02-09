namespace RCMSWebAPI.Models
{
    using DataViewModel;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SECURITY_DBEntities : DbContext
    {
        // Your context has been configured to use a 'SECURITY_DBEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'RCMSWebAPI.Models.SECURITY_DBEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SECURITY_DBEntities' 
        // connection string in the application configuration file.
        public SECURITY_DBEntities()
            : base("name=Con")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<UserMaster> UserMasters { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserMaster>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserMaster>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<UserMaster>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<UserMaster>()
                .Property(e => e.Flag)
                .IsUnicode(false);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}