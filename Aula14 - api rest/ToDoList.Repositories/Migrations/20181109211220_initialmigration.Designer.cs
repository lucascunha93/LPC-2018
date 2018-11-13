﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using ToDoList.Repositories;

namespace ToDoList.Repositories.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181109211220_initialmigration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("ToDoList.Domain.associado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cep");

                    b.Property<string>("cidade");

                    b.Property<string>("cpf");

                    b.Property<string>("dataCreate");

                    b.Property<string>("dataNascimento");

                    b.Property<string>("email");

                    b.Property<string>("endereco");

                    b.Property<string>("estadoCivil");

                    b.Property<string>("nome");

                    b.Property<string>("uf");

                    b.HasKey("id");

                    b.ToTable("associado");
                });

            modelBuilder.Entity("ToDoList.Domain.dependente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("associadoid");

                    b.Property<string>("dataNascimento");

                    b.Property<string>("nome");

                    b.Property<string>("parentesco");

                    b.HasKey("id");

                    b.HasIndex("associadoid");

                    b.ToTable("dependente");
                });

            modelBuilder.Entity("ToDoList.Domain.ToDo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("id");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("ToDoList.Domain.dependente", b =>
                {
                    b.HasOne("ToDoList.Domain.associado", "associado")
                        .WithMany()
                        .HasForeignKey("associadoid");
                });
#pragma warning restore 612, 618
        }
    }
}