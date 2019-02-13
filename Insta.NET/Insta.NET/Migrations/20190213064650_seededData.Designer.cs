﻿// <auto-generated />
using InstaDOTNET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InstaDOTNET.Migrations
{
    [DbContext(typeof(InstaDOTNETDbContext))]
    [Migration("20190213064650_seededData")]
    partial class seededData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InstaDOTNET.Models.Image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Caption");

                    b.Property<string>("Name");

                    b.Property<string>("URL");

                    b.HasKey("ID");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Author = "Mike F.",
                            Caption = "This is the first test image",
                            Name = "Image One",
                            URL = "image_one.png"
                        },
                        new
                        {
                            ID = 2,
                            Author = "Mike F.",
                            Caption = "This is the second test image",
                            Name = "Image Two",
                            URL = "image_two.png"
                        },
                        new
                        {
                            ID = 3,
                            Author = "Mike F.",
                            Caption = "This is the third test image",
                            Name = "Image Three",
                            URL = "image_three.png"
                        },
                        new
                        {
                            ID = 4,
                            Author = "Mike F.",
                            Caption = "This is the fourth test image",
                            Name = "Image Four",
                            URL = "image_four.png"
                        },
                        new
                        {
                            ID = 5,
                            Author = "Mike F.",
                            Caption = "This is the fifth test image",
                            Name = "Image Five",
                            URL = "image_five.png"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
