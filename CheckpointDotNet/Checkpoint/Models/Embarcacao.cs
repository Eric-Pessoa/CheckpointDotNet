using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint.Models
{
    public class Embarcacao
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "Informe o nome da embarcação")]
        public string Nome { get; set; }

        [Display(Name = "Quantas milhas a embarcação já navegou?")]
        public double MilhasNavegadas { get; set; }

        [Display(Name = "Qual a condição da embarcação?")]
        public Condicao Condicao { get; set; }

        [Display(Name = "Qual o porte da embarcação?")]
        public Porte Porte { get; set; }

        [Display(Name = "É uma embarcação para fins turísticos?")]
        public bool Turistico { get; set; }

    }

    public enum Condicao
    {
       Excelente, Boa, Normal, Regular, Ruim 
    }

    public enum Porte
    {
        Gigante, Grande, Médio, Pequeno
    }
}
