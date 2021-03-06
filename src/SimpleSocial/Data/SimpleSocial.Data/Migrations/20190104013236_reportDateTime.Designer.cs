﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleSocial.Data;

namespace SimpleSocial.Data.Migrations
{
    [DbContext(typeof(SimpleSocialContext))]
    [Migration("20190104013236_reportDateTime")]
    partial class reportDateTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SimpleSocial.Data.Models.Comment", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorId");

                    b.Property<string>("CommentText");

                    b.Property<string>("PostId");

                    b.Property<DateTime>("PostedOn");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("SimpleSocial.Data.Models.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PageAdminId");

                    b.HasKey("Id");

                    b.HasIndex("PageAdminId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("SimpleSocial.Data.Models.Post", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("PageId");

                    b.Property<string>("Title");

                    b.Property<string>("UserId");

                    b.Property<string>("WallId");

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.HasIndex("UserId");

                    b.HasIndex("WallId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("SimpleSocial.Data.Models.PostReport", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorId");

                    b.Property<string>("PostId");

                    b.Property<int>("ReportReason");

                    b.Property<DateTime>("ReportedOn");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PostId");

                    b.ToTable("PostReports");
                });

            modelBuilder.Entity("SimpleSocial.Data.Models.ProfilePicture", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FileName");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("ProfilePictures");
                });

            modelBuilder.Entity("SimpleSocial.Data.Models.SimpleSocialUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<DateTime?>("BirthDay");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Country");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<int?>("Gender");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfilePictureId");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("WallId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("ProfilePictureId")
                        .IsUnique()
                        .HasFilter("[ProfilePictureId] IS NOT NULL");

                    b.HasIndex("WallId")
                        .IsUnique()
                        .HasFilter("[WallId] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SimpleSocial.Data.Models.UserFollower", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("FollowerId");

                    b.Property<DateTime?>("FollowedDate");

                    b.Property<DateTime?>("UnfollowedDate");

                    b.HasKey("UserId", "FollowerId");

                    b.HasIndex("FollowerId");

                    b.ToTable("UserFollowers");
                });

            modelBuilder.Entity("SimpleSocial.Data.Models.UserLike", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("PostId");

                    b.Property<DateTime>("LikedOn");

                    b.HasKey("UserId", "PostId");

                    b.HasIndex("PostId");

                    b.ToTable("UserLikes");
                });

            modelBuilder.Entity("SimpleSocial.Data.Models.Wall", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Walls");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SimpleSocial.Data.Models.SimpleSocialUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SimpleSocial.Data.Models.SimpleSocialUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleSocial.Data.Models.SimpleSocialUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SimpleSocial.Data.Models.SimpleSocialUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleSocial.Data.Models.Comment", b =>
                {
                    b.HasOne("SimpleSocial.Data.Models.SimpleSocialUser", "Author")
                        .WithMany("Comments")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SimpleSocial.Data.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("SimpleSocial.Data.Models.Page", b =>
                {
                    b.HasOne("SimpleSocial.Data.Models.SimpleSocialUser", "PageAdmin")
                        .WithMany("UserPages")
                        .HasForeignKey("PageAdminId");
                });

            modelBuilder.Entity("SimpleSocial.Data.Models.Post", b =>
                {
                    b.HasOne("SimpleSocial.Data.Models.Page")
                        .WithMany("Posts")
                        .HasForeignKey("PageId");

                    b.HasOne("SimpleSocial.Data.Models.SimpleSocialUser", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId");

                    b.HasOne("SimpleSocial.Data.Models.Wall", "Wall")
                        .WithMany("Posts")
                        .HasForeignKey("WallId");
                });

            modelBuilder.Entity("SimpleSocial.Data.Models.PostReport", b =>
                {
                    b.HasOne("SimpleSocial.Data.Models.SimpleSocialUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("SimpleSocial.Data.Models.Post", "Post")
                        .WithMany("PostReports")
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("SimpleSocial.Data.Models.SimpleSocialUser", b =>
                {
                    b.HasOne("SimpleSocial.Data.Models.ProfilePicture", "ProfilePicture")
                        .WithOne("User")
                        .HasForeignKey("SimpleSocial.Data.Models.SimpleSocialUser", "ProfilePictureId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("SimpleSocial.Data.Models.Wall", "Wall")
                        .WithOne("User")
                        .HasForeignKey("SimpleSocial.Data.Models.SimpleSocialUser", "WallId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SimpleSocial.Data.Models.UserFollower", b =>
                {
                    b.HasOne("SimpleSocial.Data.Models.SimpleSocialUser", "Follower")
                        .WithMany()
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SimpleSocial.Data.Models.SimpleSocialUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SimpleSocial.Data.Models.UserLike", b =>
                {
                    b.HasOne("SimpleSocial.Data.Models.Post", "Post")
                        .WithMany("Likes")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleSocial.Data.Models.SimpleSocialUser", "User")
                        .WithMany("Likes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
