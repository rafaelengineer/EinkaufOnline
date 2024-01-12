﻿// <auto-generated />
using EinkaufOnline.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EinkaufOnline.Api.Migrations
{
    [DbContext(typeof(EinkaufOnlineDbContext))]
    [Migration("20240111164023_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EinkaufOnline.Api.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("EinkaufOnline.Api.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Qty")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("EinkaufOnline.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Qty")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "A kit provided by Glossier, containing skin care, hair care and makeup products",
                            ImageURL = "/Images/Beauty/Beauty1.png",
                            Name = "Glossier - Beauty Kit",
                            Price = 100m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "A kit provided by Curology, containing skin care products",
                            ImageURL = "/Images/Beauty/Beauty2.png",
                            Name = "Curology - Skin Care Kit",
                            Price = 50m,
                            Qty = 45
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "A kit provided by Curology, containing skin care products",
                            ImageURL = "/Images/Beauty/Beauty3.png",
                            Name = "Cocooil - Organic Coconut Oil",
                            Price = 20m,
                            Qty = 30
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "A kit provided by Schwarzkopf, containing skin care and hair care products",
                            ImageURL = "/Images/Beauty/Beauty4.png",
                            Name = "Schwarzkopf - Hair Care and Skin Care Kit",
                            Price = 50m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Skin Care Kit, containing skin care and hair care products",
                            ImageURL = "/Images/Beauty/Beauty5.png",
                            Name = "Skin Care Kit",
                            Price = 30m,
                            Qty = 85
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "Air Pods - in-ear wireless headphones",
                            ImageURL = "/Images/Electronic/Electronics1.png",
                            Name = "Air Pods",
                            Price = 100m,
                            Qty = 120
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "On-ear Golden Headphones - these headphones are not wireless",
                            ImageURL = "/Images/Electronic/Electronics2.png",
                            Name = "On-ear Golden Headphones",
                            Price = 40m,
                            Qty = 200
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "On-ear Black Headphones - these headphones are not wireless",
                            ImageURL = "/Images/Electronic/Electronics3.png",
                            Name = "On-ear Black Headphones",
                            Price = 40m,
                            Qty = 300
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod",
                            ImageURL = "/Images/Electronic/Electronic4.png",
                            Name = "Sennheiser Digital Camera with Tripod",
                            Price = 600m,
                            Qty = 20
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Canon Digital Camera - High quality digital camera provided by Canon",
                            ImageURL = "/Images/Electronic/Electronic5.png",
                            Name = "Canon Digital Camera",
                            Price = 500m,
                            Qty = 15
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "Gameboy - Provided by Nintendo",
                            ImageURL = "/Images/Electronic/technology6.png",
                            Name = "Nintendo Gameboy",
                            Price = 100m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "Very comfortable black leather office chair",
                            ImageURL = "/Images/Furniture/Furniture1.png",
                            Name = "Black Leather Office Chair",
                            Price = 50m,
                            Qty = 212
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "Very comfortable pink leather office chair",
                            ImageURL = "/Images/Furniture/Furniture2.png",
                            Name = "Pink Leather Office Chair",
                            Price = 50m,
                            Qty = 112
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Description = "Very comfortable lounge chair",
                            ImageURL = "/Images/Furniture/Furniture3.png",
                            Name = "Lounge Chair",
                            Price = 70m,
                            Qty = 90
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Description = "Very comfortable Silver lounge chair",
                            ImageURL = "/Images/Furniture/Furniture4.png",
                            Name = "Silver Lounge Chair",
                            Price = 120m,
                            Qty = 95
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Description = "White and blue Porcelain Table Lamp",
                            ImageURL = "/Images/Furniture/Furniture6.png",
                            Name = "Porcelain Table Lamp",
                            Price = 15m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Description = "Office Table Lamp",
                            ImageURL = "/Images/Furniture/Furniture7.png",
                            Name = "Office Table Lamp",
                            Price = 20m,
                            Qty = 73
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Description = "Comfortable Puma Sneakers in most sizes",
                            ImageURL = "/Images/Shoes/Shoes1.png",
                            Name = "Puma Sneakers",
                            Price = 100m,
                            Qty = 50
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = "Colorful trainsers - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes2.png",
                            Name = "Colorful Trainers",
                            Price = 150m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "Blue Nike Trainers - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes3.png",
                            Name = "Blue Nike Trainers",
                            Price = 200m,
                            Qty = 70
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Description = "Colorful Hummel Trainers - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes4.png",
                            Name = "Colorful Hummel Trainers",
                            Price = 120m,
                            Qty = 120
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Description = "Red Nike Trainers - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes5.png",
                            Name = "Red Nike Trainers",
                            Price = 200m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Description = "Birkenstock Sandles - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes6.png",
                            Name = "Birkenstock Sandles",
                            Price = 50m,
                            Qty = 150
                        });
                });

            modelBuilder.Entity("EinkaufOnline.Api.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("IconCSS")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCSS = "fas fa-spa",
                            Name = "Beauty"
                        },
                        new
                        {
                            Id = 2,
                            IconCSS = "fas fa-couch",
                            Name = "Furniture"
                        },
                        new
                        {
                            Id = 3,
                            IconCSS = "fas fa-headphones",
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 4,
                            IconCSS = "fas fa-shoe-prints",
                            Name = "Shoes"
                        });
                });

            modelBuilder.Entity("EinkaufOnline.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Bob"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Sarah"
                        });
                });

            modelBuilder.Entity("EinkaufOnline.Api.Entities.Product", b =>
                {
                    b.HasOne("EinkaufOnline.Api.Entities.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
