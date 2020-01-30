using RM.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RM.Domain.Entities
{
    public class Transacao : Entity
    {
        public Transacao(string cPFOrigem, string cPFDestino, double valor, DateTime data)
        {
            CPFOrigem = cPFOrigem;
            CPFDestino = cPFDestino;
            Valor = valor;
            Data = data;
        }

        public string CPFOrigem { get; set; }
        public string CPFDestino { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
