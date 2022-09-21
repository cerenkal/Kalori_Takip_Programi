using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class KullaniciMapping : EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMapping()
        {
            this.HasKey(x => x.ID);
            this.Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();



            this.Property(x => x.KullaniciAdi).HasMaxLength(50);
            this.Property(x => x.KullaniciSoyadi).HasMaxLength(50);
            this.Property(x => x.Mail).HasMaxLength(50);
            this.Property(x => x.KullaniciSifre).HasMaxLength(6);
            this.Property(x => x.KullaniciSifreTekrari).HasMaxLength(6);



            this.Property(x => x.CreatedBy).HasMaxLength(50);
            this.Property(x => x.ModifiedBy).HasMaxLength(50);
            this.Property(x => x.DeletedBy).HasMaxLength(50);



            this.Property(x => x.CreatedDate).IsRequired();
            this.Property(x => x.DeletedDate).IsOptional();
            this.Property(x => x.ModifiedDate).IsOptional();



            this.Property(x => x.Status).HasColumnName("Statu");



            this.HasOptional(k => k.KullniciHedefBilgileri)
                 .WithMany(kh => kh.Kullanicilar)
                 .HasForeignKey(k => k.KullniciHedefBilgileriID);



            this.HasOptional(k => k.AktiviteBilgileri)
                 .WithMany(ab => ab.Kullanicilar)
                 .HasForeignKey(k => k.AktiviteBilgileriID);


            this.HasMany(k => k.TuketilenBesinler)
                 .WithOptional(tb => tb.Kullanici)
                 .HasForeignKey(tb => tb.KullaniciID);



            this.HasMany(k => k.Egzersizler)
                 .WithOptional(ev => ev.Kullanici)
                 .HasForeignKey(ev => ev.KullaniciID);



            this.HasOptional(k => k.SuVerisi)
                 .WithMany(s => s.Kullanicilar)
                 .HasForeignKey(k => k.SuVerisiID);




            this.HasOptional(k => k.VucutAnalizi)
                .WithMany(v => v.Kullanicilar)
                .HasForeignKey(k => k.VucutAnaliziID);




            this.HasOptional(k => k.MakroBesinRaporu)
                .WithMany(mr => mr.Kullanicilar)
                .HasForeignKey(k => k.MakroBesinRaporuID);
        }
    }
    
}
