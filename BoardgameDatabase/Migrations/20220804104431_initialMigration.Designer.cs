﻿// <auto-generated />
using BoardgameDatabase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BoardgameDatabase.Migrations
{
    [DbContext(typeof(BoardgameDBContext))]
    [Migration("20220804104431_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BoardgameDatabase.Adress", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("ntext")
                        .HasColumnName("Adress");

                    b.HasKey("Name");

                    b.ToTable("Adresses");
                });

            modelBuilder.Entity("BoardgameDatabase.Boardgame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ForSale")
                        .HasColumnType("bit");

                    b.Property<string>("Keeper")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MaxPlayers")
                        .HasColumnType("int");

                    b.Property<int>("MinPlayers")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TagText")
                        .HasColumnType("text")
                        .HasColumnName("Tags");

                    b.HasKey("Id");

                    b.HasIndex("Keeper");

                    b.HasIndex("Owner");

                    b.ToTable("Boardgames");
                });

            modelBuilder.Entity("BoardgameDatabase.Boardgame", b =>
                {
                    b.HasOne("BoardgameDatabase.Adress", "KeeperNavigation")
                        .WithMany("BoardgameKeeperNavigations")
                        .HasForeignKey("Keeper");

                    b.HasOne("BoardgameDatabase.Adress", "OwnerNavigation")
                        .WithMany("BoardgameOwnerNavigations")
                        .HasForeignKey("Owner")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KeeperNavigation");

                    b.Navigation("OwnerNavigation");
                });

            modelBuilder.Entity("BoardgameDatabase.Adress", b =>
                {
                    b.Navigation("BoardgameKeeperNavigations");

                    b.Navigation("BoardgameOwnerNavigations");
                });
#pragma warning restore 612, 618
        }
    }
}
