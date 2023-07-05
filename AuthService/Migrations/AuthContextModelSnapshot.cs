﻿// <auto-generated />
using System;
using AuthService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AuthService.Migrations
{
    [DbContext(typeof(AuthContext))]
    partial class AuthContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("AuthService.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BossId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("AuthService.Models.GroupHoldMapper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("GroupId")
                        .HasColumnType("integer");

                    b.Property<int?>("HoldId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("HoldId");

                    b.ToTable("GroupHoldMappers");
                });

            modelBuilder.Entity("AuthService.Models.Hold", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("DestId")
                        .HasColumnType("integer");

                    b.Property<int?>("TypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Holds");
                });

            modelBuilder.Entity("AuthService.Models.Right", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Rights");
                });

            modelBuilder.Entity("AuthService.Models.RightHoldMapper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("HoldId")
                        .HasColumnType("integer");

                    b.Property<int?>("RightId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("HoldId");

                    b.HasIndex("RightId");

                    b.ToTable("RightHoldMappers");
                });

            modelBuilder.Entity("AuthService.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AuthService.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("AuthService.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LongName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AuthService.Models.UserGroupMapper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("GroupId")
                        .HasColumnType("integer");

                    b.Property<bool?>("IsBoss")
                        .HasColumnType("boolean");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("UserGroupMappers");
                });

            modelBuilder.Entity("AuthService.Models.UserHoldMapper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("HoldId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("HoldId");

                    b.HasIndex("UserId");

                    b.ToTable("UserHoldMappers");
                });

            modelBuilder.Entity("AuthService.Models.UserRoleMapper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoleMappers");
                });

            modelBuilder.Entity("AuthService.Models.GroupHoldMapper", b =>
                {
                    b.HasOne("AuthService.Models.Group", "Group")
                        .WithMany("GroupHolds")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("AuthService.Models.Hold", "Hold")
                        .WithMany("GroupHolds")
                        .HasForeignKey("HoldId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Group");

                    b.Navigation("Hold");
                });

            modelBuilder.Entity("AuthService.Models.Hold", b =>
                {
                    b.HasOne("AuthService.Models.Type", "Type")
                        .WithMany("Holds")
                        .HasForeignKey("TypeId");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("AuthService.Models.RightHoldMapper", b =>
                {
                    b.HasOne("AuthService.Models.Hold", "Hold")
                        .WithMany("RightHolds")
                        .HasForeignKey("HoldId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("AuthService.Models.Right", "Right")
                        .WithMany("RightHolds")
                        .HasForeignKey("RightId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Hold");

                    b.Navigation("Right");
                });

            modelBuilder.Entity("AuthService.Models.UserGroupMapper", b =>
                {
                    b.HasOne("AuthService.Models.Group", "Group")
                        .WithMany("UserGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("AuthService.Models.User", "User")
                        .WithMany("UserGroups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AuthService.Models.UserHoldMapper", b =>
                {
                    b.HasOne("AuthService.Models.Hold", "Hold")
                        .WithMany("UserHolds")
                        .HasForeignKey("HoldId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("AuthService.Models.User", "User")
                        .WithMany("UserHolds")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Hold");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AuthService.Models.UserRoleMapper", b =>
                {
                    b.HasOne("AuthService.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("AuthService.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AuthService.Models.Group", b =>
                {
                    b.Navigation("GroupHolds");

                    b.Navigation("UserGroups");
                });

            modelBuilder.Entity("AuthService.Models.Hold", b =>
                {
                    b.Navigation("GroupHolds");

                    b.Navigation("RightHolds");

                    b.Navigation("UserHolds");
                });

            modelBuilder.Entity("AuthService.Models.Right", b =>
                {
                    b.Navigation("RightHolds");
                });

            modelBuilder.Entity("AuthService.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("AuthService.Models.Type", b =>
                {
                    b.Navigation("Holds");
                });

            modelBuilder.Entity("AuthService.Models.User", b =>
                {
                    b.Navigation("UserGroups");

                    b.Navigation("UserHolds");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
