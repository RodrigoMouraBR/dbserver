using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RM.Service.ViewModels
{
    public class TransacaoViewModel
    {
        public Guid Id { get; set; }
        public string CPFOrigem { get; set; }
        public string CPFDestino { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
