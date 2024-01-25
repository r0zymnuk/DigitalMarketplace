﻿// <auto-generated />
using System;
using System.Collections.Generic;
using DigitalMarketplace.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DigitalMarketplace.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240125150428_UpdatedAt")]
    partial class UpdatedAt
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DigitalMarketplace.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("ParentId");

                    b.HasIndex("UserId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DigitalMarketplace.Core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AdStatus")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.ComplexProperty<Dictionary<string, object>>("Currency", "DigitalMarketplace.Core.Models.Product.Currency#Currency", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Code")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("CurrencySymbol")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("HtmlCode")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("text");
                        });

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DigitalMarketplace.Core.Models.Tag", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Name");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("DigitalMarketplace.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Balance")
                        .HasColumnType("numeric");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2024, 1, 25, 15, 4, 27, 560, DateTimeKind.Utc).AddTicks(1556));

                    b.Property<string>("CurrencyName")
                        .IsRequired()
                        .HasColumnType("character varying(25)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.Property<string>("Gender")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("ImageUri")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2024, 1, 25, 15, 4, 27, 560, DateTimeKind.Utc).AddTicks(2015));

                    b.Property<string>("Username")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)")
                        .HasDefaultValueSql("[FirstName] + '-' + [LastName] + '-' + [Id]");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyName");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DigitalMarketplace.Core.ValueObjects.Currency", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<string>("CurrencySymbol")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("HtmlCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("Name");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("DigitalMarketplace.Core.Models.Category", b =>
                {
                    b.HasOne("DigitalMarketplace.Core.Models.Category", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.HasOne("DigitalMarketplace.Core.Models.User", null)
                        .WithMany("Categories")
                        .HasForeignKey("UserId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("DigitalMarketplace.Core.Models.Product", b =>
                {
                    b.HasOne("DigitalMarketplace.Core.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigitalMarketplace.Core.Models.User", "Owner")
                        .WithMany("Products")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("DigitalMarketplace.Core.Models.Tag", b =>
                {
                    b.HasOne("DigitalMarketplace.Core.Models.Product", null)
                        .WithMany("Tags")
                        .HasForeignKey("ProductId");

                    b.HasOne("DigitalMarketplace.Core.Models.User", null)
                        .WithMany("Tags")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DigitalMarketplace.Core.Models.User", b =>
                {
                    b.HasOne("DigitalMarketplace.Core.ValueObjects.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsMany("DigitalMarketplace.Core.ValueObjects.ExternalResource", "ExternalResources", b1 =>
                        {
                            b1.Property<int>("UserId")
                                .HasColumnType("integer");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("Uri")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("UserId", "Id");

                            b1.ToTable("ExternalResource");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsMany("DigitalMarketplace.Core.ValueObjects.Language", "Languages", b1 =>
                        {
                            b1.Property<int>("UserId")
                                .HasColumnType("integer");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<int>("Level")
                                .HasColumnType("integer");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("UserId", "Id");

                            b1.ToTable("Language");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("DigitalMarketplace.Core.ValueObjects.Location", "Location", b1 =>
                        {
                            b1.Property<int>("UserId")
                                .HasColumnType("integer");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("Currency");

                    b.Navigation("ExternalResources");

                    b.Navigation("Languages");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("DigitalMarketplace.Core.Models.Category", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("DigitalMarketplace.Core.Models.Product", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("DigitalMarketplace.Core.Models.User", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Products");

                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
