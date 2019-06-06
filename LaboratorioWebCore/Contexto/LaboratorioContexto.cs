using LaboratorioWebCore.EntityConfig;
using LaboratorioWebCore.Models;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioWebCore.Contexto
{
    public class LaboratorioContexto : DbContext
    {
        public LaboratorioContexto(DbContextOptions<LaboratorioContexto> opcoes): base (opcoes)
        {
            
        }

        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Atendimento> Atendimentos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<ExamesDaConsulta> ExamesDaConsulta { get; set; }
        public DbSet<ExamesDoAtendimento> ExamesDoAtendimento { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<PlanoDeSaude> PlanosDeSaude { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            // modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // modelBuilder.Properties()
            //     .Where(p => p.Name == p.ReflectedType.Name + "Id")
            //     .Configure(p => p.IsKey());

            // modelBuilder.Properties<string>()
            //     .Configure(p => p.HasColumnType("nvarchar"));

            // modelBuilder.Properties<string>()
            //     .Configure(p => p.HasMaxLength(100));

            modelBuilder.ApplyConfiguration(new AtendimentoConfiguration());
            modelBuilder.ApplyConfiguration(new CidadeConfiguration());
            modelBuilder.ApplyConfiguration(new PlanoDeSaudeConfiguration());
            modelBuilder.ApplyConfiguration(new PacienteConfiguration());
            modelBuilder.ApplyConfiguration(new ExamesDoAtendimentoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
}
}