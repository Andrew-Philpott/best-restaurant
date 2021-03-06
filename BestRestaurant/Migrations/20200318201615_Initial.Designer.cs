﻿// <auto-generated />
using BestRestaurant.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BestRestaurant.Migrations
{
    [DbContext(typeof(BestRestaurantContext))]
    [Migration("20200318201615_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BestRestaurant.Models.Cuisine", b =>
                {
                    b.Property<int>("CuisineId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type");

                    b.HasKey("CuisineId");

                    b.ToTable("Cuisines");
                });

            modelBuilder.Entity("BestRestaurant.Models.CuisineRestaurant", b =>
                {
                    b.Property<int>("CuisineRestaurantId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CuisineId");

                    b.Property<int>("RestaurantId");

                    b.HasKey("CuisineRestaurantId");

                    b.HasIndex("CuisineId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("CuisineRestaurant");
                });

            modelBuilder.Entity("BestRestaurant.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Rating");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("BestRestaurant.Models.CuisineRestaurant", b =>
                {
                    b.HasOne("BestRestaurant.Models.Cuisine", "Cuisine")
                        .WithMany("Restaurants")
                        .HasForeignKey("CuisineId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BestRestaurant.Models.Restaurant", "Restaurant")
                        .WithMany("Cuisines")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
