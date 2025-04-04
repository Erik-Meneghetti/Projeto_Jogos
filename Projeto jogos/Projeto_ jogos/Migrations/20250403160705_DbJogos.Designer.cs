﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto__jogos.Context;

#nullable disable

namespace Projeto__jogos.Migrations
{
    [DbContext(typeof(ProjetoJogoContext))]
    [Migration("20250403160705_DbJogos")]
    partial class DbJogos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Projeto__jogos.Domains.Jogo", b =>
                {
                    b.Property<Guid>("JogoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeDoJogo")
                        .IsRequired()
                        .HasColumnType("VARCHAR (50)");

                    b.Property<string>("Plataforma")
                        .HasColumnType("VARCHAR (50)");

                    b.HasKey("JogoID");

                    b.HasIndex("NomeDoJogo")
                        .IsUnique();

                    b.ToTable("Jogo");
                });

            modelBuilder.Entity("Projeto__jogos.Domains.Usuario", b =>
                {
                    b.Property<Guid>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JogoFavorito")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("UsuarioID");

                    b.HasIndex("JogoFavorito");

                    b.HasIndex("NickName")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Projeto__jogos.Domains.Usuario", b =>
                {
                    b.HasOne("Projeto__jogos.Domains.Jogo", "Jogo")
                        .WithMany()
                        .HasForeignKey("JogoFavorito")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jogo");
                });
#pragma warning restore 612, 618
        }
    }
}
