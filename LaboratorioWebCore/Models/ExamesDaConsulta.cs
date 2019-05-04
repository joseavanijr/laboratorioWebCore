using System;

namespace LaboratorioWebCore.Models
{
    public class ExamesDaConsulta
    {
        //public ExamesDaConsulta(Agendamento agendamento)
        //{
        //    ExamesDaConsultaId = new Guid();
        //    this.Agendamento = agendamento;
        //}
        public ExamesDaConsulta()
        {

        }

        public int ExamesDaConsultaId { get; set; }
        public DateTime DataRealizacaoExame { get; set; }
        public int ExameId { get; set; }
        public virtual Exame Exame { get; set; }
        public int AgendamentoId { get; set; }
        public virtual Agendamento Agendamento { get; set; }
    }
}
