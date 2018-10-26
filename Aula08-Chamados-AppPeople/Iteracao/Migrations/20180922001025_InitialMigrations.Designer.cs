﻿// <auto-generated />
using System;
using AppChamados.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppChamados.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180922001025_InitialMigrations")]
    partial class InitialMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AppChamados.Models.Chamado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("clienteid");

                    b.Property<DateTime>("dataChamado");

                    b.Property<DateTime?>("dataSolucao");

                    b.Property<string>("descricao");

                    b.Property<TimeSpan?>("duracaoChamado");

                    b.Property<TimeSpan?>("horaFim");

                    b.Property<TimeSpan>("horaInicio");

                    b.Property<int?>("situacaoid");

                    b.HasKey("id");

                    b.HasIndex("clienteid");

                    b.HasIndex("situacaoid");

                    b.ToTable("Chamados");
                });

            modelBuilder.Entity("AppChamados.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("nome");

                    b.Property<string>("telefone");

                    b.HasKey("id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("AppChamados.Models.Situacao", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("descricao");

                    b.HasKey("id");

                    b.ToTable("Situacoes");
                });

            modelBuilder.Entity("AppChamados.Models.Chamado", b =>
                {
                    b.HasOne("AppChamados.Models.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteid");

                    b.HasOne("AppChamados.Models.Situacao", "situacao")
                        .WithMany()
                        .HasForeignKey("situacaoid");
                });
#pragma warning restore 612, 618
        }
    }
}