using System;

namespace LaboratorioWebCore.Models
{
    public class Exame
    {
        public Exame()
        {
            ExameId = new Guid();
        }
        public Guid ExameId { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
    }
}