using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint.Models
{
    public class Embarcacao
    {
        [Display(Name = "Informe o nome da embarcação")]
        public string Nome { get; set; }

        [Display(Name = "Quantas milhas a embarcação já navegou?")]
        public double MilhasNavegadas { get; set; }

        [Display(Name = "Qual a condição da embarcação?")]
        public int Condicao { get; set; }

        [Display(Name = "Qual o porte da embarcação?")]
        public int Porte { get; set; }

        [Display(Name = "É uma embarcação para fins turísticos?")]
        public bool Turistico { get; set; }

    }
}
