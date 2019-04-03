using System.ComponentModel.DataAnnotations.Schema;
using LaboratorioWebCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LaboratorioWebCore.EntityConfig
{
    public class AtendimentoConfiguration : IEntityTypeConfiguration<Atendimento>
    {
        public void Configure(EntityTypeBuilder<Atendimento> builder)
        {
            builder.ToTable("Atendimentos");
            builder.HasKey(a => a.AtendimentoId);
            builder.Property(p => p.AtendimentoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Property(a => a.Data)
                .IsRequired();
            builder.Property(a => a.Status)
                .HasMaxLength(15)
                .IsRequired();
            builder.Ignore(a => a.ValorTotal);
        }
    }
}