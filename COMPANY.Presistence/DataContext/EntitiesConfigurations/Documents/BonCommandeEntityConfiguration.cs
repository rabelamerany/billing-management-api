﻿namespace COMPANY.Presistence.DataContext.EntitiesConfigurations.Documents
{
    using COMPANY.Domain.Entities;
    using COMPANY.Domain.Entities.Documents;
    using COMPANY.Domain.Entities.OwnedEntities;
    using COMPANY.Helpers;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System.Collections.Generic;

    public class BonCommandeEntityConfiguration : IEntityTypeConfiguration<BonCommande>
    {
        public void Configure(EntityTypeBuilder<BonCommande> builder)
        {
            // properties
            builder.Property(e => e.SiteIntervention)
                .HasConversion(
                    e => e.ToJson(false, false),
                    e => e.FromJson<Address>()
                )
                .HasColumnType("LONGTEXT");

            builder.Property(e => e.Articles)
                .HasConversion(
                    e => e.ToJson(false, false),
                    e => e.FromJson<ICollection<Article>>()
                )
                .HasColumnType("LONGTEXT");

            builder.Property(e => e.Signe)
                .HasColumnType("LONGTEXT");

            builder.Property(e => e.Note)
                .HasColumnType("LONGTEXT");

            builder.Property(e => e.Historique)
                .HasConversion(
                    e => e.ToJson(false, false),
                    e => e.FromJson<ICollection<ChangesHistory>>()
                )
                .HasColumnType("LONGTEXT");

            builder.Property(e => e.Emails)
                .HasConversion(
                    e => e.ToJson(false, false),
                    e => e.FromJson<ICollection<MailHistoryModel>>()
                )
                .HasColumnType("LONGTEXT");

            // relationships
            builder
                .HasOne(e => e.Agence)
                .WithMany(e => e.BonsCommandes)
                .HasForeignKey(e => e.AgenceId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(e => e.Client)
                .WithMany(e => e.BonsCommandes)
                .HasForeignKey(e => e.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(e => e.Dossier)
                .WithMany(e => e.BonsCommandes)
                .HasForeignKey(e => e.DossierId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(e => e.User)
                .WithMany(e => e.BonsCommandes)
                .HasForeignKey(e => e.UserId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(e => e.Devis)
                .WithMany(e => e.BonsCommandes)
                .HasForeignKey(e => e.DevisId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
