using System;
using System.Collections.Generic;

namespace LaboratorioWebCore.Models
{
    public class Agendamento
    {
        public Agendamento()
        {

        }
        public int AgendamentoId { get; set; }
        public int PacienteId { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual ICollection<ExamesDaConsulta> ExamesDaConsultasList { get; set; }
    }
}
