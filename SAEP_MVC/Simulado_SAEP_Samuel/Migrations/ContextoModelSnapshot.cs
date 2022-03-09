﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Simulado_SAEP_Samuel.Data;

namespace Simulado_SAEP_Samuel.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Simulado_SAEP_Samuel.Models.Comentarios", b =>
                {
                    b.Property<int>("IdComentario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdEquipamento")
                        .HasColumnType("int");

                    b.Property<int>("IdPerfil")
                        .HasColumnType("int");

                    b.HasKey("IdComentario");

                    b.HasIndex("IdEquipamento");

                    b.HasIndex("IdPerfil");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("Simulado_SAEP_Samuel.Models.Equipamentos", b =>
                {
                    b.Property<int>("IdEquipamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Equipamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEquipamento");

                    b.ToTable("Equipamentos");
                });

            modelBuilder.Entity("Simulado_SAEP_Samuel.Models.Perfis", b =>
                {
                    b.Property<int>("IdPerfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Perfil")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPerfil");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("Simulado_SAEP_Samuel.Models.Usuarios", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdPerfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdPerfil");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Simulado_SAEP_Samuel.Models.Comentarios", b =>
                {
                    b.HasOne("Simulado_SAEP_Samuel.Models.Equipamentos", "Equipamento")
                        .WithMany("Comentarios")
                        .HasForeignKey("IdEquipamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Simulado_SAEP_Samuel.Models.Perfis", "Perfil")
                        .WithMany("Comentarios")
                        .HasForeignKey("IdPerfil")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipamento");

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("Simulado_SAEP_Samuel.Models.Usuarios", b =>
                {
                    b.HasOne("Simulado_SAEP_Samuel.Models.Perfis", "Perfil")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdPerfil")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("Simulado_SAEP_Samuel.Models.Equipamentos", b =>
                {
                    b.Navigation("Comentarios");
                });

            modelBuilder.Entity("Simulado_SAEP_Samuel.Models.Perfis", b =>
                {
                    b.Navigation("Comentarios");

                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}