﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using OSharp;
using OSharp.Demo.Web;
using System;

namespace OSharp.Demo.Web.Migrations.MySqlDefaultDb
{
    [DbContext(typeof(MySqlDefaultDbContext))]
    partial class MySqlDefaultDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("OSharp.Demo.Identity.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsLocked");

                    b.Property<bool>("IsSystem");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("NormalizedName")
                        .IsRequired();

                    b.Property<string>("Remark")
                        .HasMaxLength(512);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("OSharp.Demo.Identity.Entities.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("OSharp.Demo.Identity.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizeEmail")
                        .IsRequired();

                    b.Property<string>("NormalizedUserName")
                        .IsRequired();

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("NormalizeEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("User");
                });

            modelBuilder.Entity("OSharp.Demo.Identity.Entities.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType")
                        .IsRequired();

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("OSharp.Demo.Identity.Entities.UserDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserDetail");
                });

            modelBuilder.Entity("OSharp.Demo.Identity.Entities.UserLogin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("ProviderKey");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("LoginProvider", "ProviderKey")
                        .IsUnique()
                        .HasName("UserLoginIndex");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("OSharp.Demo.Identity.Entities.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId", "RoleId")
                        .IsUnique()
                        .HasName("UserRoleIndex");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("OSharp.Demo.Identity.Entities.UserToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<int>("UserId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("UserId", "LoginProvider", "Name")
                        .IsUnique()
                        .HasName("UserTokenIndex");

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("OSharp.Infrastructure.EntityInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassFullName")
                        .IsRequired();

                    b.Property<bool>("DataLogEnabled");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PropertyNamesJson");

                    b.HasKey("Id");

                    b.HasIndex("ClassFullName")
                        .IsUnique()
                        .HasName("ClassFullNameIndex");

                    b.ToTable("EntityInfo");
                });

            modelBuilder.Entity("OSharp.Infrastructure.Function", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessType");

                    b.Property<string>("Action");

                    b.Property<string>("Area");

                    b.Property<int>("CacheExpirationSeconds");

                    b.Property<string>("Controller");

                    b.Property<bool>("DataLogEnabled");

                    b.Property<bool>("IsAccessTypeChanged");

                    b.Property<bool>("IsAjax");

                    b.Property<bool>("IsCacheSliding");

                    b.Property<bool>("IsController");

                    b.Property<bool>("IsLocked");

                    b.Property<string>("Name");

                    b.Property<bool>("OperateLogEnabled");

                    b.HasKey("Id");

                    b.HasIndex("Area", "Controller", "Action")
                        .IsUnique()
                        .HasName("AreaControllerActionIndex");

                    b.ToTable("Function");
                });

            modelBuilder.Entity("OSharp.Demo.Identity.Entities.RoleClaim", b =>
                {
                    b.HasOne("OSharp.Demo.Identity.Entities.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OSharp.Demo.Identity.Entities.UserClaim", b =>
                {
                    b.HasOne("OSharp.Demo.Identity.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OSharp.Demo.Identity.Entities.UserDetail", b =>
                {
                    b.HasOne("OSharp.Demo.Identity.Entities.User")
                        .WithOne()
                        .HasForeignKey("OSharp.Demo.Identity.Entities.UserDetail", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OSharp.Demo.Identity.Entities.UserLogin", b =>
                {
                    b.HasOne("OSharp.Demo.Identity.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OSharp.Demo.Identity.Entities.UserRole", b =>
                {
                    b.HasOne("OSharp.Demo.Identity.Entities.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OSharp.Demo.Identity.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OSharp.Demo.Identity.Entities.UserToken", b =>
                {
                    b.HasOne("OSharp.Demo.Identity.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
