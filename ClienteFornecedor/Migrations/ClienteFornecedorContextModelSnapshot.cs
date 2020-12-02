﻿// <auto-generated />
using System;
using ClienteFornecedor.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClienteFornecedor.Migrations
{
    [DbContext(typeof(ClienteFornecedorContext))]
    partial class ClienteFornecedorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClienteFornecedor.Entidades.classes.Cliente", b =>
                {
                    b.Property<long>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Contato")
                        .HasColumnType("bigint");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ClienteFornecedor.Entidades.classes.Fornecedor", b =>
                {
                    b.Property<long>("IdFornecedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Contato")
                        .HasColumnType("bigint");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFornecedor");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("ClienteFornecedor.Entidades.classes.Itens", b =>
                {
                    b.Property<long>("IdItens")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Produto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Qtd")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdItens");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("ClienteFornecedor.Entidades.classes.Pedido", b =>
                {
                    b.Property<long>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ClienteIdCliente")
                        .HasColumnType("bigint");

                    b.Property<long?>("FornecedorIdFornecedor")
                        .HasColumnType("bigint");

                    b.Property<long?>("ItensIdItens")
                        .HasColumnType("bigint");

                    b.HasKey("IdPedido");

                    b.HasIndex("ClienteIdCliente");

                    b.HasIndex("FornecedorIdFornecedor");

                    b.HasIndex("ItensIdItens");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("ClienteFornecedor.Entidades.classes.Pedido", b =>
                {
                    b.HasOne("ClienteFornecedor.Entidades.classes.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteIdCliente");

                    b.HasOne("ClienteFornecedor.Entidades.classes.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorIdFornecedor");

                    b.HasOne("ClienteFornecedor.Entidades.classes.Itens", "Itens")
                        .WithMany()
                        .HasForeignKey("ItensIdItens");
                });
#pragma warning restore 612, 618
        }
    }
}
