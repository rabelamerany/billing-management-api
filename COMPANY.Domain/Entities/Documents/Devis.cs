﻿namespace COMPANY.Domain.Entities
{
    using COMPANY.Domain.Entities.Documents;
    using COMPANY.Domain.Entities.OwnedEntities;
    using COMPANY.Domain.Enums;
    using COMPANY.Domain.Interfaces;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// a class describe devis informations
    /// </summary>
    public class Devis : Entity<string>, IRecordable, IReferencable, IFollowAgence
    {
        public Devis()
        {
            Id = Common.Helpers.IdentityDocument.Generate("Devis");

            Articles = new HashSet<Article>();
            Historique = new HashSet<ChangesHistory>();
            Emails = new HashSet<MailHistoryModel>();
            BonsCommandes = new HashSet<BonCommande>();
        }

        /// <summary>
        /// the reference of devis
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// the site intervention of devis. 
        /// </summary>
        public Address SiteIntervention { get; set; }

        /// <summary>
        /// the visit date of devis
        /// </summary>
        public DateTime DateVisit { get; set; }

        /// <summary>
        /// the visit date prealabl of devis
        /// </summary>
        public DateTime? DateVisitePrealable { get; set; }

        /// <summary>
        /// the creation date of devis
        /// </summary>
        public DateTime DateCreation { get; set; }

        /// <summary>
        /// the articles of devis. 
        /// </summary>
        public ICollection<Article> Articles { get; set; }

        /// <summary>
        /// the status of devis
        /// </summary>
        public DevisStatus Status { get; set; }

        /// <summary>
        /// the type of devis
        /// </summary>
        public DevisType Type { get; set; }

        /// <summary>
        /// the total without tax of devis
        /// </summary>
        public decimal TotalHT { get; set; }

        /// <summary>
        /// the total TTC of devis
        /// </summary>
        public decimal TotalTTC { get; set; }

        /// <summary>
        /// the total without tax of devis
        /// </summary>
        public decimal TotalReduction { get; set; }

        /// <summary>
        /// the total paid of devis
        /// </summary>
        public decimal TotalPaid { get; set; }

        /// <summary>
        /// discount of accounting document
        /// </summary>
        public decimal Remise { get; set; }

        /// <summary>
        /// the type of discount <see cref="Enums.RemiseType"/>
        /// </summary>
        public RemiseType RemiseType { get; set; }

        /// <summary>
        /// the raison perdu of devis
        /// </summary>
        public string RaisonPerdue { get; set; }

        #region signature

        /// <summary>
        /// date of signature of devis
        /// </summary>
        public DateTime? DateSignature { get; set; }

        /// <summary>
        /// the signature image base64 of devis
        /// </summary>
        public string Signe { get; set; }

        /// <summary>
        /// the name of who sign devis
        /// </summary>
        public string NameClientSignature { get; set; }

        #endregion

        #region other

        /// <summary>
        /// the note of devis
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// the historique of devis. 
        /// </summary>
        public ICollection<ChangesHistory> Historique { get; set; }

        /// <summary>
        /// the list of emails sent of this devis.
        /// </summary>
        public ICollection<MailHistoryModel> Emails { get; set; }

        #endregion

        #region relationship

        /// <summary>
        /// the user id of devis
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// the technicien of devis
        /// </summary>
        public User User{ get; set; }

        /// <summary>
        /// the client id of devis
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// the client of devis
        /// </summary>
        public Client Client { get; set; }

        /// <summary>
        /// the dossier id of devis
        /// </summary>
        public string DossierId { get; set; }

        /// <summary>
        /// the dossier of devis
        /// </summary>
        public Dossier Dossier { get; set; }

        /// <summary>
        /// the id of agence
        /// </summary>
        public string AgenceId { get; set; }

        /// <summary>
        /// the agence who own this devis
        /// </summary>
        public Agence Agence { get; set; }

        /// <summary>
        /// the list of factures associate with this devis
        /// </summary>
        public ICollection<FactureDevis> Factures { get; set; }

        /// <summary>
        /// list of bons bons commande associate with this entity
        /// </summary>
        public ICollection<BonCommande> BonsCommandes { get; set; }

        #endregion

        public override void BuildSearchTerms()
            => SearchTerms = $"{Reference}";
    }
}
