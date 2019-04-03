using System.ComponentModel.DataAnnotations.Schema;
using LaboratorioWebCore.Models;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioWebCore.EntityConfig
{
    public class CidadeConfiguration: IEntityTypeConfiguration<Cidade>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("Cidades");
            builder.HasKey(c => c.CidadeId);
            builder.Property(p => p.CidadeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Property(c => c.Estado)
                .IsRequired();
            builder.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(60);
        }
    }
}