﻿// <auto-generated />
using System;
using AppAssociados.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppAssociados.Repositories.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181109211754_InitialMigrations")]
    partial class InitialMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AppAssociados.Domain.Associado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cep");

                    b.Property<string>("cidade");

                    b.Property<string>("cpf");

                    b.Property<DateTime>("dataCadastro");

                    b.Property<DateTime>("dataNascimento");

                    b.Property<string>("email");

                    b.Property<string>("estado");

                    b.Property<int?>("estadoCivilid");

                    b.Property<string>("nome");

                    b.Property<int>("numeroEndereco");

                    b.Property<string>("ruaEndereco");

                    b.HasKey("id");

                    b.HasIndex("estadoCivilid");

                    b.ToTable("Associado");
                });

            modelBuilder.Entity("AppAssociados.Domain.Dependente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("associadoid");

                    b.Property<int?>("parentescoid");

                    b.HasKey("id");

                    b.HasIndex("associadoid");

                    b.HasIndex("parentescoid");

                    b.ToTable("Dependente");
                });

            modelBuilder.Entity("AppAssociados.Domain.EstadoCivil", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("descricao");

                    b.HasKey("id");

                    b.ToTable("EstadoCivil");
                });

            modelBuilder.Entity("AppAssociados.Domain.Parentesco", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("descricao");

                    b.HasKey("id");

                    b.ToTable("Parentesco");
                });

            modelBuilder.Entity("AppAssociados.Domain.Associado", b =>
                {
                    b.HasOne("AppAssociados.Domain.EstadoCivil", "estadoCivil")
                        .WithMany()
                        .HasForeignKey("estadoCivilid");
                });

            modelBuilder.Entity("AppAssociados.Domain.Dependente", b =>
                {
                    b.HasOne("AppAssociados.Domain.Associado", "associado")
                        .WithMany("dependentes")
                        .HasForeignKey("associadoid");

                    b.HasOne("AppAssociados.Domain.Parentesco", "parentesco")
                        .WithMany()
                        .HasForeignKey("parentescoid");
                });
#pragma warning restore 612, 618
        }
    }
}
