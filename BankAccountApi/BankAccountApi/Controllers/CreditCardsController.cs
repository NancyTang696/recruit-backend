using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BankAccountApi.Context;
using BankAccountApi.Handlers.CreditCards;
using BankAccountApi.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankAccountApi.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class CreditCardsController : ControllerBase
    {
        private readonly IMediator _mediater;
        private readonly IMapper _mapper;

        public CreditCardsController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediater = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<AccountCreditCard>> AddAcount([FromBody] CreditCardModel account)
        {
            try
            {
                return await _mediater.Send(new AddCreditCardsCommand()
                {
                    AccountCreditCard = _mapper.Map<AccountCreditCard>(account)
                }).ConfigureAwait(false);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
