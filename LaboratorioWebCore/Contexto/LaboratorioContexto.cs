using LaboratorioWebCore.Models;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioWebCore.Contexto
{
    public class LaboratorioContexto : DbContext
    {
        public LaboratorioContexto(DbContextOptions<LaboratorioContexto> opcaoes): base (opcaoes)
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

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
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

            // modelBuilder.Configurations.Add(new AtendimentoConfiguration());
            // modelBuilder.Configurations.Add(new CidadeConfiguration());
            // modelBuilder.Configurations.Add(new PlanoDeSaudeConfiguration());
            // modelBuilder.Configurations.Add(new PacienteConfiguration());
            // modelBuilder.Configurations.Add(new ExamesDoAtendimentoConfiguration());

            // base.OnModelCreating(modelBuilder);
        // }
    }
}