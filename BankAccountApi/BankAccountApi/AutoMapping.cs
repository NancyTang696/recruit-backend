using AutoMapper;
using BankAccountApi.Context;
using BankAccountApi.Models;

namespace BankAccountApi
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CreditCardModel, AccountCreditCard>(); // means you want to map from User to UserDTO
        }
    }
}
