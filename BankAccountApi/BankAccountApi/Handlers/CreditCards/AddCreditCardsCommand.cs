using BankAccountApi.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccountApi.Handlers.CreditCards
{
    public class AddCreditCardsCommand : IRequest<AccountCreditCard>
    {
        public AccountCreditCard AccountCreditCard { get; set; }
    }
}
