using IIT.Glid.Gestion_Formation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIT.Glid.Gestion_Formation.Data
{
    public class MyContext: DbContext
    {
       
        public DbSet<Etudiant> Etudiant { get; set; }
        public DbSet<Formateur> Formateur { get; set; }
        public DbSet<Formation> Formation { get; set; }
        public IConfiguration Configuration { get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("data source =C:\\Users\\Lenovo\\source\\repos\\IIT.Glid3.GestionFormation\\IIT.Glid.Gestion_Formation.Web.Api\\db\\TrainingManagement.db");
    protected override void OnModelCreating(ModelBuilder modelBuilder )
        {
            
            modelBuilder.Entity<Etudiant>().HasData(new Etudiant
            {
                ID = 1,
                Nom = "ali",
                Prenom = "aydi",
                Telephone = "112233",
                //DateInscription= 0001-01-01T00:00:00,
                Payement = true
            });
        }
    }
}
