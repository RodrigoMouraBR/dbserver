using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RM.Data.Interfaces;
using RM.Domain.Core.Interfaces;
using RM.Domain.Entities;
using RM.Domain.Entities.Interfaces;
using RM.Service.Controllers;
using RM.Service.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RM.Service.V1
{
    [Authorize]
    [Route("api/v{version:apiVersion}/transacao")]
    public class TransacaoController : MainController
    {
        private readonly ITransacaoRepository _transacaoRepository;
        private readonly IUnitOfWork _uow;
        public TransacaoController(INotifier notifier, IUnitOfWork uow, ITransacaoRepository transacaoRepository,
                                       IUser appUser) : base(notifier, appUser)
        {
            _transacaoRepository = transacaoRepository;
            _uow = uow;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transacao>>> Get()
        {
            var transacao = await _transacaoRepository.GetAll();
            return Ok(transacao);
        }

        [HttpPost, Route("PostSimulatingError")]
        public IActionResult PostSimulatingError([FromBody] TransacaoViewModel value)
        {
            var transacao = new Transacao(value.CPFOrigem, value.CPFDestino, value.Valor, value.Data);
            _transacaoRepository.Add(transacao);
            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult<Transacao>> Post([FromBody] TransacaoViewModel value)
        {
            var transacao = new Transacao(value.CPFOrigem, value.CPFDestino, value.Valor, value.Data);
            _transacaoRepository.Add(transacao);
            var testProduct = await _transacaoRepository.GetById(transacao.Id);
            await _uow.Commit();
            testProduct = await _transacaoRepository.GetById(transacao.Id);
            return Ok(testProduct);
        }
    }
}