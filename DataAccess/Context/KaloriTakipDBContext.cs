using DataAccess.Mapping;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class KaloriTakipDBContext : DbContext
    {
        public KaloriTakipDBContext() : base("Server=LAPTOP-E9EUVB10\\MSSQLSERVER2019;Database=KaloriTakipProjesiDB;Uid=sa;Pwd=1234")
        //Server=CERENKALPC;Database=StudentCourseDB;Uid=sa;Pwd=123
        // LAPTOP-E9EUVB10\MSSQLSERVER2019
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<KaloriTakipDBContext>()); // yazmasakda olur
        }

        public DbSet<AktiviteBilgileri> AktiviteBilgileri { get; set; }
        public DbSet<BesinBilgileri> BesinBilgileri { get; set; }
        public DbSet<EgzersizVerisi> EgzersizVerileri { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullniciHedefBilgileri> KullaniciHedefBilgileri { get; set; }
        public DbSet<Makaleler> Makaleler { get; set; }
        public DbSet<MakroBesinRaporu> MakroBesinRaporları { get; set; }
        public DbSet<SuVerisi> SuVerileri { get; set; }
        public DbSet<Tarifler> Tarifler { get; set; }
        public DbSet<TuketilenBesin> TuketilenBesinler { get; set; }
        public DbSet<VucutAnalizi> VucutAnalizleri { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AktiviteBilgileriMapping());
            modelBuilder.Configurations.Add(new BesinBilgileriMapping());
            modelBuilder.Configurations.Add(new EgzersizVerisiMapping());
            modelBuilder.Configurations.Add(new KullaniciHedefBilgileriMapping());
            modelBuilder.Configurations.Add(new KullaniciMapping());
            modelBuilder.Configurations.Add(new MakalelerMapping());
            modelBuilder.Configurations.Add(new MakroBesinRaporuMapping());
            modelBuilder.Configurations.Add(new SuVerisiMapping());
            modelBuilder.Configurations.Add(new TariflerMapping());
            modelBuilder.Configurations.Add(new TuketilenBesinMapping());
            modelBuilder.Configurations.Add(new VucutAnaliziMapping());
        }



    }
}
