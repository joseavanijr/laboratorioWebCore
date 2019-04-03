using System;
using System.ComponentModel.DataAnnotations.Schema;
using LaboratorioWebCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LaboratorioWebCore.EntityConfig
{
    public class PacienteConfiguration: IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("Pacientes");
            //Se fosse chave composta
            //HasKey(c => new { c.PacienteId, c.DataNascimento});
            builder.HasKey(p => p.PacienteId);
            //AUTO-INCREMENTO
            builder.Property(p => p.PacienteId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Property(p => p.Nome)
                .HasMaxLength(50);
            builder.Property(p => p.EnumTipoConveniado)
                .HasColumnName("TipoConveniado")
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute()));
            //.HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true}));
            builder.Property(c => c.DataNascimento)
                .IsRequired()
                .HasColumnType("date");
            //HasRequired(p => p.PlanoDeSaude)
            //    .WithMany()
            //    .HasForeignKey(p => p.PlanoDeSaudeId);
        }
    }
}
