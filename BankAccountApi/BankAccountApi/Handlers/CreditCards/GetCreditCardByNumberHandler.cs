using BankAccountApi.Context;
using BankAccountApi.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BankAccountApi.Handlers.CreditCards
{
    public class GetCreditCardByNumberHandler: IRequestHandler<GetCreditCardByNumberCommand, AccountCreditCard>
    {
        private readonly IAccountRepository _accountRepository;
        public GetCreditCardByNumberHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<AccountCreditCard> Handle(GetCreditCardByNumberCommand request, CancellationToken cancellationToken)
        {
            return await _accountRepository.GetCreditCardsByNumberAsync(request.CreditCardNumber).ConfigureAwait(false);
        }
    }
}
