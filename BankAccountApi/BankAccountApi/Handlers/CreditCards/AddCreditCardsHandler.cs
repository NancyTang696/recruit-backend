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
    public class AddCreditCardsHandler : IRequestHandler<AddCreditCardsCommand, AccountCreditCard>
    {
        private readonly IAccountRepository _accountRepository;
        public AddCreditCardsHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<AccountCreditCard> Handle(AddCreditCardsCommand request, CancellationToken cancellationToken)
        {
            return await _accountRepository.AddAccountAsync(request.AccountCreditCard).ConfigureAwait(false);
        }
    }
}
