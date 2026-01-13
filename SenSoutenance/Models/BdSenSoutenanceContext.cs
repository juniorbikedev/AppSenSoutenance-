using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenSoutenance.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdSenSoutenanceContext : DbContext
    {
        public BdSenSoutenanceContext() : base("name=connBdSenSoutenance")
        {
            // Désactiver l'initialiseur pour éviter l'erreur de changement de modèle
            Database.SetInitializer<BdSenSoutenanceContext>(null);

            // Ou utiliser l'une de ces alternatives :
            // Database.SetInitializer(new CreateDatabaseIfNotExists<BdSenSoutenanceContext>());
            // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BdSenSoutenanceContext>());
        }

        public DbSet<AnneeAcademique> AnneeAcademiques { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Memoire> Memoires { get; set; }
        public DbSet<Soutenance> Soutenances { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Candidat> Candidats { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<ChefDepartement> ChefDepartements { get; set; }
        public DbSet<Admin> Admins { get; set; }

        // Supprimez cette propriété si elle n'est pas nécessaire
        // public object AnneeAcademiquesObj { get; internal set; }
    }
}