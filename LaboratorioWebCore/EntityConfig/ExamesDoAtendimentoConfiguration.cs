using System.ComponentModel.DataAnnotations.Schema;
using LaboratorioWebCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AtendimentoHospitalar.EntityConfig
{
    public class ExamesDoAtendimentoConfiguration: IEntityTypeConfiguration<ExamesDoAtendimento>
    {

        public void Configure(EntityTypeBuilder<ExamesDoAtendimento> builder)
        {
            builder.ToTable("ExamesDosAtendimentos");
            builder.HasKey(ea => ea.ExamesDoAtendimentoId);
            builder.Property(p => p.ExamesDoAtendimentoId).HasValueGenerator(DatabaseGeneratedOption.Identity);
            builder.Property(ea => ea.Data)
                .IsRequired();
            builder.Property(ea => ea.Status)
                .IsRequired()
                .HasMaxLength(15);
            //builder.HasRequired(ea => ea.Atendimento)
            //    .WithMany(a => a.ListExamesDoAtendimentos)
            //    .HasForeignKey(ea => ea.AtendimentoId);
        }
    }
}