﻿// <auto-generated />
using System;
using ColonyManager.EfMigrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ColonyManager.EfMigrations.Migrations
{
    [DbContext(typeof(MigrationDbContext))]
    [Migration("20210301200633_Add_People_Table")]
    partial class Add_People_Table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ColonyManager.Data.Entities.Account", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<bool>("AcceptTerms")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PasswordReset")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResetToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ResetTokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Verified")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.ConfigGenericGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Comment")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedUserName")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("RelatedSubject")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("ConfigGenericGroups");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.ConfigGenericItem", b =>
                {
                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Comment")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedUserName")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("GroupId", "Id");

                    b.ToTable("ConfigGenericItems");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.ConfigGenericItemExtension", b =>
                {
                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Comment")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedUserName")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("SystemDataTypeId")
                        .HasColumnType("int");

                    b.HasKey("GroupId", "ItemId", "Id");

                    b.HasIndex("SystemDataTypeId");

                    b.ToTable("ConfigGenericItemExtentions");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.ConfigGenericItemExtensionValue", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("ExtentionId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedUserName")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("ItemId", "GroupId", "ExtentionId", "Id");

                    b.HasIndex("ExtentionId", "GroupId", "ItemId");

                    b.ToTable("ConfigGenericItemExtentionValues");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.People", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comment")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<int?>("ConfigGenericGenderGroupId")
                        .HasColumnType("int");

                    b.Property<int?>("ConfigGenericGenderId")
                        .HasColumnType("int");

                    b.Property<int?>("ConfigGenericProfessionGroupId")
                        .HasColumnType("int");

                    b.Property<int?>("ConfigGenericProfessionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("LastName")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedUserName")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("ConfigGenericGenderGroupId", "ConfigGenericGenderId")
                        .IsUnique()
                        .HasFilter("[ConfigGenericGenderGroupId] IS NOT NULL AND [ConfigGenericGenderId] IS NOT NULL");

                    b.HasIndex("ConfigGenericProfessionGroupId", "ConfigGenericProfessionId")
                        .IsUnique()
                        .HasFilter("[ConfigGenericProfessionGroupId] IS NOT NULL AND [ConfigGenericProfessionId] IS NOT NULL");

                    b.ToTable("Peoples");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.RefreshToken", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("AccountId")
                        .HasColumnType("bigint");

                    b.Property<string>("CreatedByIpv4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedByIpv6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReplacedByToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime2");

                    b.Property<string>("RevokedByIpv4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RevokedByIpv6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("RefreshToken");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.SystemDataType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Comment")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<bool>("IsList")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedUserName")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("SystemDataTypes");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.ConfigGenericItem", b =>
                {
                    b.HasOne("ColonyManager.Data.Entities.ConfigGenericGroup", "ConfigGenericGroup")
                        .WithMany("ConfigGenericItems")
                        .HasForeignKey("GroupId")
                        .HasConstraintName("FK_ConfigGenericItems_ConfigGenericGroups")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ConfigGenericGroup");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.ConfigGenericItemExtension", b =>
                {
                    b.HasOne("ColonyManager.Data.Entities.SystemDataType", "SystemDataType")
                        .WithMany("ConfigGenericItemExtensions")
                        .HasForeignKey("SystemDataTypeId")
                        .HasConstraintName("FK_ConfigGenericItemExtentions_SystemDataTypes")
                        .IsRequired();

                    b.HasOne("ColonyManager.Data.Entities.ConfigGenericItem", "ConfigGenericItem")
                        .WithMany("ConfigGenericItemExtensions")
                        .HasForeignKey("GroupId", "ItemId")
                        .HasConstraintName("FK_ConfigGenericItemExtentions_ConfigGenericItems")
                        .IsRequired();

                    b.Navigation("ConfigGenericItem");

                    b.Navigation("SystemDataType");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.ConfigGenericItemExtensionValue", b =>
                {
                    b.HasOne("ColonyManager.Data.Entities.ConfigGenericItemExtension", "ConfigGenericItemExtension")
                        .WithMany("ConfigGenericItemExtensionValues")
                        .HasForeignKey("ExtentionId", "GroupId", "ItemId")
                        .HasConstraintName("FK_ConfigGenericItemExtentionValues_ConfigGenericItemExtentions")
                        .IsRequired();

                    b.Navigation("ConfigGenericItemExtension");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.People", b =>
                {
                    b.HasOne("ColonyManager.Data.Entities.ConfigGenericItem", "Gender")
                        .WithOne("PeopleGender")
                        .HasForeignKey("ColonyManager.Data.Entities.People", "ConfigGenericGenderGroupId", "ConfigGenericGenderId")
                        .HasConstraintName("FK_People_ConfigGenericItem_Gender");

                    b.HasOne("ColonyManager.Data.Entities.ConfigGenericItem", "Profession")
                        .WithOne("PeopleProfession")
                        .HasForeignKey("ColonyManager.Data.Entities.People", "ConfigGenericProfessionGroupId", "ConfigGenericProfessionId")
                        .HasConstraintName("FK_People_ConfigGenericItem_Profession");

                    b.Navigation("Gender");

                    b.Navigation("Profession");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.RefreshToken", b =>
                {
                    b.HasOne("ColonyManager.Data.Entities.Account", "Account")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("AccountId");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.Account", b =>
                {
                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.ConfigGenericGroup", b =>
                {
                    b.Navigation("ConfigGenericItems");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.ConfigGenericItem", b =>
                {
                    b.Navigation("ConfigGenericItemExtensions");

                    b.Navigation("PeopleGender");

                    b.Navigation("PeopleProfession");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.ConfigGenericItemExtension", b =>
                {
                    b.Navigation("ConfigGenericItemExtensionValues");
                });

            modelBuilder.Entity("ColonyManager.Data.Entities.SystemDataType", b =>
                {
                    b.Navigation("ConfigGenericItemExtensions");
                });
#pragma warning restore 612, 618
        }
    }
}