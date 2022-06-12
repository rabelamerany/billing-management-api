﻿namespace COMPANY.Application.Models.BusinessEntities.Documents.Paiement
{
    using COMPANY.Domain.Enums;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// a class describe payment create model
    /// </summary>
    public class PaiementCreateModel
    {
        /// <summary>
        /// the type of payment
        /// </summary>
        public PaiementType Type { get; set; }

        /// <summary>
        /// the amount of payment
        /// </summary>
        public decimal Montant { get; set; }

        /// <summary>
        /// the date of payment
        /// </summary>
        public DateTime DatePaiement { get; set; }

        /// <summary>
        /// the description of payment
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the id of bank account associate with this payment
        /// </summary>
        public string BankAccountId { get; set; }

        /// <summary>
        /// the id of regulation mode associate with this payment 
        /// </summary>
        public string RegulationModeId { get; set; }

        /// <summary>
        /// the id of avoir associate with this payment 
        /// </summary>
        public string AvoirId { get; set; }

        /// <summary>
        /// the id of agence associate with this payment 
        /// </summary>
        public string AgenceId { get; set; }

        /// <summary>
        /// possiblity of create avoir with payment
        /// </summary>
        public bool CreateAvoir { get; set; }

        /// <summary>
        /// list of facture paiements
        /// </summary>
        public ICollection<FacturePaiementModel> FacturePaiements { get; set; }
    }
}
