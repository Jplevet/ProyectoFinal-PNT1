﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoFinal_PNT1;

namespace ProyectoFinal_PNT1.Migrations
{
    [DbContext(typeof(RecitalesContext))]
    partial class RecitalesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProyectoFinal_PNT1.Banda", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("bandas");
                });

            modelBuilder.Entity("ProyectoFinal_PNT1.Recital", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Bandaid")
                        .HasColumnType("int");

                    b.Property<int?>("Ticketid")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Bandaid");

                    b.HasIndex("Ticketid");

                    b.ToTable("recitales");
                });

            modelBuilder.Entity("ProyectoFinal_PNT1.Ticket", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dniCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreCliente")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tickets");
                });

            modelBuilder.Entity("ProyectoFinal_PNT1.Recital", b =>
                {
                    b.HasOne("ProyectoFinal_PNT1.Banda", null)
                        .WithMany("recitales")
                        .HasForeignKey("Bandaid");

                    b.HasOne("ProyectoFinal_PNT1.Ticket", null)
                        .WithMany("recitales")
                        .HasForeignKey("Ticketid");
                });
#pragma warning restore 612, 618
        }
    }
}
