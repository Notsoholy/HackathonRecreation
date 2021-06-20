﻿// <auto-generated />
using System;
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(RecreationDbContext))]
    [Migration("20210619095914_TryFixOwnsOne")]
    partial class TryFixOwnsOne
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("recreation_service")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("AdditionalServiceRecreationObject", b =>
                {
                    b.Property<Guid>("AdditionalServicesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RecreationObjectsId")
                        .HasColumnType("uuid");

                    b.HasKey("AdditionalServicesId", "RecreationObjectsId");

                    b.HasIndex("RecreationObjectsId");

                    b.ToTable("AdditionalServiceRecreationObject");
                });

            modelBuilder.Entity("DiseaseRecreationObject", b =>
                {
                    b.Property<Guid>("DiseasesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RecreationObjectsId")
                        .HasColumnType("uuid");

                    b.HasKey("DiseasesId", "RecreationObjectsId");

                    b.HasIndex("RecreationObjectsId");

                    b.ToTable("DiseaseRecreationObject");
                });

            modelBuilder.Entity("Domain.Entities.AdditionalService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AdditionalServices");
                });

            modelBuilder.Entity("Domain.Entities.Disease", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Diseases");
                });

            modelBuilder.Entity("Domain.Entities.HealingMethod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("HealingMethods");
                });

            modelBuilder.Entity("Domain.Entities.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Domain.Entities.RecreationObject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<Guid?>("LocationId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Stars")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("RecreationObjects");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("UserUid")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.UserMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("MessageText")
                        .HasColumnType("text");

                    b.Property<string>("RecreationEmail")
                        .HasColumnType("text");

                    b.Property<Guid?>("RecreationObjectId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RecreationObjectId");

                    b.HasIndex("UserId");

                    b.ToTable("UserMessages");
                });

            modelBuilder.Entity("HealingMethodRecreationObject", b =>
                {
                    b.Property<Guid>("HealingMethodsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RecreationObjectsId")
                        .HasColumnType("uuid");

                    b.HasKey("HealingMethodsId", "RecreationObjectsId");

                    b.HasIndex("RecreationObjectsId");

                    b.ToTable("HealingMethodRecreationObject");
                });

            modelBuilder.Entity("AdditionalServiceRecreationObject", b =>
                {
                    b.HasOne("Domain.Entities.AdditionalService", null)
                        .WithMany()
                        .HasForeignKey("AdditionalServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.RecreationObject", null)
                        .WithMany()
                        .HasForeignKey("RecreationObjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DiseaseRecreationObject", b =>
                {
                    b.HasOne("Domain.Entities.Disease", null)
                        .WithMany()
                        .HasForeignKey("DiseasesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.RecreationObject", null)
                        .WithMany()
                        .HasForeignKey("RecreationObjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.RecreationObject", b =>
                {
                    b.HasOne("Domain.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.OwnsOne("Domain.Entities.Contacts", "Contacts", b1 =>
                        {
                            b1.Property<Guid>("RecreationObjectId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Address")
                                .HasColumnType("text");

                            b1.Property<string>("Email")
                                .HasColumnType("text");

                            b1.Property<string>("Phone")
                                .HasColumnType("text");

                            b1.Property<string>("Website")
                                .HasColumnType("text");

                            b1.HasKey("RecreationObjectId");

                            b1.ToTable("RecreationObjects");

                            b1.WithOwner()
                                .HasForeignKey("RecreationObjectId");
                        });

                    b.Navigation("Contacts");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Domain.Entities.UserMessage", b =>
                {
                    b.HasOne("Domain.Entities.RecreationObject", null)
                        .WithMany("UserMessages")
                        .HasForeignKey("RecreationObjectId");

                    b.HasOne("Domain.Entities.User", null)
                        .WithMany("UserMessages")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("HealingMethodRecreationObject", b =>
                {
                    b.HasOne("Domain.Entities.HealingMethod", null)
                        .WithMany()
                        .HasForeignKey("HealingMethodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.RecreationObject", null)
                        .WithMany()
                        .HasForeignKey("RecreationObjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.RecreationObject", b =>
                {
                    b.Navigation("UserMessages");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("UserMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
