﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BestPrinterBilling.Models;

namespace BestPrinterBilling.Data
{
    public partial class bestprinterbillingdbContext : DbContext
    {
        public bestprinterbillingdbContext()
        {
        }

        public bestprinterbillingdbContext(DbContextOptions<bestprinterbillingdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblMachine> TblMachine { get; set; }
        public virtual DbSet<TblUsers> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:bestprinterbilling-srv.database.windows.net,1433;Initial Catalog=bestprinterbilling-db;Persist Security Info=False;User ID=bpb-admin;Password=Dy6zjFS_bUHwwE!fAb5Fn*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblMachine>(entity =>
            {
                entity.HasKey(e => e.MachineId)
                    .HasName("PK__tblMACHI__DE783B9974160401");

                entity.ToTable("tblMACHINE");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CollectionMethod)
                    .IsRequired()
                    .HasColumnName("COLLECTION_METHOD");

                entity.Property(e => e.ContractEnd)
                    .HasColumnName("CONTRACT_END")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContractStart)
                    .HasColumnName("CONTRACT_START")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CurInvoiceId)
                    .IsRequired()
                    .HasColumnName("CUR_INVOICE_ID");

                entity.Property(e => e.CurInvoiceTotal).HasColumnName("CUR_INVOICE_TOTAL");

                entity.Property(e => e.CurRdsBw).HasColumnName("CUR_RDS_BW");

                entity.Property(e => e.CurRdsClr).HasColumnName("CUR_RDS_CLR");

                entity.Property(e => e.CurRdsClrlrg).HasColumnName("CUR_RDS_CLRLRG");

                entity.Property(e => e.Devicemodel)
                    .IsRequired()
                    .HasColumnName("DEVICEMODEL");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("('TRUE')");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("LOCATION");

                entity.Property(e => e.MinCharge)
                    .IsRequired()
                    .HasColumnName("MIN_CHARGE");

                entity.Property(e => e.PrevInvoiceId)
                    .IsRequired()
                    .HasColumnName("PREV_INVOICE_ID");

                entity.Property(e => e.PrevInvoiceTotal).HasColumnName("PREV_INVOICE_TOTAL");

                entity.Property(e => e.PrevRdsBw).HasColumnName("PREV_RDS_BW");

                entity.Property(e => e.PrevRdsClr).HasColumnName("PREV_RDS_CLR");

                entity.Property(e => e.PrevRdsClrlrg).HasColumnName("PREV_RDS_CLRLRG");

                entity.Property(e => e.PriceBw).HasColumnName("PRICE_BW");

                entity.Property(e => e.PriceClr).HasColumnName("PRICE_CLR");

                entity.Property(e => e.PriceClrlrg).HasColumnName("PRICE_CLRLRG");

                entity.Property(e => e.QtyBw).HasColumnName("QTY_BW");

                entity.Property(e => e.QtyClr).HasColumnName("QTY_CLR");

                entity.Property(e => e.QtyClrlrg).HasColumnName("QTY_CLRLRG");

                entity.Property(e => e.Serialnum).HasColumnName("SERIALNUM");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");
            });

            modelBuilder.Entity<TblUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblUSERS__F3BEEBFF9AF1F5C3");

                entity.ToTable("tblUSERS");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("COMPANY");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasColumnName("CONTACT NAME");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Isadmin)
                    .IsRequired()
                    .HasColumnName("ISADMIN")
                    .HasDefaultValueSql("('FALSE')");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("PHONE");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("USERNAME");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}