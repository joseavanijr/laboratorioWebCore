using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using LaboratorioWebCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LaboratorioWebCore.EntityConfig
{
    public class PlanoDeSaudeConfiguration: IEntityTypeConfiguration<PlanoDeSaude>
    {
        public void Configure(EntityTypeBuilder<PlanoDeSaude> builder)
        {
            builder.ToTable("PlanosDeSaude");
            builder.HasKey(p => p.PlanoDeSaudeId);
            builder.Property(p => p.PlanoDeSaudeId);
            builder.Property(p => p.Descricao)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
