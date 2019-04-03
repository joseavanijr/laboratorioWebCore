﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaboratorioWebCore.Models
{
    public class Atendimento
    {
        public Atendimento()
        {
            AtendimentoId = Guid.NewGuid();
        }
        public Guid AtendimentoId { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public decimal ValorTotal { get; set; }
        public virtual ICollection<ExamesDoAtendimento> ListExamesDoAtendimentos { get; set; }

        public void AdicionaExame(ExamesDoAtendimento exameDoAtendimento)
        {
            if(exameDoAtendimento.Exame == null)
                throw new Exception("Deve conter Exame");
            this.ListExamesDoAtendimentos.Add(exameDoAtendimento);
        }
    }
}