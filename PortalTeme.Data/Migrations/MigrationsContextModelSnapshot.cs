﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortalTeme.Data.Migrations;

namespace PortalTeme.Auth.Migrations
{
    [DbContext(typeof(MigrationsContext))]
    partial class MigrationsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            Id = "36f16a57-5b33-4bc3-99e8-51d61595ec2f",
                            ConcurrencyStamp = "cf3a5c72-0813-415b-879b-685eb7942e64",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ea74f168-a8e8-4267-a078-a1c2d6ef2251",
                            ConcurrencyStamp = "7706b80b-e1fc-4b06-870c-2a02a72b5684",
                            Name = "Professor",
                            NormalizedName = "PROFESSOR"
                        },
                        new
                        {
                            Id = "bd9d8efc-b46d-40e4-b0e2-5ce581d2bd0b",
                            ConcurrencyStamp = "1969f591-fd47-409f-867e-0d0fdec0c584",
                            Name = "Assistant",
                            NormalizedName = "ASSISTANT"
                        },
                        new
                        {
                            Id = "a42fcfeb-29d5-4f8e-9c31-a174b4388e02",
                            ConcurrencyStamp = "39b8570f-c1ba-4e7b-9c64-49c0d15bf96f",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        });
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

            modelBuilder.Entity("PortalTeme.Data.Application.ApplicationSetting", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value");

                    b.HasKey("Name");

                    b.ToTable("ApplicationSettings");
                });

            modelBuilder.Entity("PortalTeme.Data.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

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

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.AcademicYear", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("AcademicYears");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.Assignment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CourseId");

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("NumberOfDuplicates");

                    b.Property<string>("Slug");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.AssignmentEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AssignmentId");

                    b.Property<int?>("Grading");

                    b.Property<int>("State");

                    b.Property<string>("StudentUserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("StudentUserId");

                    b.ToTable("AssignmentEntries");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.AssignmentEntryFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AssignmentVersionId");

                    b.Property<string>("Description");

                    b.Property<int>("FileType");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AssignmentVersionId");

                    b.ToTable("AssignmentEntryFile");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.AssignmentEntryVersion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AssignmentEntryId");

                    b.Property<DateTime>("DateAdded");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentEntryId");

                    b.ToTable("AssignmentEntryVersion");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.AssignmentExtensionRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Approved");

                    b.Property<Guid>("AssignmentEntryId");

                    b.Property<DateTime>("DateApproved");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateExtended");

                    b.Property<string>("Reason")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AssignmentEntryId");

                    b.ToTable("AssignmentExtensionRequests");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.AssignmentVariant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AssignmentId");

                    b.Property<Guid>("AssignmentId1");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId1");

                    b.HasIndex("StudentId");

                    b.ToTable("AssignmentVariant");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CourseInfoId");

                    b.Property<string>("ProfessorId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CourseInfoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.CourseAssistant", b =>
                {
                    b.Property<Guid>("CourseId");

                    b.Property<string>("AssistantId");

                    b.HasKey("CourseId", "AssistantId");

                    b.HasIndex("AssistantId");

                    b.ToTable("CourseAssistant");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.CourseDefinition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Semester");

                    b.Property<string>("Slug");

                    b.Property<Guid>("YearId");

                    b.HasKey("Id");

                    b.HasIndex("YearId");

                    b.ToTable("CourseDefinitions");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.CourseGroup", b =>
                {
                    b.Property<Guid>("CourseId");

                    b.Property<Guid>("GroupId");

                    b.HasKey("CourseId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("CourseGroup");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.CourseStudent", b =>
                {
                    b.Property<Guid>("CourseId");

                    b.Property<string>("StudentId");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("DomainId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<Guid>("YearId");

                    b.HasKey("Id");

                    b.HasIndex("DomainId");

                    b.HasIndex("YearId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.StudentInfo", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<Guid>("GroupId");

                    b.Property<int>("Semester");

                    b.HasKey("UserId");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.StudyDomain", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("StudyDomains");
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
                    b.HasOne("PortalTeme.Data.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PortalTeme.Data.Identity.User")
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

                    b.HasOne("PortalTeme.Data.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PortalTeme.Data.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PortalTeme.Data.Models.Assignment", b =>
                {
                    b.HasOne("PortalTeme.Data.Models.Course", "Course")
                        .WithMany("Assignments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PortalTeme.Data.Models.AssignmentEntry", b =>
                {
                    b.HasOne("PortalTeme.Data.Models.Assignment", "Assignment")
                        .WithMany()
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PortalTeme.Data.Models.StudentInfo", "Student")
                        .WithMany()
                        .HasForeignKey("StudentUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PortalTeme.Data.Models.AssignmentEntryFile", b =>
                {
                    b.HasOne("PortalTeme.Data.Models.AssignmentEntryVersion", "AssignmentVersion")
                        .WithMany("Files")
                        .HasForeignKey("AssignmentVersionId");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.AssignmentEntryVersion", b =>
                {
                    b.HasOne("PortalTeme.Data.Models.AssignmentEntry", "AssignmentEntry")
                        .WithMany("Versions")
                        .HasForeignKey("AssignmentEntryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PortalTeme.Data.Models.AssignmentExtensionRequest", b =>
                {
                    b.HasOne("PortalTeme.Data.Models.AssignmentEntry", "AssignmentEntry")
                        .WithMany()
                        .HasForeignKey("AssignmentEntryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PortalTeme.Data.Models.AssignmentVariant", b =>
                {
                    b.HasOne("PortalTeme.Data.Models.Assignment", "Assignment")
                        .WithMany("AssignmentVariants")
                        .HasForeignKey("AssignmentId1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PortalTeme.Data.Identity.User", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("PortalTeme.Data.Models.Course", b =>
                {
                    b.HasOne("PortalTeme.Data.Models.CourseDefinition", "CourseInfo")
                        .WithMany()
                        .HasForeignKey("CourseInfoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PortalTeme.Data.Identity.User", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PortalTeme.Data.Models.CourseAssistant", b =>
                {
                    b.HasOne("PortalTeme.Data.Identity.User", "Assistant")
                        .WithMany()
                        .HasForeignKey("AssistantId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PortalTeme.Data.Models.Course", "Course")
                        .WithMany("Assistants")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PortalTeme.Data.Models.CourseDefinition", b =>
                {
                    b.HasOne("PortalTeme.Data.Models.AcademicYear", "Year")
                        .WithMany()
                        .HasForeignKey("YearId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PortalTeme.Data.Models.CourseGroup", b =>
                {
                    b.HasOne("PortalTeme.Data.Models.Course", "Course")
                        .WithMany("Groups")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortalTeme.Data.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PortalTeme.Data.Models.CourseStudent", b =>
                {
                    b.HasOne("PortalTeme.Data.Models.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PortalTeme.Data.Models.StudentInfo", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PortalTeme.Data.Models.Group", b =>
                {
                    b.HasOne("PortalTeme.Data.Models.StudyDomain", "Domain")
                        .WithMany()
                        .HasForeignKey("DomainId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PortalTeme.Data.Models.AcademicYear", "Year")
                        .WithMany()
                        .HasForeignKey("YearId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PortalTeme.Data.Models.StudentInfo", b =>
                {
                    b.HasOne("PortalTeme.Data.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PortalTeme.Data.Identity.User", "User")
                        .WithOne()
                        .HasForeignKey("PortalTeme.Data.Models.StudentInfo", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
