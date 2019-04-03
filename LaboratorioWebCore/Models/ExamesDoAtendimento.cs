﻿using System;

namespace LaboratorioWebCore.Models
{
    public class ExamesDoAtendimento
    {
        public ExamesDoAtendimento()
        {
            ExamesDoAtendimentoId = new Guid();
        }

        public Guid ExamesDoAtendimentoId { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }
        public Guid AtendimentoId { get; set; }
        public virtual Atendimento Atendimento { get; set; }
        public Guid ExameId { get; set; }
        public virtual Exame Exame { get; set; }
    }
}