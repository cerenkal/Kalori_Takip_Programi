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
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.



            //BALIKLAR VE DENİZ ÜRÜNLERİ

            BesinBilgileri somon = new BesinBilgileri() { BesinAdi = "Somon", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.08F, Karbonhidrat = 0, Protein = 0.19F, Yag = 0.13F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(somon);

            BesinBilgileri ahtapot = new BesinBilgileri() { BesinAdi = "Ahtapot", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.73F, Karbonhidrat = 0.01F, Protein = 0.15F, Yag = 0.08F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(ahtapot);

            BesinBilgileri alabalik = new BesinBilgileri() { BesinAdi = "Alabalık", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.01F, Karbonhidrat = 0, Protein = 0.19F, Yag = 0.02F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(alabalik);

            BesinBilgileri barbun = new BesinBilgileri() { BesinAdi = "Barbun", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.2F, Karbonhidrat = 0, Protein = 0.16F, Yag = 0.06F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(barbun);

            BesinBilgileri cipura = new BesinBilgileri() { BesinAdi = "Çipura", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.2F, Karbonhidrat = 0, Protein = 0.16F, Yag = 0.06F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(cipura);

            BesinBilgileri dilBaligi = new BesinBilgileri() { BesinAdi = "Dil Balığı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.79F, Karbonhidrat = 0, Protein = 0.19F, Yag = 0, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(dilBaligi);

            BesinBilgileri hamsiIzgara = new BesinBilgileri() { BesinAdi = "Izgara Hamsi", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2F, Karbonhidrat = 0.05F, Protein = 0.19F, Yag = 0.1F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(hamsiIzgara);

            BesinBilgileri hamsiKizartma = new BesinBilgileri() { BesinAdi = "Kızartma Hamsi", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.15F, Yag = 0.05F, Karbonhidrat = 0, Protein = 0.17F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(hamsiKizartma);

            BesinBilgileri havyar = new BesinBilgileri() { BesinAdi = "Havyar", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.62F, Karbonhidrat = 0.03F, Protein = 0.26F, Yag = 0.15F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(havyar);

            BesinBilgileri istakoz = new BesinBilgileri() { BesinAdi = "Istakoz", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.91F, Karbonhidrat = 0F, Protein = 0.17F, Yag = 0.02F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(istakoz);

            BesinBilgileri istavrit = new BesinBilgileri() { BesinAdi = "İstavrit", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.81F, Karbonhidrat = 0F, Protein = 0.17F, Yag = 0.01F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(istavrit);

            BesinBilgileri istiridye = new BesinBilgileri() { BesinAdi = "İstiridye", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.68F, Karbonhidrat = 0F, Protein = 0.09F, Yag = 0.01F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(istiridye);

            BesinBilgileri izmarit = new BesinBilgileri() { BesinAdi = "İzmarit", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.53F, Karbonhidrat = 0F, Protein = 0.23F, Yag = 0.06F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(izmarit);

            BesinBilgileri kalkan = new BesinBilgileri() { BesinAdi = "Kalkan Balığı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.35F, Karbonhidrat = 0F, Protein = 0.20F, Yag = 0.06F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(kalkan);

            BesinBilgileri karidesGuvec = new BesinBilgileri() { BesinAdi = "Karides Güveç", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.25F, Karbonhidrat = 0.02F, Protein = 0.16F, Yag = 0.07F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(karidesGuvec);

            BesinBilgileri tereyagdaKarides = new BesinBilgileri() { BesinAdi = "Tereyağda Karides", OlcuBirimi = OlcuBirimi.Gram, Kalori = 3.19F, Karbonhidrat = 0F, Protein = 0.16F, Yag = 0.29F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(tereyagdaKarides);

            BesinBilgileri kefal = new BesinBilgileri() { BesinAdi = "Kefal Balığı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.73F, Karbonhidrat = 0F, Protein = 0.19F, Yag = 0, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(kefal);

            BesinBilgileri kilic = new BesinBilgileri() { BesinAdi = "Kılıç Balığı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.53F, Karbonhidrat = 0F, Protein = 0.23F, Yag = 0.06F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(kilic);

            BesinBilgileri levrek = new BesinBilgileri() { BesinAdi = "İzmarit", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.86F, Karbonhidrat = 0F, Protein = 0.18F, Yag = 0, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(levrek);

            BesinBilgileri lufer = new BesinBilgileri() { BesinAdi = "Lüfer", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.37F, Karbonhidrat = 0F, Protein = 0.16F, Yag = 0.09F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(lufer);

            BesinBilgileri mezgit = new BesinBilgileri() { BesinAdi = "Mezgit", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.82F, Karbonhidrat = 0F, Protein = 0.18F, Yag = 0.06F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(mezgit);

            BesinBilgileri midyeDolma = new BesinBilgileri() { BesinAdi = "Midye Dolma", OlcuBirimi = OlcuBirimi.Adet, Kalori = 26F, Karbonhidrat = 3.08F, Protein = 1.62F, Yag = 0.71F, GramKarsiligi = 30, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(midyeDolma);

            BesinBilgileri midyeTava = new BesinBilgileri() { BesinAdi = "Midye Tava", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2F, Karbonhidrat = 0.08F, Protein = 0.09F, Yag = 0.10F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(midyeTava);

            BesinBilgileri palamut = new BesinBilgileri() { BesinAdi = "Palamut", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.51F, Karbonhidrat = 0F, Protein = 0.19F, Yag = 0.07F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(palamut);

            BesinBilgileri sardalya = new BesinBilgileri() { BesinAdi = "Sardalya", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.60F, Karbonhidrat = 0F, Protein = 0.15F, Yag = 0.09F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(sardalya);

            BesinBilgileri sazan = new BesinBilgileri() { BesinAdi = "Sazan", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.45F, Karbonhidrat = 0F, Protein = 0.19F, Yag = 0.07F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(sazan);

            BesinBilgileri denizTaragi = new BesinBilgileri() { BesinAdi = "Deniz Tarağı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.70F, Karbonhidrat = 0F, Protein = 0.10F, Yag = 0.01F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(denizTaragi);

            BesinBilgileri tekir = new BesinBilgileri() { BesinAdi = "Tekir", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.51F, Yag = 0.04F, Karbonhidrat = 0F, Protein = 0.25F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(tekir);

            BesinBilgileri ton = new BesinBilgileri() { BesinAdi = "Ton Balığı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.90F, Karbonhidrat = 0F, Protein = 0.25F, Yag = 0.21F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(ton);

            BesinBilgileri uskumru = new BesinBilgileri() { BesinAdi = "İzmarit", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.91F, Karbonhidrat = 0F, Protein = 0.19F, Yag = 0.12F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(uskumru);

            BesinBilgileri yengec = new BesinBilgileri() { BesinAdi = "İzmarit", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.01F, Karbonhidrat = 0F, Protein = 0.19F, Yag = 0.18F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(yengec);

            BesinBilgileri susi = new BesinBilgileri() { BesinAdi = "Suşi", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 125F, Karbonhidrat = 12.42F, Protein = 3.04F, Yag = 7.15F, GramKarsiligi = 155, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(susi);

            //BEYAZ ET URUNLERİ

            BesinBilgileri HaslanmisTavukGogsu = new BesinBilgileri() { BesinAdi = "Haşlanmış Tavuk Göğsü", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.97F, Karbonhidrat = 0F, Protein = 0.30F, Yag = 0.08F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(HaslanmisTavukGogsu);

            BesinBilgileri PismisTavukEti = new BesinBilgileri() { BesinAdi = "Pişmiş Tavuk Eti", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.20F, Yag = 0.12F, Karbonhidrat = 0F, Protein = 0.25F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(PismisTavukEti);

            BesinBilgileri KizarmisKanat = new BesinBilgileri() { BesinAdi = "Kızarmış Tavuk Kanadı", OlcuBirimi = OlcuBirimi.Adet, Kalori = 69F, Karbonhidrat = 0.50F, Protein = 5.85F, Yag = 4.92F, GramKarsiligi = 30, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(KizarmisKanat);

            BesinBilgileri KizarmisBut = new BesinBilgileri()
            {
                BesinAdi = "Kızarmış Tavuk But",
                OlcuBirimi = OlcuBirimi.Gram,
                Kalori = 300F,
                Karbonhidrat = 0.76F,
                Protein = 13.8F,
                Yag = 26.65F,
                GramKarsiligi = 80,
                CreatedBy = "Ayşe"
            };

            context.BesinBilgileri.Add(KizarmisBut);

            BesinBilgileri HaslanmisBut = new BesinBilgileri() { BesinAdi = "Haşlanmış Tavuk But", OlcuBirimi = OlcuBirimi.Gram, Kalori = 117F, Karbonhidrat = 4.38F, Protein = 7.96F, GramKarsiligi = 80, Yag = 7.17F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(HaslanmisBut);

            BesinBilgileri TavukKoftesi = new BesinBilgileri() { BesinAdi = "Tavuk Köftesi", OlcuBirimi = OlcuBirimi.Adet, Kalori = 46F, Karbonhidrat = 2.25F, Protein = 4.13F, GramKarsiligi = 30, Yag = 2.25F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(TavukKoftesi);

            BesinBilgileri TavukCigeri = new BesinBilgileri() { BesinAdi = "Tavuk Ciğeri", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.72F, Karbonhidrat = 0.01F, Protein = 026F, Yag = 0.06F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(TavukCigeri);

            BesinBilgileri TavukluPilav = new BesinBilgileri() { BesinAdi = "Tavuklu Pilav", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 336F, Karbonhidrat = 46.77F, Protein = 15.90F, Yag = 9.03F, GramKarsiligi = 220, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(TavukluPilav);

            BesinBilgileri TavukNugget = new BesinBilgileri() { BesinAdi = "Tavuk Nugget", OlcuBirimi = OlcuBirimi.Adet, Kalori = 121F, Karbonhidrat = 2.7F, Protein = 7.2F, Yag = 9F, GramKarsiligi = 45, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(TavukNugget);

            BesinBilgileri EkmekAraTavukDoner = new BesinBilgileri() { BesinAdi = "Ekmek Arası Tavuk Döner", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 309F, Karbonhidrat = 15.13F, Protein = 43.10F, Yag = 36.37F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(EkmekAraTavukDoner);

            BesinBilgileri KoriSosluTavuk = new BesinBilgileri() { BesinAdi = "Ekmek Arası Tavuk Döner", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 243F, Karbonhidrat = 8.92F, Protein = 31.95F, Yag = 7.9F, GramKarsiligi = 170, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(KoriSosluTavuk);

            BesinBilgileri TavukSote = new BesinBilgileri() { BesinAdi = "Tavuk Sote", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 309F, Karbonhidrat = 15.13F, Protein = 43.10F, Yag = 36.37F, GramKarsiligi = 250, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(TavukSote);

            //MEYVELER

            BesinBilgileri Elma = new BesinBilgileri() { BesinAdi = "Elma", OlcuBirimi = OlcuBirimi.Adet, Kalori = 95F, Karbonhidrat = 25.13F, Protein = 0.47F, Yag = 0.31F, GramKarsiligi = 180, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Elma);

            BesinBilgileri Armut = new BesinBilgileri() { BesinAdi = "Elma", OlcuBirimi = OlcuBirimi.Adet, Kalori = 101F, Karbonhidrat = 27.11F, Protein = 0.64F, Yag = 0.25F, GramKarsiligi = 178, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Armut);

            BesinBilgileri Portakal = new BesinBilgileri() { BesinAdi = "Portakal", OlcuBirimi = OlcuBirimi.Adet, Kalori = 62F, Karbonhidrat = 15.40F, Protein = 1.25F, Yag = 0.16F, GramKarsiligi = 130, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Portakal);

            BesinBilgileri Greyfurt = new BesinBilgileri() { BesinAdi = "Greyfurt", OlcuBirimi = OlcuBirimi.Adet, Kalori = 74F, Karbonhidrat = 18.45F, Protein = 1.35F, Yag = 0.25F, GramKarsiligi = 245, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Greyfurt);

            BesinBilgileri Ayva = new BesinBilgileri() { BesinAdi = "Elma", OlcuBirimi = OlcuBirimi.Adet, Kalori = 57F, Karbonhidrat = 15.30F, Protein = 0.40F, Yag = 0.10F, GramKarsiligi = 250, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Ayva);

            BesinBilgileri Mandalina = new BesinBilgileri() { BesinAdi = "Mandalina", OlcuBirimi = OlcuBirimi.Adet, Kalori = 40F, Karbonhidrat = 10.15F, Protein = 0.60F, Yag = 0.25F, GramKarsiligi = 75, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Mandalina);

            BesinBilgileri Kivi = new BesinBilgileri() { BesinAdi = "Kivi", OlcuBirimi = OlcuBirimi.Adet, Kalori = 42F, Karbonhidrat = 10.10F, Protein = 0.62F, Yag = 0.25F, GramKarsiligi = 69, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Kivi);

            BesinBilgileri Muz = new BesinBilgileri() { BesinAdi = "Muz", OlcuBirimi = OlcuBirimi.Adet, Kalori = 105F, Karbonhidrat = 27F, Protein = 1.30F, Yag = 0.40F, GramKarsiligi = 118, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Muz);

            BesinBilgileri Kayisi = new BesinBilgileri() { BesinAdi = "Kayısı", OlcuBirimi = OlcuBirimi.Adet, Kalori = 17F, Karbonhidrat = 3.90F, Protein = 0.50F, Yag = 0.15F, GramKarsiligi = 35, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Kayisi);

            BesinBilgileri Cilek = new BesinBilgileri() { BesinAdi = "Çilek", OlcuBirimi = OlcuBirimi.Kase, Kalori = 46F, Karbonhidrat = 11F, Protein = 0.95F, Yag = 0.45F, GramKarsiligi = 144, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Cilek);

            BesinBilgileri TrabzonHurmasi = new BesinBilgileri() { BesinAdi = "Trabzon Hurması", OlcuBirimi = OlcuBirimi.Adet, Kalori = 60F, Karbonhidrat = 16F, Protein = 0.50F, Yag = 0.17F, GramKarsiligi = 80, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(TrabzonHurmasi);

            BesinBilgileri Kiraz = new BesinBilgileri() { BesinAdi = "Kiraz", OlcuBirimi = OlcuBirimi.Kase, Kalori = 87F, Karbonhidrat = 22.10F, Protein = 1.45F, Yag = 0.30F, GramKarsiligi = 138, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Kiraz);

            BesinBilgileri Visne = new BesinBilgileri() { BesinAdi = "Vişne", OlcuBirimi = OlcuBirimi.Kase, Kalori = 52F, Karbonhidrat = 13F, Protein = 1.03F, Yag = 0.30F, GramKarsiligi = 250, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Visne);

            BesinBilgileri Kavun = new BesinBilgileri() { BesinAdi = "Kavun", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 54F, Karbonhidrat = 13.05F, Protein = 1.35F, Yag = 0.30F, GramKarsiligi = 150, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Kavun);

            BesinBilgileri Karpuz = new BesinBilgileri() { BesinAdi = "Karpuz", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 46F, Karbonhidrat = 15.13F, Protein = 43.10F, Yag = 36.37F, GramKarsiligi = 150, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Karpuz);

            BesinBilgileri Ananas = new BesinBilgileri() { BesinAdi = "Ananas", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 28F, Karbonhidrat = 7.35F, Protein = 0.30F, Yag = 0.07F, GramKarsiligi = 56, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Ananas);


            BesinBilgileri Avakado = new BesinBilgileri() { BesinAdi = "Avakado", OlcuBirimi = OlcuBirimi.Adet, Kalori = 160F, Karbonhidrat = 8.5F, Protein = 2.0F, Yag = 14.7F, GramKarsiligi = 100, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Avakado);

            BesinBilgileri Mango = new BesinBilgileri() { BesinAdi = "Mango", OlcuBirimi = OlcuBirimi.Adet, Kalori = 100F, Karbonhidrat = 24.70F, Protein = 1.35F, Yag = 0.63F, GramKarsiligi = 165, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Mango);

            BesinBilgileri Ahududu = new BesinBilgileri() { BesinAdi = "Ahududu", OlcuBirimi = OlcuBirimi.Kase, Kalori = 64F, Karbonhidrat = 14.70F, Protein = 1.5F, Yag = 0.80F, GramKarsiligi = 125, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Ahududu);

            BesinBilgileri Bogurtlen = new BesinBilgileri() { BesinAdi = "Böğürtlen", OlcuBirimi = OlcuBirimi.Kase, Kalori = 62F, Karbonhidrat = 13.80F, Protein = 1.5F, Yag = 0.80F, GramKarsiligi = 100, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Bogurtlen);

            BesinBilgileri YesilErik = new BesinBilgileri() { BesinAdi = "Yeşil Erik", OlcuBirimi = OlcuBirimi.Kase, Kalori = 76F, Karbonhidrat = 18.85F, Protein = 1.15F, Yag = 0.5F, GramKarsiligi = 165, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(YesilErik);

            BesinBilgileri Incir = new BesinBilgileri() { BesinAdi = "İncir", OlcuBirimi = OlcuBirimi.Adet, Kalori = 37F, Karbonhidrat = 9.35F, Protein = 0.4F, Yag = 0.15F, GramKarsiligi = 50, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Incir);

            BesinBilgileri Dut = new BesinBilgileri() { BesinAdi = "Dut", OlcuBirimi = OlcuBirimi.Kase, Kalori = 60F, Karbonhidrat = 13.70F, Protein = 2F, Yag = 0.55F, GramKarsiligi = 140, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Dut);

            BesinBilgileri Uzum = new BesinBilgileri() { BesinAdi = "Üzüm", OlcuBirimi = OlcuBirimi.Kase, Kalori = 104F, Karbonhidrat = 27.3F, Protein = 1.1F, Yag = 0.25F, GramKarsiligi = 150, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Uzum);

            BesinBilgileri Nar = new BesinBilgileri() { BesinAdi = "Nar", OlcuBirimi = OlcuBirimi.Kase, Kalori = 145F, Karbonhidrat = 33F, Protein = 3F, Yag = 2F, GramKarsiligi = 170, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Nar);

            BesinBilgileri Seftali = new BesinBilgileri() { BesinAdi = "Şeftali", OlcuBirimi = OlcuBirimi.Adet, Kalori = 60F, Karbonhidrat = 14.30F, Protein = 1.36F, Yag = 0.38F, GramKarsiligi = 150, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Seftali);

            BesinBilgileri Limon = new BesinBilgileri() { BesinAdi = "Limon", OlcuBirimi = OlcuBirimi.Adet, Kalori = 17F, Karbonhidrat = 5.4F, Protein = 0.65F, Yag = 0.17F, GramKarsiligi = 58, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Limon);

            BesinBilgileri KirmiziErik = new BesinBilgileri() { BesinAdi = "Kırmızı Erik", OlcuBirimi = OlcuBirimi.Kase, Kalori = 80F, Karbonhidrat = 21F, Protein = 1F, Yag = 0.15F, GramKarsiligi = 135, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(KirmiziErik);

            // SÜTLÜ TATLILAR

            BesinBilgileri Sutlac = new BesinBilgileri() { BesinAdi = "Sütlaç", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 133F, Karbonhidrat = 21.9F, Protein = 4F, Yag = 3F, GramKarsiligi = 115, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Sutlac);

            BesinBilgileri Kazandibi = new BesinBilgileri() { BesinAdi = "Kazandibi", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 294F, Karbonhidrat = 47.9F, Protein = 5.7F, Yag = 8F, GramKarsiligi = 180, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Kazandibi);

            BesinBilgileri Magnolia = new BesinBilgileri() { BesinAdi = "Magnolia", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 300F, Karbonhidrat = 50F, Protein = 3.5F, Yag = 7.2F, GramKarsiligi = 125, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Magnolia);

            BesinBilgileri Tiramisu = new BesinBilgileri() { BesinAdi = "Tiramisu", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 380F, Karbonhidrat = 56.80F, Protein = 9.25F, Yag = 11.2F, GramKarsiligi = 170, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Tiramisu);

            BesinBilgileri Cheesecake = new BesinBilgileri() { BesinAdi = "Cheesecake", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 510F, Karbonhidrat = 62F, Protein = 9.75F, Yag = 23.47F, GramKarsiligi = 150, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Cheesecake);

            BesinBilgileri Gullac = new BesinBilgileri() { BesinAdi = "Güllaç", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 143F, Karbonhidrat = 21.7F, Protein = 2.55F, Yag = 4.83F, GramKarsiligi = 110, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Gullac);

            BesinBilgileri TavukGogsuTatli = new BesinBilgileri() { BesinAdi = "Tavuk Göğsü Tatlısı", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 165F, Karbonhidrat = 31.1F, Protein = 6.25F, Yag = 0.2F, GramKarsiligi = 210, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(TavukGogsuTatli);

            BesinBilgileri Muhallebi = new BesinBilgileri() { BesinAdi = "Muhallebi", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 233F, Karbonhidrat = 38.18F, Protein = 4.7F, Yag = 4.60F, GramKarsiligi = 150, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Muhallebi);

            BesinBilgileri Puding = new BesinBilgileri() { BesinAdi = "Puding", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 132F, Karbonhidrat = 16.63F, Protein = 7.45F, Yag = 3.8F, GramKarsiligi = 200, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Puding);

            BesinBilgileri Supangle = new BesinBilgileri() { BesinAdi = "Supangle", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 160F, Karbonhidrat = 19F, Protein = 4.52F, Yag = 6.63F, GramKarsiligi = 130, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Supangle);

            BesinBilgileri Trilece = new BesinBilgileri() { BesinAdi = "Trileçe", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 301F, Karbonhidrat = 39F, Protein = 12.85F, Yag = 9.25F, GramKarsiligi = 185, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Trilece);

            BesinBilgileri Hosmerim = new BesinBilgileri() { BesinAdi = "Höşmerim", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 343F, Karbonhidrat = 111F, Protein = 17F, Yag = 10.8F, GramKarsiligi = 120, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Hosmerim);

            BesinBilgileri Keskul = new BesinBilgileri() { BesinAdi = "Keşkül", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 273F, Karbonhidrat = 42.55F, Protein = 7.3F, Yag = 7.7F, GramKarsiligi = 250, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Keskul);

            BesinBilgileri Asure = new BesinBilgileri() { BesinAdi = "Aşure", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 344F, Karbonhidrat = 61.21F, Protein = 7.84F, Yag = 5.5F, GramKarsiligi = 110, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Asure);

            BesinBilgileri Profiterol = new BesinBilgileri() { BesinAdi = "Profiterol", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 429F, Karbonhidrat = 55.8F, Protein = 5.8F, Yag = 19.3F, GramKarsiligi = 180, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Profiterol);

            BesinBilgileri MeyveliDondurma = new BesinBilgileri() { BesinAdi = "Meyveli Dondurma", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 99F, Karbonhidrat = 21.05F, Protein = 0.97F, Yag = 1.02F, GramKarsiligi = 75, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(MeyveliDondurma);

            BesinBilgileri SutluDondurma = new BesinBilgileri() { BesinAdi = "Sütlü Dondurma", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 240F, Karbonhidrat = 30.75F, Protein = 9F, Yag = 9F, GramKarsiligi = 150, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(SutluDondurma);

            BesinBilgileri CikolataliDondurma = new BesinBilgileri() { BesinAdi = "Çikolatalı Dondurma", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 216F, Karbonhidrat = 28.2F, Protein = 3.8F, Yag = 11F, GramKarsiligi = 100, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(CikolataliDondurma);

            BesinBilgileri IrmikTatlisi = new BesinBilgileri() { BesinAdi = "Sütlü İrmik Tatlısı", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 262F, Karbonhidrat = 43.15F, Protein = 7F, Yag = 5F, GramKarsiligi = 170, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(IrmikTatlisi);

            BesinBilgileri IrmikHelvasi = new BesinBilgileri() { BesinAdi = "İrmik Helvası", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 532F, Karbonhidrat = 64.9F, Protein = 7.77F, Yag = 25.20F, GramKarsiligi = 100, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(IrmikHelvasi);

            BesinBilgileri UnHelvasi = new BesinBilgileri() { BesinAdi = "Un Helvası", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 294F, Karbonhidrat = 43.5F, Protein = 0.12F, Yag = 12.18F, GramKarsiligi = 90, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(UnHelvasi);

            //ŞERBETLİ TATLILAR 

            BesinBilgileri Baklava = new BesinBilgileri() { BesinAdi = "Baklava", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 660F, Karbonhidrat = 79F, Protein = 12.36F, Yag = 34.35F, GramKarsiligi = 160, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Baklava);

            BesinBilgileri Kadayif = new BesinBilgileri() { BesinAdi = "Kadayıf", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 422F, Karbonhidrat = 51.75F, Protein = 6.85F, Yag = 22.55F, GramKarsiligi = 145, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Kadayif);

            BesinBilgileri SogukBaklava = new BesinBilgileri() { BesinAdi = "Soğuk Baklava", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 242F, Karbonhidrat = 34.45F, Protein = 3.3F, Yag = 14.75F, GramKarsiligi = 82, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(SogukBaklava);

            BesinBilgileri Tulumba = new BesinBilgileri() { BesinAdi = "Tulumba", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 256F, Karbonhidrat = 40.7F, Protein = 2.51F, Yag = 7.25F, GramKarsiligi = 90, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Tulumba);

            BesinBilgileri Kemalpasa = new BesinBilgileri() { BesinAdi = "Kemalpaşa", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 476F, Karbonhidrat = 84.4F, Protein = 16.6F, Yag = 13.55F, GramKarsiligi = 285, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Kemalpasa);

            BesinBilgileri HalkaTatlisi = new BesinBilgileri() { BesinAdi = "Halka Tatlısı", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 673F, Karbonhidrat = 66.75F, Protein = 5F, Yag = 40.6F, GramKarsiligi = 215, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(HalkaTatlisi);

            BesinBilgileri SamTatlisi = new BesinBilgileri() { BesinAdi = "Şam Tatlısı", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 330F, Karbonhidrat = 150.75F, Protein = 18.88F, Yag = 0.94F, GramKarsiligi = 90, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(SamTatlisi);

            BesinBilgileri Sobiyet = new BesinBilgileri() { BesinAdi = "Şöbiyet", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 522F, Karbonhidrat = 59.76F, Protein = 5.95F, Yag = 29.15F, GramKarsiligi = 160, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Sobiyet);

            BesinBilgileri Kunefe = new BesinBilgileri() { BesinAdi = "Künefe", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 426F, Karbonhidrat = 55F, Protein = 7.36F, Yag = 20.52F, GramKarsiligi = 120, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Kunefe);

            BesinBilgileri Sekerpare = new BesinBilgileri() { BesinAdi = "Şekerpare", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 272F, Karbonhidrat = 45.95F, Protein = 2.65F, Yag = 8.95F, GramKarsiligi = 100, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Sekerpare);

            BesinBilgileri Revani = new BesinBilgileri() { BesinAdi = "Revani", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 348F, Karbonhidrat = 55F, Protein = 5.82F, Yag = 9.4F, GramKarsiligi = 100, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Revani);

            BesinBilgileri LokmaTatlisi = new BesinBilgileri() { BesinAdi = "Lokma Tatlısı", OlcuBirimi = OlcuBirimi.Adet, Kalori = 78F, Karbonhidrat = 7.52F, Protein = 0.35F, Yag = 4.82F, GramKarsiligi = 15, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(LokmaTatlisi);

            BesinBilgileri Kalburabasti = new BesinBilgileri() { BesinAdi = "Kalburabastı", OlcuBirimi = OlcuBirimi.Adet, Kalori = 251F, Karbonhidrat = 34.38F, Protein = 4F, Yag = 11.33F, GramKarsiligi = 85, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Kalburabasti);

            BesinBilgileri FistikliSarma = new BesinBilgileri() { BesinAdi = "Fıstıklı Sarma Tatlısı", OlcuBirimi = OlcuBirimi.Adet, Kalori = 210F, Karbonhidrat = 20.95F, Protein = 3.71F, Yag = 12.08F, GramKarsiligi = 50, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(FistikliSarma);

            BesinBilgileri DilberDudagi = new BesinBilgileri() { BesinAdi = "Un Helvası", OlcuBirimi = OlcuBirimi.Adet, Kalori = 99F, Karbonhidrat = 12.63F, Protein = 0.48F, Yag = 4.81F, GramKarsiligi = 30, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(DilberDudagi);

            BesinBilgileri SanSebastian = new BesinBilgileri() { BesinAdi = "San Sebastian", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 480F, Karbonhidrat = 37.05F, Protein = 7.8F, Yag = 33.3F, GramKarsiligi = 150, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(SanSebastian);



            //SÜT ÜRÜNLERİ

            BesinBilgileri TamyagliInekSutu = new BesinBilgileri() { BesinAdi = "Tam Yağlı İnek Sütü", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 110F, Karbonhidrat = 8.64F, Protein = 5.65F, Yag = 5.85F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(TamyagliInekSutu);

            BesinBilgileri YarimYagliInekSutu = new BesinBilgileri() { BesinAdi = "Yarım Yağlı İnek Sütü", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 92F, Karbonhidrat = 10.84F, Protein = 6.66F, Yag = 2.10F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(YarimYagliInekSutu);

            BesinBilgileri KeciSutu = new BesinBilgileri() { BesinAdi = "Keçi Sütü", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 124F, Karbonhidrat = 10F, Protein = 6.66F, Yag = 6.66F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(KeciSutu);

            BesinBilgileri SoyaSutu = new BesinBilgileri() { BesinAdi = "Soya Sütü", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 112F, Karbonhidrat = 17.6F, Protein = 4F, Yag = 2.4F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(SoyaSutu);

            BesinBilgileri BademSutu = new BesinBilgileri() { BesinAdi = "Badem Sütü", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 48F, Karbonhidrat = 6F, Protein = 1F, Yag = 2.2F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(BademSutu);

            BesinBilgileri BeyazPeynir = new BesinBilgileri() { BesinAdi = "Beyaz Peynir", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 93F, Karbonhidrat = 0.76F, Protein = 6.11F, Yag = 7.30F, GramKarsiligi = 30, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(BeyazPeynir);

            BesinBilgileri SuzmePeynir = new BesinBilgileri() { BesinAdi = "Süzme Peynir", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 72F, Karbonhidrat = 1.14F, Protein = 3.4F, Yag = 6F, GramKarsiligi = 30, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(SuzmePeynir);

            BesinBilgileri LorPeyniri = new BesinBilgileri() { BesinAdi = "Lor Peyniri", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 30F, Karbonhidrat = 0.14F, Protein = 2.17F, Yag = 2.34F, GramKarsiligi = 15, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(LorPeyniri);

            BesinBilgileri KasarPeyniri = new BesinBilgileri() { BesinAdi = "Kaşar Peyniri", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 71F, Karbonhidrat = 0.51F, Protein = 5.4F, Yag = 5.32F, GramKarsiligi = 20, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(KasarPeyniri);

            BesinBilgileri Labne = new BesinBilgileri() { BesinAdi = "Labne", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 10F, Karbonhidrat = 0.28F, Protein = 0.25F, Yag = 0.9F, GramKarsiligi = 5, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Labne);

            BesinBilgileri OrguPeynir = new BesinBilgileri() { BesinAdi = "Örgü Peynir", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 72F, Karbonhidrat = 0.38F, Protein = 6.25F, Yag = 5F, GramKarsiligi = 25, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(OrguPeynir);

            BesinBilgileri DilPeyniri = new BesinBilgileri() { BesinAdi = "Dil Peyniri", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 68F, Karbonhidrat = 1.58F, Protein = 4.3F, Yag = 4.93F, GramKarsiligi = 25, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(DilPeyniri);

            BesinBilgileri HellimPeyniri = new BesinBilgileri() { BesinAdi = "Hellim Peyniri", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 90F, Karbonhidrat = 0.26F, Protein = 6.98F, Yag = 7.38F, GramKarsiligi = 25, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(HellimPeyniri);

            BesinBilgileri Mozarella = new BesinBilgileri() { BesinAdi = "Beyaz Peynir", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 90F, Karbonhidrat = 0.66F, Protein = 6.61F, Yag = 6.71F, GramKarsiligi = 30, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Mozarella);

            BesinBilgileri CheddarPeyniri = new BesinBilgileri() { BesinAdi = "Beyaz Peynir", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 61F, Karbonhidrat = 0F, Protein = 3.71F, Yag = 5.1F, GramKarsiligi = 15, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(CheddarPeyniri);

            BesinBilgileri Kefir = new BesinBilgileri() { BesinAdi = "Kefir", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 120F, Karbonhidrat = 10F, Protein = 5.6F, Yag = 6F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Kefir);

            BesinBilgileri Yogurt = new BesinBilgileri() { BesinAdi = "Yoğurt", OlcuBirimi = OlcuBirimi.Kase, Kalori = 122F, Karbonhidrat = 9.32F, Protein = 6.94F, Yag = 6.5F, GramKarsiligi = 200, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Yogurt);

            BesinBilgileri Ayran = new BesinBilgileri() { BesinAdi = "Ayran", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 76F, Karbonhidrat = 5.6F, Protein = 4F, Yag = 4F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Ayran);

            BesinBilgileri Cacik = new BesinBilgileri() { BesinAdi = "Cacık", OlcuBirimi = OlcuBirimi.Kase, Kalori = 115F, Karbonhidrat = 11F, Protein = 6.66F, Yag = 4.85F, GramKarsiligi = 200, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Cacik);


            //KAHVALTILI SICAKLARI

            BesinBilgileri HaslanmisYumurta = new BesinBilgileri() { BesinAdi = "Haşlanmış Yumurta", OlcuBirimi = OlcuBirimi.Adet, Kalori = 78F, Karbonhidrat = 0.56F, Protein = 6.3F, Yag = 5.31F, GramKarsiligi = 50, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(HaslanmisYumurta);

            BesinBilgileri Omlet = new BesinBilgileri() { BesinAdi = "Omlet", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 101F, Karbonhidrat = 1.27F, Protein = 6.7F, Yag = 7.94F, GramKarsiligi = 55, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Omlet);

            BesinBilgileri PeynirliOmlet = new BesinBilgileri() { BesinAdi = "Peynirli Omlet", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 254F, Karbonhidrat = 2.05F, Protein = 15.3F, Yag = 15F, GramKarsiligi = 130, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(PeynirliOmlet);

            BesinBilgileri MantarliOmlet = new BesinBilgileri() { BesinAdi = "Mantarlı Omlet", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 205F, Karbonhidrat = 3.7F, Protein = 12.45F, Yag = 10F, GramKarsiligi = 150, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(MantarliOmlet);

            BesinBilgileri Menemen = new BesinBilgileri() { BesinAdi = "Menemen", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 205F, Karbonhidrat = 3.7F, Protein = 12.45F, Yag = 10F, GramKarsiligi = 150, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Menemen);

            BesinBilgileri SucukluYumurta = new BesinBilgileri() { BesinAdi = "Sucuklu Yumurta", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 242F, Karbonhidrat = 3.4F, Protein = 13.5F, Yag = 19.5F, GramKarsiligi = 100, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(SucukluYumurta);

            BesinBilgileri Kuymak = new BesinBilgileri() { BesinAdi = "Kuymak - Mıhlama", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 489F, Karbonhidrat = 3.95F, Protein = 19.1F, Yag = 44.4F, GramKarsiligi = 120, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Kuymak);

            //SARKUTERI

            BesinBilgileri Sucuk = new BesinBilgileri() { BesinAdi = "Sucuk", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 166F, Karbonhidrat = 2.57F, Protein = 7.1F, Yag = 14.2F, GramKarsiligi = 50, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Sucuk);

            BesinBilgileri Sosis = new BesinBilgileri() { BesinAdi = "Sosis", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 60F, Karbonhidrat = 0.12F, Protein = 2.24F, Yag = 5.6F, GramKarsiligi = 40, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Sosis);

            BesinBilgileri DanaSalam = new BesinBilgileri() { BesinAdi = "Dana Salam", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 45F, Karbonhidrat = 0.64F, Protein = 1.65F, Yag = 3.92F, GramKarsiligi = 15, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(DanaSalam);

            BesinBilgileri HindiSalam = new BesinBilgileri() { BesinAdi = "Hindi Salam", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 17F, Karbonhidrat = 0.24F, Protein = 1.31F, Yag = 1.13F, GramKarsiligi = 8, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(HindiSalam);

            BesinBilgileri DanaJambon = new BesinBilgileri() { BesinAdi = "Dana Jambon", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 32F, Karbonhidrat = 0.7F, Protein = 4.92F, Yag = 0F, GramKarsiligi = 30, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(DanaJambon);

            BesinBilgileri HindiJambon = new BesinBilgileri() { BesinAdi = "Hindi Jambon", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 15F, Karbonhidrat = 0.35F, Protein = 2.35F, Yag = 0.46F, GramKarsiligi = 12, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(HindiJambon);

            BesinBilgileri PilicJambon = new BesinBilgileri() { BesinAdi = "Piliç Jambon", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 11F, Karbonhidrat = 0.12F, Protein = 1.56F, Yag = 0.44F, GramKarsiligi = 12, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(PilicJambon);

            BesinBilgileri HindiFume = new BesinBilgileri() { BesinAdi = "Hindi Füme", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 51F, Karbonhidrat = 0F, Protein = 8.8F, Yag = 1.5F, GramKarsiligi = 30, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(HindiFume);

            BesinBilgileri PilicFume = new BesinBilgileri() { BesinAdi = "Pilic Füme", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 26F, Karbonhidrat = 0.3F, Protein = 3.9F, Yag = 0.9F, GramKarsiligi = 30, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(PilicFume);

            BesinBilgileri Pastirma = new BesinBilgileri() { BesinAdi = "Pastırma", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 75F, Karbonhidrat = 0F, Protein = 8.85F, Yag = 4.17F, GramKarsiligi = 30, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Pastirma);

            //KAHVALTILIKLAR

            BesinBilgileri SiyahZeytin = new BesinBilgileri() { BesinAdi = "Siyah Zeytin", OlcuBirimi = OlcuBirimi.Adet, Kalori = 5F, Karbonhidrat = 0.24F, Protein = 0.03F, Yag = 0.44F, GramKarsiligi = 4, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(SiyahZeytin);

            BesinBilgileri YesilZeytin = new BesinBilgileri() { BesinAdi = "Yeşil Zeytin", OlcuBirimi = OlcuBirimi.Adet, Kalori = 6F, Karbonhidrat = 0.15F, Protein = 0.05F, Yag = 0.61F, GramKarsiligi = 4, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(YesilZeytin);

            BesinBilgileri Bal = new BesinBilgileri() { BesinAdi = "Bal", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 30F, Karbonhidrat = 8.25F, Protein = 0.04F, Yag = 0F, GramKarsiligi = 10, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Bal);

            BesinBilgileri Kaymak = new BesinBilgileri() { BesinAdi = "Kaymak", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 29F, Karbonhidrat = 0.17F, Protein = 0.05F, Yag = 3.16F, GramKarsiligi = 5, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Kaymak);

            BesinBilgileri TahinHelvasi = new BesinBilgileri() { BesinAdi = "Keçi Sütü", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 197F, Karbonhidrat = 15.8F, Protein = 5.11F, Yag = 12.53F, GramKarsiligi = 35, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(TahinHelvasi);

            BesinBilgileri YazHelvasi = new BesinBilgileri() { BesinAdi = "Cevizli Yaz Helvası", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 169F, Karbonhidrat = 13.55F, Protein = 4.41F, Yag = 10F, GramKarsiligi = 30, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(YazHelvasi);

            BesinBilgileri Tahin = new BesinBilgileri() { BesinAdi = "Tahin", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 87F, Karbonhidrat = 3.18F, Protein = 2.67F, Yag = 7.2F, GramKarsiligi = 15, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Tahin);

            BesinBilgileri Pekmez = new BesinBilgileri() { BesinAdi = "Pekmez", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 29F, Karbonhidrat = 0F, Protein = 0F, Yag = 0.01F, GramKarsiligi = 10, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Pekmez);

            BesinBilgileri TahinPekmez = new BesinBilgileri() { BesinAdi = "Tahin Pekmez", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 66F, Karbonhidrat = 6.45F, Protein = 1.52F, Yag = 3.48F, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(TahinPekmez);

            BesinBilgileri Nutella = new BesinBilgileri() { BesinAdi = "Nutella", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 27F, Karbonhidrat = 2.88F, Protein = 0.32F, Yag = 1.55F, GramKarsiligi = 5, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Nutella);

            BesinBilgileri KakaoluFindikKremasi = new BesinBilgileri() { BesinAdi = "Kakaolu Fındık Kreması", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 25F, Karbonhidrat = 2.71F, Protein = 0.44F, Yag = 1.38F, GramKarsiligi = 5, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(KakaoluFindikKremasi);

            BesinBilgileri FindikEzmesi = new BesinBilgileri() { BesinAdi = "Fındık Ezmesi", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 34F, Karbonhidrat = 3.08F, Protein = 0.55F, Yag = 2.23F, GramKarsiligi = 6, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(FindikEzmesi);

            BesinBilgileri FistikEzmesi = new BesinBilgileri() { BesinAdi = "Fıstık Ezmesi ", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 35F, Karbonhidrat = 1.3F, Protein = 1.44F, Yag = 3F, GramKarsiligi = 6, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(FistikEzmesi);

            BesinBilgileri SekersizFistikEzmesi = new BesinBilgileri() { BesinAdi = "Şekersiz Fıstık Ezmesi", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 36F, Karbonhidrat = 1.1F, Protein = 1.32F, Yag = 2.76F, GramKarsiligi = 6, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(SekersizFistikEzmesi);

            // MAKARNALAR
            BesinBilgileri HaslanmisMakarna = new BesinBilgileri() { BesinAdi = "Haşlanmış Makarna", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 157F, Karbonhidrat = 30.59F, Protein = 5.8F, Yag = 0.93F, GramKarsiligi = 100, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(HaslanmisMakarna);

            BesinBilgileri DomatesliMakarna = new BesinBilgileri() { BesinAdi = "Domatesli Makarna", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 178F, Karbonhidrat = 27.43F, Protein = 6.55F, Yag = 4.48F, GramKarsiligi = 200, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(DomatesliMakarna);

            BesinBilgileri SpagettiBolonez = new BesinBilgileri() { BesinAdi = "Spagetti Bolonez", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 303F, Karbonhidrat = 20.9F, Protein = 15.83F, Yag = 17F, GramKarsiligi = 200, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(SpagettiBolonez);

            BesinBilgileri PenneArabiata = new BesinBilgileri() { BesinAdi = "Penne Arabiata", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 164F, Karbonhidrat = 31.18F, Protein = 26.5F, Yag = 4.43F, GramKarsiligi = 100, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(PenneArabiata);

            BesinBilgileri Fettucini = new BesinBilgileri() { BesinAdi = "Fettucini Alfredo", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 289F, Karbonhidrat = 50.1F, Protein = 10.4F, Yag = 3.8F, GramKarsiligi = 100, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Fettucini);

            BesinBilgileri Lazanya = new BesinBilgileri() { BesinAdi = "Lazanya", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 272F, Karbonhidrat = 25F, Protein = 12.65F, Yag = 13.56F, GramKarsiligi = 150, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Lazanya);

            BesinBilgileri FirinMakarna = new BesinBilgileri() { BesinAdi = "Fırında Makarna", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 382F, Karbonhidrat = 52.26F, Protein = 17.14F, Yag = 11.2F, GramKarsiligi = 230, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(FirinMakarna);

            BesinBilgileri MakarnaSalatasi = new BesinBilgileri() { BesinAdi = "Makarna Salatası", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 283F, Karbonhidrat = 53.75F, Protein = 8.52F, Yag = 4.04F, GramKarsiligi = 300, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(MakarnaSalatasi);

            // SOSLAR

            BesinBilgileri Ketçap = new BesinBilgileri() { BesinAdi = "Ketçap", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 22F, Karbonhidrat = 4.8F, Protein = 0.25F, Yag = 0F, GramKarsiligi = 20, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Ketçap);

            BesinBilgileri Mayonez = new BesinBilgileri() { BesinAdi = "Mayonez", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 50F, Karbonhidrat = 3.11F, Protein = 0.12F, Yag = 4.34F, GramKarsiligi = 13, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Mayonez);

            BesinBilgileri Hardal = new BesinBilgileri() { BesinAdi = "Hardal", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 6F, Karbonhidrat = 0.58F, Protein = 0.37F, Yag = 0.33F, GramKarsiligi = 8, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Hardal);

            BesinBilgileri BarbekuSos = new BesinBilgileri() { BesinAdi = "Barbekü Sos", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 26F, Karbonhidrat = 6.38F, Protein = 0.12F, Yag = 0.06F, GramKarsiligi = 20, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(BarbekuSos);

            BesinBilgileri RanchSos = new BesinBilgileri() { BesinAdi = "Ranch Sos", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 24F, Karbonhidrat = 1.79F, Protein = 0.46F, Yag = 1.7F, GramKarsiligi = 20, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(RanchSos);

            BesinBilgileri BuffaloSos = new BesinBilgileri() { BesinAdi = "Buffalo Sos", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 56F, Karbonhidrat = 1.4F, Protein = 0.4F, Yag = 5.4F, GramKarsiligi = 20, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(BuffaloSos);

            BesinBilgileri PestoSos = new BesinBilgileri() { BesinAdi = "Pesto Sos", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 9F, Karbonhidrat = 0.54F, Protein = 3.47F, Yag = 4.86F, GramKarsiligi = 10, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(PestoSos);

            BesinBilgileri NarEkşisi = new BesinBilgileri() { BesinAdi = "Nar Ekşisi", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 15F, Karbonhidrat = 3.7F, Protein = 0.05F, Yag = 0F, GramKarsiligi = 8, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(NarEkşisi);

            BesinBilgileri KoriSos = new BesinBilgileri() { BesinAdi = "Köri Sos", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 22F, Karbonhidrat = 1.6F, Protein = 0.05F, Yag = 1.7F, GramKarsiligi = 10, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(KoriSos);

            BesinBilgileri SoyaSos = new BesinBilgileri() { BesinAdi = "Soya Sos", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 6F, Karbonhidrat = 0.56F, Protein = 1.05F, Yag = 0F, GramKarsiligi = 10, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(SoyaSos);

            //FASTFOODLAR
            BesinBilgileri CitirTavuk = new BesinBilgileri() { BesinAdi = "Çıtır Tavuk", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 529F, Karbonhidrat = 38.05F, Protein = 34F, Yag = 26.65F, GramKarsiligi = 200, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(CitirTavuk);

            BesinBilgileri TavukBurger = new BesinBilgileri() { BesinAdi = "Tavuk Burger ", OlcuBirimi = OlcuBirimi.Adet, Kalori = 270F, Karbonhidrat = 33F, Protein = 13F, Yag = 10F, GramKarsiligi = 100, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(TavukBurger);

            BesinBilgileri Cheeseburger = new BesinBilgileri() { BesinAdi = "Cheeseburger", OlcuBirimi = OlcuBirimi.Adet, Kalori = 290F, Karbonhidrat = 30.96F, Protein = 16.95F, Yag = 12F, GramKarsiligi = 115, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Cheeseburger);

            BesinBilgileri EtliEkmek = new BesinBilgileri() { BesinAdi = "Etli Ekmek", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 277F, Karbonhidrat = 31.07F, Protein = 15.28F, Yag = 9.56F, GramKarsiligi = 130, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(EtliEkmek);

            BesinBilgileri Lahmacun = new BesinBilgileri() { BesinAdi = "Lahmacun", OlcuBirimi = OlcuBirimi.Adet, Kalori = 221F, Karbonhidrat = 32.27F, Protein = 9.75F, Yag = 5.55F, GramKarsiligi = 150, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Lahmacun);

            BesinBilgileri Tantuni = new BesinBilgileri() { BesinAdi = "Tantuni", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 380F, Karbonhidrat = 19.05F, Protein = 43.6F, Yag = 50.34F, GramKarsiligi = 220, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Tantuni);

            BesinBilgileri PizzaKarisik = new BesinBilgileri() { BesinAdi = "Karışık Pizza", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 241F, Karbonhidrat = 40F, Protein = 7.8F, Yag = 5.63F, GramKarsiligi = 130, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(PizzaKarisik);

            BesinBilgileri PizzaSebzeli = new BesinBilgileri() { BesinAdi = "Sebzeli Pizza", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 266F, Karbonhidrat = 41.23F, Protein = 13.1F, Yag = 6.6F, GramKarsiligi = 220, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(PizzaSebzeli);

            BesinBilgileri Kokorec = new BesinBilgileri() { BesinAdi = "Kokoreç Yarım Ekmek", OlcuBirimi = OlcuBirimi.Adet, Kalori = 433F, Karbonhidrat = 68.77F, Protein = 28.1F, Yag = 3.93F, GramKarsiligi = 245, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Kokorec);

            BesinBilgileri Cigkofte = new BesinBilgileri() { BesinAdi = "Çiğköfte Dürüm", OlcuBirimi = OlcuBirimi.Adet, Kalori = 361F, Karbonhidrat = 64.75F, Protein = 15.06F, Yag = 30.64F, GramKarsiligi = 150, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Cigkofte);

            BesinBilgileri DurumTavukDoner = new BesinBilgileri() { BesinAdi = "Tavuk Döner Dürüm", OlcuBirimi = OlcuBirimi.Adet, Kalori = 309F, Karbonhidrat = 15.13F, Protein = 43.1F, Yag = 36.37F, GramKarsiligi = 250, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(DurumTavukDoner);

            BesinBilgileri DurumEtDoner = new BesinBilgileri() { BesinAdi = "Et Döner Dürüm", OlcuBirimi = OlcuBirimi.Adet, Kalori = 301F, Karbonhidrat = 19.7F, Protein = 29.65F, Yag = 45.6F, GramKarsiligi = 235, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(DurumEtDoner);

            BesinBilgileri Kumpir = new BesinBilgileri() { BesinAdi = "Kumpir", OlcuBirimi = OlcuBirimi.Adet, Kalori = 1296F, Karbonhidrat = 65.74F, Protein = 50F, Yag = 92.35F, GramKarsiligi = 640, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(Kumpir);

            BesinBilgileri AdanaDurum = new BesinBilgileri() { BesinAdi = "Adana Dürüm", OlcuBirimi = OlcuBirimi.Adet, Kalori = 325F, Karbonhidrat = 15.02F, Protein = 27.80F, Yag = 45.5F, GramKarsiligi = 200, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(AdanaDurum);

            BesinBilgileri UrfaDurum = new BesinBilgileri() { BesinAdi = "Urfa Dürüm", OlcuBirimi = OlcuBirimi.Adet, Kalori = 325F, Karbonhidrat = 15.02F, Protein = 27.80F, Yag = 45.5F, GramKarsiligi = 200, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(UrfaDurum);

            BesinBilgileri PatatesKizartmasi = new BesinBilgileri() { BesinAdi = "Patates Kızartması", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 250F, Karbonhidrat = 33.15F, Protein = 2.75F, Yag = 11.8F, GramKarsiligi = 80, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(PatatesKizartmasi);

            BesinBilgileri SoganHalkasi = new BesinBilgileri() { BesinAdi = "Soğan Halkası", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 97F, Karbonhidrat = 18.91F, Protein = 3.4F, Yag = 0.63F, GramKarsiligi = 100, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(SoganHalkasi);

            BesinBilgileri KiymaliPide = new BesinBilgileri() { BesinAdi = "Kıymalı Pide", OlcuBirimi = OlcuBirimi.Adet, Kalori = 628F, Karbonhidrat = 73.44F, Protein = 24.6F, Yag = 25.57F, GramKarsiligi = 300, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(KiymaliPide);

            BesinBilgileri KasarliPide = new BesinBilgileri() { BesinAdi = "Kaşarlı Pide", OlcuBirimi = OlcuBirimi.Adet, Kalori = 600F, Karbonhidrat = 69F, Protein = 19.75F, Yag = 26.83F, GramKarsiligi = 250, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(KasarliPide);

            BesinBilgileri KusbasiPide = new BesinBilgileri() { BesinAdi = "Kuşbaşılı pide", OlcuBirimi = OlcuBirimi.Adet, Kalori = 515F, Karbonhidrat = 73.2F, Protein = 28.3F, Yag = 11.5F, GramKarsiligi = 350, CreatedBy = "Ayşe" };
            context.BesinBilgileri.Add(KusbasiPide);




            //KIRMIZI ET



            BesinBilgileri danaEti = new BesinBilgileri() { BesinAdi = "Dana Eti", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.31F, Karbonhidrat = 0, Protein = 0.3F, Yag = 0.11F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(danaEti);

            BesinBilgileri kuzuEti = new BesinBilgileri() { BesinAdi = "Kuzu Eti", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.71F, Karbonhidrat = 0, Protein = 0.25F, Yag = 0.18F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kuzuEti);

            BesinBilgileri etliSebzeliPizza = new BesinBilgileri() { BesinAdi = " Etli Sebzeli Pizza", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.44F, Karbonhidrat = 0.25F, Protein = 0.11F, Yag = 0.11F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etliSebzeliPizza);

            BesinBilgileri hindiEtiKızarmıs = new BesinBilgileri() { BesinAdi = " Kızarmış Hindi Eti", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.9F, Karbonhidrat = 0, Protein = 0.28F, Yag = 0.07F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(hindiEtiKızarmıs);

            BesinBilgileri kazEti = new BesinBilgileri() { BesinAdi = "Kaz Eti", OlcuBirimi = OlcuBirimi.Gram, Kalori = 3.05F, Karbonhidrat = 0, Protein = 0.25F, Yag = 0.22F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kazEti);

            BesinBilgileri keciEti = new BesinBilgileri() { BesinAdi = " Keçi Eti", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.4F, Karbonhidrat = 0, Protein = 0.27F, Yag = 0.03F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(keciEti);

            BesinBilgileri kurutulmusSıgırEti = new BesinBilgileri() { BesinAdi = "Kurutulmuş Sığır Eti", OlcuBirimi = OlcuBirimi.Gram, Kalori = 4.1F, Karbonhidrat = 0.11F, Protein = 0.33F, Yag = 0.25F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kurutulmusSıgırEti);

            BesinBilgileri etliNohut = new BesinBilgileri() { BesinAdi = " Etli Nohut", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.74F, Karbonhidrat = 0.08F, Protein = 0.012F, Yag = 0.01F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etliNohut);

            BesinBilgileri etDoner = new BesinBilgileri() { BesinAdi = " Et Döner", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.52F, Karbonhidrat = 0.02F, Protein = 0.015F, Yag = 0.25F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etDoner);

            BesinBilgileri etKavurma = new BesinBilgileri() { BesinAdi = " Et Kavurma", OlcuBirimi = OlcuBirimi.Gram, Kalori = 3.43F, Karbonhidrat = 0, Protein = 0.2F, Yag = 0.28F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etKavurma);

            BesinBilgileri etSote = new BesinBilgileri() { BesinAdi = " Et Sote", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.43F, Karbonhidrat = 0.03F, Protein = 0.14F, Yag = 0.07F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etSote);

            BesinBilgileri danaEtliBurrito = new BesinBilgileri() { BesinAdi = " Dana Etli Burrito", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.62F, Karbonhidrat = 0.29F, Protein = 0.13F, Yag = 0.1F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(danaEtliBurrito);

            BesinBilgileri etliKuruFasulye = new BesinBilgileri() { BesinAdi = " Etli Kuru Fasulye", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.43F, Karbonhidrat = 0.13F, Protein = 0.09F, Yag = 0.06F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etliKuruFasulye);

            BesinBilgileri etliTurlu = new BesinBilgileri() { BesinAdi = " Etli Türlü", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.9F, Karbonhidrat = 0.04F, Protein = 0.054F, Yag = 0.056F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etliTurlu);

            BesinBilgileri etliTazeFasulye = new BesinBilgileri() { BesinAdi = " Etli Taze Fasulye", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.88F, Karbonhidrat = 0.024F, Protein = 0.066F, Yag = 0.057F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etliTazeFasulye);

            BesinBilgileri etliBiberDolmasi = new BesinBilgileri() { BesinAdi = " Etli Biber Dolması", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.79F, Karbonhidrat = 0.036F, Protein = 0.054F, Yag = 0.047F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etliBiberDolmasi);

            BesinBilgileri etliPatates = new BesinBilgileri() { BesinAdi = " Etli Patates Yemeği", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.6F, Karbonhidrat = 0.04F, Protein = 0.013F, Yag = 0.01F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etliPatates);

            BesinBilgileri suluKofte = new BesinBilgileri() { BesinAdi = "Sulu Köfte", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.22F, Karbonhidrat = 0.10F, Protein = 0.14F, Yag = 0.13F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(suluKofte);

            BesinBilgileri islimKebabi = new BesinBilgileri() { BesinAdi = " İslim Kebabı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.87F, Karbonhidrat = 0.03F, Protein = 0.05F, Yag = 0.06F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(islimKebabi);

            BesinBilgileri izgaraKofte = new BesinBilgileri() { BesinAdi = "Izgara Köfte", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.67F, Karbonhidrat = 0.04F, Protein = 0.14F, Yag = 0.1F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(izgaraKofte);

            BesinBilgileri izmirKofte = new BesinBilgileri() { BesinAdi = " İzmir Köfte", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.65F, Karbonhidrat = 0.115F, Protein = 0.08F, Yag = 0.1F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(izmirKofte);

            BesinBilgileri icliKöfte = new BesinBilgileri() { BesinAdi = "İçli Köfte", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.33F, Karbonhidrat = 0.32F, Protein = 0.1F, Yag = 0.07F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(icliKöfte);

            BesinBilgileri kasapKofte = new BesinBilgileri() { BesinAdi = "Kasap Köfte", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.8F, Karbonhidrat = 0.10F, Protein = 0.017F, Yag = 0.076F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kasapKofte);

            BesinBilgileri inegolKofte = new BesinBilgileri() { BesinAdi = "İnegöl Köfte", OlcuBirimi = OlcuBirimi.Gram, Kalori = 3, Karbonhidrat = 0.08F, Protein = 0.16F, Yag = 0.11F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(inegolKofte);

            BesinBilgileri kadınbuduKöfte = new BesinBilgileri() { BesinAdi = "Kadınbudu Köfte", OlcuBirimi = OlcuBirimi.Gram, Kalori = 3.52F, Karbonhidrat = 0.14F, Protein = 0.13F, Yag = 0.27F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kadınbuduKöfte);

            BesinBilgileri adanaKebabi = new BesinBilgileri() { BesinAdi = " Adana Kebabı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.29F, Karbonhidrat = 0.08F, Protein = 0.08F, Yag = 0.05F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(adanaKebabi);

            BesinBilgileri patlicanKebabi = new BesinBilgileri() { BesinAdi = " Patlıcan Kebabı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.02F, Karbonhidrat = 0.048F, Protein = 0.09F, Yag = 0.045F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(patlicanKebabi);

            BesinBilgileri ormanKebabi = new BesinBilgileri() { BesinAdi = " Orman Kebabı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.25F, Karbonhidrat = 0.1F, Protein = 0.048F, Yag = 0.04F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(ormanKebabi);

            BesinBilgileri kuzuSis = new BesinBilgileri() { BesinAdi = "Kuzu Şiş", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.67F, Karbonhidrat = 0.038F, Protein = 0.165F, Yag = 0.097F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kuzuSis);

            BesinBilgileri tasKebabi = new BesinBilgileri() { BesinAdi = " Tas Kebabı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.7F, Karbonhidrat = 0.07F, Protein = 0.05F, Yag = 0.04F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(tasKebabi);

            BesinBilgileri beytiKebabi = new BesinBilgileri() { BesinAdi = " Beyti Kebabı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2, Karbonhidrat = 0.13F, Protein = 0.1F, Yag = 0.12F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(beytiKebabi);

            BesinBilgileri cagKebabi = new BesinBilgileri() { BesinAdi = " Cağ Kebabı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.67F, Karbonhidrat = 0.038F, Protein = 0.165F, Yag = 0.097F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(cagKebabi);

            BesinBilgileri tepsiKebabi = new BesinBilgileri() { BesinAdi = "Tepsi Kebabı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.72F, Karbonhidrat = 0.04F, Protein = 0.106F, Yag = 0.123F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(tepsiKebabi);

            BesinBilgileri urfaKebabi = new BesinBilgileri() { BesinAdi = " Urfa Kebabı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.77F, Karbonhidrat = 0.016F, Protein = 0.154F, Yag = 0.118F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(urfaKebabi);

            BesinBilgileri cokertmeKebabi = new BesinBilgileri() { BesinAdi = " Çökertme Kebabı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.49F, Karbonhidrat = 0.12F, Protein = 0.105F, Yag = 0.28F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(cokertmeKebabi);

            BesinBilgileri kagıtKebabı = new BesinBilgileri() { BesinAdi = " Kağıt Kebabı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.8F, Karbonhidrat = 0.036F, Protein = 0.103F, Yag = 0.028F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kagıtKebabı);

            BesinBilgileri iskender = new BesinBilgileri() { BesinAdi = "İskender", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.93F, Karbonhidrat = 0.14F, Protein = 0.09F, Yag = 0.11F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(iskender);

            BesinBilgileri aliNazik = new BesinBilgileri() { BesinAdi = "Alinazik Kebabı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.57F, Karbonhidrat = 0.03F, Protein = 0.035F, Yag = 0.034F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(aliNazik);

            BesinBilgileri manisaKebabi = new BesinBilgileri() { BesinAdi = " Manisa Kebabı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 5.34F, Karbonhidrat = 3.35F, Protein = 2.33F, Yag = 3.36F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(manisaKebabi);

            BesinBilgileri soganKebabi = new BesinBilgileri() { BesinAdi = " Soğan Kebabı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.79F, Karbonhidrat = 0.05F, Protein = 0.09F, Yag = 0.05F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(soganKebabi);

            BesinBilgileri ıslakHamburger = new BesinBilgileri() { BesinAdi = " Islak Hamburger", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.66F, Karbonhidrat = 0.153F, Protein = 0.07F, Yag = 0.08F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(ıslakHamburger);

            BesinBilgileri hamburger = new BesinBilgileri() { BesinAdi = "Hamburger", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.58F, Karbonhidrat = 0.265F, Protein = 0.147F, Yag = 0.104F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(hamburger);

            BesinBilgileri kiymaliBorek = new BesinBilgileri() { BesinAdi = " Kıymalı Börek", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.48F, Karbonhidrat = 0.288F, Protein = 0.092F, Yag = 0.104F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kiymaliBorek);

            BesinBilgileri patlicanMusakka = new BesinBilgileri() { BesinAdi = " Patlıcan Musakka", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.42F, Karbonhidrat = 0.096F, Protein = 0.048F, Yag = 0.06F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(patlicanMusakka);

            BesinBilgileri kiymaliPide = new BesinBilgileri() { BesinAdi = " Kıymalı Pide", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.09F, Karbonhidrat = 0.245F, Protein = 0.082F, Yag = 0.085F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kiymaliPide);

            BesinBilgileri kiymaliYumurta = new BesinBilgileri() { BesinAdi = " Kıymalı Yumurta", OlcuBirimi = OlcuBirimi.Gram, Kalori = 3.62F, Karbonhidrat = 0.074F, Protein = 0.25F, Yag = 0.074F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kiymaliYumurta);

            BesinBilgileri kavrulmusKiyma = new BesinBilgileri() { BesinAdi = " Kavrulmuş Kıyma", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2, Karbonhidrat = 0.007F, Protein = 0.276F, Yag = 0.122F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kavrulmusKiyma);

            BesinBilgileri kiymaliMakarna = new BesinBilgileri() { BesinAdi = " Kıymalı Makarna", OlcuBirimi = OlcuBirimi.Gram, Kalori = 3.92F, Karbonhidrat = 0.539F, Protein = 0.155F, Yag = 0.121F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kiymaliMakarna);

            BesinBilgileri kiymaliIspanak = new BesinBilgileri() { BesinAdi = " Kıymalı Ispanak", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.75F, Karbonhidrat = 0.105F, Protein = 0.036F, Yag = 0.023F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kiymaliIspanak);

            BesinBilgileri kiymaliKarnabahar = new BesinBilgileri() { BesinAdi = " Kıymalı Karnabahar", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.12F, Karbonhidrat = 0.11F, Protein = 0.03F, Yag = 0.06F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kiymaliKarnabahar);

            BesinBilgileri kiymaliKabak = new BesinBilgileri() { BesinAdi = " Kıymalı Kabak Yemeği", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.6F, Karbonhidrat = 0.105F, Protein = 0.022F, Yag = 0.016F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kiymaliKabak);

            BesinBilgileri karniyarik = new BesinBilgileri() { BesinAdi = "Karnıyarık", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.55F, Karbonhidrat = 0.025F, Protein = 0.032F, Yag = 0.035F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(karniyarik);

            BesinBilgileri kiymaliBezelye = new BesinBilgileri() { BesinAdi = " Kıymalı Bezelye", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.96F, Karbonhidrat = 0.058F, Protein = 0.079F, Yag = 0.044F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kiymaliBezelye);

            BesinBilgileri kiymaliBamya = new BesinBilgileri() { BesinAdi = " Kıymalı Bamya", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.45F, Karbonhidrat = 0.032F, Protein = 0.034F, Yag = 0.018F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kiymaliBamya);

            BesinBilgileri kiymaliGozleme = new BesinBilgileri() { BesinAdi = " Kıymalı Gözleme", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.56F, Karbonhidrat = 0.445F, Protein = 0.103F, Yag = 0.06F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kiymaliGozleme);

            BesinBilgileri kiymaliKabuska = new BesinBilgileri() { BesinAdi = " Kıymalı Kapuska", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.59F, Karbonhidrat = 0.049F, Protein = 0.025F, Yag = 0.032F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kiymaliKabuska);

            BesinBilgileri kiymaliPatates = new BesinBilgileri() { BesinAdi = " Kıymalı Patates", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.8F, Karbonhidrat = 0.09F, Protein = 0.04F, Yag = 0.03F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kiymaliPatates);

            BesinBilgileri kiymaliYaprakSarma = new BesinBilgileri() { BesinAdi = " Kıymalı Yaprak Sarma", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.06F, Karbonhidrat = 0.052F, Protein = 0.056F, Yag = 0.071F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kiymaliYaprakSarma);

            BesinBilgileri kuzuKusleme = new BesinBilgileri() { BesinAdi = " Kuzu Küşleme", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.20F, Karbonhidrat = 0.025F, Protein = 0.328F, Yag = 0.09F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kuzuKusleme);

            BesinBilgileri etliLahanaSarma = new BesinBilgileri() { BesinAdi = " Etli Lahana Sarma", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.25F, Karbonhidrat = 0.115F, Protein = 0.04F, Yag = 0.025F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etliLahanaSarma);

            BesinBilgileri etliPilav = new BesinBilgileri() { BesinAdi = " Etli Pilav", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.42F, Karbonhidrat = 0.22F, Protein = 0.055F, Yag = 0.035F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etliPilav);

            BesinBilgileri etliEkmek = new BesinBilgileri() { BesinAdi = " Etli Ekmek", OlcuBirimi = OlcuBirimi.Gram, Kalori = 3.07F, Karbonhidrat = 0.352F, Protein = 0.11F, Yag = 0.136F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etliEkmek);



            //SEBZELER




            BesinBilgileri domates = new BesinBilgileri() { BesinAdi = "Domates", OlcuBirimi = OlcuBirimi.Adet, Kalori = 22, Karbonhidrat = 4.78F, Protein = 1.08F, Yag = 0.25F, GramKarsiligi = 123, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(domates);

            BesinBilgileri ceriDomates = new BesinBilgileri() { BesinAdi = "Çeri Domates", OlcuBirimi = OlcuBirimi.Kase, Kalori = 27, Karbonhidrat = 5.8F, Protein = 1.31F, Yag = 0.30F, GramKarsiligi = 149, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(ceriDomates);

            BesinBilgileri salatalik = new BesinBilgileri() { BesinAdi = "Salatalık", OlcuBirimi = OlcuBirimi.Adet, Kalori = 15, Karbonhidrat = 3.63F, Protein = 0.65F, Yag = 0.11F, GramKarsiligi = 100, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(salatalik);

            BesinBilgileri marul = new BesinBilgileri() { BesinAdi = "Marul", OlcuBirimi = OlcuBirimi.Kase, Kalori = 5, Karbonhidrat = 1.03F, Protein = 0.5F, Yag = 0.05F, GramKarsiligi = 36, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(marul);

            BesinBilgileri carlistonBiber = new BesinBilgileri() { BesinAdi = "Çarliston Biber", OlcuBirimi = OlcuBirimi.Adet, Kalori = 12, Karbonhidrat = 2.46F, Protein = 0.76F, Yag = 0.21F, GramKarsiligi = 46, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(carlistonBiber);

            BesinBilgileri kirmiziBiber = new BesinBilgileri() { BesinAdi = " Kırmızı Biber", OlcuBirimi = OlcuBirimi.Adet, Kalori = 37, Karbonhidrat = 7.18F, Protein = 1.18F, Yag = 0.36F, GramKarsiligi = 119, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kirmiziBiber);

            BesinBilgileri nane = new BesinBilgileri() { BesinAdi = "Nane", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 1, Karbonhidrat = 0.24F, Protein = 0.06F, Yag = 0.001F, GramKarsiligi = 5, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(nane);

            BesinBilgileri feslegen = new BesinBilgileri() { BesinAdi = "Feslegen", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 1, Karbonhidrat = 0.23F, Protein = 0.13F, Yag = 0.03F, GramKarsiligi = 10, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(feslegen);

            BesinBilgileri dereotu = new BesinBilgileri() { BesinAdi = "Dereotu", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 1, Karbonhidrat = 0.23F, Protein = 0.13F, Yag = 0.01F, GramKarsiligi = 10, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(dereotu);

            BesinBilgileri kisnis = new BesinBilgileri() { BesinAdi = "Kişniş", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 5, Karbonhidrat = 0.99F, Protein = 0.22F, Yag = 0.32F, GramKarsiligi = 5, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kisnis);

            BesinBilgileri biberiye = new BesinBilgileri() { BesinAdi = "Biberiye", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 4, Karbonhidrat = 0.77F, Protein = 0.06F, Yag = 0.18F, GramKarsiligi = 5, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(biberiye);

            BesinBilgileri maydanoz = new BesinBilgileri() { BesinAdi = "Maydanoz", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 1, Karbonhidrat = 0.24F, Protein = 0.11F, Yag = 0.03F, GramKarsiligi = 5, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(maydanoz);

            BesinBilgileri turp = new BesinBilgileri() { BesinAdi = "Turp", OlcuBirimi = OlcuBirimi.Adet, Kalori = 19, Karbonhidrat = 3.94F, Protein = 0.79F, Yag = 0.12F, GramKarsiligi = 116, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(turp);

            BesinBilgileri karnabahar = new BesinBilgileri() { BesinAdi = "Karnabahar", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 27, Karbonhidrat = 5.32F, Protein = 2.05F, Yag = 0.3F, GramKarsiligi = 107, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(karnabahar);

            BesinBilgileri brokoli = new BesinBilgileri() { BesinAdi = "Brokoli", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 31, Karbonhidrat = 6.04F, Protein = 2.57F, Yag = 0.34F, GramKarsiligi = 91, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(brokoli);

            BesinBilgileri brukselLahana = new BesinBilgileri() { BesinAdi = "Brüksel Lahana", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 38, Karbonhidrat = 7.88F, Protein = 2.97F, Yag = 0.26F, GramKarsiligi = 88, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(brukselLahana);

            BesinBilgileri beyazLahana = new BesinBilgileri() { BesinAdi = "Beyaz Lahana", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 22, Karbonhidrat = 5.16F, Protein = 1.14F, Yag = 0.09F, GramKarsiligi = 90, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(beyazLahana);

            BesinBilgileri kirmiziLahana = new BesinBilgileri() { BesinAdi = "Kırmızı Lahana", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 28, Karbonhidrat = 6.56F, Protein = 1.27F, Yag = 0.14F, GramKarsiligi = 90, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kirmiziLahana);

            BesinBilgileri havuc = new BesinBilgileri() { BesinAdi = "Havuc", OlcuBirimi = OlcuBirimi.Adet, Kalori = 25, Karbonhidrat = 5.84F, Protein = 0.57F, Yag = 0.15F, GramKarsiligi = 61, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(havuc);

            BesinBilgileri sarimsak = new BesinBilgileri() { BesinAdi = "Sarımsak", OlcuBirimi = OlcuBirimi.Adet, Kalori = 4, Karbonhidrat = 0.99F, Protein = 0.19F, Yag = 0.02F, GramKarsiligi = 5, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(sarimsak);

            BesinBilgileri sogan = new BesinBilgileri() { BesinAdi = "Soğan", OlcuBirimi = OlcuBirimi.Adet, Kalori = 44, Karbonhidrat = 10.27F, Protein = 1.21F, Yag = 0.11F, GramKarsiligi = 110, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(sogan);

            BesinBilgileri yesilSogan = new BesinBilgileri() { BesinAdi = "Yeşil Soğan", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 2, Karbonhidrat = 0.44F, Protein = 0.11F, Yag = 0.01F, GramKarsiligi = 5, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(yesilSogan);

            BesinBilgileri semizotu = new BesinBilgileri() { BesinAdi = "Semizotu", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 9, Karbonhidrat = 1.46F, Protein = 0.87F, Yag = 0.15F, GramKarsiligi = 43, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(semizotu);

            BesinBilgileri pazi = new BesinBilgileri() { BesinAdi = "Pazı", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 7, Karbonhidrat = 1.35F, Protein = 0.65F, Yag = 0.07F, GramKarsiligi = 36, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(pazi);

            BesinBilgileri kabak = new BesinBilgileri() { BesinAdi = "Kabak", OlcuBirimi = OlcuBirimi.Adet, Kalori = 33, Karbonhidrat = 6.10F, Protein = 2.37F, Yag = 0.63F, GramKarsiligi = 196, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kabak);

            BesinBilgileri roka = new BesinBilgileri() { BesinAdi = "Roka", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 5, Karbonhidrat = 0.73F, Protein = 0.52F, Yag = 0.13F, GramKarsiligi = 20, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(roka);




            //SEBZE YEMEKLERİ



            BesinBilgileri ispanakYemeği = new BesinBilgileri() { BesinAdi = "Ispanak Yemeği (Etsiz)", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 100, Kalori = 115, Karbonhidrat = 5.09F, Protein = 2.11F, Yag = 10.3F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(ispanakYemeği);

            BesinBilgileri zeytinyagliSemizotu = new BesinBilgileri() { BesinAdi = "Zeytinyağlı Semizotu", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 100, Kalori = 112, Karbonhidrat = 4.98F, Protein = 1.29F, Yag = 10.26F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(zeytinyagliSemizotu);

            BesinBilgileri zeytinyağliPazi = new BesinBilgileri() { BesinAdi = "Zeytinyağlı Pazı", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 100, Kalori = 131, Karbonhidrat = 11.89F, Protein = 3.74F, Yag = 7.18F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(zeytinyağliPazi);

            BesinBilgileri zeytinyağliTazeFasulye = new BesinBilgileri() { BesinAdi = "Zeytinyağlı Taze Fasülye", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 100, Kalori = 151, Karbonhidrat = 21.39F, Protein = 5.54F, Yag = 5.51F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(zeytinyağliTazeFasulye);

            BesinBilgileri zeytinyağliPirasa = new BesinBilgileri() { BesinAdi = "Zeytinyağlı Pırasa", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 100, Kalori = 120, Karbonhidrat = 7.25F, Protein = 0.91F, Yag = 10.27F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(zeytinyağliPirasa);

            BesinBilgileri bezelyeYemeği = new BesinBilgileri() { BesinAdi = "Bezelye Yemeği (Etsiz)", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 100, Kalori = 147, Karbonhidrat = 11.07F, Protein = 3.48F, Yag = 10.38F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(bezelyeYemeği);

            BesinBilgileri zeytinyağliBrokoli = new BesinBilgileri() { BesinAdi = "Zeytinyağlı Brokoli", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 100, Kalori = 80, Karbonhidrat = 7.14F, Protein = 2.37F, Yag = 5.41F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(zeytinyağliBrokoli);

            BesinBilgileri karnabaharYemegi = new BesinBilgileri() { BesinAdi = "Karnabahar Yemeği(Etsiz)", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 100, Kalori = 115, Karbonhidrat = 5.29F, Protein = 1.48F, Yag = 10.41F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(karnabaharYemegi);

            BesinBilgileri bamyaYemegi = new BesinBilgileri() { BesinAdi = "Bamya Yemeği (Etsiz)", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 100, Kalori = 113, Karbonhidrat = 4.68F, Protein = 1.06F, Yag = 10.57F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(bamyaYemegi);

            BesinBilgileri zeytinyağliTurlu = new BesinBilgileri() { BesinAdi = "Zeytinyağlı Türlü", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 100, Kalori = 112, Karbonhidrat = 8.68F, Protein = 1.33F, Yag = 8.87F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(zeytinyağliTurlu);

            BesinBilgileri zeytinyağliBakla = new BesinBilgileri() { BesinAdi = "Zeytinyağlı Bakla", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 100, Kalori = 145, Karbonhidrat = 9.76F, Protein = 3.32F, Yag = 10.69F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(zeytinyağliBakla);

            BesinBilgileri zeytinyağliKereviz = new BesinBilgileri() { BesinAdi = "Zeytinyağlı Kereviz", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 100, Kalori = 90, Karbonhidrat = 7.14F, Protein = 1.92F, Yag = 6.37F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(zeytinyağliKereviz);

            BesinBilgileri zeytinyağliEnginar = new BesinBilgileri() { BesinAdi = "Zeytinyağlı Enginar", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 100, Kalori = 146, Karbonhidrat = 12.09F, Protein = 2.93F, Yag = 10.71F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(zeytinyağliEnginar);

            BesinBilgileri sebzeSote = new BesinBilgileri() { BesinAdi = "Sebze Sote", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 200, Kalori = 90, Karbonhidrat = 4.55F, Protein = 0.94F, Yag = 10.19F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(sebzeSote);

            BesinBilgileri zeytinyağliSebzeDolmasi = new BesinBilgileri() { BesinAdi = "Zeytinyağlı Sebze Dolması", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 200, Kalori = 258, Karbonhidrat = 13.59F, Protein = 5.6F, Yag = 13.6F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(zeytinyağliSebzeDolmasi);

            BesinBilgileri zeytinyağliYaprakSarma = new BesinBilgileri() { BesinAdi = "Zeytinyağlı Yaprak Sarma", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 60, Kalori = 108, Karbonhidrat = 8.32F, Protein = 1.33F, Yag = 8.15F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(zeytinyağliYaprakSarma);

            BesinBilgileri zeytinyağliKabak = new BesinBilgileri() { BesinAdi = "Zeytinyağlı Kabak", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 100, Kalori = 111, Karbonhidrat = 5.19F, Protein = 0.81F, Yag = 10.18F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(zeytinyağliKabak);




            //SALATALAR


            BesinBilgileri sadeSalata = new BesinBilgileri() { BesinAdi = "Sade Salata (Karışık Yeşillik)", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 55, Kalori = 9, Karbonhidrat = 1.76F, Protein = 0.84F, Yag = 0.13F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(sadeSalata);


            BesinBilgileri mercimekliPeynirliSalata = new BesinBilgileri() { BesinAdi = "Mercimekli Lor Peynirli Salata", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 255, Kalori = 180, Karbonhidrat = 28, Protein = 2.7F, Yag = 5.1F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(mercimekliPeynirliSalata);


            BesinBilgileri tavukluSalata = new BesinBilgileri() { BesinAdi = "Tavuklu Salata", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 255, Kalori = 225, Karbonhidrat = 5.28F, Protein = 31.38F, Yag = 8.29F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(tavukluSalata);

            BesinBilgileri etliSalata = new BesinBilgileri() { BesinAdi = "Etli Salata (bonfileli/köfteli/fümeli)", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 260, Kalori = 267, Karbonhidrat = 5.28F, Protein = 24.84F, Yag = 16.49F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etliSalata);

            BesinBilgileri tonBalikliSalata = new BesinBilgileri() { BesinAdi = "Ton Balıklı Salata", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 270, Kalori = 215, Karbonhidrat = 5.28F, Protein = 21.96F, Yag = 6.35F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(tonBalikliSalata);

            BesinBilgileri kisir = new BesinBilgileri() { BesinAdi = "Kısır", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 60, Kalori = 108, Karbonhidrat = 15.84F, Protein = 2.71F, Yag = 4.64F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kisir);

            BesinBilgileri mercimekKoftesi = new BesinBilgileri() { BesinAdi = "Mercimet Köftesi", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 30, Kalori = 70, Karbonhidrat = 9.95F, Protein = 2.75F, Yag = 2.41F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(mercimekKoftesi);

            BesinBilgileri tabuleSalatasi = new BesinBilgileri() { BesinAdi = "Tabule Salatası", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 370, Kalori = 588, Karbonhidrat = 51, Protein = 14.4F, Yag = 33.3F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(tabuleSalatasi);

            BesinBilgileri peynirliYumurtaliSalata = new BesinBilgileri() { BesinAdi = "Peynirli Yumurtalı Salata", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 260, Kalori = 225, Karbonhidrat = 6.7F, Protein = 16.78F, Yag = 9.81F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(peynirliYumurtaliSalata);

            BesinBilgileri cobanSalata = new BesinBilgileri() { BesinAdi = "Çoban Salata", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 220, Kalori = 115, Karbonhidrat = 16.62F, Protein = 3.19F, Yag = 3.76F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(cobanSalata);

            BesinBilgileri gavurdağiSalata = new BesinBilgileri() { BesinAdi = "Gavurdağı Salata", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 155, Kalori = 114, Karbonhidrat = 7.71F, Protein = 2.95F, Yag = 7.72F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(gavurdağiSalata);

            BesinBilgileri patatesSalatasi = new BesinBilgileri() { BesinAdi = "Patates Salatası", OlcuBirimi = OlcuBirimi.Tabak, GramKarsiligi = 187, Kalori = 132, Karbonhidrat = 21.77F, Protein = 2.46F, Yag = 3.33F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(patatesSalatasi);

            BesinBilgileri meyveSalatasi = new BesinBilgileri() { BesinAdi = "Meyve Salatası", OlcuBirimi = OlcuBirimi.Kase, GramKarsiligi = 315, Kalori = 172, Karbonhidrat = 38.4F, Protein = 1.65F, Yag = 0.96F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(meyveSalatasi);



            //KURUYEMİŞLER



            BesinBilgileri kestane = new BesinBilgileri() { BesinAdi = "Kestane", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 50, Kalori = 98, Karbonhidrat = 22.09F, Protein = 0.81F, Yag = 0.62F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kestane);

            BesinBilgileri patlamişMisir = new BesinBilgileri() { BesinAdi = "Patlamış Mısır", OlcuBirimi = OlcuBirimi.Kase, GramKarsiligi = 20, Kalori = 76, Karbonhidrat = 15.58F, Protein = 2.40F, Yag = 0.84F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(patlamişMisir);

            BesinBilgileri sariLeblebi = new BesinBilgileri() { BesinAdi = "Sarı Leblebi", OlcuBirimi = OlcuBirimi.Avuc, GramKarsiligi = 20, Kalori = 71, Karbonhidrat = 11.7F, Protein = 3.73F, Yag = 1.25F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(sariLeblebi);

            BesinBilgileri beyazLeblebi = new BesinBilgileri() { BesinAdi = "Beyaz Leblebi", OlcuBirimi = OlcuBirimi.Avuc, GramKarsiligi = 20, Kalori = 72, Karbonhidrat = 11.9F, Protein = 3.79F, Yag = 1.2F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(beyazLeblebi);

            BesinBilgileri findik = new BesinBilgileri() { BesinAdi = "Fındık", OlcuBirimi = OlcuBirimi.Avuc, GramKarsiligi = 15, Kalori = 97, Karbonhidrat = 2.57F, Protein = 2.30F, Yag = 9.36F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(findik);

            BesinBilgileri badem = new BesinBilgileri() { BesinAdi = "Sarı Leblebi", OlcuBirimi = OlcuBirimi.Avuc, GramKarsiligi = 17, Kalori = 97, Karbonhidrat = 3.62F, Protein = 3.55F, Yag = 8.39F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(badem);

            BesinBilgileri yerFistigi = new BesinBilgileri() { BesinAdi = "Yer Fıstığı", OlcuBirimi = OlcuBirimi.Avuc, GramKarsiligi = 30, Kalori = 170, Karbonhidrat = 4.84F, Protein = 7.74F, Yag = 14.77F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(yerFistigi);

            BesinBilgileri antepFistigi = new BesinBilgileri() { BesinAdi = "Antep Fıstığı", OlcuBirimi = OlcuBirimi.Avuc, GramKarsiligi = 18, Kalori = 103, Karbonhidrat = 5.09F, Protein = 3.79F, Yag = 8.25F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(antepFistigi);

            BesinBilgileri ceviz = new BesinBilgileri() { BesinAdi = "Ceviz", OlcuBirimi = OlcuBirimi.Avuc, GramKarsiligi = 10, Kalori = 52, Karbonhidrat = 1.1F, Protein = 1.22F, Yag = 5.22F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(ceviz);

            BesinBilgileri kabakCekirdegi = new BesinBilgileri() { BesinAdi = "Kabak Çekirdeği", OlcuBirimi = OlcuBirimi.Avuc, GramKarsiligi = 20, Kalori = 104.4F, Karbonhidrat = 2.68F, Protein = 6.6F, Yag = 8.42F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kabakCekirdegi);

            BesinBilgileri cigKaju = new BesinBilgileri() { BesinAdi = "Çiğ Kaju", OlcuBirimi = OlcuBirimi.Avuc, GramKarsiligi = 20, Kalori = 111, Karbonhidrat = 6.04F, Protein = 3.64F, Yag = 8.77F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(cigKaju);

            BesinBilgileri kavrulmusKaju = new BesinBilgileri() { BesinAdi = "Kaju Fıstığı Kavrulmuş", OlcuBirimi = OlcuBirimi.Avuc, GramKarsiligi = 40, Kalori = 230, Karbonhidrat = 13.08F, Protein = 6.12F, Yag = 18.54F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kavrulmusKaju);

            BesinBilgileri galeta = new BesinBilgileri() { BesinAdi = "Sarı Leblebi", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 7, Kalori = 32, Karbonhidrat = 5.2F, Protein = 0.66F, Yag = 0.76F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(galeta);


            BesinBilgileri erikKurusu = new BesinBilgileri() { BesinAdi = "Erik Kurusu", OlcuBirimi = OlcuBirimi.Kase, GramKarsiligi = 100, Kalori = 267, Karbonhidrat = 68.9F, Protein = 3.5F, Yag = 1.2F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(erikKurusu);

            BesinBilgileri uzumKurusu = new BesinBilgileri() { BesinAdi = "Üzüm Kurusu", OlcuBirimi = OlcuBirimi.Kase, GramKarsiligi = 100, Kalori = 277, Karbonhidrat = 71.2F, Protein = 2.3F, Yag = 0.5F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(uzumKurusu);

            BesinBilgileri kayisiKurusu = new BesinBilgileri() { BesinAdi = "Kayısı Kurusu", OlcuBirimi = OlcuBirimi.Kase, GramKarsiligi = 100, Kalori = 284, Karbonhidrat = 72.2F, Protein = 5.4F, Yag = 1.2F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kayisiKurusu);

            BesinBilgileri elmaKurusu = new BesinBilgileri() { BesinAdi = "Elma Kurusu", OlcuBirimi = OlcuBirimi.Kase, GramKarsiligi = 100, Kalori = 238, Karbonhidrat = 62.3F, Protein = 2.1F, Yag = 2.1F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(elmaKurusu);

            BesinBilgileri muzKurusu = new BesinBilgileri() { BesinAdi = "Muz Kurusu", OlcuBirimi = OlcuBirimi.Kase, GramKarsiligi = 100, Kalori = 390, Karbonhidrat = 80.5F, Protein = 3.9F, Yag = 1.8F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(muzKurusu);

            BesinBilgileri kuruIncır = new BesinBilgileri() { BesinAdi = "Kuru İncir", OlcuBirimi = OlcuBirimi.Kase, GramKarsiligi = 100, Kalori = 290, Karbonhidrat = 78, Protein = 3.6F, Yag = 1.2F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kuruIncır);

            BesinBilgileri hurma = new BesinBilgileri() { BesinAdi = "Hurma", OlcuBirimi = OlcuBirimi.Kase, GramKarsiligi = 100, Kalori = 277, Karbonhidrat = 74, Protein = 2, Yag = 0.4F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(hurma);

            BesinBilgileri yabanMersini = new BesinBilgileri() { BesinAdi = "Yaban Mersini Kurusu", OlcuBirimi = OlcuBirimi.Kase, GramKarsiligi = 100, Kalori = 48, Karbonhidrat = 12, Protein = 0.38F, Yag = 0.38F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(yabanMersini);

            BesinBilgileri armutKurusu = new BesinBilgileri() { BesinAdi = "Armut Kurusu", OlcuBirimi = OlcuBirimi.Kase, GramKarsiligi = 100, Kalori = 270, Karbonhidrat = 62.6F, Protein = 2.3F, Yag = 0.6F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(armutKurusu);


            //ATIŞTIRMALIKLAR



            BesinBilgileri patatesCipsi = new BesinBilgileri() { BesinAdi = "Patates Cipsi", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 100, Kalori = 719, Karbonhidrat = 10.46F, Protein = 1.23F, Yag = 74.78F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(patatesCipsi);

            BesinBilgileri misirCipsi = new BesinBilgileri() { BesinAdi = "Mısır Cipsi", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 100, Kalori = 404, Karbonhidrat = 42.68F, Protein = 4.95F, Yag = 25.05F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(misirCipsi);

            BesinBilgileri pringles = new BesinBilgileri() { BesinAdi = "Pringles Original", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 165, Kalori = 861, Karbonhidrat = 84.15F, Protein = 6.27F, Yag = 56.1F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(pringles);

            BesinBilgileri ulkerGofret = new BesinBilgileri() { BesinAdi = "Ülker Çikolatalı Gofret", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 100, Kalori = 198, Karbonhidrat = 20.72F, Protein = 2.13F, Yag = 11.83F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(ulkerGofret);

            BesinBilgileri jelibon = new BesinBilgileri() { BesinAdi = "Jelibon", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 100, Kalori = 302, Karbonhidrat = 68.31F, Protein = 5.85F, Yag = 0.09F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(jelibon);

            BesinBilgileri petiborBiskuvi = new BesinBilgileri() { BesinAdi = "Petibör Bisküvi", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 175, Kalori = 765, Karbonhidrat = 139.77F, Protein = 13.53F, Yag = 16.8F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(petiborBiskuvi);

            BesinBilgileri formKepekliBiskuvi = new BesinBilgileri() { BesinAdi = "Form Kepekli Bisküvi", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 45, Kalori = 184, Karbonhidrat = 26.69F, Protein = 5.9F, Yag = 4.86F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(formKepekliBiskuvi);

            BesinBilgileri ciciBebeBiskuvi = new BesinBilgileri() { BesinAdi = "Cicibebe Bisküvi", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 4, Kalori = 18, Karbonhidrat = 2.96F, Protein = 0.18F, Yag = 0.6F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(ciciBebeBiskuvi);

            BesinBilgileri cikolata = new BesinBilgileri() { BesinAdi = "Çikolata", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 5, Kalori = 26, Karbonhidrat = 2.9F, Protein = 0.22F, Yag = 1.76F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(cikolata);

            BesinBilgileri proteinBar = new BesinBilgileri() { BesinAdi = "Protein Bar", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 50, Kalori = 76, Karbonhidrat = 6.6F, Protein = 2.21F, Yag = 4.54F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(proteinBar);

            BesinBilgileri oreo = new BesinBilgileri() { BesinAdi = "Oreo", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 57, Kalori = 270, Karbonhidrat = 41.04F, Protein = 2, Yag = 10.83F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(oreo);

            BesinBilgileri olips = new BesinBilgileri() { BesinAdi = "Olips Şeker", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 76, Kalori = 286, Karbonhidrat = 72.2F, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(olips);

            BesinBilgileri tadelle = new BesinBilgileri() { BesinAdi = "Tadelle Çikolata", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 30, Kalori = 167, Karbonhidrat = 14.31F, Protein = 2.7F, Yag = 10.98F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(tadelle);

            BesinBilgileri dido = new BesinBilgileri() { BesinAdi = "Dido Çikolata", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 35, Kalori = 190, Karbonhidrat = 21.88F, Protein = 2.7F, Yag = 9.98F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(dido);

            BesinBilgileri karamGurme = new BesinBilgileri() { BesinAdi = "Karam Gurme", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 50, Kalori = 259, Karbonhidrat = 29, Protein = 2.75F, Yag = 14, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(karamGurme);

            BesinBilgileri etiBrownie = new BesinBilgileri() { BesinAdi = "Eti Brownie Gold", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 40, Kalori = 154, Karbonhidrat = 22, Protein = 2.04F, Yag = 7.92F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etiBrownie);

            BesinBilgileri kinderSutDilimi = new BesinBilgileri() { BesinAdi = "Kinder Süt Dilimi", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 28, Kalori = 118, Karbonhidrat = 10.75F, Protein = 2.16F, Yag = 7.28F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kinderSutDilimi);

            BesinBilgileri kinderSurpriz = new BesinBilgileri() { BesinAdi = "Kinder Sürpriz Yumurta", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 20, Kalori = 110, Karbonhidrat = 10.4F, Protein = 1.6F, Yag = 6.8F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kinderSurpriz);

            BesinBilgileri etiGong = new BesinBilgileri() { BesinAdi = "Eti Gong", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 11, Kalori = 50, Karbonhidrat = 7.84F, Protein = 0.64F, Yag = 1.78F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etiGong);

            BesinBilgileri biskrem = new BesinBilgileri() { BesinAdi = "Biskrem", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 10, Kalori = 50, Karbonhidrat = 6.51F, Protein = 0.45F, Yag = 2.41F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(biskrem);

            BesinBilgileri probis = new BesinBilgileri() { BesinAdi = "Ülker Probis", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 8, Kalori = 39, Karbonhidrat = 4.37F, Protein = 0.93F, Yag = 1.9F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(probis);

            BesinBilgileri sutBurger = new BesinBilgileri() { BesinAdi = "Süt Burger", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 35, Kalori = 113, Karbonhidrat = 17.05F, Protein = 1.75F, Yag = 3.78F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(sutBurger);

            BesinBilgileri dankek = new BesinBilgileri() { BesinAdi = "Dankek 8kek", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 55, Kalori = 90, Karbonhidrat = 12.65F, Protein = 0.88F, Yag = 4.01F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(dankek);

            BesinBilgileri brownieIntense = new BesinBilgileri() { BesinAdi = "Brownie Intense", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 50, Kalori = 232, Karbonhidrat = 26.5F, Protein = 2.3F, Yag = 12.85F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(brownieIntense);

            BesinBilgileri etiTopkek1 = new BesinBilgileri() { BesinAdi = "Eti Topkek Kakolu", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 40, Kalori = 167, Karbonhidrat = 22.96F, Protein = 2.12F, Yag = 7.24F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etiTopkek1);

            BesinBilgileri etiPopkek2 = new BesinBilgileri() { BesinAdi = "Eti Popkek Meyveli", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 60, Kalori = 264, Karbonhidrat = 34.62F, Protein = 2.82F, Yag = 12.6F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etiPopkek2);

            BesinBilgileri etiTopKek3 = new BesinBilgileri() { BesinAdi = "Eti Topkek Portakallı", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 40, Kalori = 167, Karbonhidrat = 22.96F, Protein = 2.12F, Yag = 7.24F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etiTopKek3);

            BesinBilgileri halley = new BesinBilgileri() { BesinAdi = "Halley", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 30, Kalori = 132, Karbonhidrat = 20.31F, Protein = 1.2F, Yag = 5.1F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(halley);

            BesinBilgileri kremaliBiskuvi = new BesinBilgileri() { BesinAdi = "Ülker Kremalı Bisküvi", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 7, Kalori = 33, Karbonhidrat = 5.16F, Protein = 0.36F, Yag = 1.27F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kremaliBiskuvi);

            BesinBilgileri cokoprens = new BesinBilgileri() { BesinAdi = "Ülker Çokoprens", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 30, Kalori = 152, Karbonhidrat = 18.6F, Protein = 1.68F, Yag = 7.8F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(cokoprens);

            BesinBilgileri etiCin = new BesinBilgileri() { BesinAdi = "Eti Cin", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 10, Kalori = 44, Karbonhidrat = 7.43F, Protein = 0.47F, Yag = 1.38F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etiCin);

            BesinBilgileri etiNero = new BesinBilgileri() { BesinAdi = "Eti Nero", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 120, Kalori = 584, Karbonhidrat = 69.72F, Protein = 8.28F, Yag = 29.28F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etiNero);

            BesinBilgileri etiTutku = new BesinBilgileri() { BesinAdi = "Eti Tutku", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 10, Kalori = 51, Karbonhidrat = 6.1F, Protein = 0.5F, Yag = 2.6F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etiTutku);

            BesinBilgileri etiBenimO = new BesinBilgileri() { BesinAdi = "Eti Benim'O", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 10, Kalori = 46, Karbonhidrat = 6.13F, Protein = 0.47F, Yag = 2.16F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etiBenimO);

            BesinBilgileri etiBurcak = new BesinBilgileri() { BesinAdi = "Eti Burçak", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 15, Kalori = 68, Karbonhidrat = 9.87F, Protein = 0.93F, Yag = 2.54F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etiBurcak);

            BesinBilgileri ulkerIkram = new BesinBilgileri() { BesinAdi = "Ülker İkram", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 84, Kalori = 405, Karbonhidrat = 52.92F, Protein = 6.47F, Yag = 17.64F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(ulkerIkram);

            BesinBilgileri lotus = new BesinBilgileri() { BesinAdi = "Lotus Bisküvi", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 125, Kalori = 605, Karbonhidrat = 90.75F, Protein = 6.13F, Yag = 23.75F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(lotus);

            BesinBilgileri gretaZeytinli = new BesinBilgileri() { BesinAdi = "Şölen Greta Zeytinli", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 30, Kalori = 133, Karbonhidrat = 18.1F, Protein = 2.8F, Yag = 5.4F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(gretaZeytinli);

            BesinBilgileri cokonat = new BesinBilgileri() { BesinAdi = "Ülker Çokonat", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 33, Kalori = 181, Karbonhidrat = 19.11F, Protein = 2.05F, Yag = 11.32F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(cokonat);

            BesinBilgileri kinderBueno = new BesinBilgileri() { BesinAdi = "Kinder Bueno", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 21, Kalori = 120, Karbonhidrat = 10.4F, Protein = 1.81F, Yag = 7.83F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kinderBueno);

            BesinBilgileri etiHoşbeş = new BesinBilgileri() { BesinAdi = "Eti Hoşbeş", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 40, Kalori = 197, Karbonhidrat = 25.56F, Protein = 3.04F, Yag = 9.8F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(etiHoşbeş);

            BesinBilgileri twix = new BesinBilgileri() { BesinAdi = "Twix", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 50, Kalori = 250, Karbonhidrat = 34, Protein = 4, Yag = 12, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(twix);

            BesinBilgileri snickers = new BesinBilgileri() { BesinAdi = "Snickers", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 50, Kalori = 237, Karbonhidrat = 31.31F, Protein = 3.8F, Yag = 11.35F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(snickers);

            BesinBilgileri mars = new BesinBilgileri() { BesinAdi = "Mars", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 50, Kalori = 225, Karbonhidrat = 35, Protein = 2, Yag = 8.5F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(mars);

            BesinBilgileri albeni = new BesinBilgileri() { BesinAdi = "Ülker Albeni", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 40, Kalori = 206, Karbonhidrat = 25.2F, Protein = 2.24F, Yag = 10.64F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(albeni);

            BesinBilgileri crunch = new BesinBilgileri() { BesinAdi = "Crunch Çikolata", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 33, Kalori = 169, Karbonhidrat = 20.16F, Protein = 2.05F, Yag = 8.74F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(crunch);

            BesinBilgileri metro = new BesinBilgileri() { BesinAdi = "Ülker Metro", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 40, Kalori = 184, Karbonhidrat = 27.36F, Protein = 1.96F, Yag = 7.4F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(metro);

            BesinBilgileri frigo = new BesinBilgileri() { BesinAdi = "Alaska Frigo", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 60, Kalori = 193, Karbonhidrat = 22.98F, Protein = 2.4F, Yag = 9.78F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(frigo);

            BesinBilgileri cocoStar = new BesinBilgileri() { BesinAdi = "Coco Star", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 28, Kalori = 148, Karbonhidrat = 15.48F, Protein = 1.2F, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(cocoStar);

            BesinBilgileri cubukKraker = new BesinBilgileri() { BesinAdi = "Sade Çubuk Kraker", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 52, Kalori = 200, Karbonhidrat = 40.82F, Protein = 5.51F, Yag = 2.91F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(cubukKraker);

            BesinBilgileri susamliCubukKraker = new BesinBilgileri() { BesinAdi = "Susamlı Çubuk Kraker", OlcuBirimi = OlcuBirimi.Paket, GramKarsiligi = 37, Kalori = 172, Karbonhidrat = 22.39F, Protein = 3.89F, Yag = 7.1F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(susamliCubukKraker);

            BesinBilgileri cizi = new BesinBilgileri() { BesinAdi = "Çizi Bisküvi", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 20, Kalori = 113, Karbonhidrat = 5.47F, Protein = 3.15F, Yag = 8.86F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(cizi);

            BesinBilgileri cornetto = new BesinBilgileri() { BesinAdi = "Cornetto", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 75, Kalori = 125, Karbonhidrat = 15, Protein = 1.56F, Yag = 6.25F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(cornetto);

            BesinBilgileri magnum = new BesinBilgileri() { BesinAdi = "Magnum", OlcuBirimi = OlcuBirimi.Adet, GramKarsiligi = 77, Kalori = 239, Karbonhidrat = 24.64F, Protein = 2.7F, Yag = 14.63F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(magnum);

            BesinBilgileri misirGevregi = new BesinBilgileri() { BesinAdi = "Mısır Gevreği / Cornflakes", OlcuBirimi = OlcuBirimi.Kase, GramKarsiligi = 50, Kalori = 179, Karbonhidrat = 42.05F, Protein = 3.75F, Yag = 0.2F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(misirGevregi);

            BesinBilgileri yulafEzmesi = new BesinBilgileri() { BesinAdi = "Yulaf Ezmesi", OlcuBirimi = OlcuBirimi.Kase, GramKarsiligi = 100, Kalori = 195, Karbonhidrat = 33.14F, Protein = 8.45F, Yag = 3.45F, CreatedBy = "Ceren" };

            context.BesinBilgileri.Add(yulafEzmesi);

            //ALKOLSÜZ İÇECEKLER



            BesinBilgileri madenSuyu = new BesinBilgileri() { BesinAdi = "Maden Suyu", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 0, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(madenSuyu);


            BesinBilgileri bergamotCayi = new BesinBilgileri() { BesinAdi = "Bergamot Çayı (150 ml)", OlcuBirimi = OlcuBirimi.CayBardagi, Kalori = 2.6F, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(bergamotCayi);

            BesinBilgileri boza = new BesinBilgileri() { BesinAdi = "Boza", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 279, Karbonhidrat = 60, Protein = 45, Yag = 1.8F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(boza);

            BesinBilgileri salep = new BesinBilgileri() { BesinAdi = "Salep", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 188, Karbonhidrat = 27.8F, Protein = 5.6F, Yag = 6, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(salep);

            BesinBilgileri sprite = new BesinBilgileri() { BesinAdi = "Kahve", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 79, Karbonhidrat = 21.4F, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(sprite);

            BesinBilgileri cocaCola = new BesinBilgileri() { BesinAdi = "CocaCola", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 90, Karbonhidrat = 22.4F, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(cocaCola);

            BesinBilgileri diyetKola = new BesinBilgileri() { BesinAdi = "CocaCola Light", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 0, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(diyetKola);

            BesinBilgileri colaZero = new BesinBilgileri() { BesinAdi = "CocaCola Zero", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 0, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(colaZero);

            BesinBilgileri fanta = new BesinBilgileri() { BesinAdi = "Fanta", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 95, Karbonhidrat = 23.4F, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(fanta);

            BesinBilgileri iceTea = new BesinBilgileri() { BesinAdi = "Bergamot Çayı", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 60, Karbonhidrat = 14, Protein = 1, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(iceTea);

            BesinBilgileri limonata = new BesinBilgileri() { BesinAdi = "Limonata", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 73, Karbonhidrat = 14.69F, Protein = 0.24F, Yag = 0.2F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(limonata);

            BesinBilgileri gazoz = new BesinBilgileri() { BesinAdi = "Gazoz", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 84, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(gazoz);

            BesinBilgileri kahve = new BesinBilgileri() { BesinAdi = "Kahve", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 2, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kahve);

            BesinBilgileri milkshake = new BesinBilgileri() { BesinAdi = "Milkshake", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 230, Karbonhidrat = 36.8F, Protein = 7.2F, Yag = 5.6F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(milkshake);

            BesinBilgileri smoothie = new BesinBilgileri() { BesinAdi = "Smoothie", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 82, Karbonhidrat = 21, Protein = 0.1F, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(smoothie);

            BesinBilgileri meyveSuyu = new BesinBilgileri() { BesinAdi = "Meyve Suyu", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 100, Karbonhidrat = 24.2F, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(meyveSuyu);

            BesinBilgileri portakalSuyu = new BesinBilgileri() { BesinAdi = "Taze Sıkma Portakal Suyu", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 120, Karbonhidrat = 29.28F, Protein = 0.8F, Yag = 0.33F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(portakalSuyu);

            BesinBilgileri narSuyu = new BesinBilgileri() { BesinAdi = "Nar Suyu", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 2, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(narSuyu);

            BesinBilgileri salgamSuyu = new BesinBilgileri() { BesinAdi = "Şalgam Suyu", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 10, Karbonhidrat = 2.12F, Protein = 1.03F, Yag = 0.22F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(salgamSuyu);

            BesinBilgileri sicakCikolata = new BesinBilgileri() { BesinAdi = "Sıcak Çikolata", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 106, Karbonhidrat = 26.06F, Protein = 0, Yag = 0.1F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(sicakCikolata);

            BesinBilgileri powerade = new BesinBilgileri() { BesinAdi = "Powerade", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 32, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(powerade);

            BesinBilgileri redBull = new BesinBilgileri() { BesinAdi = "Red Bull", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 90, Karbonhidrat = 22, Protein = 0.6F, Yag = 0.2F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(redBull);

            BesinBilgileri zencefilliCay = new BesinBilgileri() { BesinAdi = "Zencefilli Bitki Çayı", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 0, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(zencefilliCay);

            BesinBilgileri cay = new BesinBilgileri() { BesinAdi = "Çay", OlcuBirimi = OlcuBirimi.CayBardagi, Kalori = 10, Karbonhidrat = 2.35F, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(cay);

            BesinBilgileri turkKahvesi = new BesinBilgileri() { BesinAdi = "Türk Kahvesi", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 4, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(turkKahvesi);

            BesinBilgileri whiteChocolateMocha = new BesinBilgileri() { BesinAdi = "White Chocolate Mocha", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 259, Karbonhidrat = 31.86F, Protein = 7.55F, Yag = 12.04F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(whiteChocolateMocha);

            BesinBilgileri coolLime = new BesinBilgileri() { BesinAdi = "Cool Lime", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 25, Karbonhidrat = 6.99F, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(coolLime);

            BesinBilgileri berryHibiscus = new BesinBilgileri() { BesinAdi = "Starbucks Berry Hibiscus", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 60, Karbonhidrat = 20, Protein = 0, Yag = 0, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(berryHibiscus);

            BesinBilgileri cappuccino = new BesinBilgileri() { BesinAdi = "Cappuccino", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 50, Karbonhidrat = 7, Protein = 4.19F, Yag = 0.005F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(cappuccino);

            BesinBilgileri latte = new BesinBilgileri() { BesinAdi = "Latte", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 60, Karbonhidrat = 8.5F, Protein = 6, Yag = 0.005F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(latte);

            BesinBilgileri filtreKahve = new BesinBilgileri() { BesinAdi = "Filtre Kahve", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 3, Karbonhidrat = 0, Protein = 0.28F, Yag = 0.07F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(filtreKahve);

            BesinBilgileri nescafeXpress = new BesinBilgileri() { BesinAdi = "Nescafe Xpress", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 100, Karbonhidrat = 16.4F, Protein = 2.8F, Yag = 2.6F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(nescafeXpress);

            BesinBilgileri nescafe3 = new BesinBilgileri() { BesinAdi = "Nescafe 3'ü 1 arada", OlcuBirimi = OlcuBirimi.Adet, Kalori = 81, Karbonhidrat = 15.19F, Protein = 0.5F, Yag = 1.89F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(nescafe3);


            //EV YEMEKLERİ


            BesinBilgileri pilavUstuFasulye = new BesinBilgileri() { BesinAdi = "Pilav Üstü Kuru", OlcuBirimi = OlcuBirimi.Porsiyon, GramKarsiligi = 230, Kalori = 336, Karbonhidrat = 57.52F, Protein = 15.28F, Yag = 4.44F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(pilavUstuFasulye);

            BesinBilgileri hamsiliPilav = new BesinBilgileri() { BesinAdi = "Hamsili Pilav", OlcuBirimi = OlcuBirimi.Porsiyon, GramKarsiligi = 230, Kalori = 334, Karbonhidrat = 30.3F, Protein = 26.52F, Yag = 12.29F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(hamsiliPilav);

            BesinBilgileri sehriyeliPilav = new BesinBilgileri() { BesinAdi = "Şehriyeli Pilav", OlcuBirimi = OlcuBirimi.Porsiyon, GramKarsiligi = 270, Kalori = 462, Karbonhidrat = 82.85F, Protein = 8.53F, Yag = 10.01F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(sehriyeliPilav);

            BesinBilgileri nohutluPilav = new BesinBilgileri() { BesinAdi = "Nohutlu Pilav ", OlcuBirimi = OlcuBirimi.Porsiyon, GramKarsiligi = 100, Kalori = 169, Karbonhidrat = 31.29F, Protein = 4.15F, Yag = 2.94F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(nohutluPilav);

            BesinBilgileri icPilav = new BesinBilgileri() { BesinAdi = "İç Pilav", OlcuBirimi = OlcuBirimi.Porsiyon, GramKarsiligi = 100, Kalori = 139, Karbonhidrat = 25.99F, Protein = 2.59F, Yag = 2.53F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(icPilav);

            BesinBilgileri sadePilav = new BesinBilgileri() { BesinAdi = "Sade Pilav", OlcuBirimi = OlcuBirimi.Porsiyon, GramKarsiligi = 80, Kalori = 118, Karbonhidrat = 22.62F, Protein = 1.99F, Yag = 1.99F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(sadePilav);

            BesinBilgileri domatesliBulgurPilavi = new BesinBilgileri() { BesinAdi = "Domatesli Bulgur Pilavı", OlcuBirimi = OlcuBirimi.Porsiyon, GramKarsiligi = 230, Kalori = 169, Karbonhidrat = 31.13F, Protein = 4.56F, Yag = 2.61F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(domatesliBulgurPilavi);

            BesinBilgileri acemPilavi = new BesinBilgileri() { BesinAdi = "Acem Pilavı", OlcuBirimi = OlcuBirimi.Porsiyon, GramKarsiligi = 245, Kalori = 480, Karbonhidrat = 43.69F, Protein = 22.32F, Yag = 23.76F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(acemPilavi);

            BesinBilgileri ozbekPilavi = new BesinBilgileri() { BesinAdi = "Özbek Pilavı", OlcuBirimi = OlcuBirimi.Porsiyon, GramKarsiligi = 340, Kalori = 570, Karbonhidrat = 58.2F, Protein = 22.35F, Yag = 27.56F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(ozbekPilavi);

            BesinBilgileri basmatiPilavi = new BesinBilgileri() { BesinAdi = "Basmati Pilavı", OlcuBirimi = OlcuBirimi.Porsiyon, GramKarsiligi = 50, Kalori = 118, Karbonhidrat = 14.05F, Protein = 1.65F, Yag = 3.1F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(basmatiPilavi);

            BesinBilgileri kuskusPilavi = new BesinBilgileri() { BesinAdi = "Kuskus Pilavı", OlcuBirimi = OlcuBirimi.Porsiyon, GramKarsiligi = 180, Kalori = 380, Karbonhidrat = 72.76F, Protein = 11.79F, Yag = 3.75F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(kuskusPilavi);

            BesinBilgileri tereyaglıPrincPilavi = new BesinBilgileri() { BesinAdi = "Tereyağlı Pirinç Pilavı", OlcuBirimi = OlcuBirimi.Porsiyon, GramKarsiligi = 170, Kalori = 283, Karbonhidrat = 46.47F, Protein = 4.14F, Yag = 8.65F, CreatedBy = "Ceren" };
            context.BesinBilgileri.Add(tereyaglıPrincPilavi);



            BesinBilgileri bezelyeCorbasi = new BesinBilgileri() { BesinAdi = "Bezelye Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 31, Karbonhidrat = 3.06F, Protein = 1.05F, Yag = 1.6F, GramKarsiligi = 150, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(bezelyeCorbasi);


            BesinBilgileri domatesCorbasi = new BesinBilgileri() { BesinAdi = "Domates Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 47, Karbonhidrat = 6.53F, Protein = 1.36F, Yag = 1.66F, GramKarsiligi = 150, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(domatesCorbasi);

            BesinBilgileri kasarliDomatesCorbasi = new BesinBilgileri() { BesinAdi = "Kaşarlı Domates Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 31, Karbonhidrat = 2.07F, Protein = 1.68F, Yag = 1.73F, GramKarsiligi = 100, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(kasarliDomatesCorbasi);

            BesinBilgileri ezogelinCorbasi = new BesinBilgileri() { BesinAdi = "Ezogelin Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 68, Karbonhidrat = 8.92F, Protein = 2.83F, Yag = 1.76F, GramKarsiligi = 150, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(ezogelinCorbasi);


            BesinBilgileri iskembeCorbasi = new BesinBilgileri() { BesinAdi = "İşkembe Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 139, Karbonhidrat = 4.93F, Protein = 15.14F, Yag = 6.35F, GramKarsiligi = 100, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(iskembeCorbasi);

            BesinBilgileri kirmiziMercimekCorbasi = new BesinBilgileri() { BesinAdi = "Kırmızı Mercimek Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 68, Karbonhidrat = 12.42F, Protein = 3.69F, Yag = 0.29F, GramKarsiligi = 150, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(kirmiziMercimekCorbasi);


            BesinBilgileri yesilMercimekCorbasi = new BesinBilgileri() { BesinAdi = "Yeşil Mercimek Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 121, Karbonhidrat = 12.04F, Protein = 4.5F, Yag = 6.03F, GramKarsiligi = 150, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(yesilMercimekCorbasi);

            BesinBilgileri sebzeCorbasi = new BesinBilgileri() { BesinAdi = "Sebze Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 44, Karbonhidrat = 6.06F, Protein = 1, Yag = 1.68F, GramKarsiligi = 100, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(sebzeCorbasi);

            BesinBilgileri tarhanaCorbasi = new BesinBilgileri() { BesinAdi = "Tarhana Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 91, Karbonhidrat = 7.48F, Protein = 3.45F, Yag = 4.93F, GramKarsiligi = 150, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(tarhanaCorbasi);

            BesinBilgileri yaylaCorbasi = new BesinBilgileri() { BesinAdi = "Yayla Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 70, Karbonhidrat = 9.71F, Protein = 12.19F, Yag = 2.41F, GramKarsiligi = 150, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(yaylaCorbasi);

            BesinBilgileri tavukCorbasi = new BesinBilgileri() { BesinAdi = "Tavuk Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 83, Karbonhidrat = 5.17F, Protein = 5.96F, Yag = 2.95F, GramKarsiligi = 150, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(tavukCorbasi);


            BesinBilgileri balkabagiCorbasi = new BesinBilgileri() { BesinAdi = "Balkabaği Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 29, Karbonhidrat = 2.41F, Protein = 1.87F, Yag = 1.19F, GramKarsiligi = 100, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(balkabagiCorbasi);

            BesinBilgileri mantarCorbasi = new BesinBilgileri() { BesinAdi = "Mantar Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 99, Karbonhidrat = 7.36F, Protein = 3.06F, Yag = 6.37F, GramKarsiligi = 150, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(mantarCorbasi);

            BesinBilgileri kremaliMantarCorbasi = new BesinBilgileri() { BesinAdi = "Kremalı Mantar Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 120, Karbonhidrat = 5.21F, Protein = 1.92F, Yag = 11.27F, GramKarsiligi = 150, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(kremaliMantarCorbasi);

            BesinBilgileri brokoliCorbasi = new BesinBilgileri() { BesinAdi = "Brokoli Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 39, Karbonhidrat = 5.06F, Protein = 1.37F, Yag = 1.47F, GramKarsiligi = 150, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(brokoliCorbasi);


            BesinBilgileri pacaCorbasi = new BesinBilgileri() { BesinAdi = "Paça Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 117, Karbonhidrat = 0.86F, Protein = 18.81F, Yag = 4.29F, GramKarsiligi = 150, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(pacaCorbasi);

            BesinBilgileri balikCorbasi = new BesinBilgileri() { BesinAdi = "Balik Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 49, Karbonhidrat = 4.43F, Protein = 4.51F, Yag = 1.27F, GramKarsiligi = 100, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(balikCorbasi);

            BesinBilgileri tutmacCorbasi = new BesinBilgileri() { BesinAdi = "Tutmac Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 72, Karbonhidrat = 7.2F, Protein = 3.01F, Yag = 3.07F, GramKarsiligi = 100, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(tutmacCorbasi);

            BesinBilgileri kerevizCorbasi = new BesinBilgileri() { BesinAdi = "Kereviz Çorbası", OlcuBirimi = OlcuBirimi.Kepce, Kalori = 67, Karbonhidrat = 6.51F, Protein = 0.87F, Yag = 4.16F, GramKarsiligi = 150, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(kerevizCorbasi);

            // ekmek ve tahıllar


            BesinBilgileri beyazEkmek = new BesinBilgileri() { BesinAdi = "Beyaz Ekmek", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 71, Karbonhidrat = 13.17F, Protein = 3.2F, Yag = 0.65F, GramKarsiligi = 30, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(beyazEkmek);

            BesinBilgileri tamBugdayekmeği = new BesinBilgileri() { BesinAdi = "Tam Buğday Ekmeği", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 63, Karbonhidrat = 10.68F, Protein = 3.11F, Yag = 0.88F, GramKarsiligi = 25, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(tamBugdayekmeği);

            BesinBilgileri cavdarEkmegi = new BesinBilgileri() { BesinAdi = "Cavdar Ekmeği", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 63, Karbonhidrat = 13.15F, Protein = 1.81F, Yag = 0.27F, GramKarsiligi = 30, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(cavdarEkmegi);

            BesinBilgileri kepekliEkmegi = new BesinBilgileri() { BesinAdi = "Kepekli Ekmek", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 54, Karbonhidrat = 11.14F, Protein = 1.51F, Yag = 0.38F, GramKarsiligi = 25, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(kepekliEkmegi);

            BesinBilgileri grisini = new BesinBilgileri() { BesinAdi = "Grissini", OlcuBirimi = OlcuBirimi.Adet, Kalori = 20, Karbonhidrat = 3.53F, Protein = 0.51F, Yag = 0.36F, GramKarsiligi = 5, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(grisini);

            BesinBilgileri beyaztostEkmeği = new BesinBilgileri() { BesinAdi = "Beyaz Tost Ekmeği", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 76, Karbonhidrat = 14.31F, Protein = 2.21F, Yag = 1, GramKarsiligi = 30, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(beyaztostEkmeği);

            BesinBilgileri cokTahilliTostEkmegi = new BesinBilgileri() { BesinAdi = "Çok Tahıllı Tost Ekmeği", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 67, Karbonhidrat = 11.65F, Protein = 3.33F, Yag = 0.79F, GramKarsiligi = 28, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(cokTahilliTostEkmegi);

            BesinBilgileri sandvicEkmegi = new BesinBilgileri() { BesinAdi = "Sandviç Ekmeği", OlcuBirimi = OlcuBirimi.Adet, Kalori = 178, Karbonhidrat = 37.21F, Protein = 5.07F, Yag = 1.61F, GramKarsiligi = 65, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(sandvicEkmegi);

            BesinBilgileri kepekliSandvicEkmegi = new BesinBilgileri() { BesinAdi = "Kepekli Sandviç Ekmeği", OlcuBirimi = OlcuBirimi.Adet, Kalori = 171, Karbonhidrat = 31.08F, Protein = 6.72F, Yag = 1.5F, GramKarsiligi = 70, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(kepekliSandvicEkmegi);

            BesinBilgileri hamburgerEkmeği = new BesinBilgileri() { BesinAdi = "Hamburger Ekmeği", OlcuBirimi = OlcuBirimi.Adet, Kalori = 142, Karbonhidrat = 29.64F, Protein = 3.64F, Yag = 1.04F, GramKarsiligi = 52, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(hamburgerEkmeği);

            BesinBilgileri yufka = new BesinBilgileri() { BesinAdi = "Yufka", OlcuBirimi = OlcuBirimi.Adet, Kalori = 387, Karbonhidrat = 80.18F, Protein = 10.94F, Yag = 1.41F, GramKarsiligi = 160, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(yufka);

            BesinBilgileri irmik = new BesinBilgileri() { BesinAdi = "İrmik", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 36, Karbonhidrat = 7.28F, Protein = 1.27F, Yag = 0.11F, GramKarsiligi = 10, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(irmik);

            BesinBilgileri misirNisastasi = new BesinBilgileri() { BesinAdi = "Mısır Nişastası", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 37, Karbonhidrat = 9.06F, Protein = 0.02F, Yag = 0.08F, GramKarsiligi = 10, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(misirNisastasi);

            BesinBilgileri galetaUnu = new BesinBilgileri() { BesinAdi = "Galeta Unu", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 40, Karbonhidrat = 7.2F, Protein = 1.34F, Yag = 0.53F, GramKarsiligi = 10, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(galetaUnu);

            BesinBilgileri un = new BesinBilgileri() { BesinAdi = "Beyaz Un", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 40, Karbonhidrat = 8.54F, Protein = 0.04F, Yag = 0.01F, GramKarsiligi = 10, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(galetaUnu);

            //Hamur işleri

            BesinBilgileri peynirliBorek = new BesinBilgileri() { BesinAdi = "Peynirli Börek", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 194, Karbonhidrat = 25.11F, Protein = 7.58F, Yag = 6.85F, GramKarsiligi = 75, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(peynirliBorek);

            BesinBilgileri patatesliBorek = new BesinBilgileri() { BesinAdi = "Patatesli Börek", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 204, Karbonhidrat = 26.87F, Protein = 4.27F, Yag = 8.67F, GramKarsiligi = 75, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(patatesliBorek);


            BesinBilgileri ispanakliBorek = new BesinBilgileri() { BesinAdi = "Ispanaklı Börek", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 116, Karbonhidrat = 21.39F, Protein = 4.29F, Yag = 2.35F, GramKarsiligi = 75, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(ispanakliBorek);

            BesinBilgileri suBoregi = new BesinBilgileri() { BesinAdi = "Su Böreği", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 172, Karbonhidrat = 18.77F, Protein = 5.39F, Yag = 8.24F, GramKarsiligi = 75, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(suBoregi);

            BesinBilgileri cigBorek = new BesinBilgileri() { BesinAdi = "Çiğ Börek", OlcuBirimi = OlcuBirimi.Adet, Kalori = 264, Karbonhidrat = 32.76F, Protein = 3.18F, Yag = 13.28F, GramKarsiligi = 70, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(cigBorek);

            BesinBilgileri patlicanliBorek = new BesinBilgileri() { BesinAdi = "Patlıcanlı Börek", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 107, Karbonhidrat = 18.43F, Protein = 4.05F, Yag = 1.08F, GramKarsiligi = 75, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(patlicanliBorek);


            BesinBilgileri biskuviliPasta = new BesinBilgileri() { BesinAdi = "Bisküvili Pasta", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 361, Karbonhidrat = 57.1F, Protein = 11.22F, Yag = 7.97F, GramKarsiligi = 220, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(biskuviliPasta);

            BesinBilgileri cikolataliPasta = new BesinBilgileri() { BesinAdi = "Çikolatalı Pasta", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 577, Karbonhidrat = 39.56F, Protein = 7.44F, Yag = 42.85F, GramKarsiligi = 150, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(cikolataliPasta);

            BesinBilgileri meyveliPasta = new BesinBilgileri() { BesinAdi = "Meyveli Pasta", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 257, Karbonhidrat = 41.5F, Protein = 6.38F, Yag = 6.09F, GramKarsiligi = 150, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(meyveliPasta);

            BesinBilgileri muzluRuloiPasta = new BesinBilgileri() { BesinAdi = "Muzlu Rulo Pasta", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 286, Karbonhidrat = 43.49F, Protein = 10.27F, Yag = 6.8F, GramKarsiligi = 160, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(muzluRuloiPasta);

            BesinBilgileri sadeKek = new BesinBilgileri() { BesinAdi = "Sade Kek", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 241, Karbonhidrat = 32.95F, Protein = 4.45F, Yag = 9.15F, GramKarsiligi = 70, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(sadeKek);


            BesinBilgileri kakaoluKek = new BesinBilgileri() { BesinAdi = "Kakaolu Kek", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 268, Karbonhidrat = 31.2F, Protein = 3.94F, Yag = 13.11F, GramKarsiligi = 70, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(kakaoluKek);

            BesinBilgileri havucluKek = new BesinBilgileri() { BesinAdi = "Havuclu Kek", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 249, Karbonhidrat = 26.91F, Protein = 3.84F, Yag = 13.36F, GramKarsiligi = 70, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(havucluKek);


            BesinBilgileri portakalliKek = new BesinBilgileri() { BesinAdi = "Portakallı Kek", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 188, Karbonhidrat = 28.92F, Protein = 3.55F, Yag = 5.7F, GramKarsiligi = 70, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(portakalliKek);

            BesinBilgileri elmaliKurabiye = new BesinBilgileri() { BesinAdi = "Elmalı Kurabiye", OlcuBirimi = OlcuBirimi.Adet, Kalori = 153, Karbonhidrat = 18.08F, Protein = 2.49F, Yag = 7.66F, GramKarsiligi = 45, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(elmaliKurabiye);

            BesinBilgileri findikliKurabiye = new BesinBilgileri() { BesinAdi = "Fındıklı Kurabiye", OlcuBirimi = OlcuBirimi.Adet, Kalori = 238, Karbonhidrat = 22.22F, Protein = 3.86F, Yag = 14.84F, GramKarsiligi = 45, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(findikliKurabiye);

            BesinBilgileri cevizliKurabiye = new BesinBilgileri() { BesinAdi = "Cevizli Kurabiye", OlcuBirimi = OlcuBirimi.Adet, Kalori = 203, Karbonhidrat = 21.61F, Protein = 3.69F, Yag = 11.38F, GramKarsiligi = 45, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(cevizliKurabiye);

            BesinBilgileri cikolataliKurabiye = new BesinBilgileri() { BesinAdi = "Çikolatalı Kurabiye", OlcuBirimi = OlcuBirimi.Adet, Kalori = 210, Karbonhidrat = 21.95F, Protein = 2.97F, Yag = 12.20F, GramKarsiligi = 45, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(cikolataliKurabiye);

            BesinBilgileri yulafliFitKurabiye = new BesinBilgileri() { BesinAdi = "Yulafli Fit Kurabiye", OlcuBirimi = OlcuBirimi.Adet, Kalori = 161, Karbonhidrat = 17.65F, Protein = 5.48F, Yag = 8.68F, GramKarsiligi = 45, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(yulafliFitKurabiye);

            BesinBilgileri kuruUzumluDiyetKurabiye = new BesinBilgileri() { BesinAdi = "Kuru Uzumlu Diyet Kurabiye", OlcuBirimi = OlcuBirimi.Adet, Kalori = 102, Karbonhidrat = 19.39F, Protein = 3.46F, Yag = 1.54F, GramKarsiligi = 45, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(kuruUzumluDiyetKurabiye);

            BesinBilgileri tuzluPastaneKurabiyesi = new BesinBilgileri() { BesinAdi = "Tuzlu Pastane Kurabiyesi", OlcuBirimi = OlcuBirimi.Adet, Kalori = 184, Karbonhidrat = 19.31F, Protein = 3.82F, Yag = 10.22F, GramKarsiligi = 30, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(tuzluPastaneKurabiyesi);

            BesinBilgileri unKurabiyesi = new BesinBilgileri() { BesinAdi = "Tuzlu Pastane Kurabiyesi", OlcuBirimi = OlcuBirimi.Adet, Kalori = 128, Karbonhidrat = 21.06F, Protein = 0.18F, Yag = 4.67F, GramKarsiligi = 30, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(unKurabiyesi);

            BesinBilgileri kandilSimidi = new BesinBilgileri() { BesinAdi = "Kandil Simidi", OlcuBirimi = OlcuBirimi.Adet, Kalori = 167, Karbonhidrat = 14.97F, Protein = 2.93F, Yag = 60.67F, GramKarsiligi = 35, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(kandilSimidi);

            BesinBilgileri simit = new BesinBilgileri() { BesinAdi = "Simit", OlcuBirimi = OlcuBirimi.Adet, Kalori = 275, Karbonhidrat = 57.14F, Protein = 10.71F, Yag = 3.57F, GramKarsiligi = 100, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(simit);

            BesinBilgileri pogaca = new BesinBilgileri() { BesinAdi = "Poğaça", OlcuBirimi = OlcuBirimi.Adet, Kalori = 243, Karbonhidrat = 22.33F, Protein = 4.91F, Yag = 14.74F, GramKarsiligi = 70, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(pogaca);


            BesinBilgileri peynirliPogaca = new BesinBilgileri() { BesinAdi = "Peynirli Poğaça", OlcuBirimi = OlcuBirimi.Adet, Kalori = 274, Karbonhidrat = 21.4F, Protein = 6.1F, Yag = 18.29F, GramKarsiligi = 70, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(peynirliPogaca);

            BesinBilgileri DereotluPogaca = new BesinBilgileri() { BesinAdi = "Dereotlu Poğaça", OlcuBirimi = OlcuBirimi.Adet, Kalori = 234, Karbonhidrat = 25.2F, Protein = 5.09F, Yag = 20.44F, GramKarsiligi = 70, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(DereotluPogaca);

            BesinBilgileri ZeytinliPogaca = new BesinBilgileri() { BesinAdi = "Zeytinli Poğaça", OlcuBirimi = OlcuBirimi.Adet, Kalori = 267, Karbonhidrat = 23.97F, Protein = 5.06F, Yag = 17.27F, GramKarsiligi = 70, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(ZeytinliPogaca);

            BesinBilgileri patatesliPogaca = new BesinBilgileri() { BesinAdi = "Patatesli Poğaça", OlcuBirimi = OlcuBirimi.Adet, Kalori = 230, Karbonhidrat = 20.01F, Protein = 3.48F, Yag = 14.96F, GramKarsiligi = 70, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(patatesliPogaca);

            BesinBilgileri acma = new BesinBilgileri() { BesinAdi = "Acma", OlcuBirimi = OlcuBirimi.Adet, Kalori = 341, Karbonhidrat = 35.22F, Protein = 5.91F, Yag = 23.89F, GramKarsiligi = 90, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(acma);

            BesinBilgileri cikolataliAcma = new BesinBilgileri() { BesinAdi = "Cikolatalı Acma", OlcuBirimi = OlcuBirimi.Adet, Kalori = 268, Karbonhidrat = 36.71F, Protein = 5.32F, Yag = 10.83F, GramKarsiligi = 75, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(cikolataliAcma);

            BesinBilgileri zeytinliAcma = new BesinBilgileri() { BesinAdi = "Zeytinli Acma", OlcuBirimi = OlcuBirimi.Adet, Kalori = 354, Karbonhidrat = 31.25F, Protein = 5.27F, Yag = 22.95F, GramKarsiligi = 90, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(zeytinliAcma);

            //kurubaklagiller

            BesinBilgileri kurufasulyeEtsiz = new BesinBilgileri() { BesinAdi = "Etsiz Kuru Fasulye", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 250, Karbonhidrat = 45.16F, Protein = 17.51F, Yag = 0.63F, GramKarsiligi = 180, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(kurufasulyeEtsiz);

            BesinBilgileri nohutYemegiEtsiz = new BesinBilgileri() { BesinAdi = "Etsiz Kuru Fasulye", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 322, Karbonhidrat = 41.16F, Protein = 11.80F, Yag = 0.63F, GramKarsiligi = 200, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(nohutYemegiEtsiz);

            BesinBilgileri bezelyeYemegi = new BesinBilgileri() { BesinAdi = "Bezelye Yemegi    ", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 132, Karbonhidrat = 22.42F, Protein = 6.15F, Yag = 2.39F, GramKarsiligi = 200, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(bezelyeYemegi);

            BesinBilgileri mercimekYemegi = new BesinBilgileri() { BesinAdi = "Mercimnek Yemegi ", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 164, Karbonhidrat = 17.04F, Protein = 8.97F, Yag = 4.52F, GramKarsiligi = 230, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(mercimekYemegi);

            BesinBilgileri zeytinyaglıBarbunya = new BesinBilgileri() { BesinAdi = "Zeytinyaglı Barbunya ", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 140, Karbonhidrat = 42.83F, Protein = 15.99F, Yag = 14.14F, GramKarsiligi = 140, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(zeytinyaglıBarbunya);

            BesinBilgileri haslanmisMisir = new BesinBilgileri() { BesinAdi = "zeytinyaglıBarbunya ", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 140, Karbonhidrat = 42.83F, Protein = 15.99F, Yag = 14.14F, GramKarsiligi = 140, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(haslanmisMisir);

            BesinBilgileri meksikaFasulyesi = new BesinBilgileri() { BesinAdi = "Meksika Fasulyesi ", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 607, Karbonhidrat = 110.32F, Protein = 40.55F, Yag = 1.91F, GramKarsiligi = 180, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(meksikaFasulyesi);

            BesinBilgileri soyaFasulyesi = new BesinBilgileri() { BesinAdi = "Soya Fasulyesi ", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 274, Karbonhidrat = 0.31F, Protein = 28.31F, Yag = 17.79F, GramKarsiligi = 180, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(soyaFasulyesi);

            //hayvansal yaglar

            BesinBilgileri balikYagi = new BesinBilgileri() { BesinAdi = "Balik Yagi ", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 44, Karbonhidrat = 0, Protein = 0, Yag = 4.99F, GramKarsiligi = 5, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(balikYagi);

            BesinBilgileri icYagi = new BesinBilgileri() { BesinAdi = "İç Yagi ", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 135, Karbonhidrat = 0, Protein = 0, Yag = 15F, GramKarsiligi = 15, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(icYagi);

            BesinBilgileri kuyrukYagi = new BesinBilgileri() { BesinAdi = "Kuyruk Yagi ", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 79, Karbonhidrat = 0.01F, Protein = 0.29F, Yag = 8.61F, GramKarsiligi = 14, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(kuyrukYagi);

            //bitkisel yağlar 

            BesinBilgileri aycicekYagi = new BesinBilgileri() { BesinAdi = "Aycicek Yagi ", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 44, Karbonhidrat = 0, Protein = 0, Yag = 5, GramKarsiligi = 5, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(aycicekYagi);


            BesinBilgileri fındıkYagı = new BesinBilgileri() { BesinAdi = "Fındık Yagi ", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 35, Karbonhidrat = 0, Protein = 0, Yag = 4, GramKarsiligi = 4, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(fındıkYagı);

            BesinBilgileri zeytinYagı = new BesinBilgileri() { BesinAdi = "Zeytin Yagi ", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 40, Karbonhidrat = 0.01F, Protein = 0, Yag = 4.5F, GramKarsiligi = 4, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(zeytinYagı);

            // Fit tarifler

            Tarifler sporcuPizzasi = new Tarifler()
            {
                TarifAdi = "Sporcu Pizzası",
                Aciklamasi =
                "Malzemeler :\n 2-3 adet orta büyüklükte tatlı patates.\n2 su bardağı tam buğday unu\n1 çay kaşığı kabartma tozu\n1 çay kaşığı tuz\nMozeralla peyniri\nDomates salçası\r\n\r\nNasıl Yapalır?\n1- Fırını önceden 400 dereceye ısıtın.\n2- Patatesleri soyup, dörde bölün. Kaynar suda 30 dakika haşlayın. Ardından bir kasede kurulayın ve ezip püre haline getirin.\n3- Patates püresine tam buğday ununu, kabartma tozunu ve tuzu ekleyerek yoğurun.\n4- Malzemeyi bir santim kalınlığında olacak şekilde,  pişirme kağıdını ya da pizza tepsisine yerleştirin.\n5- Hamur kahverengileşinceye kadar fırında 15-20 dakika pişirin.\n6- Çıkartıp üzerine istediğiniz malzemeyi ekleyin. Ve bu aşamada lütfen yaratıcı olun:) Malzemeleriniz pişinceye kadar biraz daha fırında bekletin. Mesela mozerella peyniri için 5 dakika yeterlidir."
            };

            context.Tarifler.Add(sporcuPizzasi);


            Tarifler kabakSpagetti = new Tarifler()
            {
                TarifAdi = "Kabak Spagetti",
                Aciklamasi =
                "Malzemeler:\n4 adet orta boy kabak\n4 yemek kaşığı zeytinyağı\nTuz\r\n\r\nDomates Sosu:\n1 adet büyük boy domates\n1 yemek kaşığı domates salçası\n3 yemek kaşığı sıcak su\nTuz\n2 diş sarımsak\n2 yemek kaşığı zeytinyağı\nKarabiber\nPul biberr\r\n\r\nÜzerine:\nKaşar peyniri (isteğe bağlı)\r\n\r\nNasıl Yapılır ? \nKabaklarımızı soyduktan sonra, salatalık-patates soyacağı ile uzun uzun şeritler çıkarıyoruz. Fotoğraftan net anlaşılıyor veya bıçak yardımı ile ince ince şeritler çıkarabilirsiniz.\nTavada yüksek ateşte kabaklar hafif kızarmaya başlayana kadar pişiriyoruz. Tuzunu da ekleyip altını kısmadan sürekli kavuracağız. Hafif bir su salıp çekiyor.\r\nKabağımızı kavururken bir yandan da domates sosumuzu hazırlıyoruz.\nSosu için uygun bir tencereye zeytinyağını ve sarımsakları ince ince doğrayıp tencereye ekleyerek bir iki tur kavuruyoruz.\nRendelenmiş domatesleri, karabiberi, pul biberi, yağı ve salçayı tavada kavuruyoruz. Kaynamaya başlayınca içine su ve tuz ilave ediyoruz. Pişiriyoruz.\nKavurduğumuz kabakları da ekleyip bir kaç dakika daha pişirelim. Üzerine de isteğe bağlı dilediğimiz miktarda kaşar rendesi koyuyoruz."
            };

            context.Tarifler.Add(kabakSpagetti);


            Tarifler domatesliYulafliPogaca = new Tarifler()
            {
                TarifAdi = "Domatesli Yulaflı Poğaça",
                Aciklamasi =
                "Malzemeler :\n2 su bardağı yulaf\\n1 adet yumurta\n2 yemek kaşığı dolusu yoğurt\nYarım paket kabartma tozu\n1 adet domates\n1 kaseden az beyaz peynir\n5-6 dal maydanoz\n1 çay kaşığından az pul biber\r\n1 çay kaşığından az karabiber\nTuz\nÇörek otu\r\n\r\nNasıl Yapılır ?\nTüm malzemeleri bir kaba alalım güzelce karıştıralım fırın tepsisine şekil vererek dizelim.\nÖnceden ısıtılmış 180 derece fırında üzeri kızarana kadar pişirelim."

            };

            context.Tarifler.Add(domatesliYulafliPogaca);

            Tarifler diyetekmek = new Tarifler()
            {
                TarifAdi = "Diyet Ekmek",
                Aciklamasi = "Malzemeler :\n250 gr quark (yada süzme yoğurt)\n4 adet yumurta\n50 gr fındık\n50 gr badem\n60 gr keten tohumu\n40 gr chia tohumu\nYarım paket kabartma tozu\nTuz\nÜzeri için susam ve kabak çekirdeği\r\n\r\nNasıl Yapılır ?\nÖncelikle yoğurma kabına süzme yoğurt ve yumurtayı alıp karıştırıyoruz.\nFındık ve bademi blenderdan geçirip toz haline getirip ekliyoruz.\nKeten tohumu, chia tohumu, kabartma tozu ve tuzu ekleyip karıştırıyoruz.\nHamurumuzu iyice karıştırdıktan sonra 5 dakika dinlendiriyoruz.\nDikdörtgen bir kek kalıbına yağlı kağıdı seriyoruz ve hamuru üzerine döküyoruz.\nSusamı ve çekirdeği üzerine serptikten sonra fırına (190 derece üst ve alt ısıtmalı) veriyoruz ve 60-70 dk pişiriyoruz.\nPişen ekmeğimizi fırından çıkardıktan sonra kalıpta soğumaya bırakıyoruz. Afiyet olsun. \n"
            };

            context.Tarifler.Add(diyetekmek);



            Tarifler cilekliYogurt = new Tarifler()
            {
                TarifAdi = "Çilekli Yoğurt",
                Aciklamasi = "Malzemeler :\n6 adet çilek\n6-7 kaşık yağsız yoğurt\n1 tatlı kaşığı bal (isteğe bağlı)\nKahvaltılık buğday gevreği\r\n\r\nNasıl Yapılır ?\nÇilek, yoğurt ve balı blenderdan geçirin.\nKasenin yarısına kadar gevrek doldurun.\nÜzerine meyveli yoğurdu boşaltın.\nÜzerini süsleyerek servis yapabilirsiniz."
            };

            context.Tarifler.Add(cilekliYogurt);



            Tarifler kagıttaPalamutKebabi = new Tarifler()
            {
                TarifAdi = "Kağıtta Palamut Kebabı",
                Aciklamasi = "Malzemeler :\n2 adet orta boy palamut balığı (kişi sayısına göre belirleyebilirsiniz)\nDomates\nKuru soğan\nMaydanoz\nLimon\nDefne Yaprağı\nZeytinyağı\nSarımsak\ntuz\r\n\r\nNasıl Yapılır ?\nBalıklar boyuna(fileto)  ikiye kesilip, temizlenir (balıkçınız bu aşamayı yapacaktır).\nYağlı kağıt üzerine biraz zeytinyağı dökülerek fırça ile sürülür.\nÜzerine yan yana 3-4 adet soğan dilimi dizilir.\nSoğan dilimlerinin üzerine balık koyulur. Tuz serpilir.\nBalığın üzerine sırası ile maydanoz yaprakları, domates dilimi, limon dilimi ve defne yaprağı koyulur.\n1 diş sarımsak ikiye kesilerek kağıdın üzerine koyulur.\n1 yemek kaşığı kadar zeytinyağı gezdirilir ve tüm malzemeler paketlenir.\nPaketleme işlemi için kağıdın karşılıklı iki kenarı üste doğru katlanarak balık kapatılır. Yan kısımlarda balığın altında kalacak şekilde kıvrılır. Yemeğimiz sulanacağı için suyu akmayacak şekilde paketlenir.\n190 derece fırında pişmeye bırakılır. Pişme süresi balığın boyutuna göre değişir, ben yaklaşık 40 dk kadar pişirdim."

            };
            context.Tarifler.Add(kagıttaPalamutKebabi);

            Tarifler mercimekCips = new Tarifler()
            {
                TarifAdi = "Mercimek Cips",
                Aciklamasi = "Malzemeler :\n1 su bardağı kırmızı mercimek\n1 çay kaşığı tuz (tam dolu değil)\n1 çay kaşığı mavi haşhaş\n2 çay kaşığı çörek otu\n1 çay kaşığı pul biber\n2 çay kaşığı keten tohumu\nYarım çay bardağı zeytinyağı\r\n\r\nNasıl Yapılır ?\nÖncelikle bir gece önceden kırmızı mercimekleri yıkayıp, suya koyuyoruz.\nSabah kalan suyu süzüyoruz ve rondomuza alıyoruz.\nÜzerine haşhaş, çörek otu, keten tohumu, tuz, pul biber ve zeytinyağı döküp rondoda tüm mercimekler parçalanıncaya kadar çektiriyoruz.\nTüm mercimek karışımı homojen hal aldığında yağlı kağıt serdiğimiz fırın tepsisine silikon bir spatula ile yayıyoruz. Burada ince olmasına özen gösterin, ince olursa daha kıtır olur.\n200°C fırında, 20-25 dakika üzeri kızarana kadar pişiriyoruz."

            };

            context.Tarifler.Add(mercimekCips);


            Tarifler fitDondurma = new Tarifler()
            {
                TarifAdi = "Fit Dondurma",
                Aciklamasi = "Malzemeler :\nMalzemeler;\nMuzlu çikolatalı olan için:\n2 adet muz\n4 yemek kaşığı süt\n2 yemek kaşığı bal\n1,5 yemek kaşığı kakao\nFrambuaz, böğürtleni ve çilekli için;\n1 çorba kasesi karışık meyvelerden\nYarim muz\n4 yemek kaşığı süt\n1 vanilya özütü veya şekeri\n1 yemek kaşığı bal\r\n\r\nNasıl Yapılır ?\nDondurmaya hazırlamak için ilk etapta bütün meyveler dondurulmuş olmazı gerekiyor.\nMuzlar dilimlenir ve buzluk poşetine yerleştirilir. Bir gece buzlukta bırakılır.\nDaha sonra yapımına başlamadan önce meyveler buzluktan çıkartılır ve 10 dakika dinlendirilir.\nDaha sonra yapmak istediğiniz dondurmanın bütün malzemelerini mutfak robotuna alınır ve kremamsı kıvam alana dek çekilir.\nDaha sonra buzluğa uygun kaplara koyulur ve bir kaç saat buzlukta bekletilir. Afiyet olsun.İstediğiniz meyveleri kullanabilirsiniz süt yerine yoğurt da olur\nbenim favorim kesinlikle mangolu olan"
            };

            context.Tarifler.Add(fitDondurma);

            Tarifler yulaflıKurabiye = new Tarifler()
            {
                TarifAdi = "Yulaflı Kurabiye",
                Aciklamasi = "Malzemeler :\n1 su bardağı yulaf ezmesi\n1 adet muz\n1 adet yumurta akı\nYarım çay bardağı ceviz\nYarım çay bardağı kuru üzüm\n4 adet hurma\n1 adet kuru incir\n1 çay kaşığı kabartma tozu\r\n\r\nNasıl Yapılır ?\nYumurtanın akını biraz çırpıp kıvam almasını sağladıktan sonra içine 1 orta boy muzu koyup eziyoruz.\r\nArdından yulaf ve diğer malzemeleri ekliyoruz.\nCevizin falan miktarını yazmadım tamamen kendinize kalmış ben çok az kullandım.\nBütün malzemeler karıştırıp elimize yapışmadan şekil verebileceğimiz kıvama gelince yağlı kağıdın üzerine koyup önceden ısıtılmış 180 derece fırında pişiriyoruz.\nKarışım elimize yapışırsa biraz daha yulaf ekleyebilirsiniz"

            };

            context.Tarifler.Add(yulaflıKurabiye);

            Tarifler sekersizPekmezliKurabiye = new Tarifler()
            {
                TarifAdi = "Sekesiz Pekmezli Kurabiye",
                Aciklamasi = "Malzemeler :\n1 yumurta\n1/4 (çeyrek) su bardağı pekmez\n1/2 (yarım) su bardağı tahin\nYarım çay bardağı kakao\n1 çay kaşığı kabartma tozu\n1 çay kaşığı vanilin\r\n\r\nNasıl Yapılır ?\nÖncelikle yumurta ve pekmezi çırpın daha sonra kalan tüm malzemeyi ekleyin hafif akışkan bir hamur olucak.\nKaşık yardımıyla aralarında boşluk kalıcak şekilde fırın tepsisine koyun.\n180 derece 10 dk pişirin."

            };

            context.Tarifler.Add(sekersizPekmezliKurabiye);



            Tarifler diyetOmlet = new Tarifler()
            {
                TarifAdi = "Diyet Omlet ",
                Aciklamasi = "Malzemeler :\n1 adet kırmızı biber\n1 adet sivribiber\n2 adet yumurta\nYarım çay bardağı süt\n3-4 dal maydanoz\n1 çay kaşığı tereyağı\r\n\r\nNasıl Yapılır ?\nBiberleri ve maydanozu ince ince doğrayalım. Derin bir kapta yumurta süt ve peyniri çırpalım.\nYapışmaz bir tavaya tereyağını koyalım eriyen yağın üzerine omletimizi tavada eşit dağılacak şekilde dökelim.\nÜzerine doğramış olduğumuz biberleri ve maydanozu ekleyip kısık ateşte pişirelim"

            };

            context.Tarifler.Add(diyetOmlet);


            Tarifler diyetKabakPizza = new Tarifler()
            {
                TarifAdi = "Diyet Kabak Pizza ",
                Aciklamasi = "Malzemeler :\n7-8 dilim büyük kabak dilimleri\n2 yemek kaşığı zeytinyağı\n1 adet yeşil biber\n1 adet kırmızı biber\nYarım çay bardağı rendelenmiş kaşar peyniri\nTuz, kekik, karabiber\n6-7 adet zeytin\r\n\r\nNasıl Yapılır ?\nBüyük bir kabağı soyup, 1-2 cm kalınlığında dilimleyelim ve yağlı kağıt serilmiş fırın tepsisine dizelim.\nÜzerine, fırça ile çok az zeytinyağı sürelim.\nÖnceden ısıtılmış 190 derece fırında, 5-10 dk yumuşayana kadar pişirelim.\nDaha sonra kabakları alıp; üzerine tuz, karabiber, kekik serpelim ve küçük küçük doğradığımız biberleri ve zeytinleri serpiştirelim. Yine fırına verelim.\nİyice piştikten ve kaşar peynirlerini de koyduktan sonra, eriyene kadar fırında bırakalım."

            };

            context.Tarifler.Add(diyetKabakPizza);

            Tarifler gronalaBar = new Tarifler()
            {
                TarifAdi = "Gronala Bar ",
                Aciklamasi = "Malzemeler :\n2 su bardağı yulaf ezmesi\n1/2 (yarım) su bardağı Hindistan cevizi\n1 su bardağı badem\n1/2 (yarım) su bardağı kaju\nsu bardağı kuru meyve\n1/2 (yarım) su bardağı kabak çekirdeği içi\n1 çay bardağı damla çikolata\n1 çay kaşığı tarçın\n1 çay kaşığı vanilya\n1 çay bardağı fıstık ezmesi\n1 çay bardağı bal\n1/2 (yarım) çay bardağı esmer şeker\r\n\r\nNasıl Yapılır ?\nKarıştırma kabının içerisine; yulaf ezmesi, Hindistan cevizi, badem, kaju ve kabak çekirdeği içi koyulur, karıştırılır.\nFırın tepsisine yağlı kağıt serilir. Karışım dökülür ve yayılır. Isıtılmış 150 derecelik fırında, 10 dakika pişirilir.\nYulaflı karışım fırındayken; küçük bir tencereye, bal, esmer şeker, fıstık ezmesi, tarçın ve vanilya eklenir karıştırılır.\nOcağa alınır ve kısık ateşte şeker eriyene kadar karıştırılır. (Çok fazla pişirmeyin)\r\nFırındaki yulaflı karışım derin bir kaba alınır.\nİçerisine yapılan ballı harç eklenerek karıştırılır.\nKuru meyve ve damla çikolata eklenir, karıştırılır.\n28×24 santimlik dikdörtgen fırın kabına üzerinden taşacak şekilde yağlı kağıt serilir.\nYapılan harç kaba boşaltılır ve kaşığın tersi ile sıkı sıkı bastırılarak üzeri düzleştirilir.\nÖnceden ısıtılmış 150 derecelik fırında, 20 dakika pişirilir.\nFırından çıkarılır ve soğumaya bırakılır.\nSoğuyan granola, arzu edilen şekilde keskin bir bıçak ile kesilerek servis edilir."

            };

            context.Tarifler.Add(gronalaBar);

            Tarifler diyetKek = new Tarifler()
            {
                TarifAdi = "Diyet Kek ",
                Aciklamasi = "Malzemeler :\n1 yumurta\n1 su bardağı süt\n2 yemek kaşığı pekmez\n1 çay kaşığı tarçın\n1 çay bardağı kuru üzüm\n3 adet kuru kayısı\n3-4 adet medine hurması\n1 paket kabartma tozu\n2. 5-3 su bardağı Un\r\n\r\nNasıl Yapılır ?\nKayısı ve hurmalar küçük küçük doğranır. Üzüm dahil tüm malzemeler bir kapta karıştırılır.\nPekmez malzemeleri birbirine yapıştıracağı için hızlıca karıştırmaya devam edilir.\nEn son un eklenerek çırpmadan yavaşça karıştırılır.\nKarışım hafif yağlanmış silikon kalıplara paylaştırılır.\n180 dereceli fırında 10-15 dk pişirilir. "

            };

            context.Tarifler.Add(diyetKek);

            Tarifler brokoliSalatasi = new Tarifler()
            {
                TarifAdi = "Brokoli Salatası",
                Aciklamasi = "Malzemeler :\nBrokoli\n3-4 adet salatalık turşusu\nKonserve mısır\nKözlenmiş kırmızı biber\nYeşil soğan\n2-3 diş sarımsak\nZeytinyağı\nTuz\nLimon\r\n\r\nNasıl Yapılır ?\nBrokoliyi salatasının yapımı için; ilk olarak brokolileri karnabahar gibi parçalara ayırıp, kaynar suda 4 dakika haşlıyoruz.\nHaşlandıktan sonra küçük küçük parçalara ayırıp, bir kaba alıyoruz.\nYeşil soğanları ince doğruyoruz. Brokolilere ilave ediyoruz.\nAynı şekilde közlenmiş biber ve kornişon turşuları da doğrayıp, ilave ediyoruz.\nMısırı da ekleyip, üzerine zeytinyağını gezdiriyoruz. Sarımsakları rendeliyoruz.\nLimon sıkıp, tuzunu ekliyoruz ve karıştırıp borcama alıyoruz."

            };

            context.Tarifler.Add(brokoliSalatasi);

            Tarifler fitMozaikPasta = new Tarifler()
            {
                TarifAdi = "Fit Mozaik Pasta",
                Aciklamasi = "Malzemeler :\n1 kase çiğ fındık\n1 kase çiğ badem\n1 kase kaju\n3 adet ezilmiş muz\n1 adet ince dilimlenmiş muz\r\n1 kase kuru üzüm\n1 kase gün kurusu\n5 adet küçük doğranmış kuru kayısı\n1 küçük kase elma kurusu\n1 küçük kase turna yemişi\n3 yemek kaşığı kakao\r\n\r\nNasıl Yapılır ?\nÖncelikle fındık, badem ve kajuyu iri kalacak şekilde rondoda çekelim derin bir kaba aktaralım.\n3 adet muzu yine rondoda püre haline getirip üzerine ekleyelim.\nKuru kayısı, gün kurusu, kuru elma, 1 adet muzu küçük küçük doğrayıp karışıma ekleyelim.\nKuru üzüm, turna yemişi ve kakaoyu da ekledikten sonra güzelce karıştıralım.\nStreç film serilmiş küçük boy borcama karışımı boşaltalım. Kaşıkla üzerini bastırarak sıkıştıralım.\r\nÜzerini streç filmle kapatıp 2 saat buzlukta dinlendirelim.\nKıvam alıp sertleşen pastayı streç film yardımıyla ters çevirip çıkartalım.\nKüçük küçük kare parçalar halinde dilimleyelim."

            };

            context.Tarifler.Add(fitMozaikPasta);

            Tarifler diyetElmaliKek = new Tarifler()
            {
                TarifAdi = "Diyet Elmalı Kek",
                Aciklamasi = "Malzemeler :\n2 yumurta\n1 çay bardağı üzüm pekmezi\nYarım su bardağı süt\nYarım su bardağından az zeytinyağı (tam diyet olsun isterseniz koymaya bilirsiniz)\n1 paket kabartma tozu\n1 paket vanilya\n1,5 su bardağı kepekli un\n1 adet elma\nYarım su bardağı ceviz\nYarım su bardağı kuru üzüm\nYarım çay kaşığı tarçın\r\n\r\nNasıl Yapılır ?\nYumurta ve pekmez çırpılır. Yağ ve süt eklenerek karıştırılır.\nTarçın, kabartma tozu, vanilya eklenir, karıştırılır. Un azar azar eklenir. Çok katı olduğunu düşünürseniz un miktarını azaltabilirsiniz.\nElma rendesi, ceviz ve üzümün de eklendiği hamur karıştırılarak yağlanmış kek kalıbına dökülür.\n160 derecede kek pişene kadar fırında tutulur. Pişme süresi için dk tutmadım. 30 dk’dan sonra pişip pişmediğini kürdan yardımı ile kontrol edebilirsiniz. Ceviz ve üzüm tercihe bağlı. Afiyet olsun"

            };

            context.Tarifler.Add(diyetElmaliKek);

            Tarifler fitPankek = new Tarifler()
            {
                TarifAdi = "Fit Pankek",
                Aciklamasi = "Malzemeler :\n1 orta boy yumurta\nYarım su bardağı süt\n1 su bardağından iki parmak eksik mısır unu\n1 tatlı kaşığı zeytinyağ\n1 çay kaşığı kabartma tozu\nMaydanoz\nTuz\nPeynir\r\n\r\nNasıl Yapılır ?\nİlk önce yumurtayı çırpın .\nArdından süt ve yağ ekleyip tekrar karıştırın.\nMısır unu, kabartma tozu, maydanoz, peynir, tuzunuzuda ekleyip karıştırın.\nTavaya biraz zeytinyağı ekleyip orta ateşte ısıtın.\nKarışımdan bir kaşık alıp tavaya koyun orta ateşte pişirmeye özen gösterin arkalı önlü yüzleri kızarana kadar pişirin."

            };

            context.Tarifler.Add(fitPankek);

            Tarifler patatesliTavukBaget = new Tarifler()
            {
                TarifAdi = "Patatesli Tavuk Baget",
                Aciklamasi = "Malzemeler :\nkişi sayısına göre tavuk baget (8-10 adet kadar)\nkişi sayısına göre orta boy patates (8-10 adet kadar)\n1 tatlı kaşığı domates salçası\nbaharat karışımı (yeni bahar, kimyon, kekik, kara biber, kırmızı toz biber, pul biber\r\n\r\nNasıl Yapılır ?\nPatatesler soyularak ikiye kesilir.\nBagetler tencereye alınarak istenilen baharatlar üzerine serpilir. Ben yeni bahar, kimyon, kara biber, pul biber, kırmızı toz biber, kekik kullandım)\nBiraz karıştırarak bagetler baharata bulanır.\nÜzeri patates ile örtülür.\nBir kasede domates salçası yarım su bardağı kadar suda çözdürülerek tavukların üzerine gezdirilir.\nTencerenin kapağı kapatılarak kısık ateşte pişmeye bırakılır.\nÜzeri patates ile örtülü olduğu için tavuklar yumuşacık pişecektir."

            };

            context.Tarifler.Add(patatesliTavukBaget);

            Tarifler ananaslıCheesecakeBar = new Tarifler()
            {
                TarifAdi = "Ananaslı Cheesecake Bar",
                Aciklamasi = "Malzemeler :\n1 paket burçak bisküvi \n2 yemek kaşığı Eritilmiş tereyağı\r\n\r\nKrenası için:\n100 gr yağsız krem peynir\n100 gr  tuzsuz tereyağı\n3 yumurta \n1 yemek kaşığı bal\nYarım bardak ananas suyu\n1 paket vanilin\nÜzeri için Ananas ve kiraz (isteğe bağlı).\r\n\r\nNasıl Yapılır ?\nTabanı için bir parça tereyağı ve bisküvileri rondodan geçirin.\nKalıbın zeminine yerleştirince 5 dakika fırınlayın\nDolgusu için, bir el mikseri kullanarak geniş bir kapta krem peyniri tamamen pürüzsüz olana kadar yaklaşık 1 dakika yüksek hızda çırpın\nOrta-yüksek hızda, tamamen birleşene kadar tereyağını da çırpın\nArdından yumurta ve yumurta sarısını birleştirene kadar çırpın\nSon olarak, her şey birleşene ve topak kalmayana kadar şeker, ananas suyu ve vanilyayı çırpın\nDolguyu kabuğun üzerine dökün ve 30 dakika pişirin\nArdından sertleşene kadar, 4 saat veya bir geceye kadar buzdolabında saklayın.\nSoğuduktan sonra kalıptan çıkarın ve kareler halinde kesin. Ananas ve kirazla süsleyin ve buzdolabında saklayın."

            };

            context.Tarifler.Add(ananaslıCheesecakeBar);

            Tarifler muzluChiaPuding = new Tarifler()
            {
                TarifAdi = "Muzlu Chia Puding",
                Aciklamasi = "Malzemeler :\n2 su bardağı badem sütü\n6 yemek kaşığı chia tohumu\n1 adet muz\n1 çay kaşığı vanilya özütü\n1 yemek kaşığı bal.\r\n\r\nNasıl Yapılır ?\nBir kabın içine sütü, chia tohumlarını ekleyin ve güzelce karıştırın.\nÜzeri hava almayacak şekilde dolapta chia tohumları sütü çekip, jel kıvamı alana kadar en az yarım saat bekletin.\nKıvam alan pudingi çıkarıp içerisine bal ve vanilya özütü ilave ederek karıştırın.\nMuzun kabuklarını soyup, iyice ezin ve pudingin içine ekleyin. İyice karıştırın, dilerseniz blendardan geçirin.\nServis kuplarınıza ya da kaselerinize hazırladığınız pudingleri eşit bir biçimde paylaştırın.\nÜzerini muz dilimleri ile süsleyerek servis edebilirsiniz, afiyet olsun."

            };

            context.Tarifler.Add(muzluChiaPuding);

            Tarifler kayisiliYulafToplari = new Tarifler()
            {
                TarifAdi = "Kayisili Yulaf Topları",
                Aciklamasi = "Malzemeler :\n15 adet kuru kayısı\n6 adet hurma\n1/2 su bardağı yulaf\n2 çay kaşığı tarçın\r\n\r\nNasıl Yapılır ?\nKuru kayısıları ve hurmaları bir kabın içerisine alın. Yumuşaması için üzerine sıcak su ilave edin ve yaklaşık 10 dakika bekletin.\nYumuşayan kayısıları ve hurmaları sudan çıkarın. İyice kurulayın.\nHurmaların çekirdeklerini çıkarın. Kayısı ve hurmaları gelişigüzel doğrayın.\nMutfak robotuna önce yulafı ekleyin, incelinceye dek çekin. Ardından doğradığınız kuru meyveleri ilave edin. Yulaf ve meyveler homojen bir hal alana kadar robotta çekmeye devam edin.\nKarışım çok kuruysa azar azar su ekleyerek çekmeye devam edin.\nKarışımı geniş bir kabın içerisine alın tarçın ilave ederek bir spatula yardımıyla karıştırın.\nBir tepsinin üzerine yağlı kağıt serin. Yulaflı karışıma dilediğiniz boyutlarda elinizle şekil verin ve yağlı kağıdı serili tepsinin üzerine dizin. Şekil verirken ellerinizi ıslatırsanız daha kolay şekil verebilirsiniz.\nBuzdolabında en az 1 saat tercihen 3-4 saat dinlendirin."

            };

            context.Tarifler.Add(kayisiliYulafToplari);


            Tarifler karisikSebzeliMantarDolması = new Tarifler()
            {
                TarifAdi = "Karişik Sebzeli Mantar Dolması",
                Aciklamasi = "Malzemeler :\n10-15 adet büyük boy kültür mantarı\n1 adet kuru soğan\n1 adet kırmızı biber\n1 adet yeşil biber\n1 adet domates\n2 diş sarımsak\n1 yemek kaşığı mısır\nKarabiber, pulbiber\n2 yemek kaşığı zeytinyağı\nRendelenmiş peynir\r\n\r\nNasıl Yapılır ?\nMantarların sap kısımlarını çıkarıp yıkıyoruz ve kuruluyoruz.\nYağlı kağıt serdiğimiz fırın tepsisine üzerleri açık kalacak şekilde dizip önceden ısıtılmış fırında 15 dakika kadar pişiriyoruz.\nMantarlarımız pişerken içini hazırlayalım.\nBir tavaya yağımızı alıyoruz.\nSoğanları ve sarımsakları yağ ile pembeleşene kadar kavuruyoruz.\nSonra biberleri, ardından domatesi ve en son mısırı ekleyerek soteliyoruz.\nBaharatlarını da ekleyip ocaktan alıyoruz.\nHafif yumuşayan ve suyunu salan mantarları fırından alıp içlerini hazırladığımız harç ile dolduruyoruz.\nYaklaşık 5 dakika daha fırına atıp çıkarıyoruz.\nSon olarak rendelenmiş peynirimizi ve maydanozlarımızı da üzerine ekleyip fırına atıyoruz ve peynirler eriyene kadar pişiriyoruz."

            };

            context.Tarifler.Add(karisikSebzeliMantarDolması);

            Tarifler beyazOmlet = new Tarifler()
            {
                TarifAdi = "Bol Proteinli Beyaz Omlet",
                Aciklamasi = "Malzemeler :\n3 yumurta beyazı\n1 tatlı kaşığı zeytinyağı veya tereyağı\nDoğranmış yeşillikler (maydanoz, yeşil soğan, dere otu)\nTuz\nRendelenmiş parmesan peyniri\r\n\r\nNasıl Yapılır ?\nZeytinyağı ya da tereyağını yapışmaz bir tavaya alarak kısık ateşte ısıtın. Bu sırada yumurta beyazlarını ve bir tutam tuzu güzelce çırpın, bu omletin hafif ve kabarık olmasını sağlayacak. Bunu önceden yapmamanızda fayda var, aksi takdirde yumurta beyazları sönecektir.\nÇırptığınız yumurtayı ısınan tavaya dökün ve yaklaşık 1 dakika kadar, ısıya dayanıklı silikon spatula ile devamlı karıştırarak pişirin.\nYeterince piştiğinde dilediğiniz yeşillikleri serpin.\nSpatulayı yumurtanın etrafında gezdirerek kenarlarının tavadan ayrılmasını sağlayın ve spatulayı yumurtanın altına yerleştirerek omleti ikiye katlayın.\nGüzelce birleşmesi için omletin üzerine hafifçe bastırın.\nDaha sonra omleti tavadan kaydırarak servis tabağına alın.\nÜzerine biraz parmesan peyniri ya da kaşar peyniri rendeledikten sonra sıcak sıcak servis edin"

            };

            context.Tarifler.Add(beyazOmlet);

            Tarifler fincanTatlisi = new Tarifler()
            {
                TarifAdi = "Fincan Tatlısı",
                Aciklamasi = "Malzemeler :\n5 su bardağı süt\n2 kahve fincanı tepeleme un\n2,5 kahve fincanı şeker\n1 paket vanilya\n1 yemek kaşığı margarin\r\n\r\nNasıl Yapılır ?\nFincan tatlısı için; ilk olarak süt, un ve şeker, tencerede iyice koyulaşana kadar karıştırılarak pişirilir.\nOcaktan aldığımızda vanilya ve margarin eklenir ve iyice çırparak karıştırılır.\nKahve fincanlarının içlerini ıslatarak, muhallebi doldurulur. Fincanlar ıslatılmaz ise, kalıp şeklinde çıkartamazsınız.\nTatlımız soğuduktan sonra, buzdolabında 3-4 saat bekletilir.\nTatlıları fincandan çıkarırken, kenarlarından hava almasını sağlayarak ters çevirip fincan sallanır.\nKalıp gibi düşen fincan tatlısı, Hindistan cevizine bulanıp dilendiği gibi süslenir."

            };

            context.Tarifler.Add(fincanTatlisi);


            Tarifler kasarliPatatesKroket = new Tarifler()
            {
                TarifAdi = "Kasarlı Patates Kroket",
                Aciklamasi = "Malzemeler :\n6 adet haşlanmış patates\n4 adet taze soğan\nTuz\nKarabiber\nKaşar peynirUn\nYumurta\nGaleta unu\r\n\r\nNasıl Yapılır ?\nİlk olarak patateslerimizi haşlayalım.\nDaha sonra haşladığımız patateslerimizi çift kilitli poşet içerisine alalım, merdane yardımı ile güzelce ezelim. Daha farklı şekillerde de ezebilirsiniz bu şekilde bana pratik ve hızlı geliyor.\nTaze soğanlarımızı küçük küçük doğrayalım ve patateslerimizin üzerine ekleyelim.\nTuz ve karabiberi de ekledikten sonra güzel bir şekilde karıştıralım.\nPatatesli harcımızdan 1 kaşık kadar alalım, içerisine doğradığımız kaşar peynirinden yerleştirelim ve elimizde yuvarlayarak şekil verelim. Bu aşamada elinizi ıslarsanız patates toplarınıza daha kolay şekil verebilirsiniz.\nKızartma tavamıza bol sıvı yağ alalım ve kızdıralım. Yağ ısınırken diğer yandan yumurtamızı çırpalım.\nPatates toplarımızı ilk önce una daha sonra çırptığımız yumurtaya ve son olarak galeta ununa bulayalım.\nKızgın yağın içerisine dikkatlice bırakılım ve çevirerek her yerinin kızarmasını sağlayalım.\nKızaran patates toplarımızı peçete üzerine alarak fazla yağını çektirelim, daha sonra servis tabağına alarak sıcak sıcak servis yapabilirsiniz"

            };

            context.Tarifler.Add(kasarliPatatesKroket);

            Tarifler CikolatalıSeftalidilimleri = new Tarifler()
            {
                TarifAdi = "Çikolatalı Şeftali Dilimleri",
                Aciklamasi = "Malzemeler :\n1-2 adet şeftali\n50 gram bitter çikolata\n7-8 adet ceviz içi veya fındık\r\n\r\nNasıl Yapılır ?\nŞeftaliler dilimlenir, dondurucuya atılır.\nDonmuş şeftaliler benmari usulü eritilmiş çikolataya batırılır.\nÇikolatası donmadan hemen ceviz içine bulanır ve hazır.\nara öğünlerde yaz günlerinde mis gibi atıştırmalık."

            };

            context.Tarifler.Add(CikolatalıSeftalidilimleri);

            Tarifler susamlıYumurtaEkmek = new Tarifler()
            {
                TarifAdi = "Susamlı Yumurtalı Ekmek ",
                Aciklamasi = "Malzemeler :\n4 adet yumurta\n1 yemek kaşığı susam\n1 çay kaşığı tuz\n2 ekmek\nSucuk\nKaşar\r\n\r\nNasıl Yapılır ?\nYumurtaları çırpıyoruz içine kavrulmuş susamlı tuzu ekliyoruz.\nDilimlediğimiz ekmekleri yumurta sosuna bulayıp, fırın tepsisine dizip, üzerine isteğe bağlı sucuk kaşar koyuyoruz.\n180 derecede 15 dakika pişiriyoruz afiyet olsun."

            };

            context.Tarifler.Add(susamlıYumurtaEkmek);

            Tarifler glutensizCizivic = new Tarifler()
            {
                TarifAdi = "Glutensiz Cizivic",
                Aciklamasi = "Malzemeler :\n2 tatlı kaşığı labne\n2 adet mısır patlağı veya karabuğday veya pirinç patlağı\nPulbiber\nÇörek otu\nKuru kekik\r\n\r\nNasıl Yapılır ?\nLabne ve baharatları küçük bir kasede karıştıralım. 2 patlak arasına sürelim.Afiyet olsun "

            };

            context.Tarifler.Add(glutensizCizivic);

            Tarifler incirCips = new Tarifler()
            {
                TarifAdi = "İncir Cipsi",
                Aciklamasi = "Malzemeler :\n1 kg yaş incir\r\n\r\nNasıl Yapılır ?\nİncirlerin çok yumuşak olmayan sert incirleri yuvarlak olarak 1 cm boyutunda kesilir ve yağlı kağıt serilmiş olan tepsiye dizilir.\nGüneş alan bir yerde kurutulur.\nOrtalama 4-5 gün arasında kuruyup çıtırlaşır."

            };

            context.Tarifler.Add(incirCips);

            Tarifler meyveliYogurtBar = new Tarifler()
            {
                TarifAdi = "Meyveli Yogurt Bar",
                Aciklamasi = "Malzemeler :\n1,5 su bardağı yoğurt\n1 yemek kaşığı bal\n3 adet çilek\n1 adet muz\n10 tane fıstık\n1 yemek kaşığı damla çikolata\r\n\r\nNasıl Yapılır ?\nYoğurt ve balı iyice karıştırın. Pürüzsüz kıvamda olması önemli!.\nKabınıza yağlı kağıdı serin. Yağlı kağıt serdiğiniz kabınıza yoğurt ve bal karışımını dökün.\nİşte en sevdiğim kısım başladı. Süsleme zamanı. Sırasıyla doğranmış çilek ve muzları ardından fıstık ve damla çikolataları yerleştirin.\nDondurucuda en az 1 saat bekletin. Kesip afiyetle yiyebilirsiniz. Yemediklerinizi dondurucuda saklamayı unutmayın! afiyet olsun."

            };

            context.Tarifler.Add(meyveliYogurtBar);

            Tarifler meksikaUslüNachos = new Tarifler()
            {
                TarifAdi = "Meksika Usulü Nachos",
                Aciklamasi = "Malzemeler :\n1 paket peynirli nacho / doritos\n1 bardak kadar kaşar rendesi\n3 dilim cheddar peyniri\nJalapeno turşusu (Bende yoktu başka bir turşu kullandım)\n2 kaşık mısır (Konserve)\nisteğe göre kavrulmuş kıyma\r\n\r\nNasıl Yapılır ?\nÖncelikle; büyük bir borcama yanmaz kağıdı koyun, üzerine cipsi boşaltın.\nKaşar rendesini ve kıymayı da ekleyin, eliniz ile güzelce harmanlayın.\nKaşar ne kadar bol olursa lezzeti o kadar güzel olur.\nMısırı ve turşuyuda ekletin ve karıştırın.\nEn son üzerine cheddar peynirini parça parça koparıp ekleyin.\n150 derecedeki fırınınızda 10 dakikaya yakın bekletin. Üstü kızarınca fırından alabilirsiniz "

            };

            context.Tarifler.Add(meksikaUslüNachos);

            Tarifler zerdacalliMisir = new Tarifler()
            {
                TarifAdi = "Zerdeçallı Mısır",
                Aciklamasi = "Malzemeler :\n3 yemek kaşığı mısır\n2 yemek kaşığı sıvı yağ\n1 çay kaşığı ucuyla toz zerdeçal\nArzuya göre tuz\r\n\r\nNasıl Yapılır ?\nMalzemeleri hazırlayalım tavaya iki yemek kaşığı sıvı yağ ısıtalım.\nIsınan sıvı yağa toz zerdeçallı ekleyin üzerine mısırları ilave edelim ,çok az tuz ekleyip karıştırın.\nPatlatma hâline gelene kadar kapağını kapatıp ateşi kısık olarak hepsi patlayan dek ateşte tutalım. Zerdeçallı mısırımız hazır yanına da kahve veya çay güzel olur. Afiyet olsun"

            };

            context.Tarifler.Add(zerdacalliMisir);

            Tarifler KuruFasulyePiyazi = new Tarifler()
            {
                TarifAdi = "Kuru Fasulye Piyazı",
                Aciklamasi = "Malzemeler :\n1 su bardağı kuru fasulye\n3 tane kuru soğan\n3 tane yeşil biber\n3 orta boy domates\n1 demet maydanoz\n1 tane büyük salatalık\nKimyon,karabiber,pul biber\n2 yemek kaşığı soya sosu(olmasa olur)\nNar ekşisi,tuz\n1 tatlı kaşığı biber salçası\r\n\r\nNasıl Yapılır ?\nBen kuru fasulye yapacağım zaman akşamdan ıslatmıyorum.\nFasulyeyi direk düdüklü tencereye koyup suyunu ekleyip tam kaynamaya başlayınca altını kapatıp bir saate yakın bekletiyorum sonrasında yıkayıp süzüyorum. Sonra istediğim şekilde pişiriyorum.\nFasulyeyi anlattığım şekilde suyunu süzüp yıkadıktan donra 20 dk haşladım.\nSuyu süzülürken soğanı piyazlık doğrayıp tuzladım yıkayıp suyunu süzdürdüm.\nBiberleri doğradım.\nTavaya 3 kaşık zeytinyağı koyup soğanları ve biberleri çok az soteledim.\nAz biber salçası ekledim.\nSoğanlar pişmeyecek,sadece yumuşattım.\nAltını kapatıp soya sosunu, baharatları ekledim.\nSuyu süzülen fasulyeyi büyük bir kaba koyup üzerine soğanları ilave edin.\nÜzerine doğranmış domates ve maydanozu ve salatalığı ekleyin .\n3 yemek kaşığı nar ekşisi ve tuzu ekleyip harmanlayın."

            };

            context.Tarifler.Add(KuruFasulyePiyazi);

            Tarifler fırındaKabakMucver = new Tarifler()
            {
                TarifAdi = "Fırında Kabak Mucver",
                Aciklamasi = "Malzemeler :\n3 adet orta boy rendelenmiş kabak\nDilediğiniz kadar beyaz peynir\n1 adet yumurta\n1 adet orta boy rendelenmiş patates\nYarım demet ince doğranmış maydanoz\n1 çay bardağı un\nDilediğiniz kadar karabiber,tuz ve pulbiber\nSusam ve çörekotu\r\n\r\nNasıl Yapılır ?\nRendelemiş olduğumuz kabak ve patateslerin suyunu sıkıyoruz. (cıvık olmaması için).\nDerin bir kaseye bütün malzemeleri ekleyip güzelce karıştırıyoruz.\nHarcınız cıvık olursa un ilavesi yapabilirsiniz,ben yapmadım.\nArdından yağlı kağıt serdiğimiz tepsiye elimizle yada kaşık yardımıyla şekil verip dizelim.\n180 derece fırında kızarana kadar pişirelim"

            };

            context.Tarifler.Add(fırındaKabakMucver);

            Tarifler kavunSepeti = new Tarifler()
            {
                TarifAdi = "Kavun Sepeti",
                Aciklamasi = "Malzemeler :\n1 adet bütün kavun\n1 avuç tamas (Sarı erik)\n1 avuç vişne\n3 adet dilimlenmiş şeftali\r\n\r\nNasıl Yapılır ?\nKavun güzelce yıkanır.\nYan tarafları dikkatlice bıçakla kesilerek sepet şekli verilir.\nArdından çekirdeklerinden temizlenir.\nSepetin içini dilediğiniz meyvelerle doldurabilirsiniz."

            };

            context.Tarifler.Add(kavunSepeti);

            Tarifler patatesliSebzeliMucver = new Tarifler()
            {
                TarifAdi = "Patatesli Sebzeli Mucver",
                Aciklamasi = "Malzemeler :\n2-3 tane patates\n1 adet kabak\n1 adet havuç\n1 adet yumurta (Ufaksa 2 alır)\r\nYarım su bardağı kaşar peyniri rendesi\nKarabiber\nPulbiber\nKimyon\nTuz\n1 su bardağı un (Kıvamına göre ekleyin)\r\n\r\nNasıl Yapılır ?\nPatates havuç ve kabağı kabuklarını soyup rendeleyelim suyunu iyice sıkıp genişçe bir kaba alalım üzerine un dışındaki malzemeleri ekleyip, karıştıralım.\nSon olarak unu azar azar ekleyip güzelce karıştıralım (Kıvamına göre gerekirse ekleyin benim için yeterliydi) hamurumsu bir kıvamı olup, kaşıkta toplu duruyor olmalı.\nArdından harcımızı kaşık yardımıyla alıp kızgın yağa koyalım üzerini hafif bastırıp düzleyelim ki içi iyi pişsin .\nBir tarafı pişince diğer tarafını da pişirelim tüm harcı bu şekilde hazırlayalım mücverimiz hazır. Afiyet olsun"

            };

            context.Tarifler.Add(patatesliSebzeliMucver);

            Tarifler sebzeGulleri = new Tarifler()
            {
                TarifAdi = "Sebze Gulleri",
                Aciklamasi = "Malzemeler :\n1 adet patlıcan\n1 adet kabak\n1 adet yufka\nZeytinyağı\r\n\r\nNasıl Yapılır ?\nKabak ve patlıcanları yarım ay şeklinde ince dilimler şeklinde keselim.\nYufkamızı yağlayalım, ikiye katlayıp tekrar yağlayalım.\nUzun şeritler halinde keselim. Patlıcan ve kabak dilimlerini sırayla dizelim.\nYufkayı katlayarak gül şeklini verelim.\n180 derece fırında 20 dk kızarana kadar pişirelim"

            };

            context.Tarifler.Add(sebzeGulleri);

            Tarifler Bruschetta = new Tarifler()
            {
                TarifAdi = "Bruschetta",
                Aciklamasi = "Malzemeler :\n2-3 tane domates\n1 tane kuru soğan\nTaze fesleğen\n2 adet kabak\n2 adet patlıcan\r\n2 adet kırmızı biber\n1 diş sarımsak (Rendelenmiş)\n5-6 yemek kaşığı sıvı yağ veya zeytinyağı\nTuz\r\n\r\nMantarlı Sos İçin ?\n1 paket mantar\n2 su bardağı vegan yoğurt\n3 yemek kaşığı vegan mayonez\nSıvıyağ\n1 diş rendelenmiş sarımsak\n2 paket etiform kızarmış ekmek veya italyan usulü kızarmış vegan ekmek\r\n\r\nNasıl Yapılır ?\nSebzeleri küp küp kesip, yağda kavurun.\nSarımsağı ve baharatları katıp, karıştırın.\nEkmeklerin üzerine pay edin.\nMantarlı karışım için mantarları yağda kavurun.\nSarımsağı katıp kavurmaya devam edin.\nMayonezi ve yoğurdu katıp karıştırın.\nEkmeklere pay edin. Bruschetta’lar servise hazır!."

            };

            context.Tarifler.Add(Bruschetta);

            Tarifler tavukYahnisi = new Tarifler()
            {
                TarifAdi = "Tavuk Yahnisi",
                Aciklamasi = "Malzemeler :\n2 parça tavuk bonfile\n2 adet havuç\n2 adet patates\n1 adet kuru soğan\nKarabiber\nKırmızı pul biber\n3-4 diş sarımsak\nKekik\nTuz\r\n\r\nNasıl Yapılır ?\nTavuk, havuç, patates ve kuru soğanı doğrayalım. Düdüklü tencereye alalım biraz sıvı yağ döküp kavuralım (5 dk)\nBaharatları ve sarımsağı ilave edip yaklaşık 3-3,5 su bardağı sıcak su ilavesi yapalım.\nDüdüklü tencerenin kapağını kapatalım ve kısık ateşte 15-20 dakika pişirelim. Afiyet olsun…"

            };

            context.Tarifler.Add(tavukYahnisi);

            Tarifler ruloBigMac = new Tarifler()
            {
                TarifAdi = "Rulo Big Mac",
                Aciklamasi = "Malzemeler :\n1 su bardağı yoğurt\n3 adet yumurta\n1 su bardağı kadar kaşar peyniri\nÇok az tuz ve karabiber\n100 gr az yağlı kıyma\n1 adet domates\n3 adet kornişon turşu\n1 adet küçük kırmızı soğan\nYeterince salata yaprağı\nTuz, karabiber, kırmızı toz biber\n2 yemek kaşığı yoğurt\n1 yemek kaşığı ketçap\n1 yemek kaşığı hardal\r\n\r\nNasıl Yapılır ?\nYoğurt, yumurta, kaşar peynir ve baharatları uygun bir kaba alınır ve güzelce çırpılır.\nYağlı kağıt serilmiş tepsiye yayılır. Ben bütün tepsiye yaymadım kenarlarında biraz boşluk bıraktım.\nDaha sonra önceden ısıtılmış 180 derce fırında üzeri hafif kızarana kadar (25-30 dak) pişirilir. Fırından çıkartın ve soğumaya alın.\nKıymayı uygun bir tavada yağsız kavurun.\nÜzerine tuz, karabiber ve kırmızı toz biber ekleyip ocaktan alın.\nDomates, soğan ve tursu küçük küçük doğranır. Salata yaprağı ince uzun doğranır.\nSosu için bütün malzemeleri bir kaseye alınır ve karıştırılır.\nSoğuyan ekmeği ters çevirin ve yavaşça yağlı kağıdını sıyırın.\nÜzerine sosun yarısını sürün. Kavrulmuş kıymayı her yerine eşit dağıtın.\nÜzerine taze malzemeleri ekleyin.\nKalan sosu dökün ve yavşca sıkı sıkı sarıp rulo haline getirin. Deneyecek olanlara şimden afiyet olsun"

            };

            context.Tarifler.Add(ruloBigMac);

            Tarifler patatesliMuffin = new Tarifler()
            {
                TarifAdi = "Patatesli Muffin",
                Aciklamasi = "Malzemeler :\n1 adet büyük boy patates\n2 kibrit kutusu kadar beyaz peynir\n1 adet yumurta\n5 dal yeşil soğan\n2 dal maydanoz\n1 buçuk su bardağı sut\n1 su bardağı un (tam buğday unuda olur)\n1 paket kabartma tozu\ntuz\r\n\r\nNasıl Yapılır ?\n.Öncelikle patatesi soyalım ve incecik kareler şeklinde doğrayalım. \nKarıştırma kabının içine alalım\nBeyaz peyniri ufalayalım soğan ve maydanozu incecik doğrayalım\nYumurta ,süt ,tuz ,kabartma tozu ve unu ilave edip karıştıralım. İşte bu kadar basit\nKarışımı silikon muffin kalıplarına paylaştıralım önceden ısıtılmış 180° fırında üzeri kızarana kadar pişirelim"

            };

            context.Tarifler.Add(patatesliMuffin);

            Tarifler zeytinyagliEnginarliBezelye = new Tarifler()
            {
                TarifAdi = "Zeytinyaglı enginarlı Bezelye",
                Aciklamasi = "Malzemeler :\n6 adet taze enginar\n1,5 su bardağı konserve bezelye (veya taze bezelye)\n1 adet iri kuru soğan\n3/4 (bir yarım+bir çeyrek) çay bardağı zeytinyağı\nTuz\nLimon suyu\nSüslemek için dereotu\r\n\r\nNasıl Yapılır ?\nAyıkladığınız enginarları kararması için limonlu suya alın, ayıklama esnasında sıktığınız limon kabukları ile ovalayın. Enginarları 4 veya 6 parçaya bölün.\r\nYemeklik doğradığınız kuru soğanı zeytinyağı ile tencere alın, hafif pembeleşinceye kadar kavurun.\r\nBezelye ve enginarlarınızı ekleyerek kavurmaya devam edelim. Sebzeleriniz hafif su salacak.\r\nSebze seviyesinin bir parmak altında sıcak su ekleyerek ve tuzunu ekleyerek 40-45 dk orta hararetteki ateşte suyunu çekinceye kadar pişirin. Çatal testi ile sebzelerin pişip pişmediğini kontrol edebilirsiniz.\r\nSoğumuş zeytinyağlı yemeğinizi kıyılmış dereotu ile süsleyerek servis yapın.\r\nAfiyet olsun."

            };

            context.Tarifler.Add(zeytinyagliEnginarliBezelye);


            Makaleler SporYaparkenKurallar = new Makaleler()
            {
                MakaleAdi = "Spor yaparken 8 altın kural",
                Aciklamasi = "1. Spora başlamadan önce, mutlaka sağlık kontrolünden geçmeliyiz. Kardiyovasküler olarak yapacağımız spora, uygun olup olmadığımızı bir uzmana danışmalıyız.\n2. Yaşımıza ve kilomuza uygun spor seçmeliyiz. 20-30 yaş aralığında daha yoğun antrenmanlar yapılabilirken, 40 yaş üzerinde antrenmanların yoğunluğu azaltılmalıdır.\n3- Spor yaparken vücudumuza doğru dinlenme zamanlarını tanımalıyız. Bu sebeple, antrenmanların sıklığını vücudu aşırı strese sokmayacak şekilde ayarlamalıyız.\n4. Spor yaparken zemin ve uygun ekipman seçimi çok önemlidir. Kıyafetler ne çok bol, ne de hareketimizi engelleyecek kadar dar olmamalıdır. Teri kolaylıkla dışarı atabilecek özellikte olmalıdır ve vücudun nefes almasını engellememelidir. Ayakkabı seçimine özellikle dikkat edilmelidir, ayak tabanı tam desteklemeli, ayağı iyice kavramalı ve sert yüzeylerde darbe emici özelliği olmalıdır.\n5. Spor öncesi ve sonrası beslenmeye dikkat edilmelidir. Spordan en az 1,5 saat önce yemek yenmiş olmalı, çok boş ya da çok dolu mide ile spor yapılmamalıdır. Alınan karbonhidrat ve protein miktarlarına dikkat edilmelidir.\n6. Spor esnasında ve sonrasında, terlemeyle vücudumuzda sıvı ve elektrolit kaybı yaşanmaktadır. Bu nedenle spor esnasında ve sonrasında, yeterli miktarda su tüketilmelidir. Su tüketiminde dikkat edilmesi gereken suyun hızlıca değil, yavaş yavaş içilmesidir.\n7. Spora başlamadan önce mutlaka ısınma hareketleri yapılmalıdır. Örneğin yapacağınız 10 dakikalık hafif tempoda koşu ve arkasından kol ve bacak kaslarınıza esnetme hareketleriyle, hem kalp hem de kas sağlığınızı koruyabilirsiniz.\n8. Sporu bitirdikten sonra da, soğuma amaçlı dinamik esneme hareketleriyle kaslarda biriken laktik asit dediğimiz ve kas yorgunluklarına neden olan maddenin vücuttan daha kolay atılmasını sağlayabiliriz."

            };

            context.Makaleler.Add(SporYaparkenKurallar);

            Makaleler basenNasılEritilir = new Makaleler()
            {
                MakaleAdi = "Basen Nasıl Eritilir?",
                Aciklamasi = "Basenler kalori yakımının en zor olduğu bölgelerdendir. Bu nedenle, basen eritme hareketleri doğrudan faydasını görmek için sabır gerektiren egzersizler arasındadır. Basenlerin geniş olduğu vücut tipi, genellikle hareketsiz yaşam veya genetik özelliklerden kaynaklanıyor olabilir. Ancak bu geniş basenlerinizle yaşamak zorunda olduğunuz anlamına gelmez. Vücudun diğer bölgelerine göre biraz daha sabır istese de, basen yağlarıyla savaşmak imkansız değildir.İşte basen eritme için deneyebileceğiniz bazı egzersiz türleri:\nYukarı Tekme Egzersizi / Donkey Kick\nSquat Egzersizi\nYan Kalça Kaldırma Egzersizi / Fire Hydrant\nKöprü Egzersizi / Bridge"

            };

            context.Makaleler.Add(basenNasılEritilir);

            Makaleler ucAdimdaBarfiksCekme = new Makaleler()
            {
                MakaleAdi = "3 Adımda Barfiks Cekme",
                Aciklamasi = "Barfiks çekme hareketi tamamen kas gücüne dayalı bir egzersizdir. Basit görünen ama yapması oldukça zor ve çok kalori yaktıran bir harekettir. Barfiks çekerken kendi vücut ağırlığınızı kullandığınız için, üst beden gücünüzü en iyi şekilde göstermenizi sağlar. Barfiks çekebilmeniz için bir barfiks demiri ya da bir barfiks istasyonu gerekir. Spor salonunda ya da parklardaki demirlerde de barfiks çekebileceğiniz gibi, bir kapıya ya da bir koridora monte ederek kullanabileceğiniz kapı barfiks demiri, size istediğiniz yerde barfiks çekme imkanı tanır.\r\n\r\n1. Adım: Hazırlık\n Barfiks demirinin altında durun.\n Avuç içleriniz karşıya bakacak şekilde yukarı doğru sıçrayarak barı iki elinizle birden tutun.\n Ellerinizi omuz genişliğinden biraz daha fazla açın.\nKollarınızı tamamen serbest bırakmayın ve karın kaslarınızı sıkın.\nğer daha rahat edecekseniz, ayaklarınızı birbirine dolayabilirsiniz.\r\n\r\n2. Adım: Doğru Nefes : Her egzersizde olduğu gibi barfiks çekerken de doğru nefes alıp vermek çok önemlidir. Böylesine kuvvet gerektiren bir egzersizi yaparken yanlış nefes almak performansınızı azaltır. Kendinizi yukarı çekerken nefes vermeli, gövdenizi aşağı indirirken nefes almalısınız. Barfiks çekerken asla nefesinizi tutmamalısınız.\r\n\r\n3. Adım: Egzersi :\nÇenenizi yukarı doğru kaldırmadan, gövdeniz ve sırtınız dik duracak şekilde kendinizi yukarı doğru çekin.\nKollarınızdan değil sırt kaslarınızdan güç alın.\nDirseklerinizin altında bir duvar varmış gibi kendinizi yukarı doğru itin.\nÇeneniz barın üzerine çıktığı zaman yavaşça tekrar gövdenizi aşağı doğru indirin ve başlangıç pozisyonuna dönün."

            };

            context.Makaleler.Add(ucAdimdaBarfiksCekme);

            Makaleler gobekErtimeYontemleri = new Makaleler()
            {
                MakaleAdi = "Gobek Eritme Yontemleri",
                Aciklamasi = "Göbek bölgesi en kolay yağlanan bölgelerden biridir ancak göbek eritme pek de kolay değildir. Bu nedenle göbek bölgesinde oluşan yağlanmaya karşı önlem alınmalı, sağlıklı beslenerek düzenli egzersiz yapılmalıdır. Bu bölgedeki yağ yakımını hızlandıran göbek eritme yöntemleri arasında birtakım egzersizler vardır. Bu egzersizler düzenli olarak yapıldığında kısa süre içerisinde sonuç vererek bel ve karın bölgesinde gözle görülür derecede fark yaratır.İşte, göbek bölgesinde biriken yağları yakabilecek ve birkaç hafta içerisinde forma girmenizi kolaylaştıracak göbek eritme yolları\nYarım Mekik / Crunches Egzersizi\nBisiklet / Bicycle Crunche Egzersizi\nBacakla Çember Çizme Egzersizi\nPlank Egzersizi\nHavaya Tekme / Flutter Kick Egzersizi"

            };

            context.Makaleler.Add(gobekErtimeYontemleri);

            Makaleler ipatlamaninfaydalari = new Makaleler()
            {
                MakaleAdi = "İp Atlamanın Faydaları ",
                Aciklamasi = "İp atlamak tüm vücudu çalıştıran bir egzersizdir. Kan akışınız hızlanır ve kalbe daha çok kan pompalanır. Bu da kardiyovasküler sağlığınız için çok önemlidir. Aynı zamanda daha hızlı nefes aldığınız için akciğerlerinize daha fazla oksijen gider ve bu da solunum problemlerinizi azaltmaya yardımcı olur.· Ayak bileklerinizden omuzlarınıza kadar tüm kaslarınızı çalıştırır.\n         Denge, koordinasyon ve refleks duygularınızı geliştirir.\nAkciğerlerinizin kapasitesini artırır ve kan akışınızı hızlandırır.\nKarın kaslarınızın, kalçanızın ve bacaklarınızın şekillenmesine destek olur.\nDayanıklılığınızı ve kondisyonunuzu artırır.\nStres seviyenizi azaltır ve rahatlamanıza yardımcı olur.\nKalp ve damar sağlığınızı korur.\nMetabolizmanızı hızlandırır.\nDaha dik durmanızı sağlar."

            };

            context.Makaleler.Add(ipatlamaninfaydalari);


            Makaleler evdeEgzersizHareketleri = new Makaleler()
            {
                MakaleAdi = "Evde Egzersiz Hareketleri",
                Aciklamasi = "Modern yaşamın zorunlulukları içerisinde ev ve iş arasında koşuştururken vücudunuzu ve sağlığınızı ihmal ediyor olabilirsiniz. Bu ihmalin neden olacağı problemler ilerleyen yaşlarda pişman olmanıza yol açabilir. Hareketli yaşam tarzını benimsemiş olmak, tahmin edebileceğinizden daha büyük yararlar sağlayabilir. Bu nedenle fitness salonuna ayıracak vaktiniz yoksa bile evde yapabileceğiniz basit egzersizler ile vücudunuzu dinç tutabilir, sağlıklı bir rutin oluşturabilirsiniz.Evde spor yaparak kan dolaşımınızı hızlandırabilir, kalp sağlığınızı koruyabilir ve kaslarınızı güçlendirebilirsiniz. İlerleyen yaşlarda kritik öneme sahip olan kas ve eklemler, düzenli spor sayesinde sağlıklı kalabilir. Bunun için tek yapmanız gereken günde ortalama 20-30 dakika ayırarak temel egzersizleri düzenli olarak uygulamaktır. Her gün spor yaparak ruh halinizi pozitif yönde değiştirebilir, hayata karşı motivasyon seviyenizi yükseltebilirsiniz. Sevdiklerinizle geçireceğiniz uzun ve sağlıklı bir ömür için hareketsiz yaşam tarzından kaçınmalı, beslenme düzeninizi doğru biçimde oluşturmalısınız. İşte, evde fitness yaparak fit kalmak ve sağlıklı olmak için deneyebileceğiniz egzersiz önerileri:\nStreching / Esneme Egzersizi\nPlank Egzersizi\nBird Dog Egzersizi\nŞınav / Push Up Egzersizi"

            };

            context.Makaleler.Add(evdeEgzersizHareketleri);

            Makaleler kolKasihareketleri = new Makaleler()
            {
                MakaleAdi = "Kol Kası Nasıl Yapılır ?",
                Aciklamasi = "Sağlıklı yaşam ve fit görünüm için en elzem egzersizlerden biri olan kol kası egzersizleri, hem fiziksel açıdan eşsiz bir görüntüye sahip olmanızı hem de kollarınızın sağlıklı bir şekilde güçlenmesini sağlar. Omuz genişliği veren ve giyilen her giysinin son derece şık görünmesini sağlayan kol kası egzersizleri, genel olarak erkekler arasında yaygınlaşmış olsa da kadınlarda da yaşa bağlı cilt sarkmalarını önleme, incelme ve sıkılaşma amacıyla tercih edilir. Aşağıda türlü adımları verilmiş olan kol kası egzersizlerini inceleyerek ihtiyacınıza ve vücut tipinize en uygun egzersiz tipini belirleyebilir, kusursuz kol kaslarına sahip olabilirsiniz.\nBodyweight Dips Egzersizi\nCrab Walk Egzersizi\nThe Impossible Press-Up Egzersizi\nBiceps Egzersizi"

            };

            context.Makaleler.Add(kolKasihareketleri);

            Makaleler sabahSporu = new Makaleler()
            {
                MakaleAdi = "Sabah Sporu Nasıl Yapılır?",
                Aciklamasi = "Tüm yorgunluklardan uzak, son derece dinç ve enerjik olabileceğiniz aynı zamanda fit kalabileceğiniz güzel bir gün için sabah sporunun etkili performansından yararlanabilirsiniz. Tüm dünyada yaygın olarak yapılan sabah sporu, hem beden hem de ruh sağlığınız için çok sayıda fayda sunar. Oldukça küçük vakitler ayırarak işe gitmeden önce dahi yapabileceğiniz bu kısa spor, tüm gün metabolizmanızın hızlı çalışmasını sağlayarak sindirim sorunları yaşamanızı da engeller. Peki, sabah sporu nasıl yapılır? İşte kolayca her alanda yapabileceğiniz kısa süreli sabah egzersizleri.\nIsınma ve Esneme Hareketleri\nHamstring\nTriceps Esneme\nŞınav\nSquat\nMasa Pozisyonu\nMekik\nMakas"

            };

            context.Makaleler.Add(sabahSporu);

            Makaleler bacakEgzersizleri = new Makaleler()
            {
                MakaleAdi = "İnce Ve Sıkıcı Bacaklar İçin Egzersizler",
                Aciklamasi = "Güçlü bacaklar sadece güzel görünmek için değil vücudunuzun tüm dengesi için gereklidir. Kuvvetli bacaklar daha rahat yürümenizi sağlar ve dengede kalmanıza yardımcı olur. Ayrıca vücudunuzu destekler ve günlük aktivitelerden keyif almanıza katkıda bulunur.İnce ve sıkı bacaklar için aşağıdaki egzersizleri takip ederek ipuçlarını uygulayabilirsiniz. Egzersizleri uygularken bedeninizi zorlamamayı ve gerekli durumlarda doktorunuza danışmayı unutmayın.\nSquat Egzersizi.\nLunge Egzersizi\nSuperman Plank Egzersizi\nKöprü Egzersizi\nGeriye Tekme Egzersizi\nPop (Jump) Squat Egzersizi\nİp Atlama Egzersizi\nSpinning Egzersizi\nYürüyüş Egzersizi"

            };

            context.Makaleler.Add(bacakEgzersizleri);

            Makaleler kosuBandiNasilKullanilmali = new Makaleler()
            {
                MakaleAdi = "Kosu Bandı Nasıl kullanılmalıdır?",
                Aciklamasi = "Dünyada yaygın olarak kullanılan kardiyo yöntemlerinden biri olan koşu bandı, doğru bir şekilde ve doğru tempolarla kullanıldığında vücutta büyük etkiler yaratabilir. Çeşitli hız seviyeleri de bulunan koşu bantları, ancak kişiye ve egzersize uygun seviyede kullanıldığında etkili olabilir. Hem zayıflamak hem de sıkılaşmak ve formda kalmak amacıyla kullanılan spor aletlerinden olan koşu bantları, yanlış kullanıldığında çeşitli kas zedelenmelerine ve kas ağrılarına da sebebiyet verebilir. Peki, en sağlıklı egzersiz yöntemlerinden sayılan koşu bandı nasıl kullanılmalı?\nKoşu bandınızda varsa, manuel ayarlar aracılığıyla kilonuzu girin.\nBaşlangıç için koşmak istediğiniz süreyi belirleyin.\nYakmak istediğiniz kalori miktarını spor danışmanınıza ya da doktorunuza danıştıktan sonra yazın. \nKoşu bandınızın temposunu ayarlayın.\nCihazın temposunu öncelikle yürüme egzersizine uygun bir seviyeye getirin.\nGenellikle 5 ve 5.5 yürüyüş temposudur.\nYürüyüş temposunun ardından, 5 dakika süren bir hızlandırılmış yürüyüş tamamlayın.\nHafifçe terlemeye başladığınızda ısınma antrenmanınız tamamlanmış olur.\nKoşu bandınızı koşmak için hazırlayın.\nKoşarken korkuluklara tutunmayarak kol kaslarınızın da çalışmasını sağlayabilirsiniz.\nKollarınızı birisi ileride ve birisi geride olacak şekilde, dik açıda koşu temponuza göre hareket ettirin.\n Antrenörünüzün önerdiği sürede koşu yapın.\nEğer koşu bandınızı evde kullanıyorsanız, uyguladığınız spor programında belirtilen süre kadar koşabilirsini"

            };

            context.Makaleler.Add(kosuBandiNasilKullanilmali);

            Makaleler esneklikEgzersizleri = new Makaleler()
            {
                MakaleAdi = "Nasıl Daha Esnek Olunur?",
                Aciklamasi = "Vücut esnekliğini zaman içinde yitirir ve bu durum bazı hareket kısıtlanmalarına yol açabilir. Özellikle hareketsiz yaşam tarzı vücudun esnekliğini kaybetmesine neden olur ve yaş ilerledikçe kaslar esnekliğini neredeyse tamamen kaybeder. İlerleyen yaşlarda bile esnekliğinizi korumak için hareketli yaşam tarzını benimsemeli, fazla kilodan kaçınmalısınız. Sağlıklı ve düzenli beslenerek kaslarınızın güçlü kalmasını sağlayabilirsiniz. Esnemek için uygulanabilecek yöntemler arasında bazı egzersizler de vardır. Bu egzersizlerin etkileri, düzenli olarak yapıldığında hissedilir derecede kendini gösterir. Esneklik egzersizleri günlük hayatta daha geniş hareket imkanı tanımasının yanı sıra antrenmanlarda da yapılan spordan daha fazla verim alınmasına yardımcı olur. Her gün sadece yarım saat yapılacak esneklik egzersizi ile kısa sürede sonuç alabilir, daha sağlıklı ve esnek bir vücuda kavuşabilirsiniz. Nasıl esnek olunur diye merak ediyorsanız, aşağıda yer alan egzersizleri deneyerek vücudunuza esneklik kazandırabilirsiniz. Bu egzersizleri yaparken vücudunuzu fazla zorlamamaya özen göstermelisiniz.\nKuğu Esnemesi Egzersizi\nUyluk Açma Egzersizi\nKatlanma Egzersizi\nGüvercin Egzersizi\nKelebek Esnemesi\nKöprü Egzersizi"

            };

            context.Makaleler.Add(esneklikEgzersizleri);

            Makaleler sixPackNasilCikarilir = new Makaleler()
            {
                MakaleAdi = "Six Pack Nasıl Çıkarılır??",
                Aciklamasi = "Six Pack özellikle erkeklerin hayalini süsleyen karın kasına verilen addır. Six pack kasları aslında herkeste bulunur ancak yağlanma nedeniyle görünür durumda değildir. Six pack çıkarmak için karın bölgesinde bulunan bu yağların eritilmesi gerekir. Ancak bunu sağlamak yalnızca sıkı bir çalışmayla mümkün olabilir.Belirli egzersizleri her gün düzenli olarak yaptığınızda ve tükettiğiniz gıdalara yeterli özeni gösterdiğinizde Six Pack kaslarınızı çıkartabilirsiniz. Ancak gerekli durumlarda doktorunuza danışmayı ve evde spor yaparken bedeninizi zorlamamayı unutmayın.\nSix Pack çıkarmak için egzersiz yapmanın yanı sıra dikkat etmeniz gereken konuların başında beslenme düzeniniz gelir. Beslenme düzeninizde karbonhidrat ve yağlara daha az yer verip proteine ağırlık vermeniz gerekir.\n Stresten kaynaklanan kortizol hormonu karın çevresinde yağlanmaya yol açarak Six Pack kaslarınızın görünmesine engel olur. Stres seviyenizi azaltarak egzersizlerinizin etkilerini vücudunuzda daha kısa süre içerisinde görebilirsiniz.\nSadece alt karın kaslarını çalıştırmak yeterli değildir, alt sırt kasları, oblikler, çapraz karın kasları da çalıştırılmalıdır. Bu çalışma kaslarınızın dengeli bir şekilde ortaya çıkmasını sağlayacaktır.\nKalori almamak için aç kalmak doğru bir yöntem değildir. Mutlaka yeterli ve kaliteli gıda almalısınız.\nSix pack çıkarmak için yapılması gereken belli egzersizler vardır. Bu egzersizleri mutlaka düzenli bir şekilde yapmalı, her gün vakit ayırmalısınız. İşte, six pack çıkartmak için yapabileceğiniz egzersizler:\nSide Plank / Yan Plank Egzersizi\nMekik / Sit Up Egzersizi\nAb Rollout Egzersizi\nHanging Leg Raises / Asılarak Bacak Kaldırma Egzersizi"

            };

            context.Makaleler.Add(sixPackNasilCikarilir);

            Makaleler sinavCekmeninPufNoktalari = new Makaleler()
            {
                MakaleAdi = "Şınav Çekmenin Püf Noktaları",
                Aciklamasi = "Şınav çekmek çok basit gibi görünen ama pek çok inceliği olan komplike bir harekettir. Şınav çekmek için herhangi bir ekipmana ihtiyacınız yoktur ve kendi vücut ağırlığınızla her an, her yerde yapabileceğiniz bir egzersizdir.\nŞınav yere yüz üstü uzanarak, ayak uçlarınızın üzerinde durup, ellerinizden güç alarak kollarınızla gövdenizi yukarı doğru kaldırdığınız ve tekrar göğsünüzü yere değmeyecek şekilde aşağı indirdiğiniz bir kuvvet egzersizidir. Pek çok kasınızı aynı anda kullandığınız için, bu hareketi doğru bir şekilde ve uzun süreyle yapabilmek için genel sağlığınızın ve kondisyon seviyenizin iyi durumda olması gerekir\nYere paralel uzanın ve parmak uçlarınız tam karşıya bakacak şekilde ellerinizi omuz genişliğinden biraz daha geniş açarak, avuç içlerinizi yere koyun.\nAyak parmaklarınızı yere koyun ve kollarınızdan kuvvet alarak göğsünüzü yerden kaldırın.\nŞınav çekerken doğru nefes alıp vermek çok önemlidir. Gövdenizi aşağı doğru indirirken nefes almalı, yukarı doğru kaldırırken nefes vermelisiniz.\nŞınav çekerken kalçanızı yukarı doğru kaldırmamalısınız. Başınız, kalçanız ve ayaklarınız aynı hizada olmalıdır.\nSırtınız ve kalçanız aynı hizada olacak şekilde, karın kaslarınızı sıkarak tekrar yavaşça dirseklerinizi bükün ve göğsünüzü yere doğru indirin.\nGöğsünüzü yere değdirmeden hareketi sonlandırın. Bu, bir tekrardır. Üst üste yapabildiğiniz kadar çok tekrar yapın ve aralarda mola vererek birkaç set halinde egzersizi tamamlayın."

            };

            context.Makaleler.Add(sinavCekmeninPufNoktalari);

            Makaleler yataktaYapılabilecekEgzersizler = new Makaleler()
            {
                MakaleAdi = "Yatakta Yapılabilcek Egzersizler",
                Aciklamasi = "Fit bir vücut sağlık için önemli olduğu kadar estetik bir görünüm ve olumlu bir psikoloji için de önemli kabul edilir. Böyle bir vücuda sahip olabilmek içinse sporu hayatın her alanına dahil etmek gerekir. Gündelik egzersiz programları ile desteklenen sporda en önemli aktivitelerden bir tanesi de sabah sporu olarak ifade edilebilir. Uyandıktan kısa bir süre sonra, yataktan kalkmadan bile yapılabilecek olan sabah egzersizi ile kısa sürede etkili sonuçlar alınabilir. Bu sayede hem güne dinç başlayabilir hem de vücudunuzu daha kolay şekillendirebilirsiniz.\nPlank Egzersizi\nSide Plank Egzersizi\nThe Bridge Egzersizi"

            };

            context.Makaleler.Add(yataktaYapılabilecekEgzersizler);

            Makaleler vucutGelistirmeProgrami = new Makaleler()
            {
                MakaleAdi = "Vücut Gelitirme İçin Ağırlık Programı",
                Aciklamasi = "Vücut geliştirme ve fitness, son yılların yükselen spor aktiviteleri arasında yer alır. Sağlıklı bir hayatın anahtarı olan vücut geliştirme ve fitness, doğru programlar uygulandığında kısa sürede etkili olur. Üstelik vücut geliştirmek için evde uygulayabileceğiniz çok etkili yöntemler de bulunur. Peki vücut geliştirme programı nasıl oluşturulur, biliyor musunuz? İşte karşınızda, en etkili vücut geliştirme ve fitness teknikleri!Vücut geliştirme denince akla ilk olarak ağırlık kaldırma programları gelir. Kas kütlelerini güçlendirerek genişleten ağırlıklar; kol, omuz, göğüs, bacak ve kalça başta olmak üzere pek çok kas grubunu çalıştırır. Eğer etkili bir ağırlık kaldırma programı hazırlamak isterseniz, aşağıdaki adımları takip edebilirsinizr\r\n\r\nKoşu, step ya da bisiklet gibi hafif kardiyo hareketleriyle vücudunuzu ısıtın ve esneme hareketleri yapın.\nİki elinize birer dumbell alıp vücudunuzu dik tutarak dumbell aletlerini sırayla omuz hizanıza kadar kaldırıp indirin.\nVücut gücünüze göre hazırladığınız bir halteri göğsünüze kadar kaldırıp indirin.\nSırt üstü uzanarak vücut ağırlığınıza uygun bir halteri göğüs hizanızın altına kadar indirip kaldırın.\nKarın ve Bacak Kasları İçin:\nSırt üstü uzanarak mekik çekin. Mekik esnasında vücudunuzu ellerinizle çekmemeye dikkat edin.\nSırt üstü uzanarak ellerinizi başınızın altına koyun. Bir yandan bacaklarınızı karın kaslarınızın kuvvetiyle sırayla yukarı çekerken öbür yandan çapraz dirseğinizi dizinize doğru itin.\nBacak kaslarınızı güçlendirmek için tempolu bir şekilde dizlerinizi sırayla yere değdirerek lunge hareketi yapın.\nÖn ve bacak kaslarınızı güçlendirmek için leg press makinesini ideal ağırlığa göre hazırlayın ve baldırlarınızın gücüyle itin."

            };

            context.Makaleler.Add(vucutGelistirmeProgrami);

            Makaleler sudaCimnastik = new Makaleler()
            {
                MakaleAdi = "Suda Cimnastik Nedir?",
                Aciklamasi = "Suda jimnastik ya da diğer bir deyişle Aqua Gym günümüzün en popüler sporlarından biridir. Hem eğlenceli bir spor aktivitesi olması hem de sağlık açısından büyük faydalar sağlaması nedeniyle yaygın olarak tercih edilir. Aquagym kısaca su içinde yapılan egzersizler olarak tanımlanabilir. Suyun sağladığı basınca karşı direnç göstererek yapılan bu egzersizler kasların oldukça aktif biçimde çalışmasını sağlar. Bu da suyun masaj etkisi yaparak vücuttaki ağırlığı, eklem ağrılarını azaltmasını sağlar ve negatif enerjiyi azaltır.\r\n\r\nProfesyonel sporcular tarafından da rutin olarak yapılan Aqua Gym hareketleri, hem spor hem de meditasyon işlevi görür. Özellikle bel, boyun, eklem rahatsızlıklarına iyi geldiği bilinen suda jimnastik sporu uzmanlar tarafından her yaştan bireye önerilir. Bu hareketleri yapmak için herhangi bir yeterlilik veya yaş sınırına ihtiyacınız yoktur."

            };

            context.Makaleler.Add(sudaCimnastik);

            Makaleler stepper = new Makaleler()
            {
                MakaleAdi = "Stepper Aleti Ve Faydaları",
                Aciklamasi = "Stepper egzersizi hem keyifli hem de oldukça etkili bir egzersiz türüdür. Stepper üzerinde geçirdiğiniz vaktin verimini artırmak için çekme ipli modelleri kullanabilirsiniz. Bu sayede Stepper, vücudunuzun hem alt hem de üst bölgesini çalıştırarak tüm kaslarınızın gelişmesine katkı sağlar. Özellikle yaza formda girmek isteyen kadınlar tarafından yoğun olarak kullanılan Stepper, kısa sürede etki eden bir egzersiz aletidir. Düzenli yapıldığında kalça bölgesini şekillendirmek açısından oldukça yarar sağlar.Hem bacakları hem de kalçayı şekillendiren Stepper aleti ile yaza formda girmek, kardiyo yaparak kısa sürede fazla yağlardan kurtulmak mümkündür. Ancak kapasitenizi zorlamadan, nabzınızı takip ederek egzersiz yapmanız gerektiğini unutmamalısınız.\nStepper faydaları arasında en çok dikkat çeken özellik, kısa süre içerisinde kalori yakımında etkili olmasıdır.\nStep egzersizi duruşunuzu düzelterek, bedeninizin esnek ve uyumlu olmasını sağlar. Egzersiz dışında da dik durmanıza yardımcı olur.\nStepper, kondisyonunuzu yükseltir ve genel olarak vücut kaslarınızı güçlendirir.\nNefes kontrolü sağlamayı öğreterek, düzenli ve yüksek kapasiteli nefes almanıza yardımcı olur.\nRuh halinizi pozitif yönde etkileyerek motivasyonunuzu arttırır.\nToplu olarak yapılan step egzersizleri eğlenerek stres atmanıza yardımcı olur. Sosyalleşmek için ideal ortamı yaratmanıza katkı sağlar.\nFormda kalmanıza, kalça ve bacaklarınızda sıkılaşmaya yardımcı olur. Bu özelliği sayesinde kendinizi fit ve güzel hissedebilirsiniz. Bu da öz güveninizi olumlu yönde etkiler.\n      Sağlıklı bir vücut için zinde ve hareketli olmak gerekir. Stepper, ihtiyaç duyduğunuz hareketlilik için ideal bir egzersiz aletidir.\nSpor salonuna gitmek yerine evinizde kolayca yapabileceğiniz bir antrenman türüdür."

            };

            context.Makaleler.Add(stepper);

            Makaleler biceps = new Makaleler()
            {
                MakaleAdi = "En Etkili 5 Biceps Hareketi",
                Aciklamasi = "Etkileyici biceps kası, özellikle erkeklerin vücutlarında görmek istediği bir görüntüdür. Geniş biceps kasları oluşturmak için egzersiz yapan erkekleri neredeyse her fitness salonunda görmek mümkündür. Peki, biceps nedir ve nasıl oluşturulur? Biceps kası oluşturmak için öncelikle egzersizin yanı sıra beslenme düzenine dikkat edilmeli ve protein ağırlıklı gıda tüketilmelidir. Egzersizleri yaparken vücudunuzu fazla zorlamamanız gerektiğini de unutmayın. Biceps kasları, kısaca omuz ile dirsek arasında bulunan ön kas grubudur. Genellikle erkeklerde güç ve dayanıklılık simgesi olarak görüldüğü için dış görünüm bakımından bu kasların gelişmesi kişiyi tatmin eder. Biceps kasları gelişen birey spora karşı motive olur ve sporun etkilerini vücudunda somut olarak görebildiği için yüksek derecede haz duyar. Siz de belli egzersizleri düzenli olarak yaparsanız ve yeterli çabayı gösterirseniz biceps kaslarınızı geliştirebilir, etkileyici bir görüntüye kavuşabilirsiniz. Bunun için yapmanız gerekenler sağlıklı beslenmek ve egzersizlerinizde kol ve biceps hareketlerine ağırlık vermektir. İşte, geniş kollar ve çekici bir görüntü için uygulamanız gereken biceps hareketleri:\nIncline Dumbbell Curl Egzersizi\nHammer Curl Egzersizi\nBarbell Curl Egzersizi\nBarbell Curl Egzersizi\nConcentration Curl Egzersizi"

            };

            context.Makaleler.Add(stepper);

            //Alkoller 

            BesinBilgileri beyazSarap = new BesinBilgileri() { BesinAdi = "Beyaz Şarap(1 Kadeh)", OlcuBirimi = OlcuBirimi.MLitre, Kalori = 125, Karbonhidrat = 3.81F, Protein = 0.1F, Yag = 0, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(beyazSarap);


            BesinBilgileri kirmiziŞarap = new BesinBilgileri() { BesinAdi = "Kırmızı Şarap(1 Kadeh)", OlcuBirimi = OlcuBirimi.MLitre, Kalori = 125, Karbonhidrat = 3.85F, Protein = 0.1F, Yag = 0, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(kirmiziŞarap);

            BesinBilgileri bira = new BesinBilgileri() { BesinAdi = "Bira(330cc)", Kalori = 139, OlcuBirimi = OlcuBirimi.MLitre, Karbonhidrat = 10.3F, Protein = 1.65F, Yag = 0, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(bira);

            BesinBilgileri cin = new BesinBilgileri() { BesinAdi = "Cin(100cc)", Kalori = 231, OlcuBirimi = OlcuBirimi.MLitre, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(cin);


            BesinBilgileri raki = new BesinBilgileri() { BesinAdi = "Raki(1 duble)", OlcuBirimi = OlcuBirimi.MLitre, Kalori = 186, Karbonhidrat = 0.33F, Protein = 0, Yag = 0, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(raki);

            BesinBilgileri votka = new BesinBilgileri() { BesinAdi = "Votka(1 kadeh)", OlcuBirimi = OlcuBirimi.MLitre, Kalori = 116, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(votka);

            BesinBilgileri viski = new BesinBilgileri() { BesinAdi = "Viski(1 kadeh)", OlcuBirimi = OlcuBirimi.MLitre, Kalori = 125, Karbonhidrat = 0.06F, Protein = 0, Yag = 0, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(raki);


            BesinBilgileri visneLikörü = new BesinBilgileri() { BesinAdi = "Visne Likörü(şat bardağı)", OlcuBirimi = OlcuBirimi.MLitre, Kalori = 131, Karbonhidrat = 15.21F, Protein = 0, Yag = 0, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(visneLikörü);


            BesinBilgileri portakalLikörü = new BesinBilgileri() { BesinAdi = "Portakal Likörü(şat bardağı)", OlcuBirimi = OlcuBirimi.MLitre, Kalori = 96, Karbonhidrat = 7.5F, Protein = 0, Yag = 0, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(portakalLikörü);


            BesinBilgileri sampanya = new BesinBilgileri() { BesinAdi = "Şampanya(1 kadeh)", OlcuBirimi = OlcuBirimi.MLitre, Kalori = 80, Karbonhidrat = 1.47F, Protein = 0.32F, Yag = 0, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(sampanya);

            BesinBilgileri brandy = new BesinBilgileri() { BesinAdi = "Brandy(1 kadeh)", OlcuBirimi = OlcuBirimi.MLitre, Kalori = 220, Karbonhidrat = 0, Protein = 0, Yag = 0, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(brandy);

            BesinBilgileri tekila = new BesinBilgileri() { BesinAdi = "Tekila(şat bardağı)", OlcuBirimi = OlcuBirimi.MLitre, Kalori = 138, Karbonhidrat = 7.5F, Protein = 0, Yag = 0, CreatedBy = "Tuba" };
            context.BesinBilgileri.Add(tekila);


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
