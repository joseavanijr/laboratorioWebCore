﻿// <auto-generated />
using System;
using LaboratorioWebCore.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LaboratorioWebCore.Migrations
{
    [DbContext(typeof(LaboratorioContexto))]
    [Migration("20190531055604_usando_fluent_api")]
    partial class usando_fluent_api
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LaboratorioWebCore.Models.Agendamento", b =>
                {
                    b.Property<int>("AgendamentoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PacienteId");

                    b.HasKey("AgendamentoId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("LaboratorioWebCore.Models.Atendimento", b =>
                {
                    b.Property<int>("AtendimentoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("AtendimentoId");

                    b.ToTable("Atendimentos");
                });

            modelBuilder.Entity("LaboratorioWebCore.Models.Cidade", b =>
                {
                    b.Property<int>("CidadeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Estado");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("CidadeId");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("LaboratorioWebCore.Models.Exame", b =>
                {
                    b.Property<int>("ExameId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<decimal>("Valor");

                    b.HasKey("ExameId");

                    b.ToTable("Exames");
                });

            modelBuilder.Entity("LaboratorioWebCore.Models.ExamesDaConsulta", b =>
                {
                    b.Property<int>("ExamesDaConsultaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgendamentoId");

                    b.Property<DateTime>("DataRealizacaoExame");

                    b.Property<int>("ExameId");

                    b.HasKey("ExamesDaConsultaId");

                    b.HasIndex("AgendamentoId");

                    b.HasIndex("ExameId");

                    b.ToTable("ExamesDaConsulta");
                });

            modelBuilder.Entity("LaboratorioWebCore.Models.ExamesDoAtendimento", b =>
                {
                    b.Property<int>("ExamesDoAtendimentoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AtendimentoId");

                    b.Property<DateTime>("Data");

                    b.Property<int>("ExameId");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("ExamesDoAtendimentoId");

                    b.HasIndex("AtendimentoId");

                    b.HasIndex("ExameId");

                    b.ToTable("ExamesDosAtendimentos");
                });

            modelBuilder.Entity("LaboratorioWebCore.Models.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CidadeId");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<int>("EnumTipoConveniado")
                        .HasColumnName("TipoConveniado");

                    b.Property<string>("Nome")
                        .HasMaxLength(50);

                    b.Property<int>("PlanoDeSaudeId");

                    b.HasKey("PacienteId");

                    b.HasIndex("CidadeId");

                    b.HasIndex("PlanoDeSaudeId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("LaboratorioWebCore.Models.PlanoDeSaude", b =>
                {
                    b.Property<int>("PlanoDeSaudeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("PlanoDeSaudeId");

                    b.ToTable("PlanosDeSaude");
                });

            modelBuilder.Entity("LaboratorioWebCore.Models.Agendamento", b =>
                {
                    b.HasOne("LaboratorioWebCore.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LaboratorioWebCore.Models.ExamesDaConsulta", b =>
                {
                    b.HasOne("LaboratorioWebCore.Models.Agendamento", "Agendamento")
                        .WithMany("ExamesDaConsultasList")
                        .HasForeignKey("AgendamentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LaboratorioWebCore.Models.Exame", "Exame")
                        .WithMany()
                        .HasForeignKey("ExameId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LaboratorioWebCore.Models.ExamesDoAtendimento", b =>
                {
                    b.HasOne("LaboratorioWebCore.Models.Atendimento", "Atendimento")
                        .WithMany("ListExamesDoAtendimentos")
                        .HasForeignKey("AtendimentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LaboratorioWebCore.Models.Exame", "Exame")
                        .WithMany()
                        .HasForeignKey("ExameId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LaboratorioWebCore.Models.Paciente", b =>
                {
                    b.HasOne("LaboratorioWebCore.Models.Cidade", "Cidade")
                        .WithMany("ListPacientes")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LaboratorioWebCore.Models.PlanoDeSaude", "PlanoDeSaude")
                        .WithMany("ListPacientes")
                        .HasForeignKey("PlanoDeSaudeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
