﻿// <auto-generated />
using chamados.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace chamados.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180921040401_canknkanj")]
    partial class canknkanj
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("chamados.Models.Chamado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("clienteid");

                    b.Property<string>("descricaoProblema");

                    b.Property<TimeSpan>("duracao");

                    b.Property<DateTime>("horaFim");

                    b.Property<DateTime>("horaInicio");

                    b.Property<string>("situacao");

                    b.HasKey("id");

                    b.HasIndex("clienteid");

                    b.ToTable("Chamado");
                });

            modelBuilder.Entity("Chamados.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("nome");

                    b.Property<string>("telefone");

                    b.HasKey("id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("chamados.Models.Chamado", b =>
                {
                    b.HasOne("Chamados.Models.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteid");
                });
#pragma warning restore 612, 618
        }
    }
}