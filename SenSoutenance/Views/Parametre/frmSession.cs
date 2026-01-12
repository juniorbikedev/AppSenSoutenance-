using SenSoutenance.Models;
using SenSoutenance.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenSoutenance.Views.Parametre
{
    public partial class frmSession : Form
    {
        public frmSession()
        {
            InitializeComponent();
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        FillerList filler = new FillerList();  

        private void frmSession_Load(object sender, EventArgs e)
        {
            Effacer();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Session session = new Session
            {
                LibelleSession = txtSession.Text,
                IdAnneeAcademique = int.Parse(cbAnneeAcademique.SelectedValue.ToString()) 
            };
            db.Sessions.Add(session);
            db.SaveChanges();
            Effacer();
        }
        private void Effacer()
        {
            txtSession.Clear();
            cbAnneeAcademique.SelectedIndex = -1;
            dgSession.DataSource = db.Sessions.ToList();
            cbAnneeAcademique.DataSource = filler.fillAnneeAcademique();
            cbAnneeAcademique.DisplayMember = "Text";
            cbAnneeAcademique.ValueMember = "Value";
            txtSession.Focus();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.Sessions.Find(id);
            txtSession.Text = session.LibelleSession;
            cbAnneeAcademique.SelectedValue = session.IdAnneeAcademique;
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.Sessions.Find(id);
            session.LibelleSession = txtSession.Text;
            session.IdAnneeAcademique = (int?)cbAnneeAcademique.SelectedValue;
            db.SaveChanges();
            Effacer();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.Sessions.Find(id);
            db.Sessions.Remove(session);
            db.SaveChanges();
            Effacer();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var liste = db.Sessions.ToList();

            if (!string.IsNullOrEmpty(txtRSession.Text))
            {
                liste = liste.Where(s => s.LibelleSession.Contains(txtRSession.Text)).ToList();
            }

            if(txtRanneeAcademique.Text!="")
            {
                liste = liste.Where(s => s.AnneeAcademique.LibelleAnneeAcademique.Contains(txtRanneeAcademique.Text)).ToList();
            }

            dgSession.DataSource = liste;
        }
    }
}
