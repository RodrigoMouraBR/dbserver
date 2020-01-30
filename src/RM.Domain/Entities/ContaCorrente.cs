using RM.Domain.Core.Models;
using System;

namespace RM.Domain.Entities
{
    public class ContaCorrente : Entity
    {
        public double Saldo { get; set; }
        public string Agencia { get; set; }
        public string NumeroConta { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
