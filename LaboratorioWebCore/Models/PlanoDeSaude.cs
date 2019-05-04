using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LaboratorioWebCore.Services;

namespace LaboratorioWebCore.Models
{
    public class PlanoDeSaude
    {
        public int PlanoDeSaudeId { get; set; }
        [Display(Name="Descrição")]
        public string Descricao { get; set; }
        public virtual ICollection<Paciente> ListPacientes { get; set; }

        public PlanoDeSaude()
        {
        }
    }
}
