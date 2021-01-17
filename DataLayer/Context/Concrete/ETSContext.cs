using DataLayer.Context.Abstract;
using DataLayer.Mappings;
using DataLayer.Migrations;
using DataLayer.Migrations.Assembly;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Linq;

namespace DataLayer.Context.Concrete
{
    // Add-Migration ETS -o Migrations/ETS -Verbose
    // Update-Database -Verbose

    // Update-Database 0 -Verbose
    // Remove-Migration -Verbose


    public partial class ETSContext : DbContext, IETSContext
    {
        public string Schema
        {
            get
            {
                return "ets";
            }
        }

        public ETSContext(DbContextOptions<ETSContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies(false)
                .UseNpgsql(Configuration.ConnectionString("ETSConnection"), x => x.MigrationsHistoryTable(HistoryRepository.DefaultTableName.ToLowerInvariant(), Schema))
                .ReplaceService<IModelCacheKeyFactory, DbSchemaAwareModelCacheKeyFactory>()
                .ReplaceService<IMigrationsAssembly, DbSchemaAwareMigrationAssembly>();
        }

        public DbSet<PERSON> PERSONS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(Schema);

            modelBuilder.LowerCaseConvention();
            modelBuilder.RemovePluralizingTableNameConvention();

            modelBuilder.ApplyConfiguration(new PersonMapping());

            base.OnModelCreating(modelBuilder);
        }
    }

    public static class ModelBuilderExtensions
    {
        public static void RemovePluralizingTableNameConvention(this ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public static void LowerCaseConvention(this ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetSchema(entity.GetSchema().ToLowerInvariant());
                entity.SetTableName(entity.GetTableName().ToLowerInvariant());

                foreach (IMutableProperty item in entity.GetProperties())
                {
                    item.SetPropertyAccessMode(PropertyAccessMode.Field);
                    item.SetColumnName(item.GetColumnName().ToLowerInvariant());
                    //item.SetColumnType(item.GetColumnType().ToLowerInvariant());
                }


                foreach (IMutableKey item in entity.GetKeys())
                    item.SetName(item.GetName().ToLowerInvariant());

                foreach (IMutableForeignKey item in entity.GetForeignKeys())
                {
                    item.PrincipalKey.SetName(item.PrincipalKey.GetName().ToLowerInvariant());
                    item.SetConstraintName(item.GetConstraintName().ToLowerInvariant());
                }

                foreach (IMutableIndex item in entity.GetIndexes())
                    item.SetName(item.GetName().ToLowerInvariant());

            }
        }
    }
}
