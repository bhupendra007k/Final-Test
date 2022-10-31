﻿// <auto-generated />
using System;
using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccessLayer.Models.ReimbursementModel", b =>
                {
                    b.Property<Guid>("ReimbursementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("ApprovedValue")
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReceiptUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReimbursementType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestPhase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequestedValue")
                        .HasColumnType("int");

                    b.Property<Guid>("UserModelId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ReimbursementId");

                    b.HasIndex("UserModelId");

                    b.ToTable("Reimbursements");
                });

            modelBuilder.Entity("DataAccessLayer.Models.UserModel", b =>
                {
                    b.Property<Guid>("UserModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BankAccountNo")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PAN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("UserModelId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataAccessLayer.Models.ReimbursementModel", b =>
                {
                    b.HasOne("DataAccessLayer.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}