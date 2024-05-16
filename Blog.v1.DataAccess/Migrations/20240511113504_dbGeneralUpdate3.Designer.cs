﻿// <auto-generated />
using System;
using Blog.v1.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.v1.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240511113504_dbGeneralUpdate3")]
    partial class dbGeneralUpdate3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blog.v1.Core.Model.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Content = "Web content deneme 1",
                            CreatedOn = new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3317),
                            ModifiedOn = new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3318),
                            Name = "Web Subject1",
                            Title = "Web Content Title 1"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Content = "Web content deneme 1",
                            CreatedOn = new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3323),
                            ModifiedOn = new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3323),
                            Name = "Web Subject1",
                            Title = "Web Content Title 1"
                        });
                });

            modelBuilder.Entity("Blog.v1.Core.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3069),
                            ModifiedOn = new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3078),
                            Name = "AI"
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3080),
                            ModifiedOn = new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3081),
                            Name = "Web"
                        });
                });

            modelBuilder.Entity("Blog.v1.Core.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("BlockDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedOn = new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3356),
                            Email = "bnurdursun@gmail.com",
                            FirstName = "Admin",
                            IsActive = true,
                            LastName = "adm",
                            ModifiedOn = new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3356),
                            Name = "adm",
                            Password = "1234",
                            PhoneNumber = "1234567890",
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Blog.v1.Core.Model.Article", b =>
                {
                    b.HasOne("Blog.v1.Core.Model.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Blog.v1.Core.Model.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Blog.v1.Core.Model.Category", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
