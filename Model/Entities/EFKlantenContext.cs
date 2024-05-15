using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class EFKlantenContext:DbContext
    {
        public static IConfigurationRoot configuration;
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Rekening> Rekeningen { get; set; }
        public DbSet<Personeelslid> Personeelsleden { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.FullName)
                .AddJsonFile("appsettings.json", false).Build();

            var connectionString = configuration.GetConnectionString("EFBank");	

            if (connectionString != null)
            {
                optionsBuilder.UseSqlServer(connectionString, options => options.MaxBatchSize(150));
            }
              
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Klant>().HasKey(pk => pk.KlantNr);
            modelBuilder.Entity<Klant>().Property(pk => pk.KlantNr).ValueGeneratedOnAdd();


            modelBuilder.Entity<Rekening>().HasKey(pk => pk.RekeningNr);
            modelBuilder.Entity<Rekening>().Property(s => s.Saldo).HasPrecision(18, 2);

            modelBuilder.Entity<Personeelslid>().HasKey(pk => pk.PersoneelsNr);
            modelBuilder.Entity<Personeelslid>().Property(pk => pk.Voornaam).HasMaxLength(50);

            #region KlantSeed
            modelBuilder.Entity<Klant>().HasData(

                  new Klant
                  {
                      KlantNr = 1,
                      Voornaam = "Marge"
                  },
                  new Klant
                  {
                      KlantNr = 2,
                      Voornaam = "Homer"
                  },
                  new Klant
                  {
                      KlantNr = 3,
                      Voornaam = "Lisa"
                  },
                  new Klant
                  {
                      KlantNr = 4,
                      Voornaam = "Maggie"
                  },
                  new Klant
                  {
                      KlantNr = 5,
                      Voornaam = "Bart"
                  }

                  );
            #endregion

            #region RekeningSeed
            modelBuilder.Entity<Rekening>().HasData(

                   new Rekening
                   {
                       KlantNr = 1,
                       Saldo = 1000,
                       Soort = 'Z',
                       RekeningNr = "123-4567890-02"
                   },
                   new Rekening
                   {
                       KlantNr = 1,
                       Saldo = 2000,
                       Soort = 'S',
                       RekeningNr = "234-5678901-69"
                   },
                   new Rekening
                   {
                       KlantNr = 2,
                       Saldo = 500,
                       Soort = 'S',
                       RekeningNr = "345-6789012-12"
                   }
                   );
            #endregion

            var Personeel = new List<Personeelslid>
            {
                new Personeelslid
                {
                    PersoneelsNr = 1,
                    Voornaam = "Diane"
                },

                new Personeelslid
                {
                    PersoneelsNr = 2,
                    Voornaam = "Mary",
                    ManagerNr = 1
                },

                new Personeelslid
                {
                    PersoneelsNr = 3,
                    Voornaam = "Jeff",
                    ManagerNr = 1
                },

                new Personeelslid
                {
                    PersoneelsNr = 4,
                    Voornaam = "William",
                    ManagerNr = 2
                },

                new Personeelslid
                {
                    PersoneelsNr = 5,
                    Voornaam = "Gerard",
                    ManagerNr = 2
                },

                new Personeelslid
                {
                    PersoneelsNr = 6,
                    Voornaam = "Anthony",
                    ManagerNr = 2
                },

                new Personeelslid
                {
                    PersoneelsNr = 7,
                    Voornaam = "Leslie",
                    ManagerNr = 6
                },

                new Personeelslid
                {
                    PersoneelsNr = 8,
                    Voornaam = "July",
                    ManagerNr = 6
                },

                new Personeelslid
                {
                    PersoneelsNr = 9,
                    Voornaam = "Steve",
                    ManagerNr = 6
                },

                new Personeelslid
                {
                    PersoneelsNr = 10,
                    Voornaam = "Foon Yue",
                    ManagerNr = 6
                },

                new Personeelslid
                {
                    PersoneelsNr = 11,
                    Voornaam = "George",
                    ManagerNr = 6
                },

                new Personeelslid
                {
                    PersoneelsNr = 12,
                    Voornaam = "Louj",
                    ManagerNr = 5
                },

                new Personeelslid
                {
                    PersoneelsNr = 13,
                    Voornaam = "Pamela",
                    ManagerNr = 5
                },

                new Personeelslid
                {
                    PersoneelsNr = 14,
                    Voornaam = "Larry",
                    ManagerNr = 5
                },

                new Personeelslid
                {
                    PersoneelsNr = 15,
                    Voornaam = "Barry",
                    ManagerNr = 5
                },

                new Personeelslid
                {
                    PersoneelsNr = 16,
                    Voornaam = "Any",
                    ManagerNr = 4
                },

                new Personeelslid
                {
                    PersoneelsNr = 17,
                    Voornaam = "Peter",
                    ManagerNr = 4
                },

                new Personeelslid
                {
                    PersoneelsNr = 18,
                    Voornaam = "Tom",
                    ManagerNr = 4
                },

                new Personeelslid
                {
                    PersoneelsNr = 19,
                    Voornaam = "Mami",
                    ManagerNr = 2
                },

                new Personeelslid
                {
                    PersoneelsNr = 20,
                    Voornaam = "Yoshimi",
                    ManagerNr = 19
                },

                new Personeelslid
                {
                    PersoneelsNr = 21,
                    Voornaam = "Matin",
                    ManagerNr = 5
                },
            };

            modelBuilder.Entity<Personeelslid>().HasData(Personeel);
        }
    }
}

