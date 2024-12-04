﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransportMigration;

#nullable disable

namespace TransportMigration.Migrations
{
    [DbContext(typeof(TransportDbContext))]
    partial class TransportDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.11");

            modelBuilder.Entity("Transport.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<TimeOnly>("ArrivelTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("StopStationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TransportLineId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StopStationId");

                    b.HasIndex("TransportLineId");

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArrivelTime = new TimeOnly(15, 15, 0),
                            StopStationId = 4,
                            TransportLineId = 2
                        },
                        new
                        {
                            Id = 2,
                            ArrivelTime = new TimeOnly(16, 23, 0),
                            StopStationId = 3,
                            TransportLineId = 1
                        },
                        new
                        {
                            Id = 3,
                            ArrivelTime = new TimeOnly(18, 10, 0),
                            StopStationId = 3,
                            TransportLineId = 2
                        },
                        new
                        {
                            Id = 4,
                            ArrivelTime = new TimeOnly(8, 5, 0),
                            StopStationId = 1,
                            TransportLineId = 3
                        },
                        new
                        {
                            Id = 5,
                            ArrivelTime = new TimeOnly(10, 56, 0),
                            StopStationId = 6,
                            TransportLineId = 6
                        },
                        new
                        {
                            Id = 6,
                            ArrivelTime = new TimeOnly(12, 54, 0),
                            StopStationId = 5,
                            TransportLineId = 5
                        });
                });

            modelBuilder.Entity("Transport.Models.StopStation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StopStations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "Вул. Івана Франка 1",
                            Name = "Вул. Івана Франка"
                        },
                        new
                        {
                            Id = 2,
                            Location = "Вул. Дубнівсяка 2",
                            Name = "Майдан Київський"
                        },
                        new
                        {
                            Id = 3,
                            Location = "Проспект Волі 1",
                            Name = "Облдержадміністрація"
                        },
                        new
                        {
                            Id = 4,
                            Location = "Проспект Волі 2",
                            Name = "Технікум"
                        },
                        new
                        {
                            Id = 5,
                            Location = "Проспект Волі 3",
                            Name = "Поліклініка №1"
                        },
                        new
                        {
                            Id = 6,
                            Location = "Проспект Волі 4",
                            Name = "Стоматполіклініка"
                        });
                });

            modelBuilder.Entity("Transport.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndValid")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("StartValid")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndValid = new DateTime(2023, 6, 10, 15, 34, 0, 0, DateTimeKind.Unspecified),
                            Price = 4.0,
                            StartValid = new DateTime(2023, 6, 10, 15, 24, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            EndValid = new DateTime(2023, 6, 10, 15, 40, 0, 0, DateTimeKind.Unspecified),
                            Price = 5.0,
                            StartValid = new DateTime(2024, 5, 12, 10, 25, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            EndValid = new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 25.0,
                            StartValid = new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            EndValid = new DateTime(2025, 1, 4, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 70.0,
                            StartValid = new DateTime(2024, 12, 4, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            EndValid = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 500.0,
                            StartValid = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            EndValid = new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 500.0,
                            StartValid = new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Transport.Models.TransportLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Lines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Маршрут №1",
                            Type = "Автобус"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Маршрут №2",
                            Type = "Автобус"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Маршрут №3",
                            Type = "Автобус"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Маршрут №3",
                            Type = "Тролейбус"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Маршрут №4",
                            Type = "Тролейбус"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Маршрут №5",
                            Type = "Тролейбус"
                        });
                });

            modelBuilder.Entity("Transport.Models.Schedule", b =>
                {
                    b.HasOne("Transport.Models.StopStation", "StopStation")
                        .WithMany()
                        .HasForeignKey("StopStationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Transport.Models.TransportLine", "Line")
                        .WithMany()
                        .HasForeignKey("TransportLineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Line");

                    b.Navigation("StopStation");
                });
#pragma warning restore 612, 618
        }
    }
}
