namespace DataAccess.Migrations
{
    using Entities.Concrete;
    using Entities.Enums;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.Context.KaloriTakipDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataAccess.Context.KaloriTakipDBContext context)
        {
            //BALIKLAR VE DENİZ ÜRÜNLERİ

        

            EgzersizVerisi GucAntreman = new EgzersizVerisi() { Egzersiz = Egzersiz.GucAntremani, KaloriDegeri = 5, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(GucAntreman);

            EgzersizVerisi yuruyus = new EgzersizVerisi() { Egzersiz = Egzersiz.Yuruyus, KaloriDegeri = 4, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(yuruyus);

            EgzersizVerisi bisileteBinme = new EgzersizVerisi() { Egzersiz = Egzersiz.BisikleteBinme, KaloriDegeri = 3, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(bisileteBinme);


            EgzersizVerisi kosu = new EgzersizVerisi() { Egzersiz = Egzersiz.Kosu, KaloriDegeri = 6, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(kosu);

            EgzersizVerisi kondisyonBisikleti = new EgzersizVerisi() { Egzersiz = Egzersiz.KondisyonBisikleti, KaloriDegeri = 4, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(kondisyonBisikleti);

            EgzersizVerisi yoga = new EgzersizVerisi() { Egzersiz = Egzersiz.Yoga, KaloriDegeri = 2, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(yoga);

            EgzersizVerisi yuzme = new EgzersizVerisi() { Egzersiz = Egzersiz.Yuzme, KaloriDegeri = 5, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(yuzme);

            EgzersizVerisi boks = new EgzersizVerisi() { Egzersiz = Egzersiz.Boks, KaloriDegeri = 6, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(boks);

            EgzersizVerisi daireselAntreman = new EgzersizVerisi() { Egzersiz = Egzersiz.DaireselAntreman, KaloriDegeri = 4, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(daireselAntreman);


            EgzersizVerisi dans = new EgzersizVerisi() { Egzersiz = Egzersiz.DansEtmek, KaloriDegeri = 6, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(dans);


            EgzersizVerisi evdeYapilanEgzersiz = new EgzersizVerisi() { Egzersiz = Egzersiz.EvdeYapilanEgzersiz, KaloriDegeri = 3, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(evdeYapilanEgzersiz);

            EgzersizVerisi fonksiyonel = new EgzersizVerisi() { Egzersiz = Egzersiz.FonskiyonelAntreman, KaloriDegeri = 8, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(fonksiyonel);


            EgzersizVerisi futbol = new EgzersizVerisi() { Egzersiz = Egzersiz.Futbol, KaloriDegeri = 6, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(futbol);

            EgzersizVerisi kickboks = new EgzersizVerisi() { Egzersiz = Egzersiz.KickBoks, KaloriDegeri = 4, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(kickboks);

            EgzersizVerisi kurek = new EgzersizVerisi() { Egzersiz = Egzersiz.Kurek, KaloriDegeri = 2, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(kurek);


            EgzersizVerisi voleybol = new EgzersizVerisi() { Egzersiz = Egzersiz.Voleybol, KaloriDegeri = 4, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(voleybol);

            EgzersizVerisi basketbol = new EgzersizVerisi() { Egzersiz = Egzersiz.Basketbol, KaloriDegeri = 5, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(basketbol);

            EgzersizVerisi jim = new EgzersizVerisi() { Egzersiz = Egzersiz.Jimnastik, KaloriDegeri = 3, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(jim);

            EgzersizVerisi zumba = new EgzersizVerisi() { Egzersiz = Egzersiz.Zumba, KaloriDegeri = 5, CreatedBy = "Tuba" };
            context.EgzersizVerileri.Add(zumba);




        }
    }
}
