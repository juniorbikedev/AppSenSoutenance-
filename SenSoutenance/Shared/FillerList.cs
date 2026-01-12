using SenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenSoutenance.Shared
{
    public class FillerList
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        /// <summary>
        /// Remplir la liste des années académiques
        /// </summary>
        /// <returns></returns>
        public List<ListItem> fillAnneeAcademique()
        {
            List<ListItem> laListe = new List<ListItem>();

            var liste = db.AnneeAcademiques.ToList();

            laListe.Add(new ListItem
            {
                Value = null,
                Text = "Selectionner"
            });

            foreach (var t in liste)
            {
                var item = new ListItem
                {
                    Value = t.IdAnneeAcademique.ToString(),
                    Text = t.LibelleAnneeAcademique.ToString()
                };

                laListe.Add(item);
            }

            return laListe;
        }
    }
}



