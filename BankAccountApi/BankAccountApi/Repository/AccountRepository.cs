using BankAccountApi.Context;
using BankAccountApi.Helper;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BankAccountApi.Repository
{
    public interface IAccountRepository
    {
        Task<AccountCreditCard> AddAccountAsync(AccountCreditCard account);
        Task<IList<AccountCreditCard>> GetCreditCardsAsync();

        Task<AccountCreditCard> GetCreditCardsByNumberAsync(string number);
    }
    public class AccountRepository : IAccountRepository
    {
        readonly AccountDbContext _accountContext;
        public AccountRepository(AccountDbContext accountDbContext)
        {
            _accountContext = accountDbContext;

        }

        public async Task<IList<AccountCreditCard>> GetCreditCardsAsync()
        {
            return await _accountContext.AccountCreditCards.ToListAsync().ConfigureAwait(false);
        }

        public async Task<AccountCreditCard> AddAccountAsync(AccountCreditCard account)
        {
            var creditCard = await _accountContext.FindAsync<CreditCard>(account.CreditCardNumber).ConfigureAwait(false);
            if (creditCard == null)
            {
                throw new InvalidCreditCardException("Credit Card Number Invalid");
            }

            var accountCreditCard = await _accountContext.AccountCreditCards
                .FirstOrDefaultAsync<AccountCreditCard>(x => x.Name.Equals(account.Name) && x.CreditCardNumber.Equals(account.CreditCardNumber))
                .ConfigureAwait(false);

            if (accountCreditCard == null)
            {
                _accountContext.AccountCreditCards.Add(account);
                await _accountContext.SaveChangesAsync().ConfigureAwait(false);
            }
            return account;
        }

        public async Task<AccountCreditCard> GetCreditCardsByNumberAsync(string creditCardNumber)
        {
            return await _accountContext.AccountCreditCards
                .FirstOrDefaultAsync(x => x.CreditCardNumber.Equals(creditCardNumber))
                .ConfigureAwait(false);
        }

    }
}
