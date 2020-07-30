﻿// <auto-generated />
using System;
using Basic_Bank_Solution.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Basic_Bank_Solution.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200730070542_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Basic_Bank_Solution.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("date");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Uf")
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Basic_Bank_Solution.Models.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("Basic_Bank_Solution.Models.DadosAcesso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("NomeAcesso")
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Senha")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("DadosAcessos");
                });

            modelBuilder.Entity("Basic_Bank_Solution.Models.Transacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("ContaId");

                    b.ToTable("Transacoes");
                });

            modelBuilder.Entity("Basic_Bank_Solution.Models.Conta", b =>
                {
                    b.HasOne("Basic_Bank_Solution.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Basic_Bank_Solution.Models.DadosAcesso", b =>
                {
                    b.HasOne("Basic_Bank_Solution.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Basic_Bank_Solution.Models.Transacao", b =>
                {
                    b.HasOne("Basic_Bank_Solution.Models.Conta", "Conta")
                        .WithMany()
                        .HasForeignKey("ContaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
