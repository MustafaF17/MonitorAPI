using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MonitorApplication.Model;

namespace MonitorApplication.Data
{
    /// <summary>
    /// Data context class
    /// </summary>
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }


        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MetaData> MetaDatas { get; set; }
        public virtual DbSet<MonitorApp> MonitorApps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            // Creating Metadata table 
            modelBuilder.Entity<MetaData>()
                 .HasKey(x => new { x.Id });

            // Creating Metadata table 
            modelBuilder.Entity<MonitorApp>()
                 .HasKey(x => new { x.Id });



            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
