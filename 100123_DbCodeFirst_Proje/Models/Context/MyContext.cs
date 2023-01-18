using _100123_DbCodeFirst_Proje.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100123_DbCodeFirst_Proje.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Table Design
            //Coach
            modelBuilder.Entity<Coach>().ToTable("Antrenör");
            modelBuilder.Entity<Coach>().Property(x => x.Name).HasColumnName("İsim");
            modelBuilder.Entity<Coach>().Property(x => x.TeamID).HasColumnName("Takım_ID");
            modelBuilder.Entity<Coach>().Property(x => x.Status).HasColumnName("Durum");
            modelBuilder.Entity<Coach>().Property(x => x.InsertedDate).HasColumnName("Eklenme_Tarihi");
            modelBuilder.Entity<Coach>().Property(x => x.DeletedDate).HasColumnName("Silinme_Tarihi");
            modelBuilder.Entity<Coach>().Property(x => x.UpdatedDate).HasColumnName("Güncelleme_Tarihi");
            //Team
            modelBuilder.Entity<Team>().ToTable("Takım");
            modelBuilder.Entity<Team>().Property(x => x.Name).HasColumnName("İsim");
            modelBuilder.Entity<Team>().Property(x => x.CoachID).HasColumnName("Antrenör_ID");
            modelBuilder.Entity<Team>().Property(x => x.FounderID).HasColumnName("Kurucu_ID");
            modelBuilder.Entity<Team>().Property(x => x.Status).HasColumnName("Durum");
            modelBuilder.Entity<Team>().Property(x => x.InsertedDate).HasColumnName("Eklenme_Tarihi");
            modelBuilder.Entity<Team>().Property(x => x.DeletedDate).HasColumnName("Silinme_Tarihi");
            modelBuilder.Entity<Team>().Property(x => x.UpdatedDate).HasColumnName("Güncelleme_Tarihi");
            //Player
            modelBuilder.Entity<Player>().ToTable("Oyuncu");
            modelBuilder.Entity<Player>().Property(x => x.Name).HasColumnName("İsim");
            modelBuilder.Entity<Player>().Property(x => x.TeamID).HasColumnName("Takım_ID");
            modelBuilder.Entity<Player>().Property(x => x.Status).HasColumnName("Durum");
            modelBuilder.Entity<Player>().Property(x => x.InsertedDate).HasColumnName("Eklenme_Tarihi");
            modelBuilder.Entity<Player>().Property(x => x.DeletedDate).HasColumnName("Silinme_Tarihi");
            modelBuilder.Entity<Player>().Property(x => x.UpdatedDate).HasColumnName("Güncelleme_Tarihi");
            //Founder
            modelBuilder.Entity<Founder>().ToTable("Kurucu");
            modelBuilder.Entity<Founder>().Property(x => x.Name).HasColumnName("İsim");
            modelBuilder.Entity<Founder>().Property(x => x.TeamID).HasColumnName("Takım_ID");
            modelBuilder.Entity<Founder>().Property(x => x.Status).HasColumnName("Durum");
            modelBuilder.Entity<Founder>().Property(x => x.InsertedDate).HasColumnName("Eklenme_Tarihi");
            modelBuilder.Entity<Founder>().Property(x => x.DeletedDate).HasColumnName("Silinme_Tarihi");
            modelBuilder.Entity<Founder>().Property(x => x.UpdatedDate).HasColumnName("Güncelleme_Tarihi");


            #endregion
            #region Relation Design
            //1 to 1
            modelBuilder.Entity<Team>().HasOptional(x => x.Founder).WithRequired(x => x.Team);
            modelBuilder.Entity<Team>().HasOptional(x => x.Coach).WithRequired(x => x.Team);
            #endregion
        }
    }
}
