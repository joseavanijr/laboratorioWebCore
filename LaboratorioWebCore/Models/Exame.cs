using System;

namespace LaboratorioWebCore.Models
{
    public class Exame
    {
        public Exame()
        {
        }
        public int ExameId { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
    }
}