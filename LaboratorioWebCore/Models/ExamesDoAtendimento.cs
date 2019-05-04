using System;

namespace LaboratorioWebCore.Models
{
    public class ExamesDoAtendimento
    {
        public ExamesDoAtendimento()
        {
        }

        public int ExamesDoAtendimentoId { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }
        public int AtendimentoId { get; set; }
        public virtual Atendimento Atendimento { get; set; }
        public int ExameId { get; set; }
        public virtual Exame Exame { get; set; }
    }
}