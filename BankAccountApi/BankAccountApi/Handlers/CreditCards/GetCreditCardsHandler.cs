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
    public class GetCreditCardsHandler: IRequestHandler<GetCreditCardsCommand, IList<AccountCreditCard>>
    {
        private readonly IAccountRepository _accountRepository;
        public GetCreditCardsHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<IList<AccountCreditCard>> Handle(GetCreditCardsCommand request, CancellationToken cancellationToken)
        {
            return await _accountRepository.GetCreditCardsAsync().ConfigureAwait(false);
        }
    }
}
