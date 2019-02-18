﻿// <auto-generated />
using System;
using InstaDOTNET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InstaDOTNET.Migrations
{
    [DbContext(typeof(InstaDOTNETDbContext))]
    [Migration("20190218192418_azureDeploy")]
    partial class azureDeploy
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InstaDOTNET.Models.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentAuthor")
                        .IsRequired();

                    b.Property<string>("CommentString")
                        .IsRequired();

                    b.Property<int>("ImageID");

                    b.HasKey("ID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("InstaDOTNET.Models.Image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<string>("Caption")
                        .IsRequired();

                    b.Property<int?>("CommentID");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("URL");

                    b.HasKey("ID");

                    b.HasIndex("CommentID");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Author = "Mike F.",
                            Caption = "This is the first test image",
                            Name = "Image One",
                            URL = "https://via.placeholder.com/200"
                        },
                        new
                        {
                            ID = 2,
                            Author = "Mike F.",
                            Caption = "This is the second test image",
                            Name = "Image Two",
                            URL = "https://via.placeholder.com/200"
                        },
                        new
                        {
                            ID = 3,
                            Author = "Mike F.",
                            Caption = "This is the third test image",
                            Name = "Image Three",
                            URL = "https://via.placeholder.com/200"
                        },
                        new
                        {
                            ID = 4,
                            Author = "Mike F.",
                            Caption = "This is the fourth test image",
                            Name = "Image Four",
                            URL = "https://via.placeholder.com/200"
                        },
                        new
                        {
                            ID = 5,
                            Author = "Mike F.",
                            Caption = "This is the fifth test image",
                            Name = "Image Five",
                            URL = "https://via.placeholder.com/200"
                        });
                });

            modelBuilder.Entity("InstaDOTNET.Models.Image", b =>
                {
                    b.HasOne("InstaDOTNET.Models.Comment")
                        .WithMany("Images")
                        .HasForeignKey("CommentID");
                });
#pragma warning restore 612, 618
        }
    }
}
