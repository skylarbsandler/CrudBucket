﻿// <auto-generated />
using CrudBucketMVC.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CrudBucketMVC.Migrations
{
    [DbContext(typeof(CrudBucketContext))]
    partial class CrudBucketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CrudBucketMVC.Models.Hike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("difficulty");

                    b.Property<int>("MilesTotal")
                        .HasColumnType("integer")
                        .HasColumnName("miles_total");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("Rating")
                        .HasColumnType("integer")
                        .HasColumnName("rating");

                    b.Property<int>("TownId")
                        .HasColumnType("integer")
                        .HasColumnName("town_id");

                    b.HasKey("Id")
                        .HasName("pk_hikes");

                    b.HasIndex("TownId")
                        .HasDatabaseName("ix_hikes_town_id");

                    b.ToTable("hikes", (string)null);
                });

            modelBuilder.Entity("CrudBucketMVC.Models.Town", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DistanceRT")
                        .HasColumnType("integer")
                        .HasColumnName("distance_rt");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("TimeAway")
                        .HasColumnType("integer")
                        .HasColumnName("time_away");

                    b.HasKey("Id")
                        .HasName("pk_towns");

                    b.ToTable("towns", (string)null);
                });

            modelBuilder.Entity("CrudBucketMVC.Models.Hike", b =>
                {
                    b.HasOne("CrudBucketMVC.Models.Town", "Town")
                        .WithMany("Hikes")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_hikes_towns_town_id");

                    b.Navigation("Town");
                });

            modelBuilder.Entity("CrudBucketMVC.Models.Town", b =>
                {
                    b.Navigation("Hikes");
                });
#pragma warning restore 612, 618
        }
    }
}
