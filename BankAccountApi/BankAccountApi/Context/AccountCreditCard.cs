using System;
using System.ComponentModel.DataAnnotations;

namespace BankAccountApi.Context
{
    public class AccountCreditCard
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string CreditCardNumber { get; set; }

        [StringLength(50)]
        public string CVC { get; set; }
        public DateTime ExpiryDate { get; set; }

    }
}
