using RM.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RM.Domain.Entities
{
    public class Cliente : Entity
    {
      
        public string Nome { get; set; }
        public string CPF { get; set; }
        public ICollection<ContaCorrente> Conta { get; set; }

    }
}
