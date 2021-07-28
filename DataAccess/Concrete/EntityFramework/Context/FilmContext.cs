using DataAccess.Concrete.EntityFramework.Mappings;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class FilmContext:DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options) : base(options)
        {

        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FamousActor> FamousActors { get; set; }
        public DbSet<FilmCategory> FilmAndCategories { get; set; }
        public DbSet<FilmFamousActor> FilmAndFamousActors { get; set; }
        public DbSet<FilmLanguage> FilmAndLanguages { get; set; }
        public DbSet<FilmCountry> FilmCountries { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<ProductionYear> ProductionYears { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new FilmMap());
            modelBuilder.ApplyConfiguration(new FamousActorMap());
            modelBuilder.ApplyConfiguration(new FilmCategoryMap());
            modelBuilder.ApplyConfiguration(new FilmFamousActorMap());
            modelBuilder.ApplyConfiguration(new FilmLanguageMap());
            modelBuilder.ApplyConfiguration(new FilmCountryMap());
            modelBuilder.ApplyConfiguration(new LanguageMap());
            modelBuilder.ApplyConfiguration(new ProductionYearMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
        }
    }
}
